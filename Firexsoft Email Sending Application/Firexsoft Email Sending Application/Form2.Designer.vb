﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.attach = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.destination = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.body = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse Files"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Name:"
        '
        'attach
        '
        Me.attach.Location = New System.Drawing.Point(75, 80)
        Me.attach.Name = "attach"
        Me.attach.Size = New System.Drawing.Size(196, 20)
        Me.attach.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Send Files"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Destination:"
        '
        'destination
        '
        Me.destination.Location = New System.Drawing.Point(75, 106)
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(196, 20)
        Me.destination.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Body:"
        '
        'body
        '
        Me.body.Location = New System.Drawing.Point(75, 132)
        Me.body.Multiline = True
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(196, 54)
        Me.body.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Subject:"
        '
        'subject
        '
        Me.subject.Location = New System.Drawing.Point(75, 195)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(196, 20)
        Me.subject.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "From:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 265)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.body)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.destination)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.attach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents attach As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents destination As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents body As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents subject As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
