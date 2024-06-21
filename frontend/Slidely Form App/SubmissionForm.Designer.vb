<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        nameLabel = New Label()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()
        nameTextInput = New TextBox()
        emailTextInput = New TextBox()
        phoneTextInput = New TextBox()
        githubTextInput = New TextBox()
        stopwatchText = New TextBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        stopwatchButton = New YellowButton()
        submitForm = New BlueButton()
        SuspendLayout()
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(203, 91)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(39, 15)
        nameLabel.TabIndex = 2
        nameLabel.Text = "Name"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(203, 137)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(36, 15)
        emailLabel.TabIndex = 3
        emailLabel.Text = "Email"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Location = New Point(203, 183)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(71, 15)
        phoneLabel.TabIndex = 4
        phoneLabel.Text = "Phone Num"
        ' 
        ' githubLabel
        ' 
        githubLabel.AutoSize = True
        githubLabel.Location = New Point(203, 230)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(122, 15)
        githubLabel.TabIndex = 5
        githubLabel.Text = "GitHub Link for Task 2"
        ' 
        ' nameTextInput
        ' 
        nameTextInput.Location = New Point(380, 88)
        nameTextInput.Name = "nameTextInput"
        nameTextInput.Size = New Size(186, 23)
        nameTextInput.TabIndex = 6
        ' 
        ' emailTextInput
        ' 
        emailTextInput.Location = New Point(380, 134)
        emailTextInput.Name = "emailTextInput"
        emailTextInput.Size = New Size(186, 23)
        emailTextInput.TabIndex = 7
        ' 
        ' phoneTextInput
        ' 
        phoneTextInput.Location = New Point(380, 180)
        phoneTextInput.Name = "phoneTextInput"
        phoneTextInput.Size = New Size(186, 23)
        phoneTextInput.TabIndex = 8
        ' 
        ' githubTextInput
        ' 
        githubTextInput.Location = New Point(380, 227)
        githubTextInput.Name = "githubTextInput"
        githubTextInput.Size = New Size(186, 23)
        githubTextInput.TabIndex = 9
        ' 
        ' stopwatchText
        ' 
        stopwatchText.Location = New Point(442, 302)
        stopwatchText.Name = "stopwatchText"
        stopwatchText.ReadOnly = True
        stopwatchText.Size = New Size(124, 23)
        stopwatchText.TabIndex = 10
        stopwatchText.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(272, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 15)
        Label1.TabIndex = 11
        Label1.Text = "John Doe, Slidely Task 2 - Create Submission"
        ' 
        ' stopwatchButton
        ' 
        stopwatchButton.ButtonBackColor = Color.FromArgb(CByte(255), CByte(230), CByte(170))
        stopwatchButton.ButtonForeColor = Color.Black
        stopwatchButton.Cursor = Cursors.Hand
        stopwatchButton.Location = New Point(203, 296)
        stopwatchButton.Name = "stopwatchButton"
        stopwatchButton.Size = New Size(213, 33)
        stopwatchButton.TabIndex = 12
        stopwatchButton.Text = "TOGGLE STOPWATCH (CTRL + T)"
        stopwatchButton.UseVisualStyleBackColor = True
        ' 
        ' submitForm
        ' 
        submitForm.ButtonBackColor = Color.FromArgb(CByte(179), CByte(220), CByte(250))
        submitForm.ButtonForeColor = Color.Black
        submitForm.Cursor = Cursors.Hand
        submitForm.Location = New Point(203, 352)
        submitForm.Name = "submitForm"
        submitForm.Size = New Size(363, 40)
        submitForm.TabIndex = 13
        submitForm.Text = "SUBMIT (CTRL + S) "
        submitForm.UseVisualStyleBackColor = True
        ' 
        ' SubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(submitForm)
        Controls.Add(stopwatchButton)
        Controls.Add(Label1)
        Controls.Add(stopwatchText)
        Controls.Add(githubTextInput)
        Controls.Add(phoneTextInput)
        Controls.Add(emailTextInput)
        Controls.Add(nameTextInput)
        Controls.Add(githubLabel)
        Controls.Add(phoneLabel)
        Controls.Add(emailLabel)
        Controls.Add(nameLabel)
        KeyPreview = True
        Name = "SubmissionForm"
        Text = "SubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents githubLabel As Label
    Friend WithEvents nameTextInput As TextBox
    Friend WithEvents emailTextInput As TextBox
    Friend WithEvents phoneTextInput As TextBox
    Friend WithEvents githubTextInput As TextBox
    Friend WithEvents stopwatchText As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents stopwatchButton As YellowButton
    Friend WithEvents submitForm As BlueButton
End Class
