Public Class ContactQuery
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If OptFirstOnly.Checked = False Then
            If FirstText.Text = "" OrElse SecondText.Text = "" Then
                MessageBox.Show("If the selected option is not 'First Only' then text must be entered in both text boxes. Complete both boxes and try again.", "Missing Text", MessageBoxButtons.OK)
                Exit Sub
            Else

            End If
        Else
            If FirstText.Text = "" Then
                MessageBox.Show("No text has been entered for the search! Enter some text and try again.", "Missing Text", MessageBoxButtons.OK)
                Exit Sub
            Else

            End If
        End If
    End Sub
End Class