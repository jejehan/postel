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
Imports DevExpress.Data
Imports DevExpress.Web
Imports DevExpress.Web.PanelCollection
Imports DevExpress.Web.PanelContent
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.XtraReports.UI
Imports System.Web.UI.HtmlControls.HtmlInputRadioButton
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.DateAndTime
Imports clsDataBase
Imports clsGeneral
Imports clsPersyaratan

Partial Class UserControls_ucHasilUNAR
    Inherits UserControl
    Public Shared TypeData As String
    Public Shared TypeExport As String
    Public Shared NRI, NomorKTP, Callsign As String
    Public Shared ProsesID As String
    Public Shared ProsesLevel As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            If Session("UserID") Is Nothing Then
                Response.Redirect("~/login.aspx")
            End If
            btnProsesUNAR.Visible = False
        End If

    End Sub

    Protected Sub gvHasilUNAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If

    End Sub

    Protected Sub gvHasilUNAR_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)

        Dim hasImport As Boolean
        If e.GetValue("Hasil") IsNot Nothing Then
            hasImport = e.GetValue("Hasil")
            If hasImport = "Lulus" Then
                e.Row.BackColor = System.Drawing.Color.White
            Else
                e.Row.BackColor = System.Drawing.Color.Pink
            End If
        End If

    End Sub

    Protected Sub btnProsesUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProsesUNAR.Click
        Dim s As String = ""
        Dim Tingkat As String = ""
        Dim NomorUNAR As String = ""
        Dim dt As New DataTable

        Dim NilaiPS As Decimal = 0
        Dim NilaiTR As Decimal = 0
        Dim NilaiPR As Decimal = 0
        Dim NilaiBI As Decimal = 0
        Dim NilaiKM As Decimal = 0
        Dim Konstanta As Decimal = 1
        Dim Jumlah As Decimal = 0
        Dim Hasil As String = ""

        dt = qSelectHasilUNAR()
        With dt
            If .Rows.Count > 0 Then
                For i = 0 To .Rows.Count - 1
                    Hasil = .Rows(i)("Hasil")
                    NomorUNAR = .Rows(i)("NomorUNAR")
                    NilaiPS = .Rows(i)("PS")
                    NilaiTR = .Rows(i)("TR")
                    NilaiPR = .Rows(i)("PR")
                    NilaiBI = .Rows(i)("BI")
                    NilaiKM = .Rows(i)("KM")
                    Konstanta = .Rows(i)("Konstanta")
                    Tingkat = .Rows(i)("Tingkat")
                    Select Case Tingkat
                        Case "PEMULA", "SIAGA"
                            Jumlah = (NilaiPS + NilaiTR + NilaiPR) * (6 / 5)
                        Case "PENGGALANG"
                            Jumlah = (((NilaiPS + NilaiTR + NilaiPR + NilaiBI) * (6 / 7)) + NilaiKM)
                        Case "PENEGAK"
                            Jumlah = (((NilaiPS + NilaiTR + NilaiPR + NilaiBI) * (6 / 9)) + NilaiKM)
                    End Select
                    If Jumlah >= 50 Then
                        Hasil = "Lulus"
                    Else
                        Hasil = "Tidak Lulus"
                    End If
                    s = qUpdateHasilUNAR(NomorUNAR, Jumlah, Hasil, Session("UserID"))
                    s = InsertDataProcess(s)
                    s = qUpdateDataProsesHasilUNAR(NomorUNAR, Hasil)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Hasil UNAR", "UserHasilUNAR", Session("UserID"), "DateHasilUNAR", ProsesID)
                    s = InsertDataProcess(s)
                Next
            Else
                s = "Tidak ada data..."
            End If
            gvHasilUNAR.DataBind()
        End With
    End Sub

    Protected Sub btnExportExcell_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcell.Click
        ExportAll.WriteXlsToResponse()
    End Sub

End Class
