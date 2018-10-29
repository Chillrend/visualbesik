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
        Me.addItem = New System.Windows.Forms.TextBox()
        Me.isLeft = New System.Windows.Forms.CheckBox()
        Me.addToList = New System.Windows.Forms.Button()
        Me.listLeft = New System.Windows.Forms.ListBox()
        Me.oneListToRight = New System.Windows.Forms.Button()
        Me.allListToRight = New System.Windows.Forms.Button()
        Me.oneListToLeft = New System.Windows.Forms.Button()
        Me.allListToLeft = New System.Windows.Forms.Button()
        Me.listRight = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'addItem
        '
        Me.addItem.Location = New System.Drawing.Point(60, 27)
        Me.addItem.Name = "addItem"
        Me.addItem.Size = New System.Drawing.Size(280, 20)
        Me.addItem.TabIndex = 0
        '
        'isLeft
        '
        Me.isLeft.AutoSize = True
        Me.isLeft.Location = New System.Drawing.Point(347, 29)
        Me.isLeft.Name = "isLeft"
        Me.isLeft.Size = New System.Drawing.Size(60, 17)
        Me.isLeft.TabIndex = 1
        Me.isLeft.Text = "To Left"
        Me.isLeft.UseVisualStyleBackColor = True
        '
        'addToList
        '
        Me.addToList.Location = New System.Drawing.Point(413, 25)
        Me.addToList.Name = "addToList"
        Me.addToList.Size = New System.Drawing.Size(75, 23)
        Me.addToList.TabIndex = 2
        Me.addToList.Text = "Add"
        Me.addToList.UseVisualStyleBackColor = True
        '
        'listLeft
        '
        Me.listLeft.FormattingEnabled = True
        Me.listLeft.Location = New System.Drawing.Point(31, 74)
        Me.listLeft.Name = "listLeft"
        Me.listLeft.Size = New System.Drawing.Size(208, 225)
        Me.listLeft.TabIndex = 3
        '
        'oneListToRight
        '
        Me.oneListToRight.Location = New System.Drawing.Point(255, 126)
        Me.oneListToRight.Name = "oneListToRight"
        Me.oneListToRight.Size = New System.Drawing.Size(75, 23)
        Me.oneListToRight.TabIndex = 4
        Me.oneListToRight.Text = ">"
        Me.oneListToRight.UseVisualStyleBackColor = True
        '
        'allListToRight
        '
        Me.allListToRight.Location = New System.Drawing.Point(255, 155)
        Me.allListToRight.Name = "allListToRight"
        Me.allListToRight.Size = New System.Drawing.Size(75, 23)
        Me.allListToRight.TabIndex = 5
        Me.allListToRight.Text = ">>"
        Me.allListToRight.UseVisualStyleBackColor = True
        '
        'oneListToLeft
        '
        Me.oneListToLeft.Location = New System.Drawing.Point(255, 184)
        Me.oneListToLeft.Name = "oneListToLeft"
        Me.oneListToLeft.Size = New System.Drawing.Size(75, 23)
        Me.oneListToLeft.TabIndex = 6
        Me.oneListToLeft.Text = "<"
        Me.oneListToLeft.UseVisualStyleBackColor = True
        '
        'allListToLeft
        '
        Me.allListToLeft.Location = New System.Drawing.Point(255, 213)
        Me.allListToLeft.Name = "allListToLeft"
        Me.allListToLeft.Size = New System.Drawing.Size(75, 23)
        Me.allListToLeft.TabIndex = 7
        Me.allListToLeft.Text = "<<"
        Me.allListToLeft.UseVisualStyleBackColor = True
        '
        'listRight
        '
        Me.listRight.FormattingEnabled = True
        Me.listRight.Location = New System.Drawing.Point(347, 74)
        Me.listRight.Name = "listRight"
        Me.listRight.Size = New System.Drawing.Size(208, 225)
        Me.listRight.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 318)
        Me.Controls.Add(Me.listRight)
        Me.Controls.Add(Me.allListToLeft)
        Me.Controls.Add(Me.oneListToLeft)
        Me.Controls.Add(Me.allListToRight)
        Me.Controls.Add(Me.oneListToRight)
        Me.Controls.Add(Me.listLeft)
        Me.Controls.Add(Me.addToList)
        Me.Controls.Add(Me.isLeft)
        Me.Controls.Add(Me.addItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addItem As TextBox
    Friend WithEvents isLeft As CheckBox
    Friend WithEvents addToList As Button
    Friend WithEvents listLeft As ListBox
    Friend WithEvents oneListToRight As Button
    Friend WithEvents allListToRight As Button
    Friend WithEvents oneListToLeft As Button
    Friend WithEvents allListToLeft As Button
    Friend WithEvents listRight As ListBox
End Class
