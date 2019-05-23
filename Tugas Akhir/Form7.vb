Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class PrintData

    Dim key As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim sql As String
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand

    Public Sub setData(ByVal id As String)
        key = id

    End Sub

    Private Sub PrintData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = DataConfig.connString
        loadData(key)

    End Sub

    Public Sub loadData(ByVal key As String)
        conn.Open()

        cmd.CommandText = "Select * from goods INNER JOIN senders ON sender_id = senders.id INNER JOIN receivers ON receiver_id = receivers.id where goods.id= '" & key & "'; "
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        If rd.Read Then
            tbNameReceiver.Text = rd.GetString(8)
            tbAddressReceiver.Text = rd.GetString(9)
            tbCost.Text = rd.GetString(3)
        End If

        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pf As New PrintForm
        pf.Form = Me
        pf.PrintAction = Printing.PrintAction.PrintToPreview
        pf.Print()

    End Sub
End Class