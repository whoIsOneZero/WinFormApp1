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

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim stCountry As String
        stCountry = txtCountry.Text

        ' send to lowercase
        stCountry = stCountry.ToLower

        If stCountry = "australia" Then
            MessageBox.Show("Hello, Australian. How are you?")
        ElseIf stCountry = "ghana" Then
            MessageBox.Show("Hello, Ghanaian. How are you?")
        Else
            MessageBox.Show("Hello, citizen of a country. How are you?")
        End If
    End Sub

    Private Sub btnCheckScore_Click(sender As Object, e As EventArgs) Handles btnCheckScore.Click
        Dim dblScore As Double

        ' input validation
        ' check if input is numeric before assignment
        If IsNumeric(txtExamScore.Text) Then
            dblScore = CDbl(txtExamScore.Text)
        Else
            MessageBox.Show("You must enter a number.")
            Exit Sub
        End If

        ' perform checks on score
        If dblScore > 0 And dblScore < 100 Then
            If dblScore >= 90 Then
                MessageBox.Show("Execellent")
            ElseIf dblScore >= 80 Then
                MessageBox.Show("Very Good")
            ElseIf dblScore >= 70 Then
                MessageBox.Show("Good")
            Else
                MessageBox.Show("Pass")
            End If
        Else
            MessageBox.Show("Invalid score.")
        End If

    End Sub

    Private Sub btnCheckTemp_Click(sender As Object, e As EventArgs) Handles btnCheckTemp.Click
        Dim intTemperature As Integer
        intTemperature = CInt(txtCheckTemp.Text)

        Select Case intTemperature
            Case Is = 0
                MessageBox.Show("Freezing")
            Case Is < 0
                MessageBox.Show("Sub zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 37, 38, 39, 40
                MessageBox.Show("Some temp.")
            Case Else
                MessageBox.Show("Hot")
        End Select
    End Sub
End Class
