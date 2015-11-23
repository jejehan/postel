Imports DevExpress.XtraReports
Imports DevExpress.Web
Imports System
Imports System.IO
Imports System.Data.OleDb
Imports clsDataBase
Imports clsGeneral
Imports clsPersyaratan
Imports clsCallSign
Imports DevExpress.XtraReports.UI

Partial Class UserControls_ucCetakSKAR
    Inherits System.Web.UI.UserControl
    Public Shared NomorSKAR As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cx As New CheckBox
        Dim cxItem As CheckBox
        Dim cxItemArray As String = ""
        Dim s As String

        ReportViewer1.Report = CreateReport()
        If Page.IsPostBack = False Then
            ReportViewer2.Visible = False
            ReportToolbar1.Visible = False
            ReportViewer1.Visible = True
            gvDataSKAR.Visible = True
            gvTutupSKAR.Visible = False
            btnProsesTutupData.Visible = False
        Else
            cx = gvTutupSKAR.FindHeaderTemplateControl(TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxAll")
            With gvTutupSKAR
                If (.VisibleRowCount > 0) Then
                    For i = 0 To .VisibleRowCount - 1
                        cxItem = gvTutupSKAR.FindRowCellTemplateControl(i, TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxItem")
                        If cxItem.Checked = "True" Then
                            cxItemArray = cxItemArray & "," & i.ToString
                        End If
                    Next
                    If cxItemArray <> "" Then
                        Session("CheckItem") = Right(cxItemArray, Len(cxItemArray) - 1)
                    End If
                End If
            End With

            If cx.Checked = False Then
                Session("CheckAll") = "False"
                If cxItemArray <> "" Then
                    s = setCheckedItem(Session("CheckItem"))
                End If
            Else
                s = setCheckedAll(cx.Checked)
            End If
        End If
    End Sub

    Protected Sub btnPilih_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlNomorSKAR As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlNomorSKAR"), Literal)
        NomorSKAR = ltrlNomorSKAR.Text
        ReportViewer1.Report = CreateReport()
    End Sub

    Private Function CreateReport() As XtraReport
        Dim report As New rptPreviewSKAR()
        report.nmrSKAR.Value = NomorSKAR
        report.CreateDocument()
        Return report
    End Function

    Private Function GetSelectedValue(ByVal defaultValue As String) As String
        If NomorSKAR <> "" Then
            Return NomorSKAR
        Else
            Dim dt As DataTable
            dt = qFindDataSKAR()
            NomorSKAR = dt.Rows(0)("NomorSKAR")
            Return NomorSKAR
        End If
    End Function

    Protected Sub btnCetakData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCetakData.Click
        ReportViewer1.Visible = False
        gvDataSKAR.Visible = False
        gvTutupSKAR.Visible = False
        btnProsesTutupData.Visible = False
        ReportViewer2.Visible = True
        ReportToolbar1.Visible = True
    End Sub

    Protected Sub btnEditData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditData.Click
        ReportViewer1.Visible = True
        gvDataSKAR.Visible = True
        gvDataSKAR.DataBind()
        gvTutupSKAR.Visible = False
        btnProsesTutupData.Visible = False
        ReportViewer2.Visible = False
        ReportToolbar1.Visible = False
    End Sub

    Protected Sub btnTutupData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTutupData.Click
        ReportViewer1.Visible = False
        gvDataSKAR.Visible = False
        gvTutupSKAR.Visible = True
        btnProsesTutupData.Visible = True
        ReportViewer2.Visible = False
        ReportToolbar1.Visible = False
    End Sub

    Protected Sub gvDataSKAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If

    End Sub

    Protected Sub gvTutupSKAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If

    End Sub

    Protected Sub CxAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim s As String
        Dim cx As CheckBox

        cx = sender
        s = setCheckedAll(cx.Checked)
        cx = Nothing
        GC.Collect()
        Session("CheckAll") = "True"

    End Sub

    Function setCheckedAll(ByVal NewVal As Boolean) As String

        Dim s As String = ""
        Dim i As Integer
        Dim cx As CheckBox

        Try
            With gvTutupSKAR
                If (.VisibleRowCount > 0) Then
                    For i = 0 To .VisibleRowCount - 1 '// Set Checkbox in All Rows
                        cx = .FindRowCellTemplateControl(i, TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxItem")
                        cx.Checked = NewVal
                    Next
                    cx = .FindHeaderTemplateControl(TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxAll")
                    cx.Checked = NewVal
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        cx = Nothing
        GC.Collect()
        Return s

    End Function

    Function setCheckedItem(ByVal cxItemArray As String) As String
        Dim s As String = ""
        Dim i As Integer
        Dim cxItem As CheckBox

        Try
            With gvTutupSKAR
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(cxItemArray, ",")
                    For i = 0 To cxArray.Length - 1
                        cxItem = .FindRowCellTemplateControl(cxArray.GetValue(i), TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxItem")
                        cxItem.Checked = "False"
                    Next
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        cxItem = Nothing
        GC.Collect()
        Return s

    End Function

    Function ArrayCheckList(ByVal row As Integer) As String

        Dim ProsesID As String = ""
        Dim s As String = ""

        Try
            Dim ch As CheckBox = TryCast(gvTutupSKAR.FindRowCellTemplateControl(row, TryCast(gvTutupSKAR.Columns(1), GridViewDataColumn), "CxItem"), CheckBox)
            If ch.Checked = True Then
                ProsesID = gvTutupSKAR.GetRowValues(row, New String() {gvTutupSKAR.KeyFieldName}).ToString()
            End If
        Catch ex As Exception
            s = ex.Message
        End Try

        Return ProsesID

    End Function

    Protected Sub btnProsesTutupData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProsesTutupData.Click
        Dim s As String = ""
        Dim ProsesID As String = ""
        Dim ArlTs As New ArrayList

        Try
            For i As Integer = 0 To gvTutupSKAR.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    s = qUpdateDataProses(ProsesID, "7")
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Print SKAR", "UserPrint", Session("UserID"), "DatePrint", ProsesID)
                    s = InsertDataProcess(s)
                    s = qDelete("DataSKAR", " ProsesID='" & ProsesID & "'")
                    s = InsertDataProcess(s)
                End If
            Next
            gvTutupSKAR.DataBind()
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

End Class
