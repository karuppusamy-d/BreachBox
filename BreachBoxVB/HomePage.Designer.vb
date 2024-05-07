<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        PasswordLabel = New Label()
        PasswordInput = New TextBox()
        SubmitButton = New Button()
        SecureSubmitButton = New Button()
        SuspendLayout()
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New Point(46, 32)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(185, 20)
        PasswordLabel.TabIndex = 0
        PasswordLabel.Text = "Welcome to BreachBox VB"
        ' 
        ' PasswordInput
        ' 
        PasswordInput.Location = New Point(46, 70)
        PasswordInput.Name = "PasswordInput"
        PasswordInput.PasswordChar = "*"c
        PasswordInput.Size = New Size(279, 27)
        PasswordInput.TabIndex = 1
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(46, 113)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(99, 36)
        SubmitButton.TabIndex = 2
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' SecureSubmitButton
        ' 
        SecureSubmitButton.Location = New Point(151, 113)
        SecureSubmitButton.Name = "SecureSubmitButton"
        SecureSubmitButton.Size = New Size(124, 36)
        SecureSubmitButton.TabIndex = 3
        SecureSubmitButton.Text = "Submit Secure"
        SecureSubmitButton.UseVisualStyleBackColor = True
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 198)
        Controls.Add(SecureSubmitButton)
        Controls.Add(SubmitButton)
        Controls.Add(PasswordInput)
        Controls.Add(PasswordLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "HomePage"
        Text = "BreachBoxVB"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents SecureSubmitButton As Button

End Class
