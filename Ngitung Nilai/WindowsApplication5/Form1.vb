Public Class Form1
    Private Sub itung_Click(sender As Object, e As EventArgs) Handles itung.Click
        Dim uas, uts, tugas, preuas, preuts, pretugas As Integer
        uas = nilaiUAS.Text
        uts = nilaiUTS.Text
        tugas = nilaiTugas.Text
        preuas = presentaseUAS.Text
        preuts = persentaseUTS.Text
        pretugas = presentaseTugas.Text

        Dim hasilUAS, hasilUTS, hasilTugas, hasilTotal As Integer
        hasilTotal = 0
        If preuas + preuts + pretugas <> 100 Then
            MessageBox.Show("Persentase Nilai Kurang / Lebih dari 100%")
        ElseIf uas < 0 Or uas > 100 Or uts < 0 Or uts > 100 Or tugas < 0 Or tugas > 100 Then
            MessageBox.Show("Nilai Lebih dari 100 atau Kurang dari 0")
        Else
            hasilUAS = (preuas / 100) * uas
            hasilUTS = (preuts / 100) * uts
            hasilTugas = (pretugas / 100) * tugas

            hasilTotal = hasilTugas + hasilUTS + hasilUAS
            Dim predikat As String
            predikat = "Tidak Bisa Menghitung Nilai"
            If hasilTotal < 41 Then
                predikat = "E"
            ElseIf hasilTotal < 56 Then
                predikat = "D"
            ElseIf hasilTotal < 60 Then
                predikat = "C"
            ElseIf hasilTotal < 64 Then
                predikat = "C+"
            ElseIf hasilTotal < 68 Then
                predikat = "B-"
            ElseIf hasilTotal < 72 Then
                predikat = "B"
            ElseIf hasilTotal < 76 Then
                predikat = "B+"
            ElseIf hasilTotal < 81 Then
                predikat = "A-"
            Else
                predikat = "A"
            End If

            listNilai.Items.Add("Mata Kuliah " + comboMatkul.SelectedItem.ToString + " Total Nilai = " + hasilTotal.ToString + " Predikat = " + predikat)
        End If


    End Sub

    Private Sub hapusSemuaBtn_Click(sender As Object, e As EventArgs) Handles hapusSemuaBtn.Click
        listNilai.Items.Clear()
    End Sub

    Private Sub hapusSatuBtn_Click(sender As Object, e As EventArgs) Handles hapusSatuBtn.Click
        listNilai.Items.RemoveAt(listNilai.SelectedIndex)
    End Sub
End Class
