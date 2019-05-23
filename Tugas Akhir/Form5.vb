Imports MySql.Data.MySqlClient

Public Class Form5

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim sql As String
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand
    
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = DataConfig.connString

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Close()
    End Sub
    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub search(ByVal key As String)

        If key.Length = 8 Then
            conn.Open()

            cmd.CommandText = "Select * from goods INNER JOIN senders ON sender_id = senders.id INNER JOIN receivers ON receiver_id = receivers.id where goods.id= '" & key & "'; "
            cmd.Connection = conn
            rd = cmd.ExecuteReader


            If rd.Read Then
                lblSender.Text = rd.GetString(8)
                lblSenderAddress.Text = rd.GetString(9)
                lblReceiver.Text = rd.GetString(13)
                lblReciverAddress.Text = rd.GetString(14)
            End If

            sql = "Select date as Tanggal, location as Lokasi from history INNER JOIN goods ON good_id = goods.id where goods.id= '" & tbSearch.Text & "' Order By date DESC"

            conn.Close()
            conn.Open()

            Dim da = New MySqlDataAdapter(sql, conn)
            Dim ds = New DataSet
            da.Fill(ds)

            Dim dt As New DataTable

            For Each dt In ds.Tables
                dgHistory.DataSource = dt
            Next
            conn.Close()

            dgHistory.Columns(0).Width = 250
            dgHistory.Columns(1).Width = 250
            dgHistory.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgHistory.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgHistory.Columns(1).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgHistory.Columns(0).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter





        Else
            MsgBox("Resi Harus berisi 8 huruf atau angka")
        End If


    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        search(tbSearch.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHistory.CellContentClick

    End Sub
End Class