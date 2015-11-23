Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.HttpPostedFile
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports System.IO.StreamWriter
Imports DevExpress.Data
Imports DevExpress.Web
Imports DevExpress.Web.PanelCollection
Imports DevExpress.Web.PanelContent
Imports DevExpress.Web.ASPxGridView
Imports System.Web.UI.HtmlControls.HtmlInputRadioButton
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.DateAndTime
Imports clsDataBase
Imports clsGeneral
Imports Microsoft.VisualBasic.FileIO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Net.NetworkInformation

Partial Class UserControls_ucPengaturanEmail
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GetEmailDetails()
        End If
    End Sub

    Sub GetEmailDetails()

        PnlSendEmail.Visible = True

        Dim dt As New DataTable
        Dim s As String = ""
        Try
            Dim Where As String = " WHERE Company = '" & Session("Company") & "'"
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(qSelectSendEmail(Where), cn)
            da.Fill(dt)
            With dt
                If .Rows.Count > 0 Then
                    TbxEmailFrom.Text = .Rows(0)("EmailFrom")
                    TbxEmailTo.Text = .Rows(0)("EmailTo")
                    TbxEmailCc.Text = .Rows(0)("EmailCc")
                    TbxEmailSubject.Text = .Rows(0)("EmailSubject")
                    TbxEmailBody.Text = .Rows(0)("EmailBody")
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try

    End Sub

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim s As String

        s = qUpdateDataEmail(Session("Company"), TbxEmailFrom.Text, TbxEmailTo.Text, TbxEmailCc.Text, TbxEmailSubject.Text, TbxEmailBody.Text, Session("UserID"))
        s = InsertDataBase(s)
    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        GetEmailDetails()
    End Sub
End Class
