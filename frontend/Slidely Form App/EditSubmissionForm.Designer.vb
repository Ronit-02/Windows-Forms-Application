<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubmissionForm
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
        saveButton = New BlueButton()
        cancelButton = New YellowButton()
        nameEdit = New TextBox()
        emailEdit = New TextBox()
        phoneEdit = New TextBox()
        linkEdit = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        timeEdit = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' saveButton
        ' 
        saveButton.ButtonBackColor = Color.FromArgb(CByte(179), CByte(220), CByte(250))
        saveButton.ButtonForeColor = Color.Black
        saveButton.Cursor = Cursors.Hand
        saveButton.Location = New Point(420, 350)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(153, 46)
        saveButton.TabIndex = 0
        saveButton.Text = "SAVE (CTRL + S)"
        saveButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.ButtonBackColor = Color.FromArgb(CByte(255), CByte(230), CByte(170))
        cancelButton.ButtonForeColor = Color.Black
        cancelButton.Cursor = Cursors.Hand
        cancelButton.Location = New Point(184, 350)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(160, 46)
        cancelButton.TabIndex = 1
        cancelButton.Text = "CANCEL (CTRL + C)"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' nameEdit
        ' 
        nameEdit.Location = New Point(410, 57)
        nameEdit.Name = "nameEdit"
        nameEdit.Size = New Size(154, 23)
        nameEdit.TabIndex = 2
        nameEdit.TextAlign = HorizontalAlignment.Center
        ' 
        ' emailEdit
        ' 
        emailEdit.Location = New Point(410, 108)
        emailEdit.Name = "emailEdit"
        emailEdit.Size = New Size(154, 23)
        emailEdit.TabIndex = 3
        emailEdit.TextAlign = HorizontalAlignment.Center
        ' 
        ' phoneEdit
        ' 
        phoneEdit.Location = New Point(410, 154)
        phoneEdit.Name = "phoneEdit"
        phoneEdit.Size = New Size(154, 23)
        phoneEdit.TabIndex = 4
        phoneEdit.TextAlign = HorizontalAlignment.Center
        ' 
        ' linkEdit
        ' 
        linkEdit.Location = New Point(410, 220)
        linkEdit.Name = "linkEdit"
        linkEdit.Size = New Size(163, 23)
        linkEdit.TabIndex = 5
        linkEdit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(209, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(209, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 7
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(204, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 8
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(198, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 9
        Label4.Text = "GitHub Link for Task 2"
        ' 
        ' timeEdit
        ' 
        timeEdit.Location = New Point(410, 289)
        timeEdit.Name = "timeEdit"
        timeEdit.ReadOnly = True
        timeEdit.Size = New Size(163, 23)
        timeEdit.TabIndex = 10
        timeEdit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(198, 297)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 11
        Label5.Text = "Stopwatch Time"
        ' 
        ' EditSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(timeEdit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(linkEdit)
        Controls.Add(phoneEdit)
        Controls.Add(emailEdit)
        Controls.Add(nameEdit)
        Controls.Add(cancelButton)
        Controls.Add(saveButton)
        KeyPreview = True
        Name = "EditSubmissionForm"
        Text = "EditSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents saveButton As BlueButton
    Friend WithEvents cancelButton As YellowButton
    Friend WithEvents nameEdit As TextBox
    Friend WithEvents emailEdit As TextBox
    Friend WithEvents phoneEdit As TextBox
    Friend WithEvents linkEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents timeEdit As TextBox
    Friend WithEvents Label5 As Label
End Class
