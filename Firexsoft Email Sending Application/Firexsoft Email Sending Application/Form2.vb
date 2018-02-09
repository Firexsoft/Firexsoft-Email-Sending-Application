Imports System.ComponentModel
Imports System.Net.Mail
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        attach.Text$ = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Using mail As New MailMessage
            mail.From = New MailAddress(TextBox1.Text)
            mail.To.Add(destination.Text$)
            mail.Body = body.Text$
            If Not OpenFileDialog1.FileName = vbNullString Then
                Dim attach As New Attachment(OpenFileDialog1.FileName)
                mail.Attachments.Add(attach)
            End If
            mail.Subject = subject.Text$
            mail.Priority = mail.Priority.Normal
            Using SMTP As New SmtpClient
                SMTP.EnableSsl = True
                SMTP.Port = "587"
                SMTP.Host = "smtp.gmail.com"
                SMTP.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
                SMTP.Send(mail)
            End Using
        End Using
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        destination.Clear()
        subject.Clear()
        attach.Clear()
        body.Clear()
        MsgBox("Email has been sent successfully!, MsgBoxStyle.Information")
    End Sub
End Class