﻿Imports System
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
Imports Microsoft.Office
Imports System.Diagnostics

Partial Class UserControls_ucTinjauData
    Inherits System.Web.UI.UserControl
    Public Shared TypeData As String
    Public Shared TypeExport As String
    Public Shared ProsesID As String
    Public Shared ProsesLevel As String
    Public Shared ProsesLevel2 As String = ""
    Public Shared FilePath As FileInfo
    Public Shared ltrlFileName As Literal
    Public Shared MenuAwal As String = ""
    Dim mSendEmail As New ClsSMTP

#Region "--- Public Shared ---"

    Public Shared GroupID As String = ""
    Public Shared CallSign As String = ""
    Public Shared CallSignLama As String = ""
    Public Shared Nama As String = ""
    Public Shared NamaKartu As String = ""
    Public Shared NomorKTP As String = ""
    Public Shared JenisKelamin As String = ""
    Public Shared Alamat As String = ""
    Public Shared Alamat1Kartu As String = ""
    Public Shared Alamat2Kartu As String = ""
    Public Shared Alamat3Kartu As String = ""
    Public Shared KodePos As String = ""
    Public Shared Kota As String = ""
    Public Shared Provinsi As String = ""
    Public Shared Agama As String = ""
    Public Shared Pekerjaan As String = ""
    Public Shared NomorTelepon As String = ""
    Public Shared EMail As String = ""
    Public Shared OrdaCode As String = ""
    Public Shared OrdaName As String = ""
    Public Shared OrlokCode As String = ""
    Public Shared OrlokName As String = ""
    Public Shared RapiDaerahCode As String = ""
    Public Shared RapiDaerahName As String = ""
    Public Shared JenisPermohonan As String = ""
    Public Shared Tingkat As String = ""
    Public Shared NomorUNAR As String = ""
    Public Shared TanggalUNAR As Date
    Public Shared LokasiUNAR As String = ""
    Public Shared HasilUNAR As String = ""
    Public Shared NomorSKAR As String = ""
    Public Shared TanggalTerbitSKAR As Date
    Public Shared NomorIAR As String = ""
    Public Shared MasaBerlakuIAR As String = ""
    Public Shared NomorIKRAP As String = ""
    Public Shared MasaBerlakuIKRAP As String = ""
    Public Shared FileFoto As String = ""
    Public Shared StatusData As String = ""
    Public Shared Organisasi As String = ""
    Public Shared NRI As String = ""
    Public Shared TempatLahir As String = ""
    Public Shared TanggalLahir As Date
    Public Shared Gol As String = ""

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cx As New CheckBox
        Dim cxItem As New CheckBox
        Dim cxItemArray As String = ""
        Dim s As String
        Dim cxAllAwal As String = ""
        Dim cxAllAkhir As String = ""

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            MenuAwal = Session("MenuAwal")
        End If

        '--- Setting Kolom
        With GvListAnggota.Columns
            Select Case MenuAwal
                Case "SKAR", "IAR"
                    .Item(10).Visible = False
                    .Item(18).Visible = False
                    .Item(19).Visible = False
                Case "IKRAP"
                    .Item(7).Visible = False
                    .Item(8).Visible = False
                    .Item(9).Visible = False
                    .Item(11).Visible = False
                    .Item(12).Visible = False
                    .Item(13).Visible = False
                    .Item(14).Visible = False
                    .Item(15).Visible = False
                    .Item(16).Visible = False
                    .Item(17).Visible = False
            End Select
        End With

        If Page.IsPostBack = False Then
            lblTitle.Text = MenuAwal
            Session("FilterData") = "Semua"
            GetData(Session("FilterData"))
            SetButtonLeft()
            BtnDataAll.Checked = True
        Else
            cx = GvListAnggota.FindHeaderTemplateControl(TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxAll")
            If Session("cxAllAkhir") = cx.Checked Then '--- Posisi Check All tidak berubah
                Session("cxAllAkhir") = cx.Checked
                With GvListAnggota
                    If (.VisibleRowCount > 0) Then
                        For i = 0 To .VisibleRowCount - 1
                            cxItem = GvListAnggota.FindRowCellTemplateControl(i, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
                            If cxItem.Checked = "True" Then
                                cxItemArray = cxItemArray & "," & i.ToString
                            End If
                        Next
                        If cxItemArray <> "" Then
                            Session("CheckItem") = Right(cxItemArray, Len(cxItemArray) - 1)
                        End If
                    End If
                End With
                GetData(Session("FilterData"))
                If cxItemArray <> "" Then
                    s = setCheckedItem(Session("CheckItem"))
                End If
            Else
                Session("cxAllAkhir") = cx.Checked
                GetData(Session("FilterData"))
                setCheckedAll(cx.Checked)
            End If
        End If
        Dim MenuSelect As String = Session("FilterData")

        Select Case MenuSelect
            Case "Semua"
                BtnSaveAll.Visible = False
                BtnSaveSelected.Visible = False
            Case "File"
                BtnSaveAll.Visible = False
                BtnSaveSelected.Visible = False
            Case Else
                'BtnSaveAll.Visible = True
                BtnSaveSelected.Visible = True
        End Select
        BtnSaveAll.Visible = False
    End Sub

    Sub SetButtonLeft()

        Dim MenuAwal As String = Session("MenuAwal")
        Select Case MenuAwal
            Case "SKAR"
                BtnLulusUNAR2.Visible = True
                BtnGagalUNAR2.Visible = True
                BtnDataProses.Visible = False
                BtnDataKembali.Visible = False
            Case Else
                BtnLulusUNAR2.Visible = False
                BtnGagalUNAR2.Visible = False
                BtnDataProses.Visible = True
                BtnDataKembali.Visible = True
        End Select

    End Sub

    Function GetData(ByVal Filter As String) As DataTable

        Dim Organisasi As String = ""
        Dim TypeFile As String = ""
        With GvListAnggota.Columns
            Select Case MenuAwal
                Case "SKAR"
                    ProsesLevel = "('7')"
                    ProsesLevel2 = "7"
                    Organisasi = "Orari"
                    TypeFile = "SKAR"
                Case "IAR"
                    ProsesLevel = "('15')"
                    ProsesLevel2 = "15"
                    Organisasi = "Orari"
                    TypeFile = "IAR"
                Case "IKRAP"
                    ProsesLevel = "('15')"
                    ProsesLevel2 = "15"
                    Organisasi = "Rapi"
                    TypeFile = "IKRAP"
            End Select
        End With

        Dim dt As New DataTable
        Dim s As String = ""

        Try
            'GvListAnggota.Visible = True
            GvFileList.Visible = False
            Select Case Filter
                Case "Semua"
                    dt = GetMemberList("WHERE ProsesLevel IN " & ProsesLevel & " AND Organisasi='" & Organisasi & "' ", ProsesLevel2)
                Case "LulusUNAR"
                    dt = GetMemberList("WHERE HasilUNAR = 'Lulus' AND ProsesData = Yes AND ProsesLevel IN " & ProsesLevel & " AND Organisasi='" & Organisasi & "' ", ProsesLevel2)
                Case "GagalUNAR"
                    dt = GetMemberList("WHERE HasilUNAR = 'Tidak Lulus' AND ProsesData = Yes AND ProsesLevel IN " & ProsesLevel & " AND Organisasi='" & Organisasi & "' ", ProsesLevel2)
                Case "File"
                    GvListAnggota.Visible = False
                    GvFileList.Visible = True
                    s = qSelectFilesExport(" WHERE TypeFile='" & TypeFile & "' ")
                    s = InsertDataProcess(s)
                    dt = GetFileList(" WHERE TypeFile='" & TypeFile & "' ")
                    GvFileList.DataSource = dt
                    GvFileList.DataBind()
                Case "DataDiproses"
                    dt = GetMemberList("WHERE ProsesData = Yes AND ProsesLevel IN " & ProsesLevel & " AND Organisasi='" & Organisasi & "' ", ProsesLevel2)
                Case "DataDikembalikan"
                    dt = GetMemberList("WHERE ProsesData = No AND ProsesLevel IN " & ProsesLevel & " AND Organisasi='" & Organisasi & "' ", ProsesLevel2)
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

    Protected Sub GvFileList_HtmlRowPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableRowEventArgs)

        Dim hasImport As Boolean
        If e.GetValue("SendMail") IsNot Nothing Then
            hasImport = CInt(Replace(Fix(e.GetValue("SendMail")), Nothing, 0))
            If hasImport = True Then
                e.Row.BackColor = System.Drawing.Color.Gold
            End If
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

    Protected Sub GvListAnggota_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Function GetMemberList(ByVal Where As String, Optional ByVal ProsesLevel2 As String = "") As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectMemberProses(Where, ProsesLevel2), cn)
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
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

    Function GetFileList(ByVal Where As String) As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectFilesExport(Where), cn)
            da.Fill(dt)
            GvFileList.Visible = True
            GvFileList.DataSource = dt
            GvFileList.DataBind()
            With dt
                If .Rows.Count = 0 Then
                    GvFileList.Settings.ShowVerticalScrollBar = False
                    GvFileList.SettingsPager.ShowEmptyDataRows = False
                Else
                    GvFileList.Settings.ShowVerticalScrollBar = True
                    GvFileList.SettingsPager.ShowEmptyDataRows = True
                End If
            End With
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

    Protected Sub GvListAnggota_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListAnggota.PageIndexChanged
        GetData(Session("FilterData"))
    End Sub

    Function GetFileName(ByVal TypeData As String) As String

        Dim s As String = ""
        Try
            If Session("FilterData") = "DataDiproses" Then
                s = Session("Organisasi") & "_" & TypeData & "_" & Format(Date.Now, "ddMMyy") & "_" & Format(Date.Now, "hhmmss")
            Else
                s = Session("Organisasi") & "_" & TypeData & "_" & Format(Date.Now, "ddMMyy") & "_" & Format(Date.Now, "hhmmss")
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Protected Sub BtnSaveAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveAll.Click

        Dim s As String = ""
        Dim FileName As String = ""
        Dim ProsesID As String = ""
        Dim GroupID As String = ""
        Dim TypeFile As String = Session("MenuAwal")
        Dim Where As String = ""
        Dim dt1 As New DataTable
        Try
            FileName = GetFileName(Session("FilterData"))
            dt1 = GetData(Session("FilterData"))
            s = ProsesTutupData(dt1, FileName)
            dt1 = GetData(Session("FilterData"))
        Catch ex As Exception
            s = ex.Message
        End Try

    End Sub

    Protected Sub BtnSaveSelected_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveSelected.Click

        Dim s As String = ""
        Dim FileName As String = ""
        Dim ProsesID As String = ""
        Dim Where As String = ""
        Dim dt1 As New DataTable
        Try
            FileName = GetFileName(Session("FilterData"))
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(Session("CheckItem"), ",")
                    For i = 0 To cxArray.Length - 1
                        ProsesID = .GetRowValues(cxArray(i), New String() {.KeyFieldName}).ToString()
                        If ProsesID <> "" Then
                            Where = " WHERE ProsesID='" & ProsesID & "';"
                            Dim cn As New OleDbConnection(MyDataProses)
                            Dim da1 As New OleDbDataAdapter(qSelectMemberExport(Where), cn)
                            da1.Fill(dt1)
                        End If
                    Next
                End If
            End With
            s = ProsesTutupData(dt1, FileName)
            dt1 = GetData(Session("FilterData"))
            If cbxPilihSemua.Checked = True Then cbxPilihSemua.Checked = False
        Catch ex As Exception
            s = ex.Message
        End Try

    End Sub

