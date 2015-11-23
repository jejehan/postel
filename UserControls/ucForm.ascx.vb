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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable

        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            ProsesID = Request.QueryString("ProsesID")
            ReturnUrl = Request.QueryString("returnurl")

            ddlJnsPermohonan(MenuAwal)
            ddlOrdaList(MenuAwal)

            Select Case MenuAwal
                Case "SKAR"
                    ddlOrlokList(ddlOrda.SelectedValue)
                    ddlUPTList()
                    TbxAlamat2Kartu.BackColor = Color.Transparent
                    TbxAlamat3Kartu.BackColor = Color.Transparent
                Case "IAR"
                    ddlOrlokList(ddlOrda.SelectedValue)
            End Select

            '--- Check if New Data or Import Data
            If ProsesID <> "" Then
                GetMemberList()
            Else
                DataBlank()
            End If

            CheckKondisi()
        Else
            MenuAwal = Session("MenuAwal")
        End If

        '--- If DataProses then ReadOnly
        If ReturnUrl = "DataProses.aspx" Then
            CheckReadOnly()
            BtnSave.Visible = False
            BtnSaveProses.Text = "Cetak Ulang"
        End If

    End Sub

#Region "Insert ComboBox"

    Sub ddlJnsPermohonan(ByVal MenuAwal As String)
        With ddlJenisPermohonan.Items
            .Add(New ListItem("PILIH"))
            .Add(New ListItem("BARU"))
            Select Case MenuAwal
                Case "SKAR"
                    .Add(New ListItem("NAIK TINGKAT"))
                Case "IAR"
                    .Add(New ListItem("PEMBAHARUAN"))
                    .Add(New ListItem("NAIK TINGKAT"))
                    .Add(New ListItem("SEUMUR HIDUP"))
                    .Add(New ListItem("HILANG"))
                    .Add(New ListItem("RUSAK"))
                    .Add(New ListItem("MUTASI"))
                    .Add(New ListItem("GANTI CALLSIGN"))
                    .Add(New ListItem("ASING"))
                    .Add(New ListItem("KHUSUS"))
                    .Add(New ListItem("KEHORMATAN"))
                Case "IKRAP"
                    .Add(New ListItem("PEMBAHARUAN"))
                    .Add(New ListItem("PERPANJANGAN"))
            End Select

        End With
    End Sub

    Sub ddlOrdaList(ByVal MenuAwal As String)
        Dim dt As DataTable
        ddlOrda.Items.Clear()
        ddlOrda.Items.Add(New ListItem("-- Pilih --", "0"))
        Select Case MenuAwal
            Case "SKAR", "IAR"
                dt = qFindListOrariDaerah()
                With dt
                    For i = 0 To .Rows.Count - 1
                        ddlOrda.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("Kode")))
                    Next
                End With
            Case "IKRAP"
                dt = qFindListRapiDaerah()
                With dt
                    For i = 0 To .Rows.Count - 1
                        ddlOrda.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("KodeIKRAP")))
                    Next
                End With
        End Select
    End Sub

    Sub ddlOrlokList(ByVal Orda As String)
        Dim dt As DataTable
        ddlOrlok.Items.Clear()
        ddlOrlok.Items.Add(New ListItem("--- Silakan Pilih Orlok ---", "0"))
        dt = qFindListOrariLokal(Orda)
        With dt
            For i = 0 To .Rows.Count - 1
                ddlOrlok.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("Kode")))
            Next
        End With
    End Sub

    'Protected Sub ddlOrlok_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
    '    FillOrlokCombo(e.Parameter)
    'End Sub

    'Protected Sub FillOrlokCombo(ByVal Orda As String)
    '    If String.IsNullOrEmpty(Orda) Then
    '        Return
    '    End If
    '    ddlOrlokList(Orda)
    'End Sub

    Sub ddlUPTList()
        Dim dt As DataTable
        ddlUPT.Items.Clear()
        dt = qFindListUPT()
        With dt
            For i = 0 To .Rows.Count - 1
                ddlUPT.Items.Add(New ListItem(.Rows(i)("Kota")))
            Next
        End With
        ddlUPT.Items.Add(New ListItem("Lainnya"))
    End Sub

