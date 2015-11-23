Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports clsGeneral
Imports System

Public Class ClsSMTP
    Public Function SendingEmail(ByVal EmailFrom As String, ByVal EmailTo As String, ByVal EmailCC As String, _
                                 ByVal EmailSubjects As String, ByVal EmailBody As String, _
                                 ByVal FileAttachment As String) As String

        Dim s As String
        Dim eml As SmtpClient
        Dim ValMlMsg As MailMessage
        Dim atc As Attachment
        s = ""

        Try
            eml = New SmtpClient()
            eml.Host = MySMTP()
            ValMlMsg = New MailMessage()
            ValMlMsg.To.Clear()

            '--- Set From & To
            ValMlMsg.From = New MailAddress(EmailFrom)
            ValMlMsg.To.Add(EmailTo)
            ValMlMsg.CC.Add(EmailCC)
            'ValMlMsg.Bcc.Add(EmailBcc)
            ValMlMsg.Subject = EmailSubjects
            ValMlMsg.IsBodyHtml = True
            ValMlMsg.Body = EmailBody
            atc = New Attachment(FileAttachment)
            ValMlMsg.Attachments.Add(atc)
            ''''send email
            eml.Send(ValMlMsg)
        Catch ex As Exception
            s = ex.Message
        End Try

        eml = Nothing
        ValMlMsg = Nothing

        Return s

    End Function
End Class
