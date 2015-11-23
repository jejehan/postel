Imports System
Imports System.IO
'Imports DevExpress.Web
Imports System.Data.OleDb
Imports clsDataBase
Imports clsGeneral
Imports clsPersyaratan
Imports clsCallSign
Imports System.Drawing
Imports System.Drawing.Imaging

Partial Class UserControls_ucFormKhusus
    Inherits System.Web.UI.UserControl
    Public Shared NRI, NomorKTP, Callsign, ReturnUrl As String
    Public Shared BiayaPNBP As Double
    Public Shared BiayaIuran As Double
    Public Shared BiayaUangPangkal As Double
    Public Shared BiayaAdm As Double
    Public Shared BiayaPilihCallSign As Double
    Public Shared GroupID As String = ""
    Public Shared ProsesID As String = ""
    Public Shared ProsesLevel As String = ""
    Public Shared FileFoto As String = ""
    Public Shared PilihCallSign As String = ""
    Public Shared MenuAwal As String = ""
    Public Shared dateTglAwal, dateTglAkhir, dateTglLahir, dateTglSurat As Date

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable

        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            ProsesID = Request.QueryString("ProsesID")
            ReturnUrl = Request.QueryString("returnurl")
            ddlOrdaList()
            ddlOrlokList()
            '--- Check if New Data or Import Data
            If ProsesID <> "" Then
                GetMemberList()
            Else
                DataBlank()
            End If
        End If

    End Sub

    Sub ddlOrdaList()
        Dim dt As DataTable
        ddlOrda.Items.Clear()
        ddlOrda.Items.Add(New ListItem("-- Pilih Orda--", "0"))
        dt = qFindListOrariDaerah()
        With dt
            For i = 0 To .Rows.Count - 1
                ddlOrda.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("Kode")))
            Next
        End With
    End Sub

    Sub ddlOrlokList()
        Dim dt As DataTable
        ddlOrlok.Items.Clear()
        ddlOrlok.Items.Add(New ListItem("--- Pilih Orlok ---", "0"))
        dt = qFindListOrariLokal(ddlOrda.SelectedValue)
        With dt
            For i = 0 To .Rows.Count - 1
                ddlOrlok.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("Kode")))
            Next
        End With
    End Sub

    Sub GetMemberList()

        Dim Where As String = ""
        Where = " WHERE ProsesID='" & Trim(ProsesID) & "' "

        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectIARKhusus(Where), cn)
        Dim dt As New DataTable
        da.Fill(dt)
        With dt
            If .Rows.Count > 0 Then
                '--- Data Pemohon ---
                ProsesLevel = Trim(.Rows(0)("ProsesLevel"))
                GroupID = Trim(.Rows(0)("GroupID"))
                ProsesID = Trim(.Rows(0)("ProsesID"))
                tbxNomorIzin.Text = Trim(.Rows(0)("NomorIZIN"))
                tbxCallSignKhusus.Text = Trim(.Rows(0)("NamaPanggilanKhusus"))
                tbxAlamatStasiun.Text = Trim(.Rows(0)("AlamatStasiun"))
                tbxDayaDiBawah30.Text = Trim(.Rows(0)("DayaDibawah30"))
                tbxDayaDiAtas30.Text = Trim(.Rows(0)("DayaDiatas30"))
                tbxPenggunaanStasiun.Text = Trim(.Rows(0)("PenggunaanStasiun"))
                tbxBandFrekuensi.Text = Trim(.Rows(0)("BandFrekuensi"))
                tbxKelasEmisi.Text = Trim(.Rows(0)("KelasEmisi"))
                dateTglAwal = Trim(.Rows(0)("BerlakuMulai"))
                dateTanggalAwal.Value = dateTglAwal
                dateTglAkhir = Trim(.Rows(0)("BerlakuAkhir"))
                dateTanggalAkhir.Value = dateTglAkhir
                ddlOrdaList()
                ddlOrda.SelectedValue = Trim(.Rows(0)("OrdaCode"))
                ddlOrlokList()
                ddlOrlok.SelectedValue = Trim(.Rows(0)("OrlokCode"))
                tbxNamaLengkap.Text = Trim(.Rows(0)("NamaLengkap"))
                tbxCallSign.Text = Trim(.Rows(0)("NamaPanggilan"))
                ddlKelamin.SelectedValue = Trim(.Rows(0)("JenisKelamin"))
                tbxTempatLahir.Text = Trim(.Rows(0)("TempatLahir"))
                dateTglLahir = Trim(.Rows(0)("TanggalLahir"))
                dateTanggalLahir.Value = dateTglLahir
                tbxPekerjaan.Text = Trim(.Rows(0)("Pekerjaan"))
                tbxAlamat.Text = Trim(.Rows(0)("Alamat"))
                LblNamaFoto.Text = Trim(.Rows(0)("FileFoto"))
                dateTglSurat = Trim(.Rows(0)("TanggalSurat"))
                dateTanggalSurat.Value = dateTglSurat

                Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & LblNamaFoto.Text)
                If TheFile.Exists Then
                    ImgFoto.ImageUrl = "~/FileFotoProses/" & LblNamaFoto.Text
                Else
                    ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                    LblNamaFoto.Text = "Foto Tidak Ditemukan"
                End If
            End If
        End With
        da.Dispose()
        cn.Dispose()

    End Sub

    Function SaveData() As String

        Dim s As String = ""
        Try
            Dim AddField As String = ""
            Dim AddValues As String = ""
            Dim Values As String = ""

            If ProsesID <> "" Then '--- Data Update
                s = qDeleteDataProsesKhusus(ProsesID)
                s = InsertDataProcess(s)
            Else
                '--- Proses ID (Entry Manual) ---
                Dim ProsesLevel As String = "4"
                Dim ProsesID As String = Format(Date.Now, "ddMMyyhhmmss").ToString
            End If
            Values = "'" & ProsesLevel & "','" & GroupID & "','" & ProsesID & "','" & tbxNomorIzin.Text & "','" & _
                     tbxCallSignKhusus.Text & "','" & tbxAlamatStasiun.Text & "','" & tbxDayaDiBawah30.Text & "','" & _
                     tbxDayaDiAtas30.Text & "','" & tbxPenggunaanStasiun.Text & "','" & tbxBandFrekuensi.Text & "','" & _
                     tbxKelasEmisi.Text & "',#" & dateTanggalAwal.Value & "#,#" & dateTanggalAkhir.Value & "#,'" & _
                     ddlOrda.SelectedItem.Text & "','" & ddlOrda.SelectedItem.Value & "','" & ddlOrlok.SelectedItem.Text & "','" & _
                     ddlOrlok.SelectedItem.Value & "','" & tbxNamaLengkap.Text & "','" & tbxCallSign.Text & "','" & _
                     ddlKelamin.SelectedItem.Value & "','" & tbxTempatLahir.Text & "',#" & dateTanggalLahir.Value & "#,'" & _
                     tbxPekerjaan.Text & "','" & tbxAlamat.Text & "','" & LblNamaFoto.Text & "','1',#" & dateTanggalSurat.Value & "#"
            s = qInsertDataIARKhusus(Values)
            s = InsertDataProcess(s)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SaveData()
    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Response.Redirect("~/Pages/" & ReturnUrl)
    End Sub

    Protected Sub BtnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        DataBlank()
    End Sub

    Sub DataBlank()
        '--- Data Pemohon ---
        tbxNomorIzin.Text = ""
        tbxCallSignKhusus.Text = ""
        tbxAlamatStasiun.Text = ""
        tbxDayaDiBawah30.Text = ""
        tbxDayaDiAtas30.Text = ""
        tbxPenggunaanStasiun.Text = ""
        tbxBandFrekuensi.Text = ""
        tbxKelasEmisi.Text = ""
        dateTanggalAwal.Value = "1/1/1900"
        dateTanggalAkhir.Value = "1/1/1900"
        ddlOrda.SelectedItem.Value = ""
        ddlOrlok.SelectedItem.Value = ""
        tbxNamaLengkap.Text = ""
        tbxCallSign.Text = ""
        ddlKelamin.SelectedItem.Value = ""
        tbxTempatLahir.Text = ""
        dateTanggalLahir.Text = ""
        tbxPekerjaan.Text = ""
        tbxAlamat.Text = ""
        LblNamaFoto.Text = ""
        dateTanggalSurat.Value = "1/1/1900"

        ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
        LblNamaFoto.Text = ""

    End Sub

    Protected Sub BtnSaveProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveProses.Click
        Dim NomorUrutSKAR As String = ""
        Dim Message As String = ""
        Dim s As String = ""
        Dim DataSKAR As String = ""
        Dim DataIAR As String = ""

        Dim ProsesLevel As String = ""
        Dim GroupID As String = ""
        Dim ProsesID As String = ""
        Dim NomorIZIN As String = ""
        Dim NamaPanggilanKhusus As String = ""
        Dim AlamatStasiun As String = ""
        Dim DayaDibawah30 As String = ""
        Dim DayaDiatas30 As String = ""
        Dim PenggunaanStasiun As String = ""
        Dim BandFrekuensi As String = ""
        Dim KelasEmisi As String = ""
        Dim BerlakuMulai As Date
        Dim BerlakuMulaiStr As String = ""
        Dim BerlakuAkhir As Date
        Dim BerlakuAkhirStr As String = ""
        Dim Orda As String = ""
        Dim OrdaCode As String = ""
        Dim Orlok As String = ""
        Dim OrlokCode As String = ""
        Dim NamaLengkap As String = ""
        Dim NamaPanggilan As String = ""
        Dim JenisKelamin As String = ""
        Dim TempatLahir As String = ""
        Dim TanggalLahir As Date
        Dim TanggalLahirStr As String = ""
        Dim Pekerjaan As String = ""
        Dim Alamat As String = ""
        Dim FileFoto As String = ""
        Dim ProsesData As String = ""
        Dim TanggalSurat As Date
        Dim TanggalSuratStr As String = ""

        s = SaveData()
        s = qSelectDataSyaratKhusus(ProsesID)
        Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & LblNamaFoto.Text)
        If TheFile.Exists = False Then
            s = s & "Foto,"
        End If
        Dim dt As New DataTable
        dt = ViewDataProses("SELECT * FROM DataProsesKhusus WHERE ProsesID='" & ProsesID & "'")
        With dt
            If .Rows.Count > 0 Then
                NamaLengkap = .Rows(0)("NamaLengkap")
                FileFoto = .Rows(0)("FileFoto")
                BerlakuMulai = .Rows(0)("BerlakuMulai")
                BerlakuMulaiStr = BerlakuMulai.Day.ToString & " " & ConvertBulan(BerlakuMulai.Month) & " " & BerlakuMulai.Year.ToString
                BerlakuAkhir = .Rows(0)("BerlakuAkhir")
                BerlakuAkhirStr = BerlakuAkhir.Day.ToString & " " & ConvertBulan(BerlakuAkhir.Month) & " " & BerlakuAkhir.Year.ToString
                TanggalLahir = .Rows(0)("TanggalLahir")
                TanggalLahirStr = TanggalLahir.Day.ToString & " " & ConvertBulan(TanggalLahir.Month) & " " & TanggalLahir.Year.ToString
                TanggalSurat = .Rows(0)("TanggalSurat")
                TanggalSuratStr = TanggalSurat.Day.ToString & " " & ConvertBulan(TanggalSurat.Month) & " " & TanggalSurat.Year.ToString
                If File.Exists(MapPath("~\FileFotoProses\") & FileFoto) Then
                    s = s & ""
                Else
                    s = s & "File Foto Tidak Ditemukan"
                End If
            End If
        End With

        If s = "" Then
            Select Case ProsesLevel
                Case "12"
                    s = qUpdateDataKhusus(ProsesLevel + 1, ProsesID)
                    s = InsertDataProcess(s)
                    's = qUpdateDataLog("Tinjau Data", "UserTinjauData", Session("UserID"), "DateTinjauData", ProsesID)
                    's = InsertDataProcess(s)
                Case "13"
                    s = "INSERT INTO DataIARKhusus SELECT * FROM DataProsesKhusus WHERE ProsesID='" & ProsesID & "'"
                    s = InsertDataProcess(s)
                    s = String.Format("UPDATE DataIARKhusus SET BerlakuMulai='{0}', BerlakuAkhir='{1}', TanggalLahir='{2}'," & _
                        "TanggalSurat='{3}' WHERE ProsesID='{4}'", BerlakuMulaiStr, BerlakuAkhirStr, TanggalLahirStr, TanggalSuratStr, ProsesID)
                    s = InsertDataProcess(s)
                    Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(FileFoto)
                    s = qSaveImageToDB(NamaFoto, ProsesID, "DataIARKhusus")
                    s = qUpdateDataKhusus("14", ProsesID)
                    s = InsertDataProcess(s)

                Case "15"
                    s = qUpdateDataProses(ProsesLevel - 4, ProsesID)
                    s = InsertDataProcess(s)
                    's = qUpdateDataLog("UserProsesPostel2", Session("UserID"), "DateProsesPostel2", ProsesID, ProsesLevel - 4)
                    's = InsertDataProcess(s)
            End Select
            's = InsertDataProcess(s)
            Response.Redirect("~/Pages/" & ReturnUrl)
        Else
            Message = "Anda tidak dapat memproses karena persyaratan belum lengkap, yaitu: " & Left(s, Len(s) - 1) & " tidak boleh kosong."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End If

    End Sub

    Protected Sub btnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim s As String = ""
        Dim addFileName As String = ""
        Dim strURLFile As String = ""
        Dim strFileExt As String = ""
        Dim strRealFileName As String = ""
        Dim strFileUpload As String = ""
        Dim strFileSize As String = ""
        Dim strGroupID As String = ""
        Dim YearNow As String = ""
        Dim MonthNow As String = ""
        Dim DateNow As String = ""
        Dim TimeNow As String = ""
        Dim dt As New DataTable
        Dim Message As String = ""
        '-----------------------------------------
        '    Get File Name 
        '-----------------------------------------
        strRealFileName = FotoUpload.PostedFile.FileName
        strFileUpload = System.IO.Path.GetFileName(strRealFileName).Replace(" ", "-")
        '-----------------------------------------
        '    Upload File 
        '-----------------------------------------
        If strFileUpload <> "" Then
            strFileExt = Right(strFileUpload, 4)
            Select Case strFileExt.ToLower
                Case ".jpg", ".bmp", ".gif", ".png"
                    strFileSize = FotoUpload.PostedFile.ContentLength
                    If strFileSize <= 10240000 Then
                        '--- Check jika nama file yang sama sudah ada
                        Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & strFileUpload)
                        If TheFile.Exists Then
                            File.Delete(MapPath("~\FileFotoProses\") & strFileUpload)
                        End If
                        '--- Upload file ke Server
                        FotoUpload.PostedFile.SaveAs(MyFileFoto() + strFileUpload)
                        strURLFile = "FileFoto/" & strFileUpload
                        FotoUpload.PostedFile.SaveAs(MyFileFotoProses() + strFileUpload)
                        strURLFile = "FileFotoProses/" & strFileUpload
                        strGroupID = Left(strFileUpload, Len(strFileUpload) - 4)
                        Session("GroupID") = strGroupID
                    End If
                    s = qUpdateFileFoto(strFileUpload, ProsesID)
                    s = InsertDataProcess(s)
                    LblNamaFoto.Text = strFileUpload
                Case Else
                    Message = "Format File tidak dikenal. "
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End Select
        Else
            strURLFile = "-"
        End If
        GetMemberList()
    End Sub

End Class
