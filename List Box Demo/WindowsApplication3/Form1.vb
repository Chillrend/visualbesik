Public Class Form1
    Private Sub addToList_Click(sender As Object, e As EventArgs) Handles addToList.Click
        If isLeft.Checked Then
            listLeft.Items.Add(addItem.Text)
        Else
            listRight.Items.Add(addItem.Text)
        End If
    End Sub

    Private Sub oneListToRight_Click(sender As Object, e As EventArgs) Handles oneListToRight.Click
        If listLeft.Items.Count > 0 Then
            For i = 0 To listLeft.SelectedItems.Count - 1
                listRight.Items.Add(listLeft.SelectedItems(i))
                listLeft.Items.Remove(listLeft.SelectedItems(i))
            Next
        End If

    End Sub

    Private Sub allListToRight_Click(sender As Object, e As EventArgs) Handles allListToRight.Click
        listRight.Items.AddRange(listLeft.Items)
        listLeft.Items.Clear()
    End Sub

    Private Sub oneListToLeft_Click(sender As Object, e As EventArgs) Handles oneListToLeft.Click
        If listRight.Items.Count > 0 Then
            For i = 0 To listRight.SelectedItems.Count - 1
                listLeft.Items.Add(listRight.SelectedItems(i))
                listRight.Items.Remove(listRight.SelectedItems(i))
            Next
        End If
    End Sub

    Private Sub allListToLeft_Click(sender As Object, e As EventArgs) Handles allListToLeft.Click

        listLeft.Items.AddRange(listRight.Items)
        listRight.Items.Clear()
    End Sub
End Class
