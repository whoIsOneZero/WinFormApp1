﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStart = New Button()
        varButton = New Button()
        userInput = New Button()
        txtUsername = New TextBox()
        nameLabel = New Label()
        txtLastName = New TextBox()
        lastNameLabel = New Label()
        SubmitButton = New Button()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        txtCountry = New TextBox()
        countryLabel = New Label()
        btnGreet = New Button()
        txtExamScore = New TextBox()
        lblExamScore = New Label()
        btnCheckScore = New Button()
        txtCheckTemp = New TextBox()
        btnCheckTemp = New Button()
        btnCounter = New Button()
        btnCountUp = New Button()
        btnCountToTen = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(37, 108)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(109, 81)
        btnStart.TabIndex = 0
        btnStart.Text = "Press Here"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' varButton
        ' 
        varButton.Location = New Point(37, -9)
        varButton.Name = "varButton"
        varButton.Size = New Size(102, 100)
        varButton.TabIndex = 1
        varButton.Text = "Variable Demo"
        varButton.UseVisualStyleBackColor = True
        ' 
        ' userInput
        ' 
        userInput.Location = New Point(42, 207)
        userInput.Name = "userInput"
        userInput.Size = New Size(104, 77)
        userInput.TabIndex = 2
        userInput.Text = "Enter Name"
        userInput.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(184, 24)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 3
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(187, 4)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(60, 15)
        nameLabel.TabIndex = 4
        nameLabel.Text = "Username"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(184, 74)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(100, 23)
        txtLastName.TabIndex = 5
        ' 
        ' lastNameLabel
        ' 
        lastNameLabel.AutoSize = True
        lastNameLabel.Location = New Point(187, 56)
        lastNameLabel.Name = "lastNameLabel"
        lastNameLabel.Size = New Size(63, 15)
        lastNameLabel.TabIndex = 6
        lastNameLabel.Text = "Last Name"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(199, 124)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(75, 23)
        SubmitButton.TabIndex = 7
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 15
        lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Tinker", "Tailor", "Soldier", "Sailor"})
        lstOccupation.Location = New Point(184, 177)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(117, 139)
        lstOccupation.TabIndex = 8
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(184, 159)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(69, 15)
        lblOccupation.TabIndex = 9
        lblOccupation.Text = "Occupation"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(349, 24)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(109, 23)
        txtCountry.TabIndex = 10
        ' 
        ' countryLabel
        ' 
        countryLabel.AutoSize = True
        countryLabel.Location = New Point(349, 6)
        countryLabel.Name = "countryLabel"
        countryLabel.Size = New Size(161, 15)
        countryLabel.TabIndex = 11
        countryLabel.Text = "Which country are you from?"
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(363, 53)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(75, 23)
        btnGreet.TabIndex = 12
        btnGreet.Text = "Greeting"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(358, 114)
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(100, 23)
        txtExamScore.TabIndex = 13
        ' 
        ' lblExamScore
        ' 
        lblExamScore.AutoSize = True
        lblExamScore.Location = New Point(347, 96)
        lblExamScore.Name = "lblExamScore"
        lblExamScore.Size = New Size(141, 15)
        lblExamScore.TabIndex = 14
        lblExamScore.Text = "What is your exam score?"
        ' 
        ' btnCheckScore
        ' 
        btnCheckScore.Location = New Point(368, 143)
        btnCheckScore.Name = "btnCheckScore"
        btnCheckScore.Size = New Size(75, 23)
        btnCheckScore.TabIndex = 15
        btnCheckScore.Text = "Check Score"
        btnCheckScore.UseVisualStyleBackColor = True
        ' 
        ' txtCheckTemp
        ' 
        txtCheckTemp.Location = New Point(335, 200)
        txtCheckTemp.Name = "txtCheckTemp"
        txtCheckTemp.Size = New Size(175, 23)
        txtCheckTemp.TabIndex = 16
        ' 
        ' btnCheckTemp
        ' 
        btnCheckTemp.Location = New Point(358, 229)
        btnCheckTemp.Name = "btnCheckTemp"
        btnCheckTemp.Size = New Size(130, 37)
        btnCheckTemp.TabIndex = 17
        btnCheckTemp.Text = "Check Temperature"
        btnCheckTemp.UseVisualStyleBackColor = True
        ' 
        ' btnCounter
        ' 
        btnCounter.Location = New Point(383, 303)
        btnCounter.Name = "btnCounter"
        btnCounter.Size = New Size(90, 25)
        btnCounter.TabIndex = 18
        btnCounter.Text = "Press Counter"
        btnCounter.UseVisualStyleBackColor = True
        ' 
        ' btnCountUp
        ' 
        btnCountUp.Location = New Point(358, 350)
        btnCountUp.Name = "btnCountUp"
        btnCountUp.Size = New Size(143, 64)
        btnCountUp.TabIndex = 19
        btnCountUp.Text = "Count Up Odd or Even"
        btnCountUp.UseVisualStyleBackColor = True
        ' 
        ' btnCountToTen
        ' 
        btnCountToTen.Location = New Point(531, 18)
        btnCountToTen.Name = "btnCountToTen"
        btnCountToTen.Size = New Size(95, 46)
        btnCountToTen.TabIndex = 20
        btnCountToTen.Text = "Count to 10"
        btnCountToTen.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCountToTen)
        Controls.Add(btnCountUp)
        Controls.Add(btnCounter)
        Controls.Add(btnCheckTemp)
        Controls.Add(txtCheckTemp)
        Controls.Add(btnCheckScore)
        Controls.Add(lblExamScore)
        Controls.Add(txtExamScore)
        Controls.Add(btnGreet)
        Controls.Add(countryLabel)
        Controls.Add(txtCountry)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(SubmitButton)
        Controls.Add(lastNameLabel)
        Controls.Add(txtLastName)
        Controls.Add(nameLabel)
        Controls.Add(txtUsername)
        Controls.Add(userInput)
        Controls.Add(varButton)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents varButton As Button
    Friend WithEvents userInput As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents countryLabel As Label
    Friend WithEvents btnGreet As Button
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents lblExamScore As Label
    Friend WithEvents btnCheckScore As Button
    Friend WithEvents txtCheckTemp As TextBox
    Friend WithEvents btnCheckTemp As Button
    Friend WithEvents btnCounter As Button
    Friend WithEvents btnCountUp As Button
    Friend WithEvents btnCountToTen As Button

End Class
