Imports System.IO

Public Class accesso
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ExitYN = MsgBox("Vuoi veramente uscire?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim strUsername As String = Username.Text
        ' define a variable to hold the password
        Dim strPassword As String = Password.Text

        ' create a StreamReader to read the text file
        Using sr As New StreamReader("users.txt")
            ' read the file line by line
            Do While sr.Peek() >= 0
                ' get the current line
                Dim line As String = sr.ReadLine()

                ' split the line into an array of strings (separated by ",")
                Dim parts As String() = line.Split(","c)

                ' check if the first part (username) and the second part (password) match the entered values
                If parts(0) = strUsername And parts(1) = strPassword Then
                    ' login successful, show a message box
                    MessageBox.Show("Login successful!")
                    Return
                End If
            Loop
        End Using

        ' login failed, show an error message
        MessageBox.Show("Invalid username or password. Please try again.")
    End Sub

    Private Sub accesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
