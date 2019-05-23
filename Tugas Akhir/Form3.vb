Imports MySql.Data.MySqlClient

Public Class Form3
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim adapterjenis As MySqlDataAdapter

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Dim random As New Random
    Dim strpos As String
    Dim temp_id As String
    Dim id_s_temp As String
    Dim id_r_temp As String

    Dim chars As String

    Sub generate_resi()
        chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Dim count = 0
        strpos = ""
        temp_id = ""

        While count <= 7
            strpos = random.Next(0, chars.Length)
            temp_id = temp_id & chars(strpos)
            count = count + 1

        End While
    End Sub

    Sub check_harga()
        Dim reader As MySqlDataReader
        Dim cmd_cari As New MySqlCommand
        Dim biaya As String
        Dim intbiaya As Integer
        Dim berat As String
        Dim intberat As Integer
        Dim temp_harga As Integer


        conn.Close()
        conn.Open()

        berat = tb_berat.Text
        intberat = Integer.Parse(berat)

        cmd_cari.Connection = conn
        cmd_cari.CommandType = CommandType.Text
        cmd_cari.CommandText = "select * from price where city_1_id ='" & cb_kota_s.SelectedValue & "' and city_2_id = '" & cb_kota_r.SelectedValue & "'"

        reader = cmd_cari.ExecuteReader
        reader.Read()
        biaya = reader("price")
        intbiaya = Integer.Parse(biaya)

        If cb_jenispaket.Text = "Platinum" Then
            temp_harga = intbiaya * intberat + 20000
        ElseIf cb_jenispaket.Text = "Gold" Then
            temp_harga = intbiaya * intberat + 15000
        ElseIf cb_jenispaket.Text = "Silver" Then
            temp_harga = intbiaya * intberat + 10000
        ElseIf cb_jenispaket.Text = "Bronze" Then
            temp_harga = intbiaya * intberat + 5000
        End If

        tb_biaya.Text = temp_harga

    End Sub


    Sub select_jenis_barang()
        conn.Close()
        conn.Open()

        Dim q_selectjenisbrg As String
        Dim tablejenis As DataTable

        q_selectjenisbrg = "select * from goods_category"
        COMMAND = New MySqlCommand(q_selectjenisbrg, conn)
        adapterjenis = New MySqlDataAdapter(COMMAND)
        tablejenis = New DataTable

        adapterjenis.Fill(tablejenis)
        cb_jenispaket.DataSource = tablejenis

        cb_jenispaket.DisplayMember = "name"
        cb_jenispaket.ValueMember = "id"
    End Sub

    Sub select_city()
        conn.Close()
        conn.Open()

        Dim q_selectcity As String
        Dim tablecity1 As DataTable
        Dim tablecity2 As DataTable

        q_selectcity = "select * from cities"
        COMMAND = New MySqlCommand(q_selectcity, conn)
        adapter = New MySqlDataAdapter(COMMAND)
        tablecity1 = New DataTable
        tablecity2 = New DataTable

        adapter.Fill(tablecity1)
        adapter.Fill(tablecity2)
        cb_kota_s.DataSource = tablecity1
        cb_kota_r.DataSource = tablecity2

        cb_kota_s.DisplayMember = "name"
        cb_kota_r.DisplayMember = "name"

        cb_kota_s.ValueMember = "id"
        cb_kota_r.ValueMember = "id"

    End Sub

    Sub insert_pengirim()
        Dim cmd_insert_s As New MySqlCommand


        conn.Close()
        conn.Open()

        cmd_insert_s.Connection = conn
        cmd_insert_s.CommandType = CommandType.Text
        cmd_insert_s.CommandText = "insert into senders(name, address, contact, city_id)  value ('" & tb_nama_s.Text & "','" & tb_alamat_s.Text & "','" & tb_kontak_s.Text & "', '" & cb_kota_s.SelectedValue & "')"
        cmd_insert_s.ExecuteNonQuery()

    End Sub
    Sub read_id_s()
        Dim cmd_cariid_s As New MySqlCommand

        conn.Close()
        conn.Open()

        cmd_cariid_s.Connection = conn
        cmd_cariid_s.CommandType = CommandType.Text
        cmd_cariid_s.CommandText = "select MAX(id) from senders where Name = '" & tb_nama_s.Text & "'"

        reader = cmd_cariid_s.ExecuteReader
        reader.Read()
        id_s_temp = reader.GetString(0)
    End Sub

    Sub insert_penerima()
        Dim cmd_insert_r As New MySqlCommand


        conn.Close()
        conn.Open()

        cmd_insert_r.Connection = conn
        cmd_insert_r.CommandType = CommandType.Text
        cmd_insert_r.CommandText = "insert into receivers(name, address, contact, city_id) value ('" & tb_nama_r.Text & "','" & tb_alamat_r.Text & "','" & tb_kontak_r.Text & "', '" & cb_kota_r.SelectedValue & "')"
        cmd_insert_r.ExecuteNonQuery()

    End Sub

    Sub read_id_r()
        Dim cmd_cariid_r As New MySqlCommand
        conn.Close()
        conn.Open()

        cmd_cariid_r.Connection = conn
        cmd_cariid_r.CommandType = CommandType.Text
        cmd_cariid_r.CommandText = "select MAX(id) from receivers where Name = '" & tb_nama_r.Text & "'"

        reader = cmd_cariid_r.ExecuteReader
        reader.Read()
        id_r_temp = reader.GetString(0)

    End Sub

    Sub insert_barang()
        Dim cmd_insert_g As New MySqlCommand

        conn.Close()
        conn.Open()

        cmd_insert_g.Connection = conn
        cmd_insert_g.CommandType = CommandType.Text
        cmd_insert_g.CommandText = "insert into goods value ('" & tb_kode.Text & "','" & tb_barang.Text & "','" & cb_jenispaket.SelectedValue & "','" & tb_berat.Text & "','" & tb_biaya.Text & "', '" & id_s_temp & "','" & id_r_temp & "')"
        cmd_insert_g.ExecuteNonQuery()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Panel_penerima.Visible = False

        conn = New MySqlConnection
        conn.ConnectionString = "server='192.168.80.1';port='8889';user='pemvis';password='12345678';database='jasa_pengiriman'"
        conn.Open()

        Call select_city()
        Call select_jenis_barang()

    End Sub

    Private Sub btn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click
        tb_kode.Text = ""

        Call generate_resi()

        tb_kode.Text = temp_id
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Panel_penerima.Visible = True

    End Sub

    Private Sub btn_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        Panel_penerima.Visible = False

    End Sub

    Private Sub cb_kota_r_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_kota_r.SelectedIndexChanged

        Dim kota_r As String

        kota_r = cb_kota_r.Text
        tb_kota_r.Text = kota_r
    End Sub

    Private Sub cb_kota_s_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_kota_s.SelectedIndexChanged
        Dim kota_s As String

        kota_s = cb_kota_s.Text
        tb_kota_s.Text = kota_s
    End Sub

    Private Sub btn_check_harga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_check_harga.Click

        Call check_harga()

    End Sub

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click

        Call insert_pengirim()
        Call insert_penerima()
        Call read_id_s()
        Call read_id_r()
        Call insert_barang()


        MsgBox("Data Berhasil Disimpan!")
    End Sub


    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Close()
    End Sub
End Class