#Region "--- SOP Tutup Data ---"
    '-------------------------------------------------------------------------------------------------'
    ' Langkah-langkah Tutup Data
    ' Cek MenuAwal
    ' Untuk(SKAR)
    ' - Cek Jenis Permohonan:
    ' -- Jika Baru - Insert DataSKAR
    ' -- Jika Naik Tingkat: 
    ' ---- Cek nomor CallSign:
    ' ------ Jika ada yang sama: Insert DataSKAR_Log From DataSKAR, Update DataSKAR, Update NilaiSKAR
    ' ------ Tidak ada yang sama: Insert DataSKAR 
    ' Untuk IAR dan IKRAP:
    ' - Cek Jenis Permohonan:
    ' -- Jika Baru - Insert DataIAR / DataIKRAP
    ' -- Jika Pembaharuan:
    ' ---- Cek Nomor CallSign:
    ' ------ Jika ada yang sama: Insert DataIAR_Log From DataIAR, Update DataIAR, Update DataCallSign
    ' ------ Jika tidak ada yang sama: Insert DataIAR, Get Nomor ID, Insert DataCallSign
    ' -- Jika Naik Tingkat:
    ' ---- Cek Nomor IAR / IKRAP:
    ' ------ Jika ada yang sama: Insert DataIAR_Log From DataIAR, Update DataIAR, Update DataCallSign
    ' ------ Jika tidak ada yang sama: Insert DataIAR, Get Nomor ID, Insert DataCallSign
    '-------------------------------------------------------------------------------------------------'
