Imports clsGeneral
Imports clsDataBase
Imports clsFieldTable

'--- System Module ---
Imports System
Imports System.IO
Imports System.Data.OleDb
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
Imports System.Web.UI.HtmlControls.HtmlInputRadioButton
Imports Microsoft.VisualBasic.DateAndTime

'--- DevExpress Module ---
Imports DevExpress.XtraGrid
Imports DevExpress.Web
Imports DevExpress.Web.PanelCollection
Imports DevExpress.Web.PanelContent
Imports DevExpress.Web.ASPxGridView

Partial Class UserControls_ucPengaturan
    Inherits System.Web.UI.UserControl
    '--- Custom Module ---

    Private FieldsName() As String = {"UserID"}
    Public Shared UserID As String = ""
    Public Shared Nama As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s As String
        s = RefreshListUser()
    End Sub

    Function RefreshListUser() As String

        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(qSelectUserPassword(), cn)
            Dim dt As New DataTable
            da.Fill(dt)
            da.Dispose()
            cn.Dispose()
            If dt.Rows.Count > 0 Then
                GvUserList.DataSource = dt
                GvUserList.DataBind()
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        GvUserList.FocusedRowIndex = -1
        Return s

    End Function

    Protected Sub BtnUserBaru_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUserBaru.Click
        ClearAllTextBox()
        ViewState("_Save") = "Insert"
        TbxUserID.ReadOnly = False
    End Sub

    Sub ClearAllTextBox()
        TbxUserID.Text = ""
        TbxNama.Text = ""
        TbxEmail.Text = ""
        CbxAdmin.Checked = False
        CbxAktif.Checked = False
        CbxOrari.Checked = False
        CbxRapi.Checked = False
        GvUserList.FocusedRowIndex = -1
    End Sub

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim s As String = ""
        Dim _Save As String = ""
        _Save = ViewState("_Save")
        Select Case _Save
            Case "Insert"
                s = qInsertUserLogin(TbxUserID.Text, TbxNama.Text, TbxEmail.Text, TbxPassword.Text, CbxAdmin.Value, _
                CbxAktif.Value, CbxOrari.Value, CbxRapi.Value, Session("UserID").ToString)
                s = InsertDataBase(s)
                ViewState("_Save") = ""
            Case Else
                s = qUpdateUserLogin(TbxUserID.Text, TbxNama.Text, TbxEmail.Text, TbxPassword.Text, CbxAdmin.Value, _
                CbxAktif.Value, CbxOrari.Value, CbxRapi.Value, Session("UserID").ToString)
                s = InsertDataBase(s)
        End Select
        s = RefreshListUser()
        TbxUserID.ReadOnly = True
    End Sub

    Protected Sub GvUserList_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Protected Sub BtnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExportExcel.Click
        GvUserList_ExportAll.WriteXlsToResponse()
    End Sub

End Class


