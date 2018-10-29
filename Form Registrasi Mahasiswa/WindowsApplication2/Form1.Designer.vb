<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.names = New System.Windows.Forms.TextBox()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.religion = New System.Windows.Forms.ComboBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.gey = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.addr = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.geming = New System.Windows.Forms.CheckBox()
        Me.Fishing = New System.Windows.Forms.CheckBox()
        Me.coding = New System.Windows.Forms.CheckBox()
        Me.studying = New System.Windows.Forms.CheckBox()
        Me.thinking = New System.Windows.Forms.CheckBox()
        Me.sinking = New System.Windows.Forms.CheckBox()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sambitButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'names
        '
        Me.names.Location = New System.Drawing.Point(102, 36)
        Me.names.Name = "names"
        Me.names.Size = New System.Drawing.Size(168, 20)
        Me.names.TabIndex = 1
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(102, 62)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(168, 20)
        Me.nim.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DOB"
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(102, 175)
        Me.pwd.Name = "pwd"
        Me.pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd.Size = New System.Drawing.Size(168, 20)
        Me.pwd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Religion"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(102, 251)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(168, 20)
        Me.email.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(102, 277)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(168, 20)
        Me.phone.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone"
        '
        'religion
        '
        Me.religion.FormattingEnabled = True
        Me.religion.Items.AddRange(New Object() {"Moslem", "Christian", "Buddhism", "Fascism", "Madokaism", "Protestant"})
        Me.religion.Location = New System.Drawing.Point(102, 225)
        Me.religion.Name = "religion"
        Me.religion.Size = New System.Drawing.Size(168, 21)
        Me.religion.TabIndex = 14
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(102, 201)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 15
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(156, 201)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 16
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'gey
        '
        Me.gey.AutoSize = True
        Me.gey.Location = New System.Drawing.Point(221, 201)
        Me.gey.Name = "gey"
        Me.gey.Size = New System.Drawing.Size(44, 17)
        Me.gey.TabIndex = 17
        Me.gey.TabStop = True
        Me.gey.Text = "Gay"
        Me.gey.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Address"
        '
        'addr
        '
        Me.addr.Location = New System.Drawing.Point(102, 114)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(168, 55)
        Me.addr.TabIndex = 20
        Me.addr.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Hobby"
        '
        'geming
        '
        Me.geming.AutoSize = True
        Me.geming.Location = New System.Drawing.Point(102, 307)
        Me.geming.Name = "geming"
        Me.geming.Size = New System.Drawing.Size(61, 17)
        Me.geming.TabIndex = 22
        Me.geming.Text = "Geminx"
        Me.geming.UseVisualStyleBackColor = True
        '
        'Fishing
        '
        Me.Fishing.AutoSize = True
        Me.Fishing.Location = New System.Drawing.Point(169, 306)
        Me.Fishing.Name = "Fishing"
        Me.Fishing.Size = New System.Drawing.Size(59, 17)
        Me.Fishing.TabIndex = 23
        Me.Fishing.Text = "Fishing"
        Me.Fishing.UseVisualStyleBackColor = True
        '
        'coding
        '
        Me.coding.AutoSize = True
        Me.coding.Location = New System.Drawing.Point(236, 306)
        Me.coding.Name = "coding"
        Me.coding.Size = New System.Drawing.Size(59, 17)
        Me.coding.TabIndex = 24
        Me.coding.Text = "Coding"
        Me.coding.UseVisualStyleBackColor = True
        '
        'studying
        '
        Me.studying.AutoSize = True
        Me.studying.Location = New System.Drawing.Point(102, 330)
        Me.studying.Name = "studying"
        Me.studying.Size = New System.Drawing.Size(67, 17)
        Me.studying.TabIndex = 25
        Me.studying.Text = "Studying"
        Me.studying.UseVisualStyleBackColor = True
        '
        'thinking
        '
        Me.thinking.AutoSize = True
        Me.thinking.Location = New System.Drawing.Point(169, 329)
        Me.thinking.Name = "thinking"
        Me.thinking.Size = New System.Drawing.Size(67, 17)
        Me.thinking.TabIndex = 26
        Me.thinking.Text = "Thinking"
        Me.thinking.UseVisualStyleBackColor = True
        '
        'sinking
        '
        Me.sinking.AutoSize = True
        Me.sinking.Location = New System.Drawing.Point(236, 329)
        Me.sinking.Name = "sinking"
        Me.sinking.Size = New System.Drawing.Size(61, 17)
        Me.sinking.TabIndex = 27
        Me.sinking.Text = "Sinking"
        Me.sinking.UseVisualStyleBackColor = True
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(102, 88)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(168, 20)
        Me.dob.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Exitz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sambitButton
        '
        Me.sambitButton.Location = New System.Drawing.Point(183, 353)
        Me.sambitButton.Name = "sambitButton"
        Me.sambitButton.Size = New System.Drawing.Size(75, 23)
        Me.sambitButton.TabIndex = 30
        Me.sambitButton.Text = "Sambit"
        Me.sambitButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Registration Form"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 384)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.sambitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.sinking)
        Me.Controls.Add(Me.thinking)
        Me.Controls.Add(Me.studying)
        Me.Controls.Add(Me.coding)
        Me.Controls.Add(Me.Fishing)
        Me.Controls.Add(Me.geming)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.addr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gey)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.male)
        Me.Controls.Add(Me.religion)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.names)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents names As TextBox
    Friend WithEvents nim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pwd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents religion As ComboBox
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents gey As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents addr As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents geming As CheckBox
    Friend WithEvents Fishing As CheckBox
    Friend WithEvents coding As CheckBox
    Friend WithEvents studying As CheckBox
    Friend WithEvents thinking As CheckBox
    Friend WithEvents sinking As CheckBox
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents sambitButton As Button
    Friend WithEvents Label11 As Label
End Class
