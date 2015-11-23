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

Partial Class UserControls_ucForm
    Inherits System.Web.UI.UserControl
    Public Shared NRI, NomorKTP, CallSign, ReturnUrl As String
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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable

        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            CallSign = Request.QueryString("CallSign")
            ReturnUrl = Request.QueryString("returnurl")

            GetMemberList()
        End If

    End Sub

    Sub GetMemberList()

        Dim HasilUNAR As String = ""
        Dim Query As String = ""
        Dim dt As DataTable
        Query = "SELECT * FROM DataIAR WHERE CallSign=" & Trim(CallSign)
        dt = ViewDatabase(Query)
        With dt
            If .Rows.Count > 0 Then
                '--- Data Pemohon ---
                'GroupID = Trim(.Rows(0)("GroupID"))
                ProsesID = Trim(.Rows(0)("ID"))
                ProsesLevel = "14"
                TbxNamaAnggota.Text = Trim(.Rows(0)("Nama"))
                NRI = Trim(.Rows(0)("NRI"))
                FileFoto = .Rows(0)("FileFoto")
                If FileFoto <> "" Then
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFoto\") & FileFoto)
                    If TheFile.Exists Then
                        ImgFoto.ImageUrl = "~/FileFoto/" & FileFoto
                    Else
                        ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                    End If
                Else
                    ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                End If

                TbxJenisPermohonan.Text = Trim(.Rows(0)("JenisPermohonan"))
                '--- Data Di Kartu ---
                TbxNamaDiKartu.Text = Trim(.Rows(0)("NamaKartu"))
                TbxAlamat1Kartu.Text = Trim(.Rows(0)("Alamat1Kartu"))
                TbxAlamat2Kartu.Text = Trim(.Rows(0)("Alamat2Kartu"))
                TbxAlamat3Kartu.Text = Trim(.Rows(0)("Alamat3Kartu"))

                '--- Data Pribadi ---
                TbxNmrKTP.Text = Trim(.Rows(0)("NomorKTP"))
                Dim JenisKelamin As String = Trim(.Rows(0)("JenisKelamin"))
                If JenisKelamin = "L" Then
                    TbxJenisKelamin.Text = "Laki-Laki"
                Else
                    TbxJenisKelamin.Text = "Perempuan"
                End If
                TbxTempatLahir.Text = Trim(.Rows(0)("TempatLahir"))
                TbxTanggalLahir.Text = Trim(.Rows(0)("TanggalLahir"))
                TbxAlamat.Text = Trim(.Rows(0)("Alamat"))
                TbxKota.Text = Trim(.Rows(0)("Kota"))
                TbxProvinsi.Text = Trim(.Rows(0)("Provinsi"))
                TbxKodePos.Text = Trim(.Rows(0)("KodePos"))
                TbxAgama.Text = Trim(.Rows(0)("Agama"))
                TbxGol.Text = Trim(.Rows(0)("Gol"))
                TbxPekerjaan.Text = Trim(.Rows(0)("Pekerjaan"))
                TbxNmrTelepon.Text = Trim(.Rows(0)("NomorTelepon"))
                TbxEmail.Text = Trim(.Rows(0)("Email"))
                TbxCallSign.Text = Trim(.Rows(0)("Callsign"))
                TbxOrda.Text = Trim(.Rows(0)("OrdaName"))
                TbxOrlok.Text = Trim(.Rows(0)("OrlokName"))
                TbxNmrSKAR.Text = Trim(.Rows(0)("NomorSKAR"))
                TbxTanggalTerbitSKAR.Text = Trim(.Rows(0)("TanggalTerbitSKAR"))
                TbxNmrIAR.Text = Trim(.Rows(0)("NomorIAR"))
                TbxTglBerlakuIAR.Text = Trim(.Rows(0)("MasaBerlakuIAR"))

                'TbxNmrUNAR.Text = Trim(.Rows(0)("NomorUNAR"))
                'TbxTanggalUNAR.Text = Trim(.Rows(0)("TanggalUNAR"))
                'TbxHasilUNAR.Text = Trim(.Rows(0)("HasilUNAR"))
                'TbxLokasiUNAR.Text = Trim(.Rows(0)("LokasiUNAR"))

                'Case "IKRAP"
                '    CmbOrda.Value = Trim(.Rows(0)("RapiDaerahCode"))

                '    TbxNmrIAR.Text = Trim(.Rows(0)("NomorIKRAP"))
                '    TbxTglBerlakuIAR.Text = Trim(.Rows(0)("MasaBerlakuIKRAP"))
                '    If CallSign = "" Then
                '        GetCallSign("IKRAP")
                '    End If

            End If
        End With

        'CheckKondisi(CmbJenisPermohonan.Value.ToString)

    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Response.Redirect("~/Pages/" & ReturnUrl)
    End Sub

    Protected Sub BtnCetak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCetak.Click

        Dim Message As String = ""
        Dim s As String = ""
        Dim ErrorStr As String = ""
        Dim DataIAR As String = ""

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
        Dim CallSign As String = TbxCallSign.Text
        Dim dt As New DataTable
        Dim cn As New OleDbConnection(MyDatabase)
        Dim da As New OleDbDataAdapter("SELECT * FROM [DataIAR] WHERE CallSign='" & CallSign & "' ", cn)
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
    End Sub
End Class
