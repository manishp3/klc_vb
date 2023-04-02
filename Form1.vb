Public Class Form1

    Private Sub bsingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsingle.Click
        l2.Items.Add(l1.SelectedItem.ToString)
        l1.Items.Remove(l1.SelectedItem.ToString)
    End Sub

    Private Sub bsingleb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsingleb.Click
        l1.Items.Add(l2.SelectedItem.ToString)
        l2.Items.Remove(l2.SelectedItem.ToString)
    End Sub

    Private Sub bmulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmulti.Click
        Dim i As Integer
        For i = 0 To l1.SelectedItems.Count - 1
            l2.Items.Add(l1.SelectedItems(i))
        Next
        For i = 0 To l1.SelectedItems.Count - 1
            l1.Items.RemoveAt(l1.SelectedIndex)
        Next
    End Sub

    Private Sub bmultib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmultib.Click
        Dim i As Integer
        For i = 0 To l2.SelectedItems.Count - 1
            l1.Items.Add(l2.SelectedItems(i))
        Next


        For i = 0 To l2.SelectedItems.Count - 1
            l2.Items.RemoveAt(l2.SelectedIndex)
        Next
    End Sub

    Private Sub ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ball.Click
        Dim i As Integer
        For i = 0 To l1.Items.Count - 1
            l2.Items.Add(l1.Items(i))
        Next

        l1.Items.Clear()
    End Sub

    Private Sub ballb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ballb.Click
        Dim i As Integer
        For i = 0 To l2.Items.Count - 1
            l1.Items.Add(l2.Items(i))
        Next

        l2.Items.Clear()
    End Sub
End Class
