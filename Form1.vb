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

    Private Sub userInput_Click(sender As Object, e As EventArgs) Handles userInput.Click
        Dim userName As String

        userName = InputBox("Please enter your name: ")

        MessageBox.Show("Hello, " & userName)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim stUserName As String
        Dim stLastName As String
        Dim stOccupation As String

        stUserName = txtUsername.Text
        stLastName = txtLastName.Text

        stOccupation = lstOccupation.SelectedItem

        MessageBox.Show("Hello, " & stUserName & ". You are Mr. " & stLastName &
                        ", a " & stOccupation)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Runs immediately after the programs runs,
        ' and before the form loads

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")


    End Sub
End Class
