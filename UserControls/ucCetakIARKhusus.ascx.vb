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

Partial Class UserControls_ucCetakIARKhusus
    Inherits System.Web.UI.UserControl
    Public Shared NomorIAR As String = ""
    Public Shared CallSign As String = ""
    Public Shared Tingkat As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cx As New CheckBox
        Dim cxItem As CheckBox
        Dim cxItemArray As String = ""
        Dim s As String
        Dim dt As New DataTable

        'ReportViewer1.Report = CreateReport()
        If Page.IsPostBack = False Then
            'dt = qFindDataIAR()
            'If dt.Rows.Count > 0 Then
            Display("Edit")
            gvDataIAR.Visible = True
            'rptEditIAR.Visible = True
            'End If
        Else
            'cx = gvTutupIAR.FindHeaderTemplateControl(TryCast(gvTutupIAR.Columns(0), GridViewDataColumn), "CxAll")
            'With gvTutupIAR
            '    If (.VisibleRowCount > 0) Then
            '        For i = 0 To .VisibleRowCount - 1
            '            cxItem = gvTutupIAR.FindRowCellTemplateControl(i, TryCast(gvTutupIAR.Columns(0), GridViewDataColumn), "CxItem")
            '            If cxItem.Checked = "True" Then
            '                cxItemArray = cxItemArray & "," & i.ToString
            '            End If
            '        Next
            '        If cxItemArray <> "" Then
            '            Session("CheckItem") = Right(cxItemArray, Len(cxItemArray) - 1)
            '        End If
            '    End If
            'End With

            'If cx.Checked = False Then
            '    Session("CheckAll") = "False"
            '    If cxItemArray <> "" Then
            '        s = setCheckedItem(Session("CheckItem"))
            '    End If
            'Else
            '    s = setCheckedAll(cx.Checked)
            'End If
            cx = gvTutupIAR.FindHeaderTemplateControl(TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxAll")
            With gvTutupIAR
                If (.VisibleRowCount > 0) Then
                    For i = 0 To .VisibleRowCount - 1
                        cxItem = gvTutupIAR.FindRowCellTemplateControl(i, TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxItem")
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

    Sub Display(ByVal Mode As String)
        Select Case Mode
            Case "Edit"
                divPreviewIAR.Visible = True
                divCetakIAR.Visible = False
                divProsesTutupData.Visible = False
            Case "Cetak"
                divPreviewIAR.Visible = False
                divCetakIAR.Visible = True
                divProsesTutupData.Visible = False
            Case "Tutup"
                divPreviewIAR.Visible = False
                divCetakIAR.Visible = False
                divProsesTutupData.Visible = True
        End Select
    End Sub

    'Protected Sub btnPilih_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim ltrlCallSign As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlCallSign"), Literal)
    '    Dim ltrlTingkat As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlTingkat"), Literal)
    '    CallSign = ltrlCallSign.Text
    '    Tingkat = ltrlTingkat.Text
    '    'rptEditIAR.Report = CreateReportPreview()
    'End Sub

    'Private Function CreateReportPreview() As XtraReport
    '    Dim report As New rptPreviewIAR()
    '    report._Tingkat.Value = Tingkat
    '    report._CallSign.Value = CallSign
    '    report.CreateDocument()
    '    Return report
    'End Function

    'Private Function CreateReportCetak(ByVal Tingkat As String) As XtraReport
    '    Dim reportCetak As New rptCetakIAR()
    '    reportCetak._Tingkat.Value = Tingkat
    '    reportCetak.CreateDocument()
    '    Return reportCetak
    'End Function

    Private Function GetSelectedValue(ByVal defaultValue As String) As String
        If CallSign <> "" Then
            Return CallSign
        Else
            Dim dt As DataTable
            dt = qFindDataIAR()
            NomorIAR = dt.Rows(0)("NomorIAR")
            Return NomorIAR
        End If
    End Function

    Protected Sub btnCetakData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCetakData.Click
        Display("Cetak")
        'btnIARPemula.Checked = True

        'rptCetakIARPemula.Visible = True
        'rptToolbarKhusus.Visible = True
        'rptCetakIARPenggalang.Visible = False
        'rptToolbarPenggalang.Visible = False
        'rptCetakIARSiaga.Visible = False
        'rptToolbarSiaga.Visible = False
        'rptCetakIARPenegak.Visible = False
        'rptToolbarPenegak.Visible = False

        '--- Cek Total Pemula ---
        'Dim dtPemula As New DataTable
        'dtPemula = qFindDataIAR("PEMULA")
        'btnIARPemula.Text = "Pemula (" & dtPemula.Rows.Count & ")"
        ''--- Cek Total Penggalang ---
        'Dim dtPenggalang As New DataTable
        'dtPenggalang = qFindDataIAR("PENGGALANG")
        'btnIARPenggalang.Text = "Penggalang (" & dtPenggalang.Rows.Count & ")"
        ''--- Cek Total Siaga ---
        'Dim dtSiaga As New DataTable
        'dtSiaga = qFindDataIAR("SIAGA")
        'btnIARSiaga.Text = "Siaga (" & dtSiaga.Rows.Count & ")"
        ''--- Cek Total Penegak ---
        'Dim dtPenegak As New DataTable
        'dtPenegak = qFindDataIAR("PENEGAK")
        'btnIARPenegak.Text = "Penegak (" & dtPenegak.Rows.Count & ")"

        '--- Default View ---
        btnCetakData.Checked = True
        'btnIARPemula.Checked = True
    End Sub

    Protected Sub btnEditData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditData.Click
        Display("Edit")
        gvDataIAR.Visible = True
        'rptEditIAR.Visible = True
        Dim dt As New DataTable
        dt = qFindDataIAR()
        If dt.Rows.Count > 0 Then
            divPreviewIAR.Visible = True
        End If
    End Sub

    Protected Sub btnTutupData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTutupData.Click
        Display("Tutup")
    End Sub

    Protected Sub gvDataIAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If

    End Sub

    Protected Sub gvTutupIAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

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
            With gvTutupIAR
                If (.VisibleRowCount > 0) Then
                    For i = 0 To .VisibleRowCount - 1 '// Set Checkbox in All Rows
                        cx = .FindRowCellTemplateControl(i, TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxItem")
                        cx.Checked = NewVal
                    Next
                    cx = .FindHeaderTemplateControl(TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxAll")
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
            With gvTutupIAR
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(cxItemArray, ",")
                    For i = 0 To cxArray.Length - 1
                        cxItem = .FindRowCellTemplateControl(cxArray.GetValue(i), TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxItem")
                        cxItem.Checked = "True"
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
            Dim ch As CheckBox = TryCast(gvTutupIAR.FindRowCellTemplateControl(row, TryCast(gvTutupIAR.Columns(1), GridViewDataColumn), "CxItem"), CheckBox)
            If ch.Checked = True Then
                ProsesID = gvTutupIAR.GetRowValues(row, New String() {gvTutupIAR.KeyFieldName}).ToString()
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
            For i As Integer = 0 To gvTutupIAR.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    s = qUpdateDataKhusus("15", ProsesID)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Cetak", "UserPrint", Session("UserID"), "DatePrint", ProsesID)
                    s = InsertDataProcess(s)
                    s = qDelete("DataIARKhusus", " ProsesID='" & ProsesID & "'")
                    s = InsertDataProcess(s)
                End If
            Next
            gvTutupIAR.DataBind()
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

End Class