#End Region

    Function ProsesTutupData(ByVal dt1 As DataTable, ByVal FileName As String) As String
        Dim s As String = ""
        Dim GroupID As String = ""
        Dim TypeFile As String = Session("MenuAwal")

        Try
            With dt1
                If .Rows.Count > 0 Then
                    For Baris As Integer = 0 To .Rows.Count - 1
                        '--- Data Pemohon ---
                        GroupID = Trim(.Rows(Baris)("GroupID"))
                        ProsesID = Trim(.Rows(Baris)("ProsesID"))
                        ProsesLevel = Trim(.Rows(Baris)("ProsesLevel"))
                        CallSign = Trim(.Rows(Baris)("CallSign"))
                        JenisPermohonan = Trim(.Rows(Baris)("JenisPermohonan"))
                        FileFoto = .Rows(Baris)("FileFoto")
                        If GroupID <> "CETAKULANG" Then
                            Select Case MenuAwal
                                Case "SKAR"
                                    NomorSKAR = Trim(.Rows(Baris)("NomorSKAR"))
                                    NomorIAR = Trim(.Rows(Baris)("NomorIAR"))
                                    NomorUNAR = Trim(.Rows(Baris)("NomorUNAR"))
                                    HasilUNAR = Trim(.Rows(Baris)("HasilUNAR"))
                                    s = qSelectDatabase("WHERE NomorUNAR='" & NomorUNAR & "'", "DataSKAR")
                                    If s = "True" Then
                                        s = qUpdateDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    Else '--- Anggota lama yang belum ada di Database
                                        s = qInsertDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    End If
                                    s = qUpdateHasilUNAR(NomorUNAR)
                                    s = InsertDataBase(s)
                                    s = qDeleteHasilUNAR(ProsesID)
                                    s = InsertDataProcess(s)
                                Case "IAR"
                                    NomorSKAR = Trim(.Rows(Baris)("NomorSKAR"))
                                    NomorIAR = Trim(.Rows(Baris)("NomorIAR"))
                                    s = qSelectDatabase("WHERE CallSign='" & CallSign & "'", "DataIAR")
                                    If s = "True" Then
                                        s = qUpdateDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    Else '--- Anggota lama yang belum ada di Database
                                        s = qInsertDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    End If
                                Case "IKRAP"
                                    NomorIKRAP = Trim(.Rows(Baris)("NomorIKRAP"))
                                    s = qSelectDatabase("WHERE CallSign='" & CallSign & "'", "DataIKRAP")
                                    If s = "True" Then
                                        s = qUpdateDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    Else '--- Anggota lama yang belum ada di Database
                                        s = qInsertDatabase(dt1, Baris)
                                        s = InsertDataBase(s)
                                    End If
                            End Select
                        Else
                            s = qUpdateDbCetakUlang(dt1, Baris)
                        End If
                        '--- Hapus Data Selesai di DataProses
                        s = qDeleteDataProses(ProsesID)
                        s = InsertDataProcess(s)
                        s = qDeleteDataLog(ProsesID)
                        s = InsertDataProcess(s)
                        s = qDisableFile(GroupID, "False")
                        s = InsertDataProcess(s)
                        '--- Hapus File Foto ---
                        If FileFoto <> "" Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                            If TheFile.Exists Then
                                File.Delete(MapPath("~\FileFotoProses\") & FileFoto)
                            End If
                        End If
                    Next
                End If
            End With
            s = ExportDataTableToCsv(dt1, FileName)
            s = qInsertFilesExport(GroupID, TypeFile, FileName, Session("Organisasi"), Session("UserID"), Session("FilterData"))
            s = InsertDataProcess(s)

            '--- Hapus File Foto di Folder FotoProses
            'With dt1
            '    If .Rows.Count > 0 Then
            '        For Baris As Integer = 0 To .Rows.Count - 1
            '            '--- Data Pemohon ---
            '            FileFoto = .Rows(0)("FileFoto")
            '            If FileName <> "" Then
            '                Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
            '                If TheFile.Exists Then
            '                    File.Delete(MapPath("~\FileFotoProses\") & FileFoto)
            '                End If
            '            End If
            '        Next
            '    End If
            'End With

            Dim Message1 As String = "Ekspor Data ke File telah selesai..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message1.Replace("'", "")), True)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Protected Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GetData(Session("FilterData"))
    End Sub

    Protected Sub CxAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim s As String
        Dim cx As CheckBox

        cx = sender
        If cx.Checked = True Then
            s = setCheckedAll("True")
            Session("CheckAll") = "True"
        Else
            s = setCheckedAll("False")
            Session("CheckAll") = "False"
        End If
        cx = Nothing
        GC.Collect()

    End Sub

    Function setCheckedItem(ByVal cxItemArray As String) As String
        Dim s As String = ""
        Dim i As Integer
        Dim cxItem As CheckBox

        Try
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(cxItemArray, ",")
                    For i = 0 To cxArray.Length - 1
                        cxItem = .FindRowCellTemplateControl(cxArray.GetValue(i), TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
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

    Function setCheckedItemOnly(ByVal cxItemArray As String) As String
        Dim s As String = ""
        Dim i As Integer
        Dim cxItem As CheckBox

        Try
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(cxItemArray, ",")
                    For i = 0 To cxArray.Length - 1
                        cxItem = .FindRowCellTemplateControl(cxArray.GetValue(i), TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
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

    Function setCheckedAll(ByVal NewVal As Boolean) As String

        Dim s As String = ""
        Dim i As Integer
        Dim cx As CheckBox

        Try
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    For i = 0 To .VisibleRowCount - 1 '// Set Checkbox in All Rows
                        cx = .FindRowCellTemplateControl(i, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
                        cx.Checked = NewVal
                    Next
                    cx = .FindHeaderTemplateControl(TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxAll")
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

    Function ArrayCheckList(ByVal row As Integer) As String
        Dim ProsesID As String = ""
        Dim s As String = ""
        Try
            Dim ch As CheckBox = TryCast(GvListAnggota.FindRowCellTemplateControl(row, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem"), CheckBox)
            If ch.Checked = True Then
                ProsesID = GvListAnggota.GetRowValues(row, New String() {GvListAnggota.KeyFieldName}).ToString()
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return ProsesID
    End Function

    Function ArrayCheckListSelected(ByVal row As String) As String
        Dim ProsesID As String = ""
        Dim s As String = ""
        Try
            Dim ch As CheckBox = TryCast(GvListAnggota.FindRowCellTemplateControl(row, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem"), CheckBox)
            If ch.Checked = True Then
                ProsesID = GvListAnggota.GetRowValues(row, New String() {GvListAnggota.KeyFieldName}).ToString()
            End If
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(row, ",")
                    For i = 0 To cxArray.Length - 1
                        ProsesID = GvListAnggota.GetRowValues(row, New String() {GvListAnggota.KeyFieldName}).ToString()
                    Next
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return ProsesID
    End Function

    Function ArrayCheckListAll(ByVal row As Integer) As String
        Dim ProsesID As String = ""
        Dim s As String = ""
        Try
            Dim ch As CheckBox = TryCast(GvListAnggota.FindRowCellTemplateControl(row, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem"), CheckBox)
            ProsesID = GvListAnggota.GetRowValues(row, New String() {GvListAnggota.KeyFieldName}).ToString()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return ProsesID
    End Function

    Function ExportDataTableToCsv(ByVal MyDataTable As DataTable, ByVal FileName As String) As String

        Dim s As String = ""
        Dim sSecretKey As String = "pUpUtN!4"

        Try
            '------------------
            ' Create CSV File
            '------------------
            Dim Split As String = Chr(34)
            Dim SplitMiddle As String = Chr(34) & "," & Chr(34)
            Dim myString As New StringBuilder()
            Dim bFirstRecord As Boolean = True
            Dim myWriter As New System.IO.StreamWriter(MyFileExport() & FileName & ".csv")

            '--- Header ---
            For k As Integer = 0 To 0
                myString.Append(Split + MyDataTable.Columns(k).ColumnName + SplitMiddle)
            Next
            For k As Integer = 1 To MyDataTable.Columns.Count - 2
                myString.Append(MyDataTable.Columns(k).ColumnName + SplitMiddle)
            Next
            For k As Integer = MyDataTable.Columns.Count - 1 To MyDataTable.Columns.Count - 1
                myString.Append(MyDataTable.Columns(k).ColumnName + Split)
            Next

            myString.Append(vbCr & vbLf)

            '--- Content ---
            For i As Integer = 0 To MyDataTable.Rows.Count - 1
                For k As Integer = 0 To 0
                    myString.Append(Split + MyDataTable.Rows(i)(k).ToString().Replace(",", ",") + SplitMiddle)
                Next
                For k As Integer = 1 To MyDataTable.Columns.Count - 2
                    myString.Append(MyDataTable.Rows(i)(k).ToString().Replace(",", ",") + SplitMiddle)
                Next
                For k As Integer = MyDataTable.Columns.Count - 1 To MyDataTable.Columns.Count - 1
                    myString.Append(MyDataTable.Rows(i)(k).ToString().Replace(",", ",") + Split)
                Next
                myString.Append(vbCr & vbLf)
            Next
            myWriter.WriteLine(myString)
            myWriter.Close()

            '------------------
            ' Create DAT File
            '------------------
            Dim Split2 As String = "~"c
            Dim myString2 As New StringBuilder()
            Dim bFirstRecord2 As Boolean = True
            Dim myWriter2 As New System.IO.StreamWriter(MyFileExport() & FileName & ".da_")

            '--- Header ---
            For k As Integer = 0 To MyDataTable.Columns.Count - 1
                myString2.Append(MyDataTable.Columns(k).ColumnName + Split2)
            Next
            myString2.Append(vbCr & vbLf)

            '--- Content ---
            For i As Integer = 0 To MyDataTable.Rows.Count - 1
                For k As Integer = 0 To MyDataTable.Columns.Count - 1
                    myString2.Append(MyDataTable.Rows(i)(k).ToString().Replace(",", ",") + Split2)
                Next
                myString2.Append(vbCr & vbLf)
            Next
            myWriter2.WriteLine(myString2)
            myWriter2.Close()

            If MenuAwal = "IAR" Or MenuAwal = "SKAR" Then
                '--- Encript File
                Dim gch As GCHandle = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned)
                EncryptFile(MyFileExport() & FileName & ".da_", MyFileExport() & FileName & ".dat", sSecretKey)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return s

    End Function

    Function ExportDataTableToXls(ByVal MyDataTable As DataTable, ByVal FileName As String) As String

        Dim Excel As Object = CreateObject("Excel.Application")
        Dim strFilename As String
        Dim intCol, intRow As Integer
        Dim strPath As String = MyFileExport()
        Dim s As String = ""
        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
        Else
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()
                    .cells(1, 1).EntireRow.Font.Bold = True
                    Dim intI As Integer = 1
                    For intCol = 0 To MyDataTable.Columns.Count - 1
                        .cells(1, intI).value = MyDataTable.Columns(intCol).ColumnName
                        .cells(1, intI).EntireRow.Font.Bold = True
                        intI += 1
                    Next
                    intI = 2
                    Dim intK As Integer = 1
                    For intCol = 0 To MyDataTable.Columns.Count - 1
                        intI = 2
                        For intRow = 0 To MyDataTable.Rows.Count - 1
                            .Cells(intI, intK).Value = MyDataTable.Rows(intRow).ItemArray(intCol)
                            intI += 1
                        Next
                        intK += 1
                    Next
                    If Mid$(strPath, strPath.Length, 1) <> "\" Then
                        strPath = strPath & "\"
                    End If
                    strFilename = strPath & FileName & ".xls"
                    .ActiveCell.Worksheet.SaveAs(strFilename)
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing

                Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL.EXE")
                For Each i As Process In pro
                    i.Kill()
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Return s
    End Function

    Protected Sub btnSaveFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlFileName As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)
        Response.Redirect("~/FileExport/" & ltrlFileName.Text & ".csv")
    End Sub

    Protected Sub btnSaveExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlFileName As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)
        Dim FileExcel As String = Right(ltrlFileName.Text, Len(ltrlFileName.Text))
        Response.Redirect("~/FileExport/" & FileExcel & ".xls")
    End Sub

    Sub EncryptFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)

        Dim s As String = ""
        Dim fsInput As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim cryptostream As New CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write)

        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()

    End Sub

    Protected Sub btnDeleteFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ltrlFileName = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)
        Dim s As String = ""
        Dim dt As DataTable
        Dim FileName As String = ""
        Dim Message As String = ""
        Try
            If Session("Admin") = "True" Then
                FileName = ltrlFileName.Text
                If FileName <> "" Then
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileExport\") & FileName & ".dat")
                    If TheFile.Exists Then
                        File.Delete(MapPath("~\FileExport\") & FileName & ".dat")
                        File.Delete(MapPath("~\FileExport\") & FileName & ".csv")
                        File.Delete(MapPath("~\FileExport\") & FileName & ".da_")
                        s = qDelete("FilesExport", " FileName='" & FileName & "'")
                        s = InsertDataProcess(s)
                        dt = GetFileList("")
                    Else
                        s = qDelete("FilesExport", " FileName='" & FileName & "'")
                        s = InsertDataProcess(s)
                        Throw New FileNotFoundException()
                    End If
                End If
            End If
        Catch ex As FileNotFoundException
            Message = "Nama File tidak ditemukan. Mungkin file sudah dihapus secara manual..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        Catch ex As Exception
            Message = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        dt = GetFileList("")
    End Sub

    Protected Sub btnMailFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ltrlFileName = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlFileName"), Literal)
        Dim s As String = ""
        Dim FileName As String = ""
        Dim Message As String = ""
        Try
            FileName = ltrlFileName.Text & ".dat"
            If FileName <> "" Then
                FilePath = New FileInfo(MapPath("~\FileExport\") & FileName)
                If FilePath.Exists Then
                    GetEmailDetails(FileName)
                End If
            End If
        Catch ex As FileNotFoundException
            Message = "Nama File tidak ditemukan. Mungkin file sudah dihapus secara manual..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        Catch ex As Exception
            Message = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
    End Sub

    Sub GetEmailDetails(ByVal FileName As String)

        GvFileList.Visible = False
        GvListAnggota.Visible = False
        PnlSendEmail.Visible = True
        Dim dt As New DataTable
        Dim s As String = ""
        Dim Message As String = ""
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
                    LblFileAttachment.Text = FileName
                    TbxEmailSubject.Text = .Rows(0)("EmailSubject")
                    TbxEmailBody.Text = .Rows(0)("EmailBody")
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try

    End Sub

    Protected Sub BtnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        Dim Message As String = ""
        Dim s As String = ""
        Try
            s = mSendEmail.SendingEmail(TbxEmailFrom.Text, TbxEmailTo.Text, TbxEmailCc.Text, TbxEmailSubject.Text, TbxEmailBody.Text, FilePath.ToString)
        Catch ex As Exception
            s = ex.Message
        End Try
        If s = "" Then
            Message = "Email sudah terkirim..."
            TbxEmailFrom.Enabled = False
            TbxEmailTo.Enabled = False
            TbxEmailCc.Enabled = False
            TbxEmailSubject.Enabled = False
            TbxEmailBody.Enabled = False
            PnlSendEmail.Visible = False
            GvFileList.Visible = True
            s = qUpdateFileExport(Left(LblFileAttachment.Text, Len(LblFileAttachment.Text) - 4), Session("UserID"))
            s = InsertDataProcess(s)
            GetData(Session("FilterData"))
        Else
            Message = "Email gagal terkirim dengan error " & s
            GvListAnggota.Visible = False
            GvFileList.Visible = False
        End If
        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)

    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        GvFileList.Visible = True
        GvListAnggota.Visible = False
        PnlSendEmail.Visible = False
    End Sub

    Protected Sub BtnDataAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataAll.Click
        Session("FilterData") = "Semua"
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = True
        PnlSendEmail.Visible = False
    End Sub

    Protected Sub BtnDataProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataProses.Click
        Session("FilterData") = "DataDiproses"
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = True
        PnlSendEmail.Visible = False
        'BtnSaveAll.Visible = True
        BtnSaveSelected.Visible = True

    End Sub

    Protected Sub BtnDataKembali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataKembali.Click
        Session("FilterData") = "DataDikembalikan"
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = True
        PnlSendEmail.Visible = False
        'BtnSaveAll.Visible = True
        BtnSaveSelected.Visible = True

    End Sub

    Protected Sub BtnLulusUNAR2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLulusUNAR2.Click
        Session("FilterData") = "LulusUNAR"
        MenuAwal = "SKAR"
        Session("cxAllAkhir") = False
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = True
        PnlSendEmail.Visible = False
        BtnSaveAll.Visible = False
        BtnSaveSelected.Visible = True

    End Sub

    Protected Sub BtnGagalUNAR2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGagalUNAR2.Click
        Session("FilterData") = "GagalUNAR"
        MenuAwal = "SKAR"
        Session("cxAllAkhir") = False
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = True
        PnlSendEmail.Visible = False
        BtnSaveAll.Visible = False
        BtnSaveSelected.Visible = True

    End Sub

    Protected Sub BtnFileExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFileExport.Click
        Session("FilterData") = "File"
        GetData(Session("FilterData"))
        SetButtonLeft()
        GvListAnggota.Visible = False
        PnlSendEmail.Visible = False
        BtnSaveAll.Visible = False
        BtnSaveSelected.Visible = False
    End Sub

#Region "--- Closing Data ---"

    '--- Copy Data ke File Database.mdb ---
    Public Shared Function qSelectDatabase(ByVal WHERE As String, ByVal TableName As String) As String
        Dim s As String = ""
        Dim dt As New DataTable

        Try
            s = String.Format("SELECT * FROM {0} {1}", TableName, WHERE)
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da1 As New OleDbDataAdapter(s, cn)
            da1.Fill(dt)
            If dt.Rows.Count > 0 Then
                '--- Jika ketemu berarti ada yang sama, di copy ke Table Data Sejarah ---
                s = String.Format("INSERT INTO {0}_Log SELECT * FROM {0} {1}", TableName, CallSign)
                s = InsertDataBase(s)
            End If
            If dt.Rows.Count > 0 Then
                s = "True"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Function qUpdateDatabase(ByVal dt As DataTable, ByVal i As Integer) As String

        Dim s As String = ""
        Try
            With dt
                CallSign = .Rows(i)("CallSign")
                Nama = .Rows(i)("Nama")
                NamaKartu = .Rows(i)("NamaKartu")
                NomorKTP = .Rows(i)("NomorKTP")
                Alamat = .Rows(i)("Alamat")
                Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                KodePos = .Rows(i)("KodePos")
                Kota = .Rows(i)("Kota")
                Provinsi = .Rows(i)("Provinsi")
                Agama = .Rows(i)("Agama")
                Pekerjaan = .Rows(i)("Pekerjaan")
                NomorTelepon = .Rows(i)("NomorTelepon")
                EMail = .Rows(i)("EMail")
                OrdaCode = .Rows(i)("OrdaCode")
                OrdaName = .Rows(i)("OrdaName")
                OrlokCode = .Rows(i)("OrlokCode")
                OrlokName = .Rows(i)("OrlokName")
                RapiDaerahCode = .Rows(i)("RapiDaerahCode")
                RapiDaerahName = .Rows(i)("RapiDaerahName")
                JenisPermohonan = .Rows(i)("JenisPermohonan")
                Tingkat = .Rows(i)("Tingkat")
                NomorUNAR = .Rows(i)("NomorUNAR")
                TanggalUNAR = .Rows(i)("TanggalUNAR")
                LokasiUNAR = .Rows(i)("LokasiUNAR")
                HasilUNAR = .Rows(i)("HasilUNAR")
                NomorSKAR = .Rows(i)("NomorSKAR")
                TanggalTerbitSKAR = .Rows(i)("TanggalTerbitSKAR")
                NomorIAR = .Rows(i)("NomorIAR")
                MasaBerlakuIAR = .Rows(i)("MasaBerlakuIAR")
                FileFoto = .Rows(i)("FileFoto")
                StatusData = .Rows(i)("ProsesData")
                GroupID = .Rows(i)("GroupID")
            End With

            Select Case MenuAwal
                Case "SKAR"
                    s = String.Format("UPDATE DataSKAR SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',OrdaCode='{15}',OrdaName='{16}',OrlokCode='{17}',OrlokName='{18}'," & _
                                  "JenisPermohonan='{19}',Tingkat='{20}',NomorUNAR='{21}'," & _
                                  "TanggalUNAR=#{22}#,LokasiUNAR='{23}',HasilUNAR='{24}',NomorSKAR='{25}',TanggalTerbitSKAR=#{28}#," & _
                                  "FileFoto='{27}', StatusData={28}, UserUpdate='{29}',GroupID='{30}'" & _
                                  "DateUpdate=#" & Date.Now & "# WHERE NomorUNAR = '" & NomorUNAR & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, OrdaCode, OrdaName, OrlokCode, OrlokName, _
                                  JenisPermohonan, Tingkat, NomorUNAR, _
                                  TanggalUNAR, LokasiUNAR, HasilUNAR, NomorSKAR, TanggalTerbitSKAR, _
                                  FileFoto, StatusData, Session("UserID"), GroupID)
                Case "IAR"
                    s = String.Format("UPDATE DataIAR SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',OrdaCode='{15}',OrdaName='{16}',OrlokCode='{17}',OrlokName='{18}'," & _
                                  "JenisPermohonan='{19}',Tingkat='{20}',NomorSKAR='{21}',TanggalTerbitSKAR=#{22}#," & _
                                  "NomorIAR='{23}', MasaBerlakuIAR='{24}', FileFoto='{25}', StatusData={26}, UserUpdate='{27}',GroupID='{28}'," & _
                                  "DateUpdate=#" & Date.Now & "# WHERE CallSign = '" & CallSign & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, OrdaCode, OrdaName, OrlokCode, OrlokName, _
                                  JenisPermohonan, Tingkat, NomorSKAR, TanggalTerbitSKAR, _
                                  NomorIAR, MasaBerlakuIAR, FileFoto, StatusData, Session("UserID"), GroupID)
                Case "IKRAP"
                    s = String.Format("UPDATE DataIKRAP SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',RapiDaerahCode='{15}',RapiDaerahName='{16}',JenisPermohonan='{17}'," & _
                                  "NomorIKRAP='{18}', MasaBerlakuIKRAP='{19}', FileFoto='{20}', StatusData={21}, UserUpdate='{22}',GroupID='{23}'," & _
                                  "DateUpdate=#" & Date.Now & "# WHERE CallSign = '" & CallSign & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, OrdaCode, OrdaName, OrlokCode, OrlokName, _
                                  RapiDaerahCode, RapiDaerahName, JenisPermohonan, _
                                  NomorIAR, MasaBerlakuIAR, FileFoto, StatusData, Session("UserID"), GroupID)
            End Select
        Catch ex As Exception
            s = ex.Message.ToString
        End Try
        Return s

    End Function

    Function qUpdateDbCetakUlang(ByVal dt As DataTable, ByVal i As Integer) As String

        Dim s As String = ""
        Try
            With dt
                CallSign = .Rows(i)("CallSign")
                CallSignLama = .Rows(i)("CallSignLama")
                Nama = .Rows(i)("Nama")
                NamaKartu = .Rows(i)("NamaKartu")
                NomorKTP = .Rows(i)("NomorKTP")
                Alamat = .Rows(i)("Alamat")
                Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                KodePos = .Rows(i)("KodePos")
                Kota = .Rows(i)("Kota")
                Provinsi = .Rows(i)("Provinsi")
                Agama = .Rows(i)("Agama")
                Pekerjaan = .Rows(i)("Pekerjaan")
                NomorTelepon = .Rows(i)("NomorTelepon")
                EMail = .Rows(i)("EMail")
                OrdaCode = .Rows(i)("OrdaCode")
                OrdaName = .Rows(i)("OrdaName")
                OrlokCode = .Rows(i)("OrlokCode")
                OrlokName = .Rows(i)("OrlokName")
                RapiDaerahCode = .Rows(i)("RapiDaerahCode")
                RapiDaerahName = .Rows(i)("RapiDaerahName")
                JenisPermohonan = .Rows(i)("JenisPermohonan")
                Tingkat = .Rows(i)("Tingkat")
                NomorUNAR = .Rows(i)("NomorUNAR")
                TanggalUNAR = .Rows(i)("TanggalUNAR")
                LokasiUNAR = .Rows(i)("LokasiUNAR")
                HasilUNAR = .Rows(i)("HasilUNAR")
                NomorSKAR = .Rows(i)("NomorSKAR")
                TanggalTerbitSKAR = .Rows(i)("TanggalTerbitSKAR")
                NomorIAR = .Rows(i)("NomorIAR")
                MasaBerlakuIAR = .Rows(i)("MasaBerlakuIAR")
                NomorIKRAP = .Rows(i)("NomorIKRAP")
                MasaBerlakuIKRAP = .Rows(i)("MasaBerlakuIKRAP")
                FileFoto = .Rows(i)("FileFoto")
                StatusData = .Rows(i)("ProsesData")
                'GroupID = .Rows(i)("GroupID")
            End With

            Select Case MenuAwal
                Case "SKAR"
                    s = String.Format("UPDATE DataSKAR SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',OrdaCode='{15}',OrdaName='{16}',OrlokCode='{17}',OrlokName='{18}'," & _
                                  "JenisPermohonan='{19}',Tingkat='{20}',NomorUNAR='{21}'," & _
                                  "TanggalUNAR=#{22}#,LokasiUNAR='{23}',HasilUNAR='{24}',NomorSKAR='{25}',TanggalTerbitSKAR=#{28}#," & _
                                  "FileFoto='{27}', StatusData={28}, UserUpdate='{29}'" & _
                                  "DateUpdate=#" & Date.Now & "# WHERE CallSign = '" & CallSign & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, OrdaCode, OrdaName, OrlokCode, OrlokName, _
                                  JenisPermohonan, Tingkat, NomorUNAR, _
                                  TanggalUNAR, LokasiUNAR, HasilUNAR, NomorSKAR, TanggalTerbitSKAR, _
                                  FileFoto, StatusData, Session("UserID"))
                    s = InsertDataBase(s)
                    If CallSign <> CallSignLama Then
                        '--- Rename File Foto ---
                        If FileFoto <> "" Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                            If TheFile.Exists Then
                                File.Copy(MapPath("~\FileFotoProses\") & FileFoto, MapPath("~\FileFotoProses\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFotoProses\") & FileFoto)
                                File.Copy(MapPath("~\FileFotoProses\") & CallSign & ".JPG", MapPath("~\FileFoto\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFoto\") & FileFoto)
                            End If
                        End If
                        s = String.Format("UPDATE DataSKAR SET Callsign='{0}', FileFoto='{1}' WHERE CallSign = '" & CallSignLama & "' ", CallSign, CallSign & ".JPG")
                        s = InsertDataBase(s)
                    End If
                Case "IAR"
                    s = String.Format("UPDATE DataIAR SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',OrdaCode='{15}',OrdaName='{16}',OrlokCode='{17}',OrlokName='{18}'," & _
                                  "JenisPermohonan='{19}',Tingkat='{20}',NomorSKAR='{21}',TanggalTerbitSKAR=#{22}#," & _
                                  "NomorIAR='{23}', MasaBerlakuIAR='{24}', FileFoto='{25}', StatusData={26}, UserUpdate='{27}'," & _
                                  "DateUpdate=#" & Date.Now & "# WHERE CallSign = '" & CallSign & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, OrdaCode, OrdaName, OrlokCode, OrlokName, _
                                  JenisPermohonan, Tingkat, NomorSKAR, TanggalTerbitSKAR, _
                                  NomorIAR, MasaBerlakuIAR, FileFoto, StatusData, Session("UserID"))
                    s = InsertDataBase(s)
                    If CallSign <> CallSignLama Then
                        '--- Rename File Foto ---
                        If FileFoto <> "" Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                            If TheFile.Exists Then
                                File.Copy(MapPath("~\FileFotoProses\") & FileFoto, MapPath("~\FileFotoProses\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFotoProses\") & FileFoto)
                                File.Copy(MapPath("~\FileFotoProses\") & CallSign & ".JPG", MapPath("~\FileFoto\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFoto\") & FileFoto)
                            End If
                        End If
                        s = String.Format("UPDATE DataIAR SET Callsign='{0}', FileFoto='{1}' WHERE CallSign = '" & CallSignLama & "' ", CallSign, CallSign & ".JPG")
                        s = InsertDataBase(s)
                    End If
                Case "IKRAP"
                    s = String.Format("UPDATE DataIKRAP SET Callsign='{0}',Nama='{1}',NamaKartu='{2}',NomorKTP='{3}'," & _
                                  "Alamat='{4}',Alamat1Kartu='{5}',Alamat2Kartu='{6}',Alamat3Kartu='{7}'," & _
                                  "KodePos='{8}',Kota='{9}',Provinsi='{10}',Agama='{11}',Pekerjaan='{12}',NomorTelepon='{13}'," & _
                                  "EMail='{14}',RapiDaerahCode='{15}',RapiDaerahName='{16}',JenisPermohonan='{17}'," & _
                                  "NomorIKRAP='{18}', MasaBerlakuIKRAP='{19}', FileFoto='{20}', StatusData={21}, UserUpdate='{22}'," & _
                                  "DateUpdate=#" & Date.Now & "# WHERE CallSign = '" & CallSign & "' ", _
                                  CallSign, Nama, NamaKartu, NomorKTP, _
                                  Alamat, Alamat1Kartu, Alamat2Kartu, Alamat3Kartu, _
                                  KodePos, Kota, Provinsi, Agama, Pekerjaan, NomorTelepon, _
                                  EMail, RapiDaerahCode, RapiDaerahName, JenisPermohonan, _
                                  NomorIKRAP, MasaBerlakuIKRAP, FileFoto, StatusData, Session("UserID"))
                    s = InsertDataBase(s)
                    If CallSign <> CallSignLama Then
                        '--- Rename File Foto ---
                        If FileFoto <> "" Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                            If TheFile.Exists Then
                                File.Copy(MapPath("~\FileFotoProses\") & FileFoto, MapPath("~\FileFotoProses\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFotoProses\") & FileFoto)
                                File.Copy(MapPath("~\FileFotoProses\") & CallSign & ".JPG", MapPath("~\FileFoto\") & CallSign & ".JPG")
                                File.Delete(MapPath("~\FileFoto\") & FileFoto)
                            End If
                        End If
                        s = String.Format("UPDATE DataIKRAP SET Callsign='{0}', FileFoto='{1}' WHERE CallSign = '" & CallSignLama & "' ", CallSign, CallSign & ".JPG")
                        s = InsertDataBase(s)
                    End If
            End Select
        Catch ex As Exception
            s = ex.Message.ToString
        End Try
        Return s

    End Function

    Function qInsertDatabase(ByVal dt As DataTable, ByVal i As Integer) As String

        Dim s As String = ""

        Try
            With dt
                GroupID = .Rows(i)("GroupID")
                Organisasi = .Rows(i)("Organisasi")
                NRI = .Rows(i)("NRI")
                TempatLahir = .Rows(i)("TempatLahir")
                TanggalLahir = .Rows(i)("TanggalLahir")
                Gol = .Rows(i)("Gol")
                CallSign = .Rows(i)("CallSign")
                Nama = .Rows(i)("Nama")
                NamaKartu = .Rows(i)("NamaKartu")
                NomorKTP = .Rows(i)("NomorKTP")
                JenisKelamin = .Rows(i)("JenisKelamin")
                If JenisKelamin = "LAKI-LAKI" Then
                    JenisKelamin = "L"
                Else
                    JenisKelamin = "P"
                End If
                Alamat = .Rows(i)("Alamat")
                Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                KodePos = .Rows(i)("KodePos")
                Kota = .Rows(i)("Kota")
                Provinsi = .Rows(i)("Provinsi")
                Agama = .Rows(i)("Agama")
                Pekerjaan = .Rows(i)("Pekerjaan")
                NomorTelepon = .Rows(i)("NomorTelepon")
                EMail = .Rows(i)("EMail")
                OrdaCode = .Rows(i)("OrdaCode")
                OrdaName = .Rows(i)("OrdaName")
                OrlokCode = .Rows(i)("OrlokCode")
                OrlokName = .Rows(i)("OrlokName")
                RapiDaerahCode = .Rows(i)("RapiDaerahCode")
                RapiDaerahName = .Rows(i)("RapiDaerahName")
                JenisPermohonan = .Rows(i)("JenisPermohonan")
                Tingkat = .Rows(i)("Tingkat")
                NomorUNAR = .Rows(i)("NomorUNAR")
                TanggalUNAR = .Rows(i)("TanggalUNAR")
                LokasiUNAR = .Rows(i)("LokasiUNAR")
                HasilUNAR = .Rows(i)("HasilUNAR")
                NomorSKAR = .Rows(i)("NomorSKAR")
                TanggalTerbitSKAR = .Rows(i)("TanggalTerbitSKAR")
                NomorIAR = .Rows(i)("NomorIAR")
                MasaBerlakuIAR = .Rows(i)("MasaBerlakuIAR")
                If MasaBerlakuIAR = "Seumur Hidup" Then
                    MasaBerlakuIAR = "1/1/2100"
                End If
                NomorIKRAP = .Rows(i)("NomorIKRAP")
                MasaBerlakuIKRAP = .Rows(i)("MasaBerlakuIKRAP")
                If MasaBerlakuIKRAP = "Seumur Hidup" Then
                    MasaBerlakuIKRAP = "1/1/2100"
                End If
                FileFoto = .Rows(i)("FileFoto")
                StatusData = .Rows(i)("ProsesData")
            End With
            Select Case MenuAwal
                Case "SKAR"
                    's = "INSERT INTO DataSKAR (GroupID,CallSign,Nama,TempatTanggalLahir,Alamat," & _
                    '  "Tingkat,OrdaCode,OrdaName,OrlokCode,OrlokName,NomorUNAR,TanggalUNAR,LokasiUNAR,NomorSKAR," & _
                    '  "TanggalSKAR,FileFoto,UserUpdate,DateUpdate) " & _
                    '  "VALUES ('" & GroupID & "','" & CallSign & "','" & NamaKartu & "','" & _
                    '  TempatLahir & ", " & TanggalLahir.Day & " " & ConvertBulan(TanggalLahir.Month) & " " & _
                    '  TanggalLahir.Year & "','" & Alamat & "','" & Tingkat & "','" & _
                    '  OrdaCode & "','" & OrdaName & "','" & OrlokCode & "','" & OrlokName & "','" & _
                    '  NomorUNAR & "',#" & TanggalUNAR & "#,'" & LokasiUNAR & "','" & NomorSKAR & "',#" & _
                    '  TanggalTerbitSKAR & "#,'" & FileFoto & "','" & Session("UserID") & "',#" & Date.Now & "#)"
                    s = "INSERT INTO DataSKAR (GroupID,Organisasi,Callsign,Nama,NamaKartu,NRI,NomorKTP," & _
                      "JenisKelamin,TempatLahir,TanggalLahir,TempatTanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu," & _
                      "Alamat3Kartu,KodePos,Kota,Provinsi,Agama,Gol,Pekerjaan,NomorTelepon,EMail," & _
                      "OrdaCode,OrdaName,OrlokCode,OrlokName,JenisPermohonan,Tingkat," & _
                      "NomorUNAR,TanggalUNAR,LokasiUNAR,NomorSKAR,TanggalTerbitSKAR,NomorIAR,MasaBerlakuIAR," & _
                      "FileFoto,StatusData,UserUpdate,DateUpdate) VALUES " & _
                      "('" & GroupID & "','" & Organisasi & "','" & CallSign & "','" & Nama & "','" & NamaKartu & "','" & NRI & "','" & _
                      NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & "',#" & TanggalLahir & "#,'" & _
                      TempatLahir & ", " & TanggalLahir.Day & " " & ConvertBulan(TanggalLahir.Month) & " " & TanggalLahir.Year & "','" & _
                      Alamat & "','" & Alamat1Kartu & "','" & _
                      Alamat2Kartu & "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & "','" & Gol & "','" & _
                      Pekerjaan & "','" & NomorTelepon & "','" & EMail & "','" & OrdaCode & "','" & OrdaName & "','" & OrlokCode & "','" & _
                      OrlokName & "','" & JenisPermohonan & "','" & Tingkat & "','" & NomorUNAR & "','" & TanggalUNAR & "','" & LokasiUNAR & "','" & _
                      NomorSKAR & "',#" & TanggalTerbitSKAR & "#,'" & NomorIAR & "','" & _
                      MasaBerlakuIAR & "','" & FileFoto & "'," & StatusData & ",'" & Session("UserID") & "',#" & Date.Now & "#)"
                Case "IAR"
                    s = "INSERT INTO DataIAR (GroupID,Organisasi,Callsign,Nama,NamaKartu,NRI,NomorKTP," & _
                      "JenisKelamin,TempatLahir,TanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu," & _
                      "Alamat3Kartu,KodePos,Kota,Provinsi,Agama,Gol,Pekerjaan,NomorTelepon,EMail," & _
                      "OrdaCode,OrdaName,OrlokCode,OrlokName,JenisPermohonan,Tingkat," & _
                      "NomorSKAR,TanggalTerbitSKAR,NomorIAR,MasaBerlakuIAR,FileFoto,StatusData," & _
                      "UserUpdate,DateUpdate) VALUES ('" & GroupID & "','" & Organisasi & "','" & CallSign & "','" & Nama & "','" & NamaKartu & "','" & NRI & "','" & _
                      NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & "',#" & TanggalLahir & "#,'" & Alamat & "','" & Alamat1Kartu & "','" & _
                      Alamat2Kartu & "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & "','" & Gol & "','" & _
                      Pekerjaan & "','" & NomorTelepon & "','" & EMail & "','" & OrdaCode & "','" & OrdaName & "','" & OrlokCode & "','" & _
                      OrlokName & "','" & JenisPermohonan & "','" & Tingkat & "','" & NomorSKAR & "',#" & TanggalTerbitSKAR & "#,'" & NomorIAR & "','" & _
                      MasaBerlakuIAR & "','" & FileFoto & "'," & StatusData & ",'" & Session("UserID") & "',#" & Date.Now & "#)"
                Case "IKRAP"
                    s = "INSERT INTO DataIKRAP (GroupID,Organisasi,Callsign,Nama,NamaKartu,NRI,NomorKTP," & _
                      "JenisKelamin,TempatLahir,TanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu," & _
                      "Alamat3Kartu,KodePos,Kota,Provinsi,Agama,Gol,Pekerjaan,NomorTelepon,EMail," & _
                      "RapiDaerahCode,RapiDaerahName," & _
                      "JenisPermohonan,NomorIKRAP,MasaBerlakuIKRAP,FileFoto,StatusData," & _
                      "UserUpdate,DateUpdate) VALUES ('" & GroupID & "','" & Organisasi & "','" & CallSign & "','" & Nama & "','" & NamaKartu & "','" & NRI & "','" & _
                      NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & "',#" & TanggalLahir & "#,'" & Alamat & "','" & Alamat1Kartu & "','" & _
                      Alamat2Kartu & "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & "','" & Gol & "','" & Pekerjaan & "','" & _
                      NomorTelepon & "','" & EMail & "','" & RapiDaerahCode & "','" & _
                      RapiDaerahName & "','" & JenisPermohonan & "','" & NomorIKRAP & "','" & MasaBerlakuIKRAP & "','" & FileFoto & "'," & _
                      StatusData & ",'" & Session("UserID") & "',#" & Date.Now & "#)"
            End Select
        Catch ex As Exception
            s = ex.Message.ToString
        End Try
        Return s
    End Function

    Public Shared Function qUpdateHasilUNAR(ByVal NomorUNAR As String) As String

        Dim s As String = ""
        Dim dt As New DataTable
        Dim PS, TR, PR, BI, KM, Teori, Jumlah, Nilai, KMKirim, KMTerima As Decimal
        Dim Hasil As String = ""
        Dim Keterangan As String = ""
        Try
            s = String.Format("SELECT * FROM HasilUNAR WHERE NomorUNAR='{0}'", NomorUNAR)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                PS = dt.Rows(0)("PS")
                TR = dt.Rows(0)("TR")
                PR = dt.Rows(0)("PR")
                BI = dt.Rows(0)("BI")
                KM = dt.Rows(0)("KM")
                Teori = dt.Rows(0)("Teori")
                Jumlah = dt.Rows(0)("Jumlah")
                Nilai = dt.Rows(0)("Nilai")
                Hasil = dt.Rows(0)("Hasil")
                Keterangan = dt.Rows(0)("Keterangan")
                KMKirim = dt.Rows(0)("KMKirim")
                KMTerima = dt.Rows(0)("KMTerima")
            End If
            s = String.Format("UPDATE DataSKAR SET PS='{0}',TR='{1}',PR='{2}',BI='{3}'," & _
                              "KM='{4}',Teori='{5}',Jumlah='{6}',Nilai='{7}'," & _
                              "Hasil='{8}',Keterangan='{9}',KMKirim='{10}',KMTerima='{11}'" & _
                              " WHERE NomorUNAR='{12}'", _
                              PS, TR, PR, BI, KM, Teori, Jumlah, Nilai, Hasil, Keterangan, _
                              KMKirim, KMTerima, NomorUNAR)
        Catch ex As Exception
            s = ex.Message.ToString
        End Try
        Return s

    End Function

#End Region

    Protected Sub cbxPilihSemua_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxPilihSemua.CheckedChanged
        Dim s As String
        Dim cx As CheckBox
        Session("CheckAll") = ""
        cx = sender
        If cx.Checked = True Then
            s = setCheckedAll("True")
            Session("CheckAll") = "True"
        Else
            s = setCheckedAll("False")
            Session("CheckAll") = "False"
        End If
        cx = Nothing
        GC.Collect()
    End Sub
End Class