Imports Newtonsoft.Json
Imports System.IO
Imports System.Net

Public Class ViewSubmissionsForm
    Private currentId As Integer
    Private maxId As Integer

    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        currentId = 1
        Try
            LoadMaxId()
            LoadSubmission(currentId)
            UpdateNavigationButtons()
        Catch ex As Exception
            MessageBox.Show("Error during form load: " & ex.Message)
        End Try
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            prevButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            nextButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            editButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            deleteButton.PerformClick()
        End If
    End Sub

    Private Sub LoadMaxId()
        Try
            Dim request As WebRequest = WebRequest.Create("http://localhost:8000/get-max-id")
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            ' Deserialize the JSON response
            Dim maxIdResponse As Dictionary(Of String, Integer) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(responseFromServer)

            If maxIdResponse IsNot Nothing AndAlso maxIdResponse.ContainsKey("maxId") Then
                maxId = maxIdResponse("maxId")
            Else
                MessageBox.Show("Max ID not found in response.")
            End If

            reader.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading max ID: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateNavigationButtons()
        Try
            prevButton.Enabled = currentId > 1
            nextButton.Enabled = currentId < maxId
        Catch ex As Exception
            MessageBox.Show("Error updating navigation buttons: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSubmission(id As Integer)
        Try
            Dim request As WebRequest = WebRequest.Create($"http://localhost:8000/read/{id}")
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            ' Deserialize the JSON response
            Dim submission As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseFromServer)

            If submission IsNot Nothing Then
                ' Assign values to text boxes
                nameText.Text = If(submission.ContainsKey("name"), submission("name").ToString(), "")
                emailText.Text = If(submission.ContainsKey("email"), submission("email").ToString(), "")
                phoneText.Text = If(submission.ContainsKey("phone"), submission("phone").ToString(), "")
                linkText.Text = If(submission.ContainsKey("link"), submission("link").ToString(), "")
                timeText.Text = If(submission.ContainsKey("time"), submission("time").ToString(), "")
                currentId = id
                UpdateNavigationButtons()
            Else
                MessageBox.Show("No submission found.")
            End If

            reader.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading submission: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        If currentId > 1 Then
            LoadSubmission(currentId - 1)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If currentId < maxId Then
            LoadSubmission(currentId + 1)
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If currentId > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Dim request As WebRequest = WebRequest.Create($"http://localhost:8000/delete/{currentId}")
                    request.Method = "DELETE"
                    Dim response As WebResponse = request.GetResponse()
                    Dim dataStream As Stream = response.GetResponseStream()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()

                    reader.Close()
                    response.Close()

                    ' Update maxId after deletion
                    LoadMaxId()

                    ' Load next or previous submission
                    If currentId < maxId Then
                        LoadSubmission(currentId + 1)
                    ElseIf currentId > 1 Then
                        LoadSubmission(currentId - 1)
                    Else
                        ' No submissions left
                        nameText.Clear()
                        emailText.Clear()
                        phoneText.Clear()
                        linkText.Clear()
                        timeText.Clear()
                        currentId = 0
                    End If

                    UpdateNavigationButtons()
                    MessageBox.Show("Submission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting submission: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("No submission selected to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim editForm As New EditSubmissionForm(currentId, nameText.Text, emailText.Text, phoneText.Text, linkText.Text, timeText.Text)
        editForm.ShowDialog()
        LoadSubmission(currentId)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Try
            Dim email As String = searchTextBox.Text
            Dim request As WebRequest = WebRequest.Create($"http://localhost:8000/search?email={email}")
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            ' Deserialize the JSON response
            Dim submission As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseFromServer)

            If submission IsNot Nothing Then
                ' Assign values to text boxes
                nameText.Text = If(submission.ContainsKey("name"), submission("name").ToString(), "")
                emailText.Text = If(submission.ContainsKey("email"), submission("email").ToString(), "")
                phoneText.Text = If(submission.ContainsKey("phone"), submission("phone").ToString(), "")
                linkText.Text = If(submission.ContainsKey("link"), submission("link").ToString(), "")
                timeText.Text = If(submission.ContainsKey("time"), submission("time").ToString(), "")
                currentId = submission("id")
                searchTextBox.Clear()
                UpdateNavigationButtons()
            Else
                MessageBox.Show("No submission found.")
            End If

            reader.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("No submission found.")
            'MessageBox.Show("Error during search: " & ex.Message)
        End Try
    End Sub
End Class