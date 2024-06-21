Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Label1 = New Label()
        btnCreateNewSubmission = New BlueButton()
        btnViewSubmissions = New YellowButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 15)
        Label1.TabIndex = 2
        Label1.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.ButtonBackColor = Color.FromArgb(CByte(179), CByte(220), CByte(250))
        btnCreateNewSubmission.ButtonForeColor = Color.Black
        btnCreateNewSubmission.Cursor = Cursors.Hand
        btnCreateNewSubmission.Location = New Point(201, 255)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(361, 40)
        btnCreateNewSubmission.TabIndex = 3
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = True
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.ButtonBackColor = Color.FromArgb(CByte(255), CByte(230), CByte(170))
        btnViewSubmissions.ButtonForeColor = Color.Black
        btnViewSubmissions.Cursor = Cursors.Hand
        btnViewSubmissions.Location = New Point(201, 163)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(361, 40)
        btnViewSubmissions.TabIndex = 4
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        ClientSize = New Size(797, 449)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "MainForm"
        Text = "Main Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateNewSubmission As BlueButton
    Friend WithEvents btnViewSubmissions As YellowButton
End Class
