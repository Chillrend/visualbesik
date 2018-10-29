Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles male.CheckedChanged

    End Sub

    Private Sub sambitButton_Click(sender As Object, e As EventArgs) Handles sambitButton.Click
        Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information

        Dim gender As String

        If male.Checked Then
            gender = male.Text
        ElseIf female.Checked Then
            gender = female.Text
        Else
            gender = gey.Text
        End If

        Dim Hobby As String
        Dim Temporary As String

        If Fishing.Checked Then
            Hobby = Hobby & "," & Fishing.Text
        End If
        If geming.Checked Then
            Hobby = Hobby & "," & geming.Text
        End If
        If coding.Checked Then
            Hobby = Hobby & "," & coding.Text
        End If
        If thinking.Checked Then
            Hobby = Hobby & "," & thinking.Text
        End If
        If sinking.Checked Then
            Hobby = Hobby & "," & sinking.Text
        End If
        If studying.Checked Then
            Hobby = Hobby & "," & studying.Text
        End If

        Dim response As String = "Name : " & names.Text & vbNewLine & "Nim : " & nim.Text & vbNewLine & "DOB : " & dob.Value _
            & vbNewLine & "Address : " & addr.Text & vbNewLine & "Password : " & pwd.Text & "Gender : " & gender & vbNewLine _
            & "Religion : " & religion.SelectedItem & vbNewLine & "Email : " & email.Text & vbNewLine & "Phone : " & phone.Text _
            & vbNewLine & "Hobby : " & Hobby

        var.gUsername = nim.Text
        var.gPassword = pwd.Text




        MsgBox(response, style, "Succsess")

        Form2.Show()




    End Sub
End Class