#End Region

    Sub GetMemberList()

        Dim HasilUNAR As String = ""
        Dim Where As String = ""
        Where = " WHERE ProsesID='" & Trim(ProsesID) & "' "

        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
        Dim dt As New DataTable
        da.Fill(dt)
        With dt
            If .Rows.Count > 0 Then
                '--- Data Pemohon ---
                GroupID = Trim(.Rows(0)("GroupID"))
                ProsesID = Trim(.Rows(0)("ProsesID"))
                ProsesLevel = Trim(.Rows(0)("ProsesLevel"))
                TbxNamaAnggota.Text = Trim(.Rows(0)("Nama"))
                NRI = Trim(.Rows(0)("NRI"))
                FileFoto = .Rows(0)("FileFoto")
                If FileFoto <> "" Then
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & FileFoto)
                    If TheFile.Exists Then
                        ImgFoto.ImageUrl = "~/FileFotoProses/" & FileFoto
                        LblNamaFoto.Text = FileFoto
                    Else
                        ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                        LblNamaFoto.Text = "Foto Tidak Ditemukan"
                    End If
                Else
                    ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                    LblNamaFoto.Text = "Foto Tidak Ditemukan"
                End If

                ddlJenisPermohonan.SelectedValue = Trim(.Rows(0)("JenisPermohonan"))
                If Trim(.Rows(0)("JenisPermohonan")) = "" Then
                    ddlJenisPermohonan.SelectedValue = "PILIH"
                End If
                CbxProsesData.Checked = Trim(.Rows(0)("ProsesData"))
                '--- Data Di Kartu ---
                If Trim(.Rows(0)("NamaKartu")) = "" Then
                    TbxNamaDiKartu.Text = Trim(.Rows(0)("Nama"))
                Else
                    TbxNamaDiKartu.Text = Trim(.Rows(0)("NamaKartu"))
                End If
                If Trim(.Rows(0)("Alamat1Kartu")) = "" Then
                    TbxAlamat1Kartu.Text = Trim(.Rows(0)("Alamat"))
                Else
                    TbxAlamat1Kartu.Text = Trim(.Rows(0)("Alamat1Kartu"))
                End If
                If Trim(.Rows(0)("Alamat2Kartu")) = "" Then
                    TbxAlamat2Kartu.Text = Trim(.Rows(0)("Kota"))
                Else
                    TbxAlamat2Kartu.Text = Trim(.Rows(0)("Alamat2Kartu"))
                End If
                If Trim(.Rows(0)("Alamat3Kartu")) = "" Then
                    TbxAlamat3Kartu.Text = Trim(.Rows(0)("Provinsi"))
                Else
                    TbxAlamat3Kartu.Text = Trim(.Rows(0)("Alamat3Kartu"))
                End If

                '--- Data Pribadi ---
                TbxNmrKTP.Text = Trim(.Rows(0)("NomorKTP"))
                ddlKelamin.SelectedValue = Trim(.Rows(0)("JenisKelamin"))
                TbxTempatLahir.Text = Trim(.Rows(0)("TempatLahir"))
                Dim TglLahir As Date = Trim(.Rows(0)("TanggalLahir"))
                DateTglLahir.Value = TglLahir
                TbxAlamat.Text = Trim(.Rows(0)("Alamat"))
                TbxKota.Text = Trim(.Rows(0)("Kota"))
                TbxProvinsi.Text = Trim(.Rows(0)("Provinsi"))
                TbxKodePos.Text = Trim(.Rows(0)("KodePos"))
                ddlAgama.SelectedValue = Trim(.Rows(0)("Agama"))
                ddlGolDarah.SelectedValue = Trim(.Rows(0)("Gol"))
                TbxPekerjaan.Text = Trim(.Rows(0)("Pekerjaan"))
                TbxNmrTelepon.Text = Trim(.Rows(0)("NomorTelepon"))
                TbxEmail.Text = Trim(.Rows(0)("Email"))

                '--- Call Sign ---
                Callsign = Trim(.Rows(0)("Callsign"))
                Select Case MenuAwal
                    Case "SKAR", "IAR"
                        If Trim(.Rows(0)("Callsign")) <> "" Then
                            ddlCS1.Items.Add(New ListItem(Left(Callsign, 2)))
                            ddlCS1.SelectedIndex = 0
                            TbxCS2.Text = Mid(Callsign, 3, 1)
                            TbxCS3.Text = Right(Callsign, Len(Callsign) - 3)
                        End If
                    Case "IKRAP"
                        If Trim(.Rows(0)("Callsign")) <> "" Then
                            ddlCS1.Items.Add(New ListItem(Left(Callsign, 2)))
                            ddlCS1.SelectedIndex = 0
                            TbxCS2.Text = Mid(Callsign, 3, 2)
                            TbxCS3.Text = Right(Callsign, Len(Callsign) - 3)
                        End If
                End Select

                '--- Data Organisasi ---
                Select Case MenuAwal
                    Case "SKAR"
                        ddlOrda.SelectedValue = Trim(.Rows(0)("OrdaCode"))
                        If ddlOrda.SelectedValue <> Nothing Then
                            ddlOrlokList(ddlOrda.SelectedValue.ToString)
                            ddlOrlok.SelectedValue = Trim(.Rows(0)("OrlokCode"))
                        End If
                        ddlTingkat.SelectedValue = UCase(Trim(.Rows(0)("Tingkat")))

                        '--- UNAR ---
                        TbxNmrUNAR.Text = Trim(.Rows(0)("NomorUNAR"))
                        Dim TglUNAR As Date = Trim(.Rows(0)("TanggalUNAR"))
                        DateTglUNAR.Value = TglUNAR
                        ddlHasilUNAR.Enabled = True
                        ddlHasilUNAR.SelectedValue = Trim(.Rows(0)("HasilUNAR"))
                        ddlUPT.SelectedValue = Trim(.Rows(0)("LokasiUNAR"))

                        '--- SKAR ---
                        TbxNmrSKAR.Text = Trim(.Rows(0)("NomorSKAR"))
                        Dim TglTerbitSKAR As Date = Trim(.Rows(0)("TanggalTerbitSKAR"))
                        DateTglTerbitSKAR.Value = TglTerbitSKAR
                        TbxNmrIAR.Text = Trim(.Rows(0)("NomorIAR"))
                        TbxTglBerlakuIAR.Text = Trim(.Rows(0)("MasaBerlakuIAR"))
                    Case "IAR"
                        ddlOrda.SelectedValue = Trim(.Rows(0)("OrdaCode"))
                        If ddlOrda.SelectedValue <> Nothing Then
                            ddlOrlokList(ddlOrda.SelectedValue.ToString)
                            ddlOrlok.SelectedValue = Trim(.Rows(0)("OrlokCode"))
                        End If
                        TbxNmrUNAR.Text = Trim(.Rows(0)("NomorUNAR"))
                        Dim TglUNAR As Date = Trim(.Rows(0)("TanggalUNAR"))
                        DateTglUNAR.Value = TglUNAR
                        ddlTingkat.SelectedValue = UCase(Trim(.Rows(0)("Tingkat")))
                        TbxNmrSKAR.Text = Trim(.Rows(0)("NomorSKAR"))
                        Dim TglTerbitSKAR As Date = Trim(.Rows(0)("TanggalTerbitSKAR"))
                        DateTglTerbitSKAR.Value = TglTerbitSKAR
                        TbxNmrIAR.Text = Trim(.Rows(0)("NomorIAR"))
                        TbxTglBerlakuIAR.Text = Trim(.Rows(0)("MasaBerlakuIAR"))
                        If Callsign = "" Then
                            GetCallSign("IAR")
                        End If
                    Case "IKRAP"
                        ddlOrda.SelectedValue = Trim(.Rows(0)("RapiDaerahCode"))

                        TbxNmrIAR.Text = Trim(.Rows(0)("NomorIKRAP"))
                        TbxTglBerlakuIAR.Text = Trim(.Rows(0)("MasaBerlakuIKRAP"))
                        If Callsign = "" Then
                            GetCallSign("IKRAP")
                        End If
                End Select

                '--- Biaya-Biaya ---
                TbxValidasiBank.Text = Trim(.Rows(0)("ValidasiBank"))
                Dim TglBayar As Date = Trim(.Rows(0)("TanggalBayar"))
                DateTglBayar.Value = TglBayar
                BiayaPNBP = .Rows(0)("PNBP")
                TbxBiayaPNBP.Text = BiayaPNBP.ToString
            End If
        End With
        da.Dispose()
        cn.Dispose()

        'CheckKondisi(ddlJenisPermohonan.Value.ToString)

    End Sub

    Function SaveData() As String

        Dim s As String = ""
        Try
            Dim AddField As String = ""
            Dim AddValues As String = ""
            Dim Values As String = ""
            Dim HasilUNAR As String = ddlHasilUNAR.SelectedValue
            Dim NomorUrutIAR As String = ""
            Dim NomorUrutIKRAP As String = ""
            Dim NomorIAR As String = ""
            Dim NomorIKRAP As String = ""
            Dim TglLahir As String = Replace("#" & DateTglLahir.Value & "#", "##", "")
            Dim TglTerbitSKAR As String = Replace("#" & DateTglTerbitSKAR.Value & "#", "##", "")
            Dim TglBerlakuIAR As String = TbxTglBerlakuIAR.Text
            Dim TglBayar As String = Replace("#" & DateTglBayar.Value & "#", "##", "")
            Dim TglUNAR As String = Replace("#" & DateTglUNAR.Value & "#", "##", "")
            Dim MasaBerlakuIAR As String = ""
            Dim MasaBerlakuIKRAP As String = ""

            PilihCallSign = Trim(ddlCS1.SelectedValue) & Trim(TbxCS2.Text) & Trim(TbxCS3.Text)

            's = qSelectDataSyarat(ProsesID, Session("Organisasi"), ddlJenisPermohonan.Value, MenuAwal)
            If s = "" Then '--- Jika tidak ada Error ---
                If ProsesID <> "" Then '--- Data Update
                    s = qDeleteDataProses(ProsesID)
                    s = InsertDataProcess(s)
                Else
                    '--- Proses ID (Entry Manual) ---
                    Dim ProsesLevel As String = "4"
                    Dim ProsesID As String = Format(Date.Now, "ddMMyyhhmmss").ToString
                End If

                ' Cek Apakah Call Sign Berubah untuk merubah nama file Foto
                Select Case MenuAwal
                    Case "SKAR"
                        If Trim(UCase(TbxNmrUNAR.Text)) <> Replace(UCase(LblNamaFoto.Text), ".JPG", "") Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & UCase(LblNamaFoto.Text))
                            If TheFile.Exists Then
                                FileFoto = Trim(UCase(TbxNmrUNAR.Text)) & ".JPG"
                                TheFile.CopyTo(MapPath("~/FileFotoProses/" & FileFoto))
                                TheFile.Delete()
                                ImgFoto.ImageUrl = "~/FileFotoProses/" & FileFoto
                                LblNamaFoto.Text = FileFoto
                            Else
                                ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                                LblNamaFoto.Text = "Foto Tidak Ditemukan"
                            End If
                        End If
                    Case "IAR", "IKRAP"
                        If PilihCallSign <> Replace(UCase(LblNamaFoto.Text), ".JPG", "") Then
                            Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFotoProses\") & UCase(LblNamaFoto.Text))
                            If TheFile.Exists Then
                                FileFoto = PilihCallSign & ".JPG"
                                TheFile.CopyTo(MapPath("~/FileFotoProses/" & FileFoto))
                                TheFile.Delete()
                                ImgFoto.ImageUrl = "~/FileFotoProses/" & FileFoto
                                LblNamaFoto.Text = FileFoto
                            Else
                                ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                                LblNamaFoto.Text = "Foto Tidak Ditemukan"
                            End If
                        End If
                End Select

                Values = "'" & GroupID & "','" & ProsesID & "','" & ProsesLevel & "','" & Session("Organisasi") & "','" & _
                            PilihCallSign & "','" & Callsign & "','" & TbxNamaAnggota.Text & "','" & TbxNamaDiKartu.Text & "','" & _
                            NRI & "','" & TbxNmrKTP.Text & "','" & ddlKelamin.SelectedValue & "','" & TbxTempatLahir.Text & "',#" & _
                            DateTglLahir.Value & "#,'" & TbxAlamat.Text & "','" & TbxAlamat1Kartu.Text & "','" & _
                            TbxAlamat2Kartu.Text & "','" & TbxAlamat3Kartu.Text & "','" & TbxKodePos.Text & "','" & _
                            TbxKota.Text & "','" & TbxProvinsi.Text & "','" & ddlAgama.SelectedValue & "','" & ddlGolDarah.SelectedValue & "','" & _
                            TbxPekerjaan.Text & "','" & TbxNmrTelepon.Text & "','" & TbxEmail.Text & "','','','','','','','" & _
                            ddlJenisPermohonan.SelectedValue & "',''," & _
                            "'',#1/1/1900#,'','','',#1/1/1900#,'',#1/1/1900#,'',#1/1/1900#,'" & _
                            TbxValidasiBank.Text & "',#" & DateTglBayar.Value & "#,'" & _
                            TbxBiayaPNBP.Text & "','" & LblNamaFoto.Text & "',True"
                s = qInsertDataProses(Values)
                s = InsertDataProcess(s)

                If DateTglUNAR.Value Is Nothing Then DateTglUNAR.Value = "1/1/1900"
                If DateTglTerbitSKAR.Value Is Nothing Then DateTglTerbitSKAR.Value = "1/1/1900"

                Select Case MenuAwal
                    Case "SKAR"
                        Values = "OrdaCode='" & ddlOrda.SelectedValue & "',OrdaName='" & ddlOrda.SelectedItem.Text & "',OrlokCode='" & ddlOrlok.SelectedValue & _
                                "',OrlokName='" & ddlOrlok.SelectedItem.Text & "',Tingkat='" & UCase(ddlTingkat.SelectedItem.Text) & "',NomorUNAR='" & TbxNmrUNAR.Text & _
                                "',TanggalUNAR=#" & DateTglUNAR.Value & "#,LokasiUNAR='" & ddlUPT.SelectedValue & "',HasilUNAR='" & ddlHasilUNAR.SelectedValue & _
                                "',NomorSKAR='" & TbxNmrSKAR.Text & "',TanggalTerbitSKAR=#" & DateTglTerbitSKAR.Value & _
                                "#,NomorIAR='" & TbxNmrIAR.Text & "',MasaBerlakuIAR='" & TbxTglBerlakuIAR.Text & "'"
                        s = "UPDATE DataProses SET " & Values & " WHERE ProsesID='" & ProsesID & "' "
                        s = InsertDataProcess(s)
                    Case "IAR"
                        Values = "OrdaCode='" & ddlOrda.SelectedValue & "',OrdaName='" & ddlOrda.SelectedItem.Text & "',OrlokCode='" & ddlOrlok.SelectedValue & _
                                "',OrlokName='" & ddlOrlok.SelectedItem.Text & "',Tingkat='" & UCase(ddlTingkat.SelectedItem.Text) & "',NomorUNAR='" & TbxNmrUNAR.Text & _
                                "',TanggalUNAR=#" & DateTglUNAR.Value & "#,LokasiUNAR='" & ddlUPT.SelectedValue & "',HasilUNAR='" & ddlHasilUNAR.SelectedValue & _
                                "',NomorSKAR='" & TbxNmrSKAR.Text & "',TanggalTerbitSKAR=#" & DateTglTerbitSKAR.Value & _
                                "#,NomorIAR='" & TbxNmrIAR.Text & "',MasaBerlakuIAR='" & TbxTglBerlakuIAR.Text & "'"
                        s = "UPDATE DataProses SET " & Values & " WHERE ProsesID='" & ProsesID & "' "
                        s = InsertDataProcess(s)
                    Case "IKRAP"
                        AddValues = "RapiDaerahCode='" & ddlOrda.SelectedValue & "',RapiDaerahName='" & ddlOrda.SelectedItem.Text & _
                                    "',NomorIKRAP='" & TbxNmrIAR.Text & "',MasaBerlakuIKRAP='" & TbxTglBerlakuIAR.Text & "'"
                        s = "UPDATE DataProses SET " & AddValues & " WHERE ProsesID='" & ProsesID & "' "
                        s = InsertDataProcess(s)
                End Select
            Else
                Dim Message As String = "Anda tidak dapat memproses karena persyaratan belum lengkap, yaitu: " & Left(s, Len(s) - 1) & " tidak boleh kosong."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Sub CheckKondisi()
        LoadingPanel.ShowImage = True
        '--- Disable Panel ---
        PnlAsing.Visible = False
        PnlKehormatan.Visible = False
        PnlKhusus.Visible = False

        '--- Syarat Permohonan ---
        Select Case MenuAwal
            Case "SKAR"
                BtnCheck.Visible = False
                lblDataKartu.Text = "Data di Sertifikat"
                ddlHasilUNAR.Enabled = False
                LblOrda.Text = "ORARI Daerah"
                LblNomorIAR.Text = "Nomor IAR"
                LblMasaBerlakuIAR.Text = "Masa Berlaku IAR"

                '--- Syarat Data ---
                ddlTingkat.BackColor = Color.Yellow
                TbxNmrUNAR.BackColor = Color.Yellow
                ddlUPT.BackColor = Color.Yellow
                DateTglUNAR.BackColor = Color.Yellow
            Case "IAR"
                lblDataKartu.Text = "Data di Kartu"
                ddlHasilUNAR.Enabled = False
                LblOrda.Text = "ORARI Daerah"
                LblNomorIAR.Text = "Nomor IAR"
                LblMasaBerlakuIAR.Text = "Masa Berlaku IAR"

                'If ProsesLevel = "13" Then
                '    Dim IARNumber As String = qSelectNomorIAR(ProsesID)
                '    TbxNmrIAR.Text = IARNumber
                '    If ddlJenisPermohonan.SelectedValue <> "SEUMUR HIDUP" Then
                '        If GroupID <> "CETAKULANG" Then
                '            Dim MasaBerlakuIAR As String = qGetMasaBerlakuIAR(ddlTingkat.SelectedValue)
                '            TbxTglBerlakuIAR.Text = MasaBerlakuIAR
                '        End If
                '    End If
                'End If

                '--- Syarat Data ---
                ddlTingkat.BackColor = Color.Yellow
                TbxNmrSKAR.BackColor = Color.Yellow
                DateTglTerbitSKAR.BackColor = Color.Yellow
                ddlCS1.BackColor = Color.Yellow
                TbxCS2.BackColor = Color.Yellow
                TbxCS3.BackColor = Color.Yellow
                '--- Kondisi Perpanjangan tidak perlu data UNAR ---
                If ddlJenisPermohonan.SelectedValue = "PEMBAHARUAN" Then
                    TbxNmrUNAR.Visible = False
                    ddlUPT.Visible = False
                    DateTglUNAR.Visible = False
                    ddlHasilUNAR.Visible = False
                End If
            Case "IKRAP"
                lblDataKartu.Text = "Data di Kartu"
                LblOrda.Text = "RAPI Daerah"
                LblNomorIAR.Text = "Nomor IKRAP"
                LblOrlok.Visible = False
                ddlOrlok.Visible = False
                LblNomorSKAR.Visible = False
                TbxNmrSKAR.Visible = False
                LblTglSKAR.Visible = False
                DateTglTerbitSKAR.Visible = False
                LblTingkat.Visible = False
                ddlTingkat.Visible = False
                LblMasaBerlakuIAR.Text = "Masa Berlaku IKRAP"
                LblNomorUNAR.Visible = False
                TbxNmrUNAR.Visible = False
                LblLokasiUNAR.Visible = False
                ddlUPT.Visible = False
                tbxUPTLainnya.Visible = False
                LblHasilUNAR.Visible = False
                ddlHasilUNAR.Visible = False
                LblTanggalUNAR.Visible = False
                DateTglUNAR.Visible = False

        End Select
        Select Case UCase(Trim(ddlJenisPermohonan.SelectedValue))
            Case "ASING"
                PnlAsing.Visible = True
            Case "KHUSUS"
                PnlKhusus.Visible = True
            Case "KEHORMATAN"
                PnlKehormatan.Visible = True
        End Select
    End Sub

    Sub CheckReadOnly()
        TbxAlamat.Enabled = False
        TbxAlamat1Kartu.Enabled = False
        TbxAlamat2Kartu.Enabled = False
        TbxAlamat3Kartu.Enabled = False
        TbxBiayaPNBP.Enabled = False
        TbxCS2.Enabled = False
        TbxCS3.Enabled = False
        TbxEmail.Enabled = False
        TbxJabatanPenanggungJawab.Enabled = False
        TbxKodePos.Enabled = False
        TbxKota.Enabled = False
        TbxNamaAnggota.Enabled = False
        TbxNamaDiKartu.Enabled = False
        TbxNamaPanggilan.Enabled = False
        TbxNmrIAR.Enabled = False
        TbxNmrKTP.Enabled = False
        TbxNmrSKAR.Enabled = False
        TbxNmrTelepon.Enabled = False
        TbxNmrUNAR.Enabled = False
        TbxNomorIjinKhusus.Enabled = False
        TbxPekerjaan.Enabled = False
        TbxProvinsi.Enabled = False
        TbxSKKehormatan.Enabled = False
        TbxTempatLahir.Enabled = False
        TbxValidasiBank.Enabled = False

        ddlAgama.Enabled = False
        ddlCS1.Enabled = False
        ddlGolDarah.Enabled = False
        ddlHasilUNAR.Enabled = False
        ddlJenisPermohonan.Enabled = False
        ddlKelamin.Enabled = False
        ddlKewarganegaraan.Enabled = False
        ddlOrda.Enabled = False
        ddlOrlok.Enabled = False
        ddlStasiunKegiatan.Enabled = False
        ddlTingkat.Enabled = False

        FotoUpload.Enabled = False

        CbxPaspor.Enabled = False
        CbxProsesData.Enabled = False
        CbxRekomendasi.Enabled = False
        CbxSuratIjinMenetap.Enabled = False
        DateSKKehormatan.Enabled = False
        DateTglBayar.Enabled = False
        TbxTglBerlakuIAR.Enabled = False
        DateTglLahir.Enabled = False
        DateTglMulaiKhusus.Enabled = False
        DateTglSelesaiKhusus.Enabled = False
        DateTglTerbitSKAR.Enabled = False
        DateTglUNAR.Enabled = False

    End Sub

    Protected Sub ddlJenisPermohonan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlJenisPermohonan.SelectedIndexChanged
        CheckKondisi()
    End Sub

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
        Dim dt As DataTable
        '--- Data Pemohon ---
        TbxNamaAnggota.Text = ""
        ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
        ddlJenisPermohonan.SelectedValue = ""
        NRI = ""
        '--- Data Pribadi ---
        TbxNmrKTP.Text = ""
        ddlKelamin.SelectedValue = ""
        TbxTempatLahir.Text = ""
        DateTglLahir.Value = ""
        TbxAlamat.Text = ""
        TbxKota.Text = ""
        TbxProvinsi.Text = ""
        TbxKodePos.Text = ""
        ddlAgama.SelectedValue = ""
        ddlGolDarah.SelectedValue = ""
        TbxPekerjaan.Text = ""
        TbxNmrTelepon.Text = ""
        TbxEmail.Text = ""
        '--- Data Organisasi ---
        ddlOrda.Items.Clear()
        dt = qFindListOrariDaerah()
        With dt
            For i = 0 To .Rows.Count - 1
                ddlOrda.Items.Add(New ListItem(.Rows(i)("Nama"), .Rows(i)("Kode")))
            Next
        End With
        ddlOrlok.Items.Clear()
        TbxNmrSKAR.Text = ""
        DateTglTerbitSKAR.Value = ""
        TbxNmrIAR.Text = ""
        TbxTglBerlakuIAR.Text = ""
        ddlTingkat.SelectedValue = ""
        PilihCallSign = ""
        TbxNmrUNAR.Text = ""
        DateTglUNAR.Value = ""
        ddlHasilUNAR.SelectedValue = ""
        '--- Data Persyaratan ---
        CbxRekomendasi.Checked = False
        CbxSuratIjinMenetap.Checked = False
        CbxPaspor.Checked = False
        CbxKehormatan.Checked = False

        '--- Biaya-Biaya ---
        TbxValidasiBank.Text = ""
        DateTglBayar.Value = ""
        TbxBiayaPNBP.Text = ""
    End Sub

    Protected Sub BtnSaveProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveProses.Click
        Dim NomorUrutSKAR As String = ""
        Dim NomorUrutIAR As String = ""
        Dim NomorIAR As String = ""
        Dim MasaBerlakuIAR As String = ""
        Dim NomorUrutIKRAP As String = ""
        Dim NomorIKRAP As String = ""
        Dim MasaBerlakuIKRAP As String = ""
        Dim Message As String = ""
        Dim s As String = ""
        Dim DataSKAR As String = ""
        Dim DataIAR As String = ""
        Dim DataIKRAP As String = ""
        Dim TanggalLahir As Date = DateTglLahir.Value
        Dim TanggalSKAR As Date = DateTglTerbitSKAR.Value
        Dim TanggalUNAR As Date = DateTglUNAR.Value

        If GroupID <> "CETAKULANG" Then
            '--- Update Last IAR Number
            If ProsesLevel = "13" Then
                If MenuAwal = "IAR" Then
                    NomorUrutIAR = GetNomorUrut(ProsesID, "IAR") '--- Nomor Urut (7 Digit)
                    NomorIAR = GetNomorIAR(ProsesID, ConvertDigit(NomorUrutIAR, 7))
                    TbxNmrIAR.Text = NomorIAR
                    MasaBerlakuIAR = qGetMasaBerlakuIAR(UCase(ddlTingkat.SelectedItem.Text))
                    If ddlJenisPermohonan.SelectedItem.Text = "SEUMUR HIDUP" Then MasaBerlakuIAR = "SEUMUR HIDUP"
                    TbxTglBerlakuIAR.Text = MasaBerlakuIAR
                    s = qUpdateDataIAR(NomorIAR, ProsesID)
                    s = InsertDataProcess(s)
                Else
                    NomorUrutIKRAP = GetNomorUrut(ProsesID, "IKRAP")
                    NomorIKRAP = ConvertDigit(NomorUrutIKRAP, 7)
                    TbxNmrIAR.Text = NomorIKRAP
                    MasaBerlakuIKRAP = qGetMasaBerlakuIKRAP()
                    If ddlJenisPermohonan.SelectedItem.Text = "SEUMUR HIDUP" Then MasaBerlakuIKRAP = "SEUMUR HIDUP"
                    TbxTglBerlakuIAR.Text = MasaBerlakuIKRAP
                    s = qUpdateDataIKRAP(NomorIKRAP, ProsesID)
                    s = InsertDataProcess(s)
                End If
            End If
        End If

        Select Case MenuAwal
            Case "SKAR"
                DataSKAR = "'" & GroupID & "','" & ProsesID & "','" & TbxNamaDiKartu.Text & "','" & TbxTempatLahir.Text & ", " & Day(TanggalLahir) & _
                            " " & ConvertBulan(Month(TanggalLahir)) & " " & Year(TanggalLahir) & _
                            "','" & TbxAlamat1Kartu.Text & "','" & UCase(ddlTingkat.SelectedItem.Text) & "','" & Day(TanggalUNAR) & _
                            " " & ConvertBulan(Month(TanggalUNAR)) & " " & Year(TanggalUNAR) & _
                            "','" & ddlOrda.Text & "','" & TbxNmrSKAR.Text & "','" & Day(TanggalSKAR) & _
                            " " & ConvertBulan(Month(TanggalSKAR)) & " " & Year(TanggalSKAR) & _
                            "','" & LblNamaFoto.Text & "','" & ddlCS1.SelectedValue & Trim(TbxCS2.Text) & Trim(TbxCS3.Text) & _
                            "','" & ddlOrda.SelectedItem.Text & "' "
            Case "IAR"
                DataIAR = "'" & GroupID & "','" & ProsesID & "','" & TbxNamaDiKartu.Text & "','" & UCase(ddlTingkat.SelectedItem.Text) & _
                            "','" & ConvertTingkat(UCase(ddlTingkat.SelectedItem.Text)) & "','" & ddlCS1.SelectedItem.Text & TbxCS2.Text & TbxCS3.Text & _
                            "','" & TbxAlamat1Kartu.Text & "','" & TbxAlamat2Kartu.Text & "','" & TbxAlamat3Kartu.Text & _
                            "','" & TbxTglBerlakuIAR.Text & "','" & TbxNmrIAR.Text & "','" & LblNamaFoto.Text & _
                            "','" & ddlOrda.SelectedItem.Text & "' "
            Case "IKRAP"
                'GroupID,ProsesID,Nama,CallSign,Alamat1,Alamat2,Alamat3,TanggalBerlakuIKRAP,NomorIKRAP,FileFoto,RapiDaerah
                DataIKRAP = "'" & GroupID & "','" & ProsesID & "','" & TbxNamaDiKartu.Text & _
                            "','" & ddlCS1.SelectedItem.Text & TbxCS2.Text & TbxCS3.Text & _
                            "','" & TbxAlamat1Kartu.Text & "','" & TbxAlamat2Kartu.Text & "','" & TbxAlamat3Kartu.Text & _
                            "','" & TbxTglBerlakuIAR.Text & "','" & TbxNmrIAR.Text & "','" & LblNamaFoto.Text & _
                            "','" & ddlOrda.SelectedItem.Text & "' "
        End Select
        s = SaveData()
        's = CekPersyaratan(Trim(ProsesID), Session("Company"))
        s = qSelectDataSyarat(ProsesID, Session("Organisasi"), ddlJenisPermohonan.SelectedValue, MenuAwal)
        If s = "" Then
            Select Case ProsesLevel
                Case "4"
                    s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                    s = InsertDataProcess(s)
                    's = qUpdateDataLog("Tinjau Data", "UserTinjauData", Session("UserID"), "DateTinjauData", ProsesID)
                    's = InsertDataProcess(s)
                    If GroupID <> "CETAKULANG" Then
                        s = qInsertHasilUNAR(ProsesID)
                        s = InsertDataProcess(s)
                    End If
                Case "5"
                    s = qInsertDataSKAR(DataSKAR)
                    s = InsertDataProcess(s)
                    Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(LblNamaFoto.Text)
                    s = qSaveImageToDB(NamaFoto, ProsesID, "DataSKAR")
                    s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                    s = InsertDataProcess(s)
                    's = qUpdateDataLog("Persetujuan", "UserPersetujuan", Session("UserID"), "DatePersetujuan", ProsesID)
                    's = InsertDataProcess(s)
                Case "12"
                    s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Tinjau Data", "UserTinjauData", Session("UserID"), "DateTinjauData", ProsesID)
                    s = InsertDataProcess(s)
                Case "13"
                    Select Case MenuAwal
                        Case "IAR"
                            s = qInsertDataIAR(DataIAR)
                            s = InsertDataProcess(s)
                            Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(LblNamaFoto.Text)
                            Dim FileHeader As String = MapPath("~/Images/Background/") & Trim(UCase(ddlTingkat.SelectedItem.Text)) & ".jpg"
                            s = qSaveImageToDB(NamaFoto, ProsesID, "DataIAR")
                        Case "IKRAP"
                            s = qInsertDataIKRAP(DataIKRAP)
                            s = InsertDataProcess(s)
                            Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(LblNamaFoto.Text)
                            Dim FileHeader As String = MapPath("~/Images/Background/") & Trim(UCase(ddlTingkat.SelectedItem.Text)) & ".jpg"
                            s = qSaveImageToDB(NamaFoto, ProsesID, "DataIKRAP")
                    End Select
                    s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Persetujuan", "UserPersetujuan", Session("UserID"), "DatePersetujuan", ProsesID)
                    s = InsertDataProcess(s)
                Case "8"
                    s = qUpdateDataProses(ProsesID, ProsesLevel - 4)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("UserProsesPostel1", Session("UserID"), "DateProsesPostel1", ProsesID, ProsesLevel - 4)
                    s = InsertDataProcess(s)
                Case "15"
                    s = qUpdateDataProses(ProsesID, ProsesLevel - 4)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("UserProsesPostel2", Session("UserID"), "DateProsesPostel2", ProsesID, ProsesLevel - 4)
                    s = InsertDataProcess(s)
            End Select
            's = InsertDataProcess(s)
            Response.Redirect("~/Pages/" & ReturnUrl)
        Else
            Message = "Anda tidak dapat memproses karena persyaratan belum lengkap, yaitu: " & Left(s, Len(s) - 1) & " tidak boleh kosong."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End If

    End Sub

    Protected Sub BtnCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        Dim s As String = ""
        s = CekCallSign(Trim(ddlCS1.SelectedValue) & Trim(TbxCS2.Text) & Trim(TbxCS3.Text), MenuAwal)
        If s <> "" Then
            ImgWarning.Visible = True
            ddlCS1.Enabled = True
            TbxCS2.ReadOnly = False
            TbxCS3.ReadOnly = False
            GetCallSign(MenuAwal)
        Else
            ImgSuccess.Visible = True
            ddlCS1.Enabled = False
            TbxCS2.ReadOnly = True
            TbxCS3.ReadOnly = True
        End If

    End Sub

    Protected Sub ddlHasilUNAR_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlHasilUNAR.SelectedIndexChanged
        Dim s As String = ""
        If ddlHasilUNAR.SelectedValue = "Lulus" Then
            s = qUpdateSKARNumber("Lulus", ProsesID, Session("Organisasi"), Session("UserID"), ProsesLevel)
        ElseIf ddlHasilUNAR.SelectedValue = "Tidak Lulus" Then
            s = "-"
        End If
        TbxNmrSKAR.Text = s
        DateTglTerbitSKAR.Value = Date.Now()
    End Sub

    Protected Sub BtnSaveFoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSaveFoto.Click
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

    Protected Sub ddlTingkat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlTingkat.SelectedIndexChanged
        If MenuAwal = "IAR" Then
            'If ddlCS1.SelectedValue & TbxCS2.Text & TbxCS3.Text = "" Then
            GetCallSign("IAR")
            'End If
        End If
    End Sub

    Function GetCallSign(ByVal Type As String) As String

        Dim s As String = ""
        Dim CS As String = ""
        Dim TingkatLevel As String = ""
        Try
            Dim CS1 As String = ""
            Dim CS2 As String = ""
            Dim CS3 As String = ""
            Dim i As Integer
            TingkatLevel = UCase(ddlTingkat.SelectedValue)
            '--- Get CS1 Value ---
            ddlCS1.Enabled = True
            TbxCS2.ReadOnly = False
            TbxCS3.ReadOnly = False
            Select Case Type
                Case "IAR"
                    ddlCS1.Items.Clear()
                    CS1 = CallSignPrefixHuruf(ProsesID, Session("Company"), TingkatLevel, ddlOrda.SelectedValue)
                    Dim SplitCS1 = Split(CS1, ",")
                    For i = 0 To UBound(SplitCS1)
                        ddlCS1.Items.Add(New ListItem(SplitCS1(i)))
                    Next
                    CS2 = CallArea(ddlOrda.SelectedValue)
                    CS3 = CallSignSuffix(ProsesID, Session("Company"), TingkatLevel, ddlOrda.SelectedValue, CS1)
                    ddlCS1.SelectedIndex = 0
                    TbxCS2.Text = CS2
                    TbxCS3.Text = CS3
                    CS = CS1 & CS2 & CS3
                    s = CekCallSign(CS, "IAR")
                Case "IKRAP"
                    CS1 = "JZ"
                    CS2 = ddlOrda.SelectedValue
                    For a = 11 To 36
                        For b = 11 To 36
                            For c = 11 To 36
                                CS3 = a & b & c
                                CS = CS1 & CS2 & CS3
                                s = CekCallSign(CS, "IKRAP")
                            Next
                        Next
                    Next
                    CS3 = TbxCS3.Text
                    ddlCS1.SelectedIndex = 0
                    TbxCS2.Text = CS2
                    TbxCS3.Text = CS3
            End Select
            If s <> "" Then
                GetCallSign(Type)
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return CS

    End Function

    Function ConvertSuffixRapi(ByVal Number As String) As String
        Dim s As String = ""
        Try
            Select Case Number
                Case "11"
                    s = "A"
                Case "12"
                    s = "B"
                Case "13"
                    s = "C"
                Case "14"
                    s = "D"
                Case "15"
                    s = "E"
                Case "16"
                    s = "F"
                Case "17"
                    s = "G"
                Case "18"
                    s = "H"
                Case "19"
                    s = "I"
                Case "20"
                    s = "J"
                Case "21"
                    s = "K"
                Case "22"
                    s = "L"
                Case "23"
                    s = "M"
                Case "24"
                    s = "N"
                Case "25"
                    s = "O"
                Case "26"
                    s = "P"
                Case "27"
                    s = "Q"
                Case "28"
                    s = "R"
                Case "29"
                    s = "S"
                Case "30"
                    s = "T"
                Case "31"
                    s = "U"
                Case "32"
                    s = "V"
                Case "33"
                    s = "W"
                Case "34"
                    s = "X"
                Case "35"
                    s = "Y"
                Case "36"
                    s = "Z"


            End Select
        Catch ex As Exception

        End Try
        Return s
    End Function

    Protected Sub ddlOrda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlOrda.SelectedIndexChanged
        ddlOrlokList(ddlOrda.SelectedValue)
    End Sub
End Class
