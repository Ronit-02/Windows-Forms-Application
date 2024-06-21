Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class SubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchSeconds As Integer = 0

    Private Sub SubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Start the stopwatch as soon as the form loads
        Timer1.Start()
        stopwatchRunning = True
    End Sub

    Private Sub SubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            stopwatchButton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            submitForm.PerformClick()
        End If
    End Sub

    Private Sub btnStartPauseStopwatch_Click(sender As Object, e As EventArgs) Handles stopwatchButton.Click
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
            ' stopwatchText.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            stopwatchRunning = True
            ' stopwatchText.Text = "Pause Stopwatch"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchSeconds += 1
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(stopwatchSeconds)
        stopwatchText.Text = timeSpan.ToString("hh\:mm\:ss")
    End Sub

    Private Sub submitForm_Click(sender As Object, e As EventArgs) Handles submitForm.Click
        ' Stop the stopwatch when the form is submitted
        Timer1.Stop()
        stopwatchRunning = False

        Dim name As String = nameTextInput.Text
        Dim email As String = emailTextInput.Text
        Dim phone As String = phoneTextInput.Text
        Dim link As String = githubTextInput.Text
        Dim time As String = stopwatchText.Text

        Dim formData As New Dictionary(Of String, String)
        formData.Add("name", name)
        formData.Add("email", email)
        formData.Add("phone", phone)
        formData.Add("link", link)
        formData.Add("time", time)

        sendToApi(formData)

        nameTextInput.Clear()
        emailTextInput.Clear()
        phoneTextInput.Clear()
        githubTextInput.Clear()
        stopwatchText.Clear()

    End Sub

    Private Async Sub sendToApi(formData As Dictionary(Of String, String))

        Dim jsonData As String = JsonConvert.SerializeObject(formData)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))

            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:8000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed. Please try again.")
            End If
        End Using

    End Sub


    Private Sub toggleStopwatch_Click(sender As Object, e As EventArgs) Handles stopwatchButton.Click

    End Sub

    Private Sub emailTextInput_TextChanged(sender As Object, e As EventArgs) Handles emailTextInput.TextChanged

    End Sub

    Private Sub nameTextInput_TextChanged(sender As Object, e As EventArgs) Handles nameTextInput.TextChanged

    End Sub

    Private Sub phoneTextInput_TextChanged(sender As Object, e As EventArgs) Handles phoneTextInput.TextChanged

    End Sub

    Private Sub githubTextInput_TextChanged(sender As Object, e As EventArgs) Handles githubTextInput.TextChanged

    End Sub

End Class