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
Imports System.Web.UI.HtmlControls.HtmlInputRadioButton
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.DateAndTime
Imports clsDataBase
Imports clsGeneral
Imports clsPersyaratan
Imports clsCallSign

Partial Class UserControls_ucDataProsesKhusus
    Inherits System.Web.UI.UserControl
    Public Shared TypeData As String = ""
    Public Shared TypeExport As String = ""
    Public Shared NRI, NomorKTP, Callsign As String
    Public Shared ProsesID As String = ""
    Public Shared ProsesLevel As String = ""
    Public Shared Message As String = ""
    Public Shared MenuAwal As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            MenuAwal = Session("MenuAwal")
        End If

        '--- Setting Kolom
        Select Case MenuAwal
            Case "SKAR", "IAR"
                GvListAnggota.Columns.Item(16).Visible = False
                GvListAnggota.Columns.Item(17).Visible = False
            Case "IKRAP"
                GvListAnggota.Columns.Item(3).Visible = False
                GvListAnggota.Columns.Item(5).Visible = False
                GvListAnggota.Columns.Item(6).Visible = False
                GvListAnggota.Columns.Item(12).Visible = False
                GvListAnggota.Columns.Item(13).Visible = False
                GvListAnggota.Columns.Item(14).Visible = False
                GvListAnggota.Columns.Item(15).Visible = False
                GvListAnggota.Columns.Item(16).Visible = False
                GvListAnggota.Columns.Item(17).Visible = False
                GvListAnggota.Columns.Item(18).Visible = False
        End Select

        If Page.IsPostBack = False Then
            DdlOrda.Items.Clear()
            DdlTingkat.Items.Clear()
            Session("FilterData") = "Semua"
            Select Case MenuAwal
                Case "SKAR", "IAR", "KHUSUS"
                    lblOrda.Text = "Orari Daerah: "
                    DdlTingkat.Items.Add("*SEMUA")
                    DdlTingkat.Items.Add("PEMULA")
                    DdlTingkat.Items.Add("SIAGA")
                    DdlTingkat.Items.Add("PENGGALANG")
                    DdlTingkat.Items.Add("PENEGAK")
                    DdlOrda.Items.Add("*SEMUA")
                    dt = qFindDistintOrariDaerah()
                    For i = 0 To dt.Rows.Count - 1
                        DdlOrda.Items.Add(dt.Rows(i)("OrdaName"))
                    Next
                    DdlOrda.SelectedIndex = 0
                    DdlTingkat.SelectedIndex = 0
                Case "IKRAP"
                    lblTingkat.Visible = False
                    DdlTingkat.Visible = False
                    dt = qFindListRapiDaerah()
                    lblOrda.Text = "Rapi Daerah: "
                    DdlOrda.Items.Add("*SEMUA")
                    dt = qFindDistintRapiDaerah()
                    For i = 0 To dt.Rows.Count - 1
                        DdlOrda.Items.Add(dt.Rows(i)("RapiDaerahName"))
                    Next
                    DdlOrda.SelectedIndex = 0
                    DdlTingkat.SelectedIndex = 0
            End Select
            SetButtonLeft()
            'BtnDataAll.Checked = True
        Else
            If Session("FilterData") Is Nothing Then
                Session("FilterData") = "Semua"
            End If
            GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)
        End If

    End Sub

    Sub SetButtonLeft()
        Dim s As String = "0"

        Select Case MenuAwal
            Case "SKAR"
                BtnLulusUNAR2.Visible = False
                BtnGagalUNAR2.Visible = False
                BtnDataProses.Visible = False
                BtnDataKembali.Visible = False
                lblMenuAwal.Text = "SKAR"
                '--- Get Total Data Row ---
                s = GetMemberCount(" WHERE ProsesLevel IN ('4','5','6','7','8','9','10','11') ")
                BtnDataAll.Text = "Semua Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('4') AND ProsesData = Yes ")
                btnTinjauData.Text = "Tinjau Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('5') AND HasilUNAR = '' AND ProsesData = Yes ")
                btnHasilUNAR.Text = "Hasil UNAR (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('5') AND HasilUNAR <> '' AND ProsesData = Yes ")
                btnPersetujuan.Text = "Persetujuan (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('6') AND ProsesData = Yes ")
                btnCetak.Text = "Cetak (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('7') AND ProsesData = Yes ")
                btnExport.Text = "Export (" & s & ")"
            Case "IAR"
                BtnLulusUNAR2.Visible = False
                BtnGagalUNAR2.Visible = False
                btnHasilUNAR.Visible = False
                lblMenuAwal.Text = "IAR"
                '--- Get Total Data Row ---
                s = GetMemberCount(" WHERE ProsesLevel IN ('12','13','14','15','16','17') AND Organisasi = 'Orari' ")
                BtnDataAll.Text = "Semua Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('12') AND Organisasi = 'Orari' AND ProsesData = Yes ")
                btnTinjauData.Text = "Tinjau Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('13') AND Organisasi = 'Orari' AND ProsesData = Yes ")
                btnPersetujuan.Text = "Persetujuan (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('14') AND Organisasi = 'Orari' AND ProsesData = Yes ")
                btnCetak.Text = "Cetak (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('15') AND Organisasi = 'Orari' AND ProsesData = Yes ")
                btnExport.Text = "Export (" & s & ")"
            Case "IKRAP"
                BtnLulusUNAR2.Visible = False
                BtnGagalUNAR2.Visible = False
                btnHasilUNAR.Visible = False
                lblMenuAwal.Text = "KRAP"
                '--- Get Total Data Row ---
                s = GetMemberCount(" WHERE ProsesLevel IN ('12','13','14','15','16','17') AND Organisasi = 'Rapi' ")
                BtnDataAll.Text = "Semua Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('12') AND Organisasi = 'Rapi' ")
                btnTinjauData.Text = "Tinjau Data (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('13') AND Organisasi = 'Rapi' ")
                btnPersetujuan.Text = "Persetujuan (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('14') AND Organisasi = 'Rapi' ")
                btnCetak.Text = "Cetak (" & s & ")"
                s = GetMemberCount(" WHERE ProsesLevel IN ('15') AND Organisasi = 'Rapi' ")
                btnExport.Text = "Export (" & s & ")"
        End Select

    End Sub

    Sub GetData(ByVal Filter As String, ByVal OrdaName As String, ByVal Tingkat As String)

        Dim ProsesLevel As String = ""
        Dim FilterData As String = ""
        Select Case MenuAwal
            Case "SKAR"
                If DdlOrda.Value <> "*SEMUA" Then
                    FilterData = " AND OrdaName = '" & DdlOrda.Value & "' "
                End If
                If DdlTingkat.Value <> "*SEMUA" Then
                    FilterData = FilterData & " AND Tingkat = '" & DdlTingkat.Value & "' "
                End If
                Select Case Filter
                    Case "Semua"
                        GetMemberList("WHERE ProsesLevel IN ('4','5','6','7','8','9','10') " & FilterData & " ")
                    Case "LulusUNAR"
                        GetMemberList("WHERE HasilUNAR = 'Lulus UNAR' AND ProsesData = Yes AND ProsesLevel IN ('5') " & FilterData & " ")
                    Case "GagalUNAR"
                        GetMemberList("WHERE HasilUNAR = 'Gagal UNAR' AND ProsesData = Yes AND ProsesLevel IN ('5') " & FilterData & " ")
                    Case "DataDiproses"
                        GetMemberList("WHERE ProsesData = Yes" & FilterData & " ")
                    Case "DataDikembalikan"
                        GetMemberList("WHERE ProsesData = No" & FilterData & " ")
                    Case "TinjauData"
                        GetMemberList("WHERE ProsesLevel IN ('4')" & FilterData & " ")
                    Case "HasilUNAR"
                        GetMemberList("WHERE HasilUNAR = '' AND ProsesLevel IN ('5')" & FilterData & " ")
                    Case "Persetujuan"
                        GetMemberList("WHERE ProsesLevel IN ('5')" & FilterData & " ")
                    Case "Cetak"
                        GetMemberList("WHERE ProsesLevel IN ('6')" & FilterData & " ")
                    Case "Export"
                        GetMemberList("WHERE ProsesLevel IN ('7')" & FilterData & " ")
                End Select
            Case "IAR"
                If DdlOrda.Value <> "*SEMUA" Then
                    FilterData = " AND OrdaName = '" & DdlOrda.Value & "' "
                End If
                If DdlTingkat.Value <> "*SEMUA" Then
                    FilterData = FilterData & " AND Tingkat = '" & DdlTingkat.Value & "' "
                End If
                Select Case Filter
                    Case "Semua"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesLevel IN ('12','13','14','15','16','17') " & FilterData & " ")
                    Case "DataDiproses"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesData = Yes" & FilterData & " ")
                    Case "DataDikembalikan"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesData = No" & FilterData & " ")
                    Case "TinjauData"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesLevel IN ('12')" & FilterData & " ")
                    Case "Persetujuan"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesLevel IN ('13')" & FilterData & " ")
                    Case "Cetak"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesLevel IN ('14')" & FilterData & " ")
                    Case "Export"
                        GetMemberList("WHERE Organisasi = 'Orari' AND ProsesLevel IN ('15')" & FilterData & " ")
                End Select
            Case "IKRAP"
                If DdlOrda.Value <> "*SEMUA" Then
                    FilterData = " AND RapiDaerahName = '" & DdlOrda.Value & "' "
                End If
                If DdlTingkat.Value <> "*SEMUA" Then
                    FilterData = FilterData & " AND Tingkat = '" & DdlTingkat.Value & "' "
                End If
                Select Case Filter
                    Case "Semua"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesLevel IN ('12','13','14','15','16','17') " & FilterData & " ")
                    Case "DataDiproses"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesData = Yes" & FilterData & " ")
                    Case "DataDikembalikan"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesData = No" & FilterData & " ")
                    Case "TinjauData"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesLevel IN ('12')" & FilterData & " ")
                    Case "Persetujuan"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesLevel IN ('13')" & FilterData & " ")
                    Case "Cetak"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesLevel IN ('14')" & FilterData & " ")
                    Case "Export"
                        GetMemberList("WHERE Organisasi = 'Rapi' AND ProsesLevel IN ('15')" & FilterData & " ")
                End Select
        End Select

    End Sub

    Protected Sub GvListAnggota_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)

        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If

    End Sub

    Protected Sub GvListAnggota_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)

        Dim hasImport As Boolean

        If e.GetValue("ProsesData") IsNot Nothing Then
            hasImport = CInt(Replace(Fix(e.GetValue("ProsesData")), Nothing, 0))
            If hasImport = True Then
                e.Row.BackColor = System.Drawing.Color.White
            Else
                e.Row.BackColor = System.Drawing.Color.Pink
            End If
        End If

    End Sub

    Function GetMemberList(ByVal Where As String) As String

        Dim s As String = "0"
        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectDataLog(Where), cn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            GvListAnggota.DataSource = dt
            GvListAnggota.DataBind()
            With dt
                If .Rows.Count = 0 Then
                    GvListAnggota.Settings.ShowVerticalScrollBar = False
                    GvListAnggota.SettingsPager.ShowEmptyDataRows = False
                Else
                    GvListAnggota.Settings.ShowVerticalScrollBar = True
                    GvListAnggota.SettingsPager.ShowEmptyDataRows = True
                End If
            End With
            s = dt.Rows.Count.ToString
            'da.Dispose()
            'cn.Dispose()
        Catch ex As Exception
            Message = ex.Message.ToString
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        Return s
    End Function

    Function GetMemberCount(ByVal Where As String) As String

        Dim s As String = "0"
        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            s = dt.Rows.Count.ToString
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            Message = ex.Message.ToString
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        Return s
    End Function

    Protected Sub GvListAnggota_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListAnggota.PageIndexChanged

        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)

    End Sub

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)
        GvListAnggota_ExportAll.WriteXlsToResponse()

    End Sub

    Protected Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)

    End Sub

    Protected Sub BtnDataAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataAll.Click
        Session("FilterData") = "Semua"
        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub BtnDataProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataProses.Click
        Session("FilterData") = "DataDiproses"
        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub BtnDataKembali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataKembali.Click
        Session("FilterData") = "DataDikembalikan"
        GetData(Session("FilterData"), DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub BtnLulusUNAR2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLulusUNAR2.Click
        Session("FilterData") = "LulusUNAR"
        GetData("LulusUNAR", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub BtnGagalUNAR2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGagalUNAR2.Click
        Session("FilterData") = "GagalUNAR"
        GetData("GagalUNAR", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub btnTinjauData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTinjauData.Click
        Session("FilterData") = "TinjauData"
        GetData("TinjauData", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub btnPersetujuan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPersetujuan.Click
        Session("FilterData") = "Persetujuan"
        GetData("Persetujuan", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub btnCetak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        Session("FilterData") = "Cetak"
        GetData("Cetak", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Session("FilterData") = "Export"
        GetData("Export", DdlOrda.Value, DdlTingkat.Value)
    End Sub

    Protected Sub btnHasilUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHasilUNAR.Click
        Session("FilterData") = "HasilUNAR"
        GetData("HasilUNAR", DdlOrda.Value, DdlTingkat.Value)
    End Sub
End Class
