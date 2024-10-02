Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("Hello World!")
        MessageBox.Show("another message")
    End Sub

    Private Sub varButton_Click(sender As Object, e As EventArgs) Handles varButton.Click
        Dim firstName As String
        Dim age As Integer
        Dim isMale As Boolean
        Dim height As Double
        Dim weight As Decimal
        Dim dateOfBirth As Date

        firstName = "Shalom"

        MessageBox.Show("Hello " & firstName)

        age = 45
        isMale = True
        height = 144.34
        weight = 55
        dateOfBirth = #09/03/2000#

        MessageBox.Show("It is " & isMale &
                        " that you are male" & vbCrLf & "Yes!")

    End Sub
End Class
