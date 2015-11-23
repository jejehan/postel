'--- System Module ---
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Data.OleDb
Imports System.Security.Cryptography

'--- Custom Module ---
Imports clsGeneral
Imports clsDataBase

'--- DevExpress Module ---
Imports DevExpress.Web

Partial Class usercontrols_ucImportFileUNAR

    Inherits System.Web.UI.UserControl
    Dim Message As String = ""
    Public Shared strGroupID As String = ""
    Public Shared MenuAwal As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s As String
        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            s = RefreshListFile()
        End If
    End Sub

#Region "Delete & Unduh"

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ltrlFileName As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)

        Dim s As String = ""
        Dim FileName As String = ""

        Try
            If Session("Admin") = "True" Then
                FileName = ltrlFileName.Text
                If FileName <> "" Then
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileUpload\") & FileName)
                    If TheFile.Exists Then
                        File.Delete(MapPath("~\FileUpload\") & FileName)
                        s = qDelete("Files", String.Format(" FileName='{0}'", FileName))
                        s = InsertDataProcess(s)
                        If Right(FileName, 4) = ".xls" Then
                            s = qDelete("DataProses", " GroupID='" & Replace(FileName, ".xls", "") & "'")
                            s = InsertDataProcess(s)
                            s = qDelete("DataLog", " GroupID='" & Replace(FileName, ".xls", "") & "'")
                            s = InsertDataProcess(s)
                            If MenuAwal = "SKAR" Then
                                s = qDelete("HasilUNAR", " GroupID='" & Replace(FileName, ".xls", "") & "'")
                                s = InsertDataProcess(s)
                            End If
                        End If
                    Else
                        s = qDelete("Files", String.Format(" FileName='{0}'", FileName))
                        s = InsertDataProcess(s)
                        Throw New FileNotFoundException()
                    End If
                Else
                    Message = "[Import 012]: Nama File tidak ditemukan..."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            Else
                Message = "[Import 013]: Hanya Admin yang bisa menghapus file..."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As FileNotFoundException
            Message = "[Import 014]: File tidak ditemukan..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        Catch ex As Exception
            Message = "[Import 015]: Hapus file gagal dengan error " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        s = RefreshListFile()

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim s As String = ""
    End Sub

    Protected Sub btnFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ltrlFileName As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)

        Dim s As String = ""
        Dim FileName As String = ""

        Try
            FileName = ltrlFileName.Text
            If FileName <> "" Then
                Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileUpload\") & FileName)
                If TheFile.Exists Then
                    Response.Redirect("~\FileUpload\" & FileName)
                End If
            Else
                Message = "[Import 012]: Nama File tidak ditemukan..."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As FileNotFoundException
            Message = "[Import 014]: File tidak ditemukan..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        Catch ex As Exception
            Message = "[Import 015]: Unduh file gagal dengan error " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
    End Sub

#End Region

    Function RefreshListFile() As String

        Dim s As String = ""
        Dim dt As New DataTable
        Dim Where As String = ""
        Dim SemuaData As String = ""
        Try
            If CbxSemuaData.Checked = False Then
                SemuaData = " AND Proses = True"
            End If
            If MenuAwal = "SKAR" Then
                Where = " WHERE TypeFile IN ('SKAR','UNAR') " & SemuaData
            Else
                Where = String.Format(" WHERE TypeFile = '{0}' " & SemuaData, Session("MenuAwal"))
            End If
            dt = GetListFile(Where)
            GvFileList.DataSource = dt
            GvFileList.DataBind()
        Catch ex As Exception
            Message = "[Import 016]: " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        Return s

    End Function

    Function GetMemberList(ByVal Where As String) As String

        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
        Dim dt As New DataTable

        Dim s As String = ""
        Try
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = "1"
            End If
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Protected Sub GvFileList_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)

        Dim hasImport As Boolean
        If e.GetValue("Proses") IsNot Nothing Then
            hasImport = CInt(Replace(Fix(e.GetValue("Proses")), Nothing, 0))
            If hasImport = True Then
                e.Row.BackColor = System.Drawing.Color.LightSalmon
            End If
        End If

    End Sub

    Protected Sub CbxSemuaData_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxSemuaData.CheckedChanged
        RefreshListFile()
    End Sub
End Class
