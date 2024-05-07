Public Class HomePage
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim result = PasswordValidator.checkPassword(PasswordInput.Text)
        If result Then
            MessageBox.Show("Access Granted: Congratulations, Code Whisperer!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Access Denied: Did You Try ‘Password123’? 🙃", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SecureSubmitButton_Click(sender As Object, e As EventArgs) Handles SecureSubmitButton.Click
        Dim password = PasswordInput.Text
        Dim result = PasswordValidator.checkPasswordSecure(password)
        If result Then
            MessageBox.Show("Access Granted: Level Up Your Hacker Hat!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Access Denied: Did You Forget to Wear Your Hacker Hat?", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
