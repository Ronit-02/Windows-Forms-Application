<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        nameText = New TextBox()
        emailText = New TextBox()
        phoneText = New TextBox()
        linkText = New TextBox()
        timeText = New TextBox()
        Label6 = New Label()
        prevButton = New YellowButton()
        nextButton = New BlueButton()
        deleteButton = New Button()
        editButton = New Button()
        searchTextBox = New TextBox()
        searchButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(201, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(201, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 3
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(201, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 4
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(201, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 5
        Label4.Text = "GitHub Link for Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(201, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 6
        Label5.Text = "Stopwatch Time"
        ' 
        ' nameText
        ' 
        nameText.Location = New Point(420, 102)
        nameText.Name = "nameText"
        nameText.ReadOnly = True
        nameText.Size = New Size(170, 23)
        nameText.TabIndex = 7
        nameText.TextAlign = HorizontalAlignment.Center
        ' 
        ' emailText
        ' 
        emailText.Location = New Point(420, 144)
        emailText.Name = "emailText"
        emailText.ReadOnly = True
        emailText.Size = New Size(170, 23)
        emailText.TabIndex = 8
        emailText.TextAlign = HorizontalAlignment.Center
        ' 
        ' phoneText
        ' 
        phoneText.Location = New Point(420, 189)
        phoneText.Name = "phoneText"
        phoneText.ReadOnly = True
        phoneText.Size = New Size(170, 23)
        phoneText.TabIndex = 9
        phoneText.TextAlign = HorizontalAlignment.Center
        ' 
        ' linkText
        ' 
        linkText.Location = New Point(420, 233)
        linkText.Name = "linkText"
        linkText.ReadOnly = True
        linkText.Size = New Size(170, 23)
        linkText.TabIndex = 10
        linkText.TextAlign = HorizontalAlignment.Center
        ' 
        ' timeText
        ' 
        timeText.Location = New Point(420, 278)
        timeText.Name = "timeText"
        timeText.ReadOnly = True
        timeText.Size = New Size(170, 23)
        timeText.TabIndex = 11
        timeText.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(276, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(235, 15)
        Label6.TabIndex = 12
        Label6.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' prevButton
        ' 
        prevButton.ButtonBackColor = Color.FromArgb(CByte(255), CByte(230), CByte(170))
        prevButton.ButtonForeColor = Color.Black
        prevButton.Cursor = Cursors.Hand
        prevButton.Location = New Point(201, 389)
        prevButton.Name = "prevButton"
        prevButton.Size = New Size(181, 34)
        prevButton.TabIndex = 13
        prevButton.Text = "PREVIOUS (CTRL + P)"
        prevButton.UseVisualStyleBackColor = True
        ' 
        ' nextButton
        ' 
        nextButton.ButtonBackColor = Color.FromArgb(CByte(179), CByte(220), CByte(250))
        nextButton.ButtonForeColor = Color.Black
        nextButton.Cursor = Cursors.Hand
        nextButton.Location = New Point(409, 389)
        nextButton.Name = "nextButton"
        nextButton.Size = New Size(181, 34)
        nextButton.TabIndex = 14
        nextButton.Text = "NEXT (CTRL + N)"
        nextButton.UseVisualStyleBackColor = True
        ' 
        ' deleteButton
        ' 
        deleteButton.Cursor = Cursors.Hand
        deleteButton.Location = New Point(409, 343)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(181, 31)
        deleteButton.TabIndex = 15
        deleteButton.Text = "DELETE (CTRL + D)"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' editButton
        ' 
        editButton.Cursor = Cursors.Hand
        editButton.Location = New Point(201, 343)
        editButton.Name = "editButton"
        editButton.Size = New Size(181, 31)
        editButton.TabIndex = 16
        editButton.Text = "EDIT (CTRL + E)"
        editButton.UseVisualStyleBackColor = True
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Location = New Point(201, 55)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(268, 23)
        searchTextBox.TabIndex = 17
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(503, 55)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(87, 23)
        searchButton.TabIndex = 18
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(searchButton)
        Controls.Add(searchTextBox)
        Controls.Add(editButton)
        Controls.Add(deleteButton)
        Controls.Add(nextButton)
        Controls.Add(prevButton)
        Controls.Add(Label6)
        Controls.Add(timeText)
        Controls.Add(linkText)
        Controls.Add(phoneText)
        Controls.Add(emailText)
        Controls.Add(nameText)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents emailText As TextBox
    Friend WithEvents phoneText As TextBox
    Friend WithEvents linkText As TextBox
    Friend WithEvents timeText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents prevButton As YellowButton
    Friend WithEvents nextButton As BlueButton
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
End Class
