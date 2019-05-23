Imports MySql.Data.MySqlClient

Public Class LoginForm1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
  
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = DataConfig.connString
        conn.Open()
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub login_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        Dim READER As MySqlDataReader

        conn.Close()
        conn.Open()

        Try
            Dim query As String
            query = "SELECT * FROM jasa_pengiriman.users where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "' "
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count += 1
            End While
            If count = 1 Then
                MsgBox("Login Success!")
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Incorrect User and Password")
                PasswordTextBox.Clear()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
