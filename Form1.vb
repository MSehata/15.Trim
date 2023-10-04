Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        Dim phrase As String
        phrase = txtPhrase.Text
        txtSelectedTrimResults.Text = LTrim(RTrim(phrase))
    End Sub

    Private Sub btnLTrim_Click(sender As Object, e As EventArgs) Handles btnLTrim.Click
        Dim phrase As String
        phrase = txtPhrase.Text
        txtSelectedTrimResults.Text = LTrim(phrase)
    End Sub

    Private Sub btnRTrim_Click(sender As Object, e As EventArgs) Handles btnRTrim.Click
        Dim phrase As String
        phrase = txtPhrase.Text
        txtSelectedTrimResults.Text = RTrim(phrase)
    End Sub
End Class
