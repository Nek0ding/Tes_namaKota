Public Class Form1
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim kota = input_kota.Text
        list_kota.Items.Add(kota)
        input_kota.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list_kota.Items.Add("Jakarta")
        list_kota.Items.Add("Bogor")
        list_kota.Items.Add("Medan")
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pilihan = list_kota.SelectedIndex
        list_kota.Items.RemoveAt(pilihan)
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        list_kota.Items.Clear()
    End Sub

    Private Sub btn_jumlah_Click(sender As Object, e As EventArgs) Handles btn_jumlah.Click
        Dim jumlah = list_kota.Items.Count
        output_jumlah.Text = jumlah
    End Sub
End Class
