Imports System.Security.Cryptography

Public Class PasswordValidator
    Public Shared Function checkPassword(input As String) As Boolean
        ' Ch3ckm@t3
        Dim password = "Ch3ckm@t3"
        Return String.Compare(password, input) = 0
    End Function
    Public Shared Function checkPasswordSecure(input As String) As Boolean
        ' ByteMeUp!512
        Dim password = "d30442596ffa5dd3d286ce3e8130e20999f0749acc7c7d2800d3ab2f8601bb436c5cc35e3f6110295a8273e745a058d8a185943802752e410e071d02245cfcb7"
        Dim hashedPassword = HashPasswordSHA512(input)
        Return String.Compare(password, hashedPassword) = 0
    End Function


    'https://github.com/uk1337/VB.NET-Password-Hash-Functions/blob/main/HashFunctions.vb
    Private Shared Function HashPasswordSHA512(password As String) As String
        Dim sha512 = Security.Cryptography.SHA512.Create()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha512.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

End Class
