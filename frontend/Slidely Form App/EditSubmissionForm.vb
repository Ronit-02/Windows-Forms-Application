Imports Newtonsoft.Json
Imports System.IO
Imports System.Net

Public Class EditSubmissionForm
    Private currentId As Integer

    Public Sub New(id As Integer, name As String, email As String, phone As String, link As String, time As String)
        InitializeComponent()
        currentId = id
        nameEdit.Text = name
        emailEdit.Text = email
        phoneEdit.Text = phone
        linkEdit.Text = link
        timeEdit.Text = time
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.C Then
            cancelButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            saveButton.PerformClick()
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Try
            Dim updatedSubmission As New Dictionary(Of String, String) From {
                {"name", nameEdit.Text},
                {"email", emailEdit.Text},
                {"phone", phoneEdit.Text},
                {"link", linkEdit.Text},
                {"time", timeEdit.Text}
            }

            Dim request As WebRequest = WebRequest.Create($"http://localhost:8000/update/{currentId}")
            request.Method = "PUT"
            request.ContentType = "application/json"

            Dim data As String = JsonConvert.SerializeObject(updatedSubmission)
            Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
            request.ContentLength = byteArray.Length

            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As WebResponse = request.GetResponse()
            response.Close()

            MessageBox.Show("Submission updated successfully.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating submission: " & ex.Message)
        End Try
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
End Class
