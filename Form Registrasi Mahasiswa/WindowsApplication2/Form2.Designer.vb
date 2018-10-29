<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(93, 50)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(100, 20)
        Me.nim.TabIndex = 3
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(93, 80)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(100, 20)
        Me.pwd.TabIndex = 4
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(93, 106)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 5
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 164)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.nim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nim As TextBox
    Friend WithEvents pwd As TextBox
    Friend WithEvents login As Button

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim iForm As New Form1

        If nim.Text.Equals(var.gUsername) And pwd.Text.Equals(var.gPassword) Then
            MsgBox("Login Success!" + vbNewLine + "Hello, " + var.gUsername, MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
        Else
            MsgBox("Wrong NIM and Password !", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Failed")
        End If
    End Sub
End Class
