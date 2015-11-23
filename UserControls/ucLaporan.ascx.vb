'--- Custom Module ---
Imports clsGeneral
Imports clsDataBase
'--- System Module ---
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Security.Cryptography
'--- DevExpress Module ---
Imports DevExpress.Web

Partial Class UserControls_ucLaporan
    Inherits System.Web.UI.UserControl

    Public Shared Organisasi As String = ""
    Public Shared CallSign As String = ""
    Public Shared Where As String = ""
    Public Shared MenuAwal As String = ""
    Public Shared TableName As String = ""
    Public Shared GroupID As String = ""
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
    Public Shared NRI As String = ""
    Public Shared TempatLahir As String = ""
    Public Shared TanggalLahir As Date
    Public Shared Gol As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        Else
            Organisasi = Session("Organisasi")
            MenuAwal = Session("MenuAwal")
            If MenuAwal = "SKAR" Then
                ddlKriteria.Enabled = False
            End If
        End If

        If Page.IsPostBack = False Then
            TableName = "Data" & MenuAwal
            GetYear()
            GetMonth()
            GetData(TableName, Where)
            Select Case MenuAwal
                Case "SKAR"
                    GvDataSKAR.Visible = True
                Case "IAR"
                    GvDataIAR.Visible = True
                Case "IKRAP"
                    GvDataIKRAP.Visible = True
            End Select
        Else
            GetData(TableName, Where)
        End If
        
    End Sub

    Sub GetData(ByVal TableName As String, ByVal Where As String)
        Dim s As String
        Dim dt As DataTable
        Dim Bulan As Integer = Date.Now.Month
        Dim Tahun As Integer = Date.Now.Year

        '----------------------
        ' Get Kriteria
        '----------------------
        If Len(ddlKriteria.SelectedValue) = 1 Then
            If Bulan = 12 Then
                Bulan = 0 + ddlKriteria.SelectedValue
                Tahun = Tahun + 1
            Else
                Bulan = Date.Now.Month + ddlKriteria.SelectedValue
            End If
        End If
        'Where = " WHERE "

        Select Case ddlKriteria.SelectedValue
            Case "Semua"
                Where = ""
            Case "Aktif"
                If Where <> "" Then
                    Where = Where & " AND "
                End If
                Where = Where & " CDATE(MasaBerlakuIAR) > #" & Date.Now & "# "
            Case "InAktif"
                If Where <> "" Then
                    Where = Where & " AND "
                End If
                Where = Where & " CDATE(MasaBerlakuIAR) < #" & Date.Now & "# "
            Case Else
                If Where <> "" Then
                    Where = Where & " AND "
                End If
                Where = Where & " CDATE(MasaBerlakuIAR) > #" & Date.Now & "# AND CDATE(MasaBerlakuIAR) < #" & Bulan.ToString & "/" & Date.DaysInMonth(Tahun, Bulan) & "/" & Tahun.ToString & "# "
        End Select

        '----------------------
        ' Get Date
        '----------------------
        Select Case ddlTahun.SelectedValue
            Case "Semua"
                Where = Where & ""
            Case Else
                If Where <> "" Then
                    Where = Where & " AND "
                End If
                Where = Where & " Year(DateUpdate) = '" & ddlTahun.SelectedValue & "' AND " & _
                        " Month(DateUpdate) BETWEEN " & ddlMonthStart.SelectedValue & " AND " & ddlMonthEnd.SelectedValue & " "
        End Select
        If Where <> "" Then
            Where = " WHERE " & Where
        End If
        s = qSelectAllMember(TableName, Where)
        dt = ViewDatabase(s)
        Select Case TableName
            Case "DataSKAR"
                GvDataSKAR.DataSource = dt
                GvDataSKAR.DataBind()
                GvDataSKAR.Visible = True
            Case "DataIAR"
                GvDataIAR.DataSource = dt
                GvDataIAR.DataBind()
                GvDataIAR.Visible = True
            Case "DataIKRAP"
                GvDataIKRAP.DataSource = dt
                GvDataIKRAP.DataBind()
                GvDataIKRAP.Visible = True
        End Select
    End Sub

    Sub GetYear()
        Dim YearStart As Integer = 2010
        Dim YearEnd As Integer = Date.Now.Year
        ddlTahun.Items.Clear()
        ddlTahun.Items.Add(New ListItem("Semua", "Semua"))
        For i = YearStart To YearEnd
            ddlTahun.Items.Add(New ListItem(i.ToString, i.ToString))
        Next
        ddlTahun.SelectedValue = "Semua"
    End Sub

    Sub GetMonth()
        Dim MonthStart As Integer = 1
        Dim MonthEnd As Integer = Date.Now.Month
        ddlMonthStart.Items.Clear()
        ddlMonthEnd.Items.Clear()
        If ddlTahun.SelectedValue <> "Semua" Then
            If Date.Now.Year > ddlTahun.SelectedValue Then
                For i = 1 To Date.Now.Month
                    ddlMonthStart.Items.Add(New ListItem(ConvertBulan(i), i))
                    ddlMonthEnd.Items.Add(New ListItem(ConvertBulan(i), i))
                Next
                ddlMonthStart.SelectedValue = "1"
                ddlMonthEnd.SelectedValue = Date.Now.Month
            Else
                For i = 1 To 12
                    ddlMonthStart.Items.Add(New ListItem(ConvertBulan(i), i))
                    ddlMonthEnd.Items.Add(New ListItem(ConvertBulan(i), i))
                Next
                ddlMonthStart.SelectedValue = "1"
                ddlMonthEnd.SelectedValue = "12"
            End If
        Else
            ddlMonthStart.Items.Add(New ListItem(ConvertBulan(1), 1))
            ddlMonthEnd.Items.Add(New ListItem(ConvertBulan(12), 12))
            ddlMonthStart.SelectedValue = "1"
            ddlMonthEnd.SelectedValue = "12"
            ddlMonthStart.Enabled = False
            ddlMonthEnd.Enabled = False
        End If

    End Sub

    Protected Sub GvDataIAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "NO." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Protected Sub GvLaporanIAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "NO." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Protected Sub GvDataIKRAP_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Protected Sub GvDataSKAR_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDisplayTextEventArgs)
        If e.Column.Caption = "No." Then
            e.DisplayText = e.VisibleRowIndex.ToString() + 1
        End If
    End Sub

    Protected Sub btnCetakSKAR_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlNomorSKAR As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlNomorSKAR"), Literal)
        qPrintSKAR(ltrlNomorSKAR.Text)
    End Sub

    Protected Sub btnLihatSKAR_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlNomorID As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlNomorID"), Literal)
        Response.Redirect(String.Format("~/pages/formSKAR.aspx?NomorID='{0}'&returnurl={1}", ltrlNomorID.Text, "Laporan.aspx"))
    End Sub

    Protected Sub btnCetakIAR_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlCallSign As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlCallSign"), Literal)
        qPrintIAR(ltrlCallSign.Text)
    End Sub

    Protected Sub btnLihatIAR_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlCallSign As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlCallSign"), Literal)
        Response.Redirect(String.Format("~/pages/formIAR.aspx?CallSign='{0}'&returnurl={1}", ltrlCallSign.Text, "Laporan.aspx"))
    End Sub

    Protected Sub btnCetakIKRAP_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlCallSign As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlCallSign"), Literal)
        qPrintIKRAP(ltrlCallSign.Text)
    End Sub

    Protected Sub btnLihatIKRAP_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlCallSign As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlCallSign"), Literal)
        Response.Redirect(String.Format("~/pages/formIKRAP.aspx?CallSign='{0}'&returnurl={1}", ltrlCallSign.Text, "Laporan.aspx"))
    End Sub

    Protected Sub btnXlsExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Select Case MenuAwal
            Case "SKAR"
                Me.GvExportDataSKAR.WriteXlsToResponse()
            Case "IAR"
                Me.GvExportDataIAR.WriteXlsToResponse()
            Case "IKRAP"
                Me.GvExportDataIKRAP.WriteXlsToResponse()
        End Select
    End Sub

    Protected Sub btnPdfExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPdfFile.Click
        Select Case MenuAwal
            Case "SKAR"
                Me.GvExportDataSKAR.WritePdfToResponse()
            Case "IAR"
                Me.GvExportDataIAR.WritePdfToResponse()
            Case "IKRAP"
                Me.GvExportDataIKRAP.WritePdfToResponse()
        End Select
    End Sub

    Protected Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GetData("Data" & MenuAwal, Where)
    End Sub

    Protected Sub btnCariData_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCariData.Click
        Dim s As String = ""
        Dim dt As New DataTable
        Where = " WHERE " & ddlCariData.SelectedValue & " LIKE '%" & Replace(Trim(tbxCariData.Text), "0", "Ø") & "%' "
        If Trim(tbxCariData.Text) = "" Then
            Where = ""
        End If
        s = qSelectAllMember(TableName, Where)
        dt = ViewDatabase(s)
        Select Case TableName
            Case "DataSKAR"
                GvDataSKAR.DataSource = dt
                GvDataSKAR.DataBind()
                GvDataSKAR.Visible = True
            Case "DataIAR"
                GvDataIAR.DataSource = dt
                GvDataIAR.DataBind()
                GvDataIAR.Visible = True
            Case "DataIKRAP"
                GvDataIKRAP.DataSource = dt
                GvDataIKRAP.DataBind()
                GvDataIKRAP.Visible = True
        End Select

    End Sub

    Function qPrintSKAR(ByVal NomorSKAR As String) As String

        Dim Message As String = ""
        Dim s As String = ""
        Dim ErrorStr As String = ""
        Try
            '--- Get Profile Data
            Dim GroupID As String = ""
            Dim ProsesID As String = ""
            Dim NamaKartu As String = ""
            Dim TempatTanggalLahir As String = ""
            Dim Alamat As String = ""
            Dim Tingkat As String = ""
            Dim TanggalUNAR As String = ""
            Dim LokasiUNAR As String = ""
            Dim TanggalSKAR As String = ""
            Dim CallSign As String = ""
            Dim FileFoto As String = ""
            Dim DataSKAR As String = ""
            Dim OrdaName As String = ""

            Dim dt As New DataTable
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter("SELECT * FROM [DataSKAR] WHERE NomorSKAR='" & NomorSKAR & "' ORDER BY ID ", cn)
            da.Fill(dt)
            With dt
                If .Rows.Count > 0 Then
                    Dim i As Integer = .Rows.Count - 1
                    GroupID = "CETAKULANG"
                    ProsesID = "CETAKULANG_" & NomorSKAR
                    JenisPermohonan = .Rows(i)("JenisPermohonan")
                    Nama = .Rows(i)("Nama")
                    NamaKartu = .Rows(i)("NamaKartu")
                    TempatLahir = .Rows(i)("TempatLahir")
                    TanggalLahir = .Rows(i)("TanggalLahir")
                    TempatTanggalLahir = .Rows(i)("TempatTanggalLahir")
                    NomorKTP = .Rows(i)("NomorKTP")
                    JenisKelamin = .Rows(i)("JenisKelamin")
                    Alamat = .Rows(i)("Alamat")
                    Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                    Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                    Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                    Kota = .Rows(i)("Kota")
                    Provinsi = .Rows(i)("Provinsi")
                    KodePos = .Rows(i)("KodePos")
                    Agama = .Rows(i)("Agama")
                    Pekerjaan = .Rows(i)("Pekerjaan")
                    NomorTelepon = .Rows(i)("NomorTelepon")
                    EMail = .Rows(i)("EMail")
                    Tingkat = .Rows(i)("Tingkat")
                    CallSign = .Rows(i)("CallSign")
                    FileFoto = .Rows(i)("FileFoto")
                    OrdaCode = .Rows(i)("OrdaCode")
                    OrdaName = .Rows(i)("OrdaName")
                    OrlokCode = .Rows(i)("OrlokCode")
                    OrlokName = .Rows(i)("OrlokName")
                    HasilUNAR = .Rows(i)("Hasil")
                    NomorUNAR = .Rows(i)("NomorUNAR")
                    TanggalUNAR = .Rows(i)("TanggalUNAR")
                    LokasiUNAR = .Rows(i)("LokasiUNAR")
                    NomorSKAR = .Rows(i)("NomorSKAR")
                    TanggalTerbitSKAR = .Rows(i)("TanggalTerbitSKAR")
                    NomorIAR = .Rows(i)("NomorIAR")
                    MasaBerlakuIAR = .Rows(i)("MasaBerlakuIAR")
                    StatusData = .Rows(i)("StatusData")
                    If HasilUNAR = "LULUS" Then
                        DataSKAR = "'" & GroupID & "','" & ProsesID & "','4','Orari','" & CallSign & "','','" & NamaKartu & _
                                 "','" & NamaKartu & "','','" & NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & _
                                 "',#" & TanggalLahir & "#,'" & Alamat & "','" & Alamat1Kartu & "','" & Alamat2Kartu & _
                                 "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & _
                                 "','" & Gol & "','" & Pekerjaan & "','" & NomorTelepon & "','" & EMail & "','" & OrdaCode & _
                                 "','" & OrdaName & "','" & OrlokCode & "','" & OrlokName & "','" & RapiDaerahCode & "','" & RapiDaerahName & _
                                 "','" & JenisPermohonan & "','" & Tingkat & "','" & NomorUNAR & "',#" & TanggalUNAR & "#,'" & LokasiUNAR & _
                                 "','" & HasilUNAR & "','" & NomorSKAR & "',#" & TanggalTerbitSKAR & "#,'" & NomorIAR & "','" & MasaBerlakuIAR & _
                                 "','" & NomorIKRAP & "','" & MasaBerlakuIKRAP & "','',#1/1/1900#,0,'" & FileFoto & "','1' "
                        s = qInsertDataProses(DataSKAR)
                        s = InsertDataProcess(s)

                        Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFoto\") & FileFoto)
                        If TheFile.Exists Then
                            Dim TheFileProses As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                            If TheFileProses.Exists = False Then
                                File.Copy(MapPath("~\FileFoto\") & FileFoto, MapPath("~\FileFotoProses\") & FileFoto)
                            End If
                        Else
                            Dim TheFile1 As FileInfo = New FileInfo(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"))
                            If TheFile1.Exists Then
                                File.Copy(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"), MapPath("~\FileFotoProses\") & Replace(FileFoto, "0", "Ø"))
                            Else
                                s = "File Foto tidak ketemu."
                            End If
                        End If
                    Else
                        s = "Hasil UNAR TIDAK LULUS"
                    End If

                    If s = "" Then
                        If MenuAwal = "SKAR" Then
                            Message = "Nomor SKAR " & NomorSKAR & " siap untuk cetak ulang."
                        Else
                            Message = "CallSign " & CallSign & " siap untuk cetak ulang."
                        End If
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    Else
                        If MenuAwal = "SKAR" Then
                            Message = "Nomor SKAR " & NomorSKAR & " tidak bisa cetak ulang dengan Error: " & s & " "
                        Else
                            Message = "CallSign " & CallSign & " tidak bisa cetak ulang dengan Error: " & s & " "
                        End If
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                Else
                    Message = "Data tidak ditemukan."
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return Message
    End Function

    Function qPrintIAR(ByVal CallSign As String) As String

        Dim Message As String = ""
        Dim s As String = ""
        Dim ErrorStr As String = ""
        Dim DataIAR As String = ""
        Try
            '--- Get Profile Data
            Dim GroupID As String = ""
            Dim ProsesID As String = ""
            Dim ProsesLevel As String = ""
            Dim Organisasi As String = ""
            Dim CallsignLama As String = ""
            Dim Nama As String = ""
            Dim NamaKartu As String = ""
            Dim NRI As String = ""
            Dim NomorKTP As String = ""
            Dim JenisKelamin As String = ""
            Dim TempatLahir As String = ""
            Dim TanggalLahir As Date
            Dim Alamat As String = ""
            Dim Alamat1Kartu As String = ""
            Dim Alamat2Kartu As String = ""
            Dim Alamat3Kartu As String = ""
            Dim KodePos As String = ""
            Dim Kota As String = ""
            Dim Provinsi As String = ""
            Dim Agama As String = ""
            Dim Gol As String = ""
            Dim Pekerjaan As String = ""
            Dim NomorTelepon As String = ""
            Dim EMail As String = ""
            Dim OrdaCode As String = ""
            Dim OrdaName As String = ""
            Dim OrlokCode As String = ""
            Dim OrlokName As String = ""
            Dim RapiDaerahCode As String = ""
            Dim RapiDaerahName As String = ""
            Dim JenisPermohonan As String = ""
            Dim Tingkat As String = ""
            Dim NomorUNAR As String = ""
            Dim TanggalUNAR As Date
            Dim LokasiUNAR As String = ""
            Dim HasilUNAR As String = ""
            Dim NomorSKAR As String = ""
            Dim TanggalTerbitSKAR As Date
            Dim NomorIAR As String = ""
            Dim MasaBerlakuIAR As String = ""
            Dim NomorIKRAP As String = ""
            Dim MasaBerlakuIKRAP As String = "1/1/1900"
            Dim ValidasiBank As String = ""
            Dim TanggalBayar As Date = Date.Now
            Dim PNBP As Integer = 0
            Dim FileFoto As String = ""
            Dim ProsesData As String = ""
            Dim dt As New DataTable
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter("SELECT * FROM [DataIAR] WHERE CallSign='" & CallSign & "' ORDER BY ID ", cn)
            da.Fill(dt)
            With dt
                If .Rows.Count > 0 Then
                    Dim i As Integer = .Rows.Count - 1
                    GroupID = "CETAKULANG"
                    ProsesID = "CETAKULANG_" & CallSign
                    Nama = .Rows(i)("Nama")
                    NamaKartu = .Rows(i)("NamaKartu")
                    NomorKTP = .Rows(i)("NomorKTP")
                    JenisKelamin = .Rows(i)("JenisKelamin")
                    TempatLahir = .Rows(i)("TempatLahir")
                    TanggalLahir = .Rows(i)("TanggalLahir")
                    Alamat = .Rows(i)("Alamat")
                    Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                    Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                    Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                    KodePos = .Rows(i)("KodePos")
                    Kota = .Rows(i)("Kota")
                    Provinsi = .Rows(i)("Provinsi")
                    Agama = .Rows(i)("Agama")
                    Gol = .Rows(i)("Gol")
                    Pekerjaan = .Rows(i)("Pekerjaan")
                    NomorTelepon = .Rows(i)("NomorTelepon")
                    EMail = .Rows(i)("EMail")
                    OrdaCode = .Rows(i)("OrdaCode")
                    OrdaName = .Rows(i)("OrdaName")
                    OrlokCode = .Rows(i)("OrlokCode")
                    OrlokName = .Rows(i)("OrlokName")
                    JenisPermohonan = .Rows(i)("JenisPermohonan")
                    Tingkat = .Rows(i)("Tingkat")
                    NomorSKAR = .Rows(i)("NomorSKAR")
                    TanggalTerbitSKAR = .Rows(i)("TanggalTerbitSKAR")
                    NomorIAR = .Rows(i)("NomorIAR")
                    MasaBerlakuIAR = .Rows(i)("MasaBerlakuIAR")
                    FileFoto = .Rows(i)("FileFoto")
                    DataIAR = "'" & GroupID & "','" & ProsesID & "','13','Orari','" & CallSign & "','','" & Nama & _
                              "','" & NamaKartu & "','" & NRI & "','" & NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & _
                              "',#" & TanggalLahir & "#,'" & Alamat & "','" & Alamat1Kartu & "','" & Alamat2Kartu & _
                              "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & _
                              "','" & Gol & "','" & Pekerjaan & "','" & NomorTelepon & "','" & EMail & "','" & OrdaCode & _
                              "','" & OrdaName & "','" & OrlokCode & "','" & OrlokName & "','" & RapiDaerahCode & "','" & RapiDaerahName & _
                              "','" & JenisPermohonan & "','" & Tingkat & "','" & NomorUNAR & "',#" & TanggalUNAR & "#,'" & LokasiUNAR & _
                              "','" & HasilUNAR & "','" & NomorSKAR & "',#" & TanggalTerbitSKAR & "#,'" & NomorIAR & "','" & MasaBerlakuIAR & _
                              "','" & NomorIKRAP & "','" & MasaBerlakuIKRAP & "','" & ValidasiBank & "',#" & TanggalBayar & "#," & PNBP & _
                              ",'" & FileFoto & "','1' "
                    s = qInsertDataProses(DataIAR)
                    s = InsertDataProcess(s)
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFoto\") & FileFoto)
                    If TheFile.Exists Then
                        File.Copy(MapPath("~\FileFoto\") & FileFoto, MapPath("~\FileFotoProses\") & FileFoto)
                    Else
                        Dim TheFile1 As FileInfo = New FileInfo(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"))
                        If TheFile1.Exists Then
                            File.Copy(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"), MapPath("~\FileFotoProses\") & Replace(FileFoto, "0", "Ø"))
                        Else
                            s = "File Foto tidak ketemu."
                        End If
                    End If
                    If s = "" Then
                        Message = "CallSign " & CallSign & " siap untuk cetak ulang."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    Else
                        Message = "CallSign " & CallSign & " tidak bisa cetak ulang dengan Error " & s & " "
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                Else
                    Message = "Data tidak ditemukan."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return Message
    End Function

    Function qPrintIKRAP(ByVal CallSign As String) As String

        Dim Message As String = ""
        Dim s As String = ""
        Dim DataIKRAP As String = ""
        Try
            '--- Get Profile Data
            Dim GroupID As String = ""
            Dim ProsesID As String = ""
            Dim ProsesLevel As String = ""
            Dim Organisasi As String = ""
            Dim Nama As String = ""
            Dim NamaKartu As String = ""
            Dim NRI As String = ""
            Dim NomorKTP As String = ""
            Dim JenisKelamin As String = ""
            Dim TempatLahir As String = ""
            Dim TanggalLahir As Date
            Dim Alamat As String = ""
            Dim Alamat1Kartu As String = ""
            Dim Alamat2Kartu As String = ""
            Dim Alamat3Kartu As String = ""
            Dim KodePos As String = ""
            Dim Kota As String = ""
            Dim Provinsi As String = ""
            Dim Agama As String = ""
            Dim Gol As String = ""
            Dim Pekerjaan As String = ""
            Dim NomorTelepon As String = ""
            Dim EMail As String = ""
            Dim RapiDaerahCode As String = ""
            Dim RapiDaerahName As String = ""
            Dim JenisPermohonan As String = ""
            Dim Tingkat As String = ""
            Dim NomorIKRAP As String = ""
            Dim MasaBerlakuIKRAP As String = "1/1/1900"
            Dim ValidasiBank As String = ""
            Dim TanggalBayar As Date = Date.Now
            Dim PNBP As Integer = 0
            Dim FileFoto As String = ""
            Dim ProsesData As String = ""
            Dim dt As New DataTable
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter("SELECT * FROM [DataIKRAP] WHERE CallSign='" & CallSign & "' ORDER BY ID ", cn)
            da.Fill(dt)
            With dt
                If .Rows.Count > 0 Then
                    Dim i As Integer = .Rows.Count - 1
                    GroupID = "CETAKULANG"
                    ProsesID = "CETAKULANG_" & CallSign
                    Nama = .Rows(i)("Nama")
                    NamaKartu = .Rows(i)("NamaKartu")
                    NomorKTP = .Rows(i)("NomorKTP")
                    JenisKelamin = .Rows(i)("JenisKelamin")
                    TempatLahir = .Rows(i)("TempatLahir")
                    TanggalLahir = .Rows(i)("TanggalLahir")
                    Alamat = .Rows(i)("Alamat")
                    Alamat1Kartu = .Rows(i)("Alamat1Kartu")
                    Alamat2Kartu = .Rows(i)("Alamat2Kartu")
                    Alamat3Kartu = .Rows(i)("Alamat3Kartu")
                    KodePos = .Rows(i)("KodePos")
                    Kota = .Rows(i)("Kota")
                    Provinsi = .Rows(i)("Provinsi")
                    Agama = .Rows(i)("Agama")
                    Gol = .Rows(i)("Gol")
                    Pekerjaan = .Rows(i)("Pekerjaan")
                    NomorTelepon = .Rows(i)("NomorTelepon")
                    EMail = .Rows(i)("EMail")
                    RapiDaerahCode = .Rows(i)("RapiDaerahCode")
                    RapiDaerahName = .Rows(i)("RapiDaerahName")
                    JenisPermohonan = .Rows(i)("JenisPermohonan")
                    NomorIKRAP = .Rows(i)("NomorIKRAP")
                    MasaBerlakuIKRAP = .Rows(i)("MasaBerlakuIKRAP")
                    FileFoto = .Rows(i)("FileFoto")
                    DataIKRAP = "'" & GroupID & "','" & ProsesID & "','13','Rapi','" & CallSign & "','','" & Nama & _
                              "','" & NamaKartu & "','" & NRI & "','" & NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & _
                              "',#" & TanggalLahir & "#,'" & Alamat & "','" & Alamat1Kartu & "','" & Alamat2Kartu & _
                              "','" & Alamat3Kartu & "','" & KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & _
                              "','" & Gol & "','" & Pekerjaan & "','" & NomorTelepon & "','" & EMail & "','','','','','" & RapiDaerahCode & _
                              "','" & RapiDaerahName & "','" & JenisPermohonan & "','','',#1/1/1900#,'','','',#1/1/1900#,'" & _
                              "','','" & NomorIKRAP & "','" & MasaBerlakuIKRAP & "','" & ValidasiBank & "',#" & TanggalBayar & "#," & PNBP & _
                              ",'" & FileFoto & "','1' "
                    s = qInsertDataProses(DataIKRAP)
                    s = InsertDataProcess(s)
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFoto\") & FileFoto)
                    If TheFile.Exists Then
                        File.Copy(MapPath("~\FileFoto\") & FileFoto, MapPath("~\FileFotoProses\") & FileFoto)
                    Else
                        Dim TheFile1 As FileInfo = New FileInfo(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"))
                        If TheFile1.Exists Then
                            File.Copy(MapPath("~\FileFoto\") & Replace(FileFoto, "0", "Ø"), MapPath("~\FileFotoProses\") & Replace(FileFoto, "0", "Ø"))
                        Else
                            s = "File Foto tidak ketemu."
                        End If
                    End If
                    If s = "" Then
                        Message = "CallSign " & CallSign & " siap untuk cetak ulang."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    Else
                        Message = "CallSign " & CallSign & " tidak bisa cetak ulang dengan Error " & s & " "
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                Else
                    Message = "Data tidak ditemukan."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return Message
    End Function

    Protected Sub ddlTahun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlTahun.SelectedIndexChanged
        If ddlTahun.SelectedValue <> "Semua" Then
            ddlMonthStart.Enabled = True
            ddlMonthEnd.Enabled = True
        Else
            ddlMonthStart.Enabled = False
            ddlMonthEnd.Enabled = False
        End If
    End Sub
End Class
