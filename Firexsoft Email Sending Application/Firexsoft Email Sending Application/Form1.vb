Imports System.Web
Imports System.IO
Imports System.Net.Mail
Public Class Form1

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Dim email As New MailMessage
    Dim smtp As New SmtpClient
    Dim mail As System.Net.Mail.MailAddress

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        email.From = New MailAddress(TextBox1.Text)
        email.Subject = TextBox3.Text
        email.Body = RichTextBox1.Text
        email.To.Add(TextBox4.Text)
        smtp.EnableSsl = True
        smtp.Port = TextBox5.Text
        smtp.Host = TextBox6.Text
        smtp.Send(email)
        MsgBox("The e-mail has been sent!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class