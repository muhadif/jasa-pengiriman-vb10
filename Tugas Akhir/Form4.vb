Imports MySql.Data.MySqlClient

Public Class Form4
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim sql As String
    Dim StrVar As String
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = DataConfig.connString
        conn.Open()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Close()
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        search(tbSearch.Text)
    End Sub

    Private Sub search(ByVal key As String)
        If key.Length = 8 Then
            cmd.CommandText = "Select * from goods INNER JOIN senders ON sender_id = senders.id INNER JOIN receivers ON receiver_id = receivers.id where goods.id= '" & key & "'; "
            cmd.Connection = conn
            rd = cmd.ExecuteReader


            If rd.Read Then
                lblSender.Text = rd.GetString(8)
                lblSenderAddress.Text = rd.GetString(9)
                lblReceiver.Text = rd.GetString(13)
                lblReciverAddress.Text = rd.GetString(14)
                lblWeight.Text = rd.GetString(3)
                reloadLastLocation()
            End If


        Else
            MsgBox("Resi Harus berisi 8 huruf atau angka")
        End If

        rd.Close()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSearch.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim resi As String
        Dim location As String
        Dim cmd_insert_g As New MySqlCommand

        conn.Close()
        conn.Open()

        cmd_insert_g.Connection = conn
        cmd_insert_g.CommandType = CommandType.Text
        cmd_insert_g.CommandText = "insert into history(good_id,location) value ('" & tbSearch.Text & "','" & tbLocation.Text & "')"
        cmd_insert_g.ExecuteNonQuery()

        MsgBox("Update lokasi berhasil")
        reloadLastLocation()

        conn.Close()

    End Sub

    Private Sub reloadLastLocation()
        conn.Close()
        conn.Open()
        cmd.CommandText = "Select * from history INNER JOIN goods ON good_id = goods.id where goods.id= '" & tbSearch.Text & "' Order By date DESC limit 1 "
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        If rd.Read Then
            lblLastLocation.Text = rd.GetString(3)
        End If

        conn.Close()
    End Sub
End Class