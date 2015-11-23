'--- System Module ---
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Data.OleDb
Imports System.Security.Cryptography

'--- Custom Module ---
Imports clsGeneral
Imports clsDataBase

Partial Class Pages_ImportProses
    Inherits System.Web.UI.Page

    Dim Message As String = ""
    Public Shared strGroupID As String = ""
    Public Shared MenuAwal As String = ""
    Public Shared Organisasi As String = ""
    Public Shared FileName As String = ""
    Public Shared TypeFile As String = ""
    Public Shared RowNumber As Integer = 0
    Public Shared RowTotal As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            FileName = Request.QueryString("FileName")
            TypeFile = Request.QueryString("TypeFile")
            RowNumber = Request.QueryString("RowNumber")
            RowTotal = Request.QueryString("RowTotal")
            If FileName <> "" Then
                imgProses.Visible = True
                LblFileName.Text = FileName
                ProsesData(FileName, TypeFile, RowNumber + 1, RowTotal)
            End If
            Organisasi = Session("Organisasi")
            MenuAwal = Session("MenuAwal")
            If MenuAwal = "SKAR" Then
                cbxHasilUNAR.Visible = True
                lblHasilUNAR.Visible = True
            End If
            If CbxNewGroupID.Checked = True Then
                TbxGroupID.Enabled = False
            End If
        End If
    End Sub

    Protected Sub BtnUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpload.Click

        Dim s As String = ""
        Dim addFileName As String = ""
        Dim strURLFile As String = ""
        Dim strFileExt As String = ""
        Dim strRealFileName As String = ""
        Dim strFileUpload As String = ""
        Dim strFileSize As String = ""
        Dim YearNow As String = ""
        Dim MonthNow As String = ""
        Dim DateNow As String = ""
        Dim TimeNow As String = ""
        Dim dt As New DataTable
        Dim TypeFile As String = ""

        Try
            imgProses.Visible = True
            '-------------------------------------------
            '   Get Date Parameter To Add In File Name
            '-------------------------------------------
            YearNow = Date.Now.Year.ToString
            MonthNow = Date.Now.Month.ToString("D2")
            DateNow = Date.Now.Day.ToString("D2")
            TimeNow = Left(Replace(Date.Now.TimeOfDay.ToString, ":", ""), 6)
            addFileName = String.Format("{0}{1}{2}-{3}", YearNow, MonthNow, DateNow, TimeNow)
            '-----------------------------------------
            '    Get File Name 
            '-----------------------------------------
            strRealFileName = DocFileUpload.PostedFile.FileName
            strFileUpload = Path.GetFileName(strRealFileName).Replace(" ", "-")
            '-----------------------------------------
            '    Upload File 
            '-----------------------------------------
            If strFileUpload <> "" Then
                strFileExt = Right(strFileUpload, 4)
                Select Case strFileExt.ToLower
                    Case ".xls", ".zip", ".jpg", ".bmp", ".gif", ".csv", ".dat", ".jpeg"
                        strFileSize = DocFileUpload.PostedFile.ContentLength
                        If strFileSize <= 20480000 Then
                            DocFileUpload.PostedFile.SaveAs(MyFileUpload() + strFileUpload)
                            strURLFile = "FileUpload/" & strFileUpload
                            LblFileName.Text = strFileUpload
                            LblFileSize.Text = CStr(CInt(strFileSize / 1024)) & "KB"
                            If CbxNewGroupID.Checked = False Then
                                If Trim(TbxGroupID.Text) <> "" Then
                                    strGroupID = Trim(TbxGroupID.Text)
                                    Session("GroupID") = strGroupID
                                Else
                                    Message = "Anda tidak memilih Buat Group Baru tapi tidak menulis Nama Group Lama!"
                                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                                End If
                            Else
                                If Session("GroupID") = "" Then
                                    strGroupID = Left(strFileUpload, Len(strFileUpload) - 4)
                                    Session("GroupID") = strGroupID
                                ElseIf Session("GroupID") Is Nothing Then
                                    strGroupID = Left(strFileUpload, Len(strFileUpload) - 4)
                                    Session("GroupID") = strGroupID
                                End If
                            End If
                            s = qFindFileProses(strFileUpload)
                            If s = "True" Then
                                Message = "[Import 002]: Nama File sudah ada yang sama persis. Mohon dicek kembali..."
                                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                            Else
                                If cbxHasilUNAR.Checked = True Then
                                    TypeFile = "UNAR"
                                Else
                                    TypeFile = MenuAwal
                                End If
                                s = InsertFileToDB(Session("GroupID"), strFileUpload, strFileSize, TypeFile, Session("UserID"), Session("Organisasi"), "0")
                                's = RefreshListFile()
                                ProsesData(LblFileName.Text, TypeFile, 0, 0)
                            End If
                        Else
                            Message = "[Import 003]: Ukuran File lebih dari 10,240KB atau 10MB"
                            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                        End If
                    Case Else
                        Message = "[Import 004]: Format File tidak dikenal."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End Select
            Else
                Message = "[Import 005]: Nama File tidak dikenal..."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As Exception
            Message = "[Import 006]: " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
    End Sub

    Sub ProsesData(ByVal NamaFile As String, ByVal TypeFile As String, ByVal RowNumber As Integer, ByVal RowTotal As Integer)

        Dim s As String = ""
        Dim Proses As String = ""

        Try
            If NamaFile <> "" Then
                'Proses = qFindFileProses(NamaFile)
                'If Proses = "False" Then
                Select Case Right(NamaFile, 4)
                    Case ".jpg", ".jpeg", ".png"
                        File.Move(MapPath("~\FileUpload\") & NamaFile, MapPath("~\FileFoto\") & NamaFile)
                        File.Move(MapPath("~\FileUpload\") & NamaFile, MapPath("~\FileFotoProses\") & NamaFile)
                        s = qUpdateFile(NamaFile, Session("UserID"))
                        s = InsertDataProcess(s)
                    Case ".zip"
                        Dim x As New ICSharpCode.SharpZipLib.Zip.FastZip
                        x.CreateEmptyDirectories = True
                        x.ExtractZip(MyFileUpload() & NamaFile, MyFileFoto, "")
                        x.ExtractZip(MyFileUpload() & NamaFile, MyFileFotoProses, "")
                        s = qUpdateFile(NamaFile, Session("UserID"))
                        s = InsertDataProcess(s)
                    Case ".xls"
                        s = InsertExcelToDB(NamaFile, Session("GroupID"), TypeFile, RowNumber, RowTotal)
                    Case ".csv"
                        s = InsertCSVToDB(NamaFile, Session("GroupID"))
                    Case ".dat"
                        s = InsertCSVToDB(NamaFile, Session("GroupID"))
                    Case Else
                        Message = "[Import 007]: Jenis File tidak Dikenal..."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End Select
                If s = "" Then
                    imgProses.Visible = False
                    Message = "Data berhasil diproses..."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    s = qUpdateFile(NamaFile, Session("UserID"))
                    s = InsertDataProcess(s)
                    'Response.Redirect("~/Pages/Import.aspx")
                    ClientScript.RegisterStartupScript(Me.GetType(), "ClientScript", "window.parent.location.href = window.parent.location.href;", True)
                Else
                    Dim k As String
                    '--- Hapus File dan Data yang sudah diupload ---
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileUpload\") & NamaFile)
                    If TheFile.Exists Then
                        File.Delete(MapPath("~\FileUpload\") & NamaFile)
                        k = qDelete("Files", String.Format(" FileName='{0}'", NamaFile))
                        k = InsertDataProcess(k)
                        If Right(FileName, 4) = ".xls" Then
                            k = qDelete("DataProses", " GroupID='" & Session("GroupID") & "'")
                            k = InsertDataProcess(k)
                            k = qDelete("DataLog", " GroupID='" & Session("GroupID") & "'")
                            k = InsertDataProcess(k)
                        End If
                    Else
                        k = qDelete("Files", String.Format(" FileName='{0}'", NamaFile))
                        k = InsertDataProcess(s)
                        Throw New FileNotFoundException()
                    End If
                    Message = "[Import 008]: " & s
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
                'Else
                '    Message = "[Import 009]: File sudah pernah diproses..."
                '    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                'End If
            Else
                Message = "[Import 010]: Nama File tidak dikenal..."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
            Session.Remove("GroupID")
        Catch ex As Exception
            Message = "[Import 011]: " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    Function InsertExcelToDB(ByVal NamaFile As String, ByVal GroupID As String, ByVal TypeFile As String, ByVal RowNumber As Integer, ByVal RowTotal As Integer) As String

        Dim s As String = ""
        Dim i As Integer = 0
        Dim RowGroup As Integer = 0
        Dim RowLeft As Integer = 0
        Dim dt As New DataTable
        Dim QueryType As String = ""

        Try
            '--- Check if File from Orda ---
            If RowTotal = 0 Then
                Dim strConn As String = MyExcelNewHeader(MyFileUpload() & NamaFile)
                Dim myData As New OleDbDataAdapter("SELECT * FROM [Sheet1$] ", strConn)
                myData.TableMappings.Add("Table", "ExcelTest")
                myData.Fill(dt)
                RowTotal = dt.Rows.Count - 1
                RowNumber = 1
                dt.Dispose()
            End If
            If TypeFile = "UNAR" Then
                s = InsertFileUNARToDB(NamaFile, GroupID)
            Else
                s = InsertExcelFileToDB(NamaFile, GroupID, TypeFile, RowNumber, RowTotal)
            End If
        Catch ex As Exception
            Message = "[Import 019]: " & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        Return s

    End Function

    Function InsertExcelFileToDB(ByVal NamaFile As String, ByVal GroupID As String, ByVal TypeFile As String, ByVal RowNumber As Integer, ByVal RowTotal As Integer) As String

        Dim s As String = ""
        Dim i As Integer = 0
        Dim dt As New DataTable
        Dim QueryType As String = ""
        Dim LatestProsesID As Integer = 0
        Dim RowLeft As Integer = 0
        Dim RowUntil As Integer = 0
        Try
            '--- Get Latest ProsesID ---
            'If Left(s, 6) = Right(Date.Now.Year.ToString, 2) & ConvertDigit(Date.Now.Month.ToString, 2) & ConvertDigit(Date.Now.Day.ToString, 2) Then
            'LatestProsesID = Right(s, 6)
            'Else
            'LatestProsesID = "000000"
            'End If

            Dim strConn As String = MyExcelNewHeader(MyFileUpload() & NamaFile)
            Dim myData As New OleDbDataAdapter("SELECT * FROM [Sheet1$] ", strConn)
            myData.TableMappings.Add("Table", "ExcelTest")
            myData.Fill(dt)

            RowLeft = RowTotal - RowNumber
            If RowLeft >= 50 Then
                RowUntil = RowNumber + 50
            Else
                RowUntil = RowNumber + RowLeft
            End If
            myData.Dispose()

            With dt
                If RowLeft >= 0 Then
                    For i = RowNumber To RowUntil
                        LatestProsesID = qGetLatestProsesID() + 1
                        '--- Definisi Parameter Umum ---
                        Dim JenisPermohonan As String = ""
                        'GroupID = Left(NamaFile, Len(NamaFile) - 4)
                        Dim Callsign As String = ""
                        Dim Nama As String = ""
                        Dim NamaKartu As String = ""
                        Dim NomorKTP As String = ""
                        Dim NRI As String = ""
                        Dim JenisKelamin As String = ""
                        Dim TempatLahir As String = ""
                        Dim TanggalLahir As Date = "1/1/1900"
                        Dim Alamat As String = ""
                        Dim Kota As String = ""
                        Dim Provinsi As String = ""
                        Dim Alamat1Kartu As String = ""
                        Dim Alamat2Kartu As String = ""
                        Dim Alamat3Kartu As String = ""
                        Dim KodePos As String = ""
                        Dim Agama As String = ""
                        Dim KodeAgama As String = ""
                        Dim Gol As String = ""
                        Dim Pekerjaan As String = ""
                        Dim NomorTelepon As String = ""
                        Dim Email As String = ""
                        Dim ValidasiBank As String = ""
                        Dim TanggalBayar As Date = "1/1/1900"
                        Dim PNBP As Integer = 0
                        Dim FileFoto As String = ""

                        '--- Parameter SKAR ---
                        Dim Tingkat As String = ""
                        Dim NomorUNAR As String = ""
                        Dim TanggalUNAR As Date = "1/1/1900"
                        Dim LokasiUNAR As String = ""
                        Dim HasilUNAR As String = ""
                        Dim NomorSKAR As String = ""
                        Dim TanggalTerbitSKAR As Date = "1/1/1900"

                        '--- Parameter IAR ---
                        Dim NomorIAR As String = ""
                        Dim MasaBerlakuIAR As String = "1/1/1900"
                        Dim OrdaName As String = ""
                        Dim OrdaCode As String = ""
                        Dim OrlokName As String = ""
                        Dim OrlokCode As String = ""

                        '--- Parameter IKRAP ---
                        Dim RapiDaerahName As String = ""
                        Dim RapiDaerahCode As String = ""
                        Dim NomorIKRAP As String = ""
                        Dim MasaBerlakuIKRAP As String = "1/1/1900"

                        '--- Berbeda untuk IAR Khusus ---
                        If .Rows(i)("JenisPermohonan") IsNot DBNull.Value Then
                            JenisPermohonan = UCase(Trim(.Rows(i)("JenisPermohonan")))
                        Else
                            If .Rows(i)("Nama") Is DBNull.Value Then
                                Return s
                                Exit Function
                            End If
                        End If
                        If JenisPermohonan = "KHUSUS" Then
                            s = InsertFileIARKhusus(dt, GroupID, LatestProsesID, NamaFile)
                            Return s
                            Exit Function
                        End If

                        '--- Baca Data dari File Excel ---
                        If .Rows(i)("Callsign") IsNot DBNull.Value Then Callsign = Replace(Replace(Trim(.Rows(i)("Callsign")), "0", "Ø"), " ", "")
                        If .Rows(i)("Nama") IsNot DBNull.Value Then Nama = Replace(Trim(.Rows(i)("Nama")), "'", "~")
                        If .Rows(i)("NamaKartu") IsNot DBNull.Value Then NamaKartu = Replace(Trim(.Rows(i)("NamaKartu")), "'", "~")
                        If .Rows(i)("NomorKTP") IsNot DBNull.Value Then NomorKTP = Replace(Trim(.Rows(i)("NomorKTP")), " ", "")
                        If .Rows(i)("JenisKelamin") IsNot DBNull.Value Then JenisKelamin = Left(UCase(Trim(.Rows(i)("JenisKelamin"))), 1)
                        If .Rows(i)("TempatLahir") IsNot DBNull.Value Then TempatLahir = Trim(.Rows(i)("TempatLahir"))
                        If .Rows(i)("TanggalLahir") IsNot DBNull.Value Then
                            If Trim(.Rows(i)("TanggalLahir")) <> "" Then
                                TanggalLahir = Trim(.Rows(i)("TanggalLahir"))
                            End If
                        End If
                        If .Rows(i)("Alamat") IsNot DBNull.Value Then Alamat = Trim(.Rows(i)("Alamat"))
                        If .Rows(i)("Kota") IsNot DBNull.Value Then Kota = UCase(Trim(.Rows(i)("Kota")))
                        If .Rows(i)("Provinsi") IsNot DBNull.Value Then Provinsi = UCase(Trim(.Rows(i)("Provinsi")))
                        If .Rows(i)("Alamat1Kartu") IsNot DBNull.Value Then Alamat1Kartu = Trim(.Rows(i)("Alamat1Kartu"))
                        If MenuAwal <> "SKAR" Then
                            If .Rows(i)("Alamat2Kartu") IsNot DBNull.Value Then Alamat2Kartu = Trim(.Rows(i)("Alamat2Kartu"))
                            If .Rows(i)("Alamat3Kartu") IsNot DBNull.Value Then Alamat3Kartu = Trim(.Rows(i)("Alamat3Kartu"))
                        End If
                        If .Rows(i)("KodePos") IsNot DBNull.Value Then KodePos = Trim(.Rows(i)("KodePos"))
                        If .Rows(i)("Agama") IsNot DBNull.Value Then Agama = UCase(Trim(.Rows(i)("Agama")))
                        If Agama <> "" Then
                            KodeAgama = qFindKodeAgama(Agama)
                        End If
                        If .Rows(i)("Gol") IsNot DBNull.Value Then Gol = UCase(Trim(.Rows(i)("Gol")))
                        If .Rows(i)("Pekerjaan") IsNot DBNull.Value Then Pekerjaan = .Rows(i)("Pekerjaan")
                        If .Rows(i)("NomorTelepon") IsNot DBNull.Value Then NomorTelepon = .Rows(i)("NomorTelepon")
                        If .Rows(i)("Email") IsNot DBNull.Value Then Email = Trim(.Rows(i)("Email"))
                        If .Rows(i)("ValidasiBank") IsNot DBNull.Value Then ValidasiBank = Trim(.Rows(i)("ValidasiBank"))
                        If .Rows(i)("TanggalBayar") IsNot DBNull.Value Then
                            If Trim(.Rows(i)("TanggalBayar")) <> "" Then
                                TanggalBayar = Trim(.Rows(i)("TanggalBayar"))
                            End If
                        End If
                        If .Rows(i)("PNBP") IsNot DBNull.Value Then
                            If Trim(.Rows(i)("PNBP")) <> "" Then
                                PNBP = Trim(.Rows(i)("PNBP"))
                            End If
                        End If
                        If MenuAwal <> "SKAR" Then
                            If .Rows(i)("Callsign") IsNot DBNull.Value Then
                                FileFoto = Trim(.Rows(i)("Callsign")) & ".jpg"
                            End If
                        Else
                            If .Rows(i)("NamaFileFoto") IsNot DBNull.Value Then
                                FileFoto = Trim(.Rows(i)("NamaFileFoto"))
                            End If
                        End If

                        Select Case MenuAwal
                            Case "SKAR", "IAR"
                                Organisasi = "Orari"
                                If Left(Callsign, 2) = "JZ" Then
                                    If i < RowUntil Then
                                        Message = String.Format("Baris ke-{0}. Pesan Error: {1}", i, "Anda memasukkan data IKRAP ke menu SKAR/IAR!")
                                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                                        Return s
                                        Exit Function
                                    End If
                                End If
                                If MenuAwal = "SKAR" Then
                                    If .Rows(i)("NomorUNAR") IsNot DBNull.Value Then NomorUNAR = Trim(.Rows(i)("NomorUNAR"))
                                    If .Rows(i)("TanggalUNAR") IsNot DBNull.Value Then
                                        If Trim(.Rows(i)("TanggalUNAR")) <> "" Then
                                            TanggalUNAR = Trim(.Rows(i)("TanggalUNAR"))
                                        End If
                                    End If
                                    If .Rows(i)("LokasiUNAR") IsNot DBNull.Value Then LokasiUNAR = UCase(Trim(.Rows(i)("LokasiUNAR")))
                                    If FileFoto = "" Then
                                        If NomorUNAR <> "" Then FileFoto = Replace(Trim(.Rows(i)("NomorUNAR")), "/", "-") & ".jpg"
                                    End If
                                End If
                                If .Rows(i)("NRI") IsNot DBNull.Value Then NRI = Trim(.Rows(i)("NRI"))
                                If .Rows(i)("Tingkat") IsNot DBNull.Value Then Tingkat = UCase(Trim(.Rows(i)("Tingkat")))
                                If .Rows(i)("NomorSKAR") IsNot DBNull.Value Then NomorSKAR = Trim(.Rows(i)("NomorSKAR"))
                                If .Rows(i)("TanggalTerbitSKAR") IsNot DBNull.Value Then
                                    If Trim(.Rows(i)("TanggalTerbitSKAR")) <> "" Then
                                        TanggalTerbitSKAR = Trim(.Rows(i)("TanggalTerbitSKAR"))
                                    End If
                                End If
                                If .Rows(i)("NomorIAR") IsNot DBNull.Value Then NomorIAR = Trim(.Rows(i)("NomorIAR"))
                                If JenisPermohonan = "SEUMUR HIDUP" Then
                                    MasaBerlakuIAR = "SEUMUR HIDUP"
                                Else
                                    If .Rows(i)("MasaBerlakuIAR") IsNot DBNull.Value Then
                                        If Trim(.Rows(i)("MasaBerlakuIAR")) <> "" Then
                                            If Trim(.Rows(i)("MasaBerlakuIAR")) = "SEUMUR HIDUP" Then
                                                MasaBerlakuIAR = "SEUMUR HIDUP"
                                            Else
                                                Dim MasaBerlakuIARDate As Date = Trim(.Rows(i)("MasaBerlakuIAR"))
                                                MasaBerlakuIAR = MasaBerlakuIARDate
                                            End If
                                        End If
                                    End If
                                End If
                                If .Rows(i)("OrariDaerah") IsNot DBNull.Value Then OrdaName = UCase(Trim(.Rows(i)("OrariDaerah")))
                                If OrdaName <> "" Then
                                    OrdaCode = qFindKodeOrariDaerah(OrdaName)
                                    If Len(OrdaCode) > 2 Then
                                        Return "Error Baris :" & i & ", Kode Orda tidak ditemukan."
                                        Exit Function
                                    End If
                                End If
                                If .Rows(i)("OrariLokal") IsNot DBNull.Value Then OrlokName = UCase(Trim(.Rows(i)("OrariLokal")))
                                If OrlokName <> "" Then
                                    OrlokCode = qFindKodeOrariLokal(OrdaCode, OrlokName)
                                End If
                            Case "IKRAP"
                                Organisasi = "Rapi"
                                If Left(Callsign, 2) <> "JZ" Then
                                    If i < RowUntil Then
                                        Message = String.Format("Baris ke-{0}. Pesan Error: {1}", i, "Anda memasukkan data SKAR/IAR ke menu IKRAP!")
                                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                                        Return s
                                        Exit Function
                                    End If
                                End If
                                If .Rows(i)("RAPIDaerah") IsNot DBNull.Value Then RapiDaerahName = UCase(Trim(.Rows(i)("RapiDaerah")))
                                If RapiDaerahName <> "" Then
                                    RapiDaerahCode = qFindKodeRapiDaerah(RapiDaerahName)
                                    If Len(RapiDaerahCode) > 2 Then
                                        Return "Error Baris :" & i & ", Kode RAPI Daerah tidak ditemukan."
                                        Exit Function
                                    End If
                                End If
                                If .Rows(i)("NomorIKRAP") IsNot DBNull.Value Then NomorIKRAP = Trim(.Rows(i)("NomorIKRAP"))
                                If JenisPermohonan = "SEUMUR HIDUP" Then
                                    MasaBerlakuIAR = "SEUMUR HIDUP"
                                Else
                                    If .Rows(i)("MasaBerlakuIKRAP") IsNot DBNull.Value Then
                                        If Trim(.Rows(i)("MasaBerlakuIKRAP")) <> "" Then
                                            Dim MasaBerlakuIKRAPDate As Date = Trim(.Rows(i)("MasaBerlakuIKRAP"))
                                            MasaBerlakuIKRAP = MasaBerlakuIKRAPDate
                                        End If
                                    End If
                                End If
                        End Select

                        '/// Give Line Number
                        If .Rows(i)("No") IsNot DBNull.Value Then
                            If Trim(.Rows(i)("No")) <> "" Then
                                If i = 0 Then
                                    i = i + 1
                                End If
                            End If
                        Else
                            Exit For
                        End If

                        '/// Proses ID & ProsesLevel
                        Dim ProsesID As String = Format(Date.Now, "yyMMdd").ToString & (LatestProsesID).ToString("D6")
                        Dim ProsesLevel As String
                        If Session("MenuAwal") = "SKAR" Then
                            ProsesLevel = "4"
                        Else
                            ProsesLevel = "12"
                        End If

                        '/// Insert Data Proses
                        Dim Values As String = ""
                        Values = "'" & GroupID & "','" & ProsesID & "','" & ProsesLevel & "','" & Organisasi & "','" & _
                                    Callsign & "','" & Callsign & "','" & Nama & "','" & NamaKartu & "','" & NRI & "','" & _
                                    NomorKTP & "','" & JenisKelamin & "','" & TempatLahir & "',#" & TanggalLahir & "#,'" & _
                                    Alamat & "','" & Alamat1Kartu & "','" & Alamat2Kartu & "','" & Alamat3Kartu & "','" & _
                                    KodePos & "','" & Kota & "','" & Provinsi & "','" & Agama & "','" & Gol & "','" & _
                                    Pekerjaan & "','" & NomorTelepon & "','" & Email & "','" & OrdaCode & "','" & _
                                    OrdaName & "','" & OrlokCode & "','" & OrlokName & "','" & RapiDaerahCode & "','" & _
                                    RapiDaerahName & "','" & JenisPermohonan & "','" & Tingkat & "','" & NomorUNAR & "',#" & _
                                    TanggalUNAR & "#,'" & LokasiUNAR & "','" & HasilUNAR & "','" & NomorSKAR & "',#" & _
                                    TanggalTerbitSKAR & "#,'" & NomorIAR & "','" & MasaBerlakuIAR & "','" & NomorIKRAP & "','" & _
                                    MasaBerlakuIKRAP & "','" & ValidasiBank & "',#" & TanggalBayar & "#,'" & PNBP & "','" & _
                                    FileFoto & "',True"
                        s = qInsertDataProses(Values)
                        s = InsertDataProcess(s)
                        Values = "'" & GroupID & "','" & ProsesID & "','" & Organisasi & "','" & Callsign & "','" & NomorSKAR & "','" & _
                                    NomorIAR & "','" & NomorIKRAP & "','" & Session("UserID") & "',#" & Date.Now & "#"
                        's = qInsertDataLama(Values)
                        's = InsertDataProcess(s)
                        s = qUpdateProsesID(LatestProsesID)
                        s = InsertDataProcess(s)
                        s = qInsertDataLog("GroupID,ProsesID,Tahapan,UserProses,DateProses", String.Format("'{0}','{1}','Tinjau Data','{2}',#{3}#", GroupID, ProsesID, Session("UserID"), Date.Now))
                        s = InsertDataProcess(s)
                    Next
                    RowNumber = RowNumber + 50
                    If RowNumber < RowTotal Then
                        Response.Redirect("~/Pages/ImportProses.aspx?FileName=" & NamaFile & "&TypeFile=" & TypeFile & "&RowNumber=" & RowNumber.ToString & "&RowTotal=" & RowTotal.ToString & " ")
                    End If
                Else
                    Message = "[Import 021]: Data Berhasil..."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            End With
            dt.Dispose()
        Catch ex As Exception
            Message = String.Format("Baris ke-{0}. Pesan Error: {1}", i, ex.Message)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        Return s

    End Function

    Function InsertFileIARKhusus(ByVal dt As DataTable, ByVal GroupID As String, _
                                 ByVal LatestProsesID As Integer, ByVal NamaFile As String) As String
        Dim s As String = ""
        Dim i As Integer = 0
        Try
            With dt
                For i = 1 To .Rows.Count - 1
                    Dim NamaPanggilanKhusus As String = ""
                    Dim AlamatStasiun As String = ""
                    Dim DayaDibawah30 As String = ""
                    Dim DayaDiatas30 As String = ""
                    Dim PenggunaanStasiun As String = ""
                    Dim BandFrekuensi As String = ""
                    Dim KelasEmisi As String = ""
                    Dim BerlakuMulai As Date
                    Dim BerlakuAkhir As Date
                    Dim Orda As String = ""
                    Dim OrdaCode As String = "0"
                    Dim Orlok As String = ""
                    Dim OrlokCode As String = "0"
                    Dim NamaLengkap As String = ""
                    Dim NamaPanggilan As String = ""
                    Dim JenisKelamin As String = ""
                    Dim TempatLahir As String = ""
                    Dim TanggalLahir As Date
                    Dim Pekerjaan As String = ""
                    Dim Alamat As String = ""
                    Dim KodeTingkat As String = ""
                    Dim FileFoto As String = ""
                    Dim CallArea As String = ""
                    '/// Check Kalau Baris Tidak Kosong
                    If .Rows(i)("No") IsNot DBNull.Value Then
                        If Trim(.Rows(i)("No")) <> "" Then
                            If i = 0 Then
                                i = i + 1
                            End If
                        End If
                    Else
                        Exit For
                    End If

                    '--- Baca Data dari File Excel ---
                    If .Rows(i)("NamaPanggilanKhusus") IsNot DBNull.Value Then NamaPanggilanKhusus = Trim(.Rows(i)("NamaPanggilanKhusus"))
                    If .Rows(i)("AlamatStasiun") IsNot DBNull.Value Then AlamatStasiun = Trim(.Rows(i)("AlamatStasiun"))
                    If .Rows(i)("DayaDibawah30") IsNot DBNull.Value Then DayaDibawah30 = Trim(.Rows(i)("DayaDibawah30"))
                    If .Rows(i)("DayaDiatas30") IsNot DBNull.Value Then DayaDiatas30 = Trim(.Rows(i)("DayaDiatas30"))
                    If .Rows(i)("PenggunaanStasiun") IsNot DBNull.Value Then PenggunaanStasiun = Trim(.Rows(i)("PenggunaanStasiun"))
                    If .Rows(i)("BandFrekuensi") IsNot DBNull.Value Then BandFrekuensi = Trim(.Rows(i)("BandFrekuensi"))
                    If .Rows(i)("KelasEmisi") IsNot DBNull.Value Then KelasEmisi = Trim(.Rows(i)("KelasEmisi"))
                    If .Rows(i)("OrariDaerah") IsNot DBNull.Value Then Orda = Trim(.Rows(i)("OrariDaerah"))
                    If Orda <> "" Then
                        OrdaCode = qFindKodeOrariDaerah(Orda)
                    End If
                    If .Rows(i)("OrariLokal") IsNot DBNull.Value Then Orlok = Trim(.Rows(i)("OrariLokal"))
                    If Orlok <> "" Then
                        OrlokCode = qFindKodeOrariLokal(OrdaCode, Orlok)
                    End If
                    If .Rows(i)("NamaLengkap") IsNot DBNull.Value Then NamaLengkap = Trim(.Rows(i)("NamaLengkap"))
                    If .Rows(i)("NamaPanggilan") IsNot DBNull.Value Then
                        NamaPanggilan = Trim(.Rows(i)("NamaPanggilan"))
                        FileFoto = NamaPanggilan & ".jpg"
                    End If
                    If .Rows(i)("JenisKelamin") IsNot DBNull.Value Then JenisKelamin = Left(UCase(Trim(.Rows(i)("JenisKelamin"))), 1)
                    If .Rows(i)("TempatLahir") IsNot DBNull.Value Then TempatLahir = Trim(.Rows(i)("TempatLahir"))
                    If .Rows(i)("Pekerjaan") IsNot DBNull.Value Then Pekerjaan = Trim(.Rows(i)("Pekerjaan"))
                    If .Rows(i)("Alamat") IsNot DBNull.Value Then Alamat = Trim(.Rows(i)("Alamat"))
                    If .Rows(i)("BerlakuMulai") IsNot DBNull.Value Then
                        If Trim(.Rows(i)("BerlakuMulai")) <> "" Then
                            BerlakuMulai = Trim(.Rows(i)("BerlakuMulai"))
                            'BerlakuMulai = TanggalMulai.Day & " " & ConvertBulan(TanggalMulai.Month) & " " & TanggalMulai.Year
                        End If
                    End If
                    If .Rows(i)("BerlakuAkhir") IsNot DBNull.Value Then
                        If Trim(.Rows(i)("BerlakuAkhir")) <> "" Then
                            BerlakuAkhir = Trim(.Rows(i)("BerlakuAkhir"))
                            'BerlakuAkhir = TanggalAkhir.Day & " " & ConvertBulan(TanggalAkhir.Month) & " " & TanggalAkhir.Year
                        End If
                    End If
                    If .Rows(i)("TanggalLahir") IsNot DBNull.Value Then
                        If Trim(.Rows(i)("TanggalLahir")) <> "" Then
                            TanggalLahir = Trim(.Rows(i)("TanggalLahir"))
                            'TanggalLahir = TglLahir.Day & " " & ConvertBulan(TglLahir.Month) & " " & TglLahir.Year
                        End If
                    End If

                    '/// Get Tingkat Code
                    Select Case Left(NamaPanggilanKhusus, 2)
                        Case "YH" '--- PEMULA
                            KodeTingkat = "H"
                        Case "YD", "YG" '--- SIAGA
                            KodeTingkat = "D"
                        Case "YC", "YF" '--- PENGGALANG
                            KodeTingkat = "C"
                        Case "YB", "YE" '--- PENEGAK
                            KodeTingkat = "B"
                    End Select

                    '--- Call Area (1 Digit)
                    Dim cn As New OleDbConnection(MyDataProses)
                    Dim da3 As New OleDbDataAdapter(qSelectCallArea("*", OrdaCode), cn)
                    Dim dt3 As New DataTable
                    da3.Fill(dt3)
                    With dt3
                        CallArea = .Rows(0)("KodeIAR")
                    End With

                    '/// Proses ID & NomorIzin
                    Dim ProsesID As String = Format(Date.Now, "yyMMdd").ToString & (i + LatestProsesID).ToString("D6")
                    Dim NomorUrutIAR As String = GetNomorUrut(ProsesID, "IAR") '--- Nomor Urut (7 Digit)
                    Dim NomorIZIN As String = ConvertDigit(NomorUrutIAR, 7) & CallArea & "5" & KodeTingkat & ConvertDigit(Date.Now.Month.ToString, 2) & Right(Date.Now.Year.ToString, 2)
                    'TanggalBerlaku = Date.Now.Day & " " & ConvertBulan(Date.Now.Month) & " " & Date.Now.Year
                    Dim Values As String = ""
                    Values = "'12','" & GroupID & "','" & ProsesID & "','" & NomorIZIN & "','" & NamaPanggilanKhusus & _
                            "','" & AlamatStasiun & "','" & DayaDibawah30 & "','" & DayaDiatas30 & "','" & PenggunaanStasiun & _
                            "','" & BandFrekuensi & "','" & KelasEmisi & "',#" & BerlakuMulai & "#,#" & BerlakuAkhir & _
                            "#,'" & Orda & "','" & OrdaCode & "','" & Orlok & "','" & OrlokCode & "','" & NamaLengkap & _
                            "','" & NamaPanggilan & "','" & JenisKelamin & "','" & TempatLahir & "',#" & TanggalLahir & _
                            "#,'" & Pekerjaan & "','" & Alamat & "','" & FileFoto & "',1,#" & Date.Now & "#"
                    s = qInsertDataIARKhusus(Values)
                    s = InsertDataProcess(s)
                Next
            End With
            s = qUpdateFile(NamaFile, Session("UserID"))
            s = InsertDataProcess(s)
        Catch ex As Exception
            Message = String.Format("Baris ke-{0}. Pesan Error: {1}", i.ToString, ex.Message)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        Return s

    End Function

    Function InsertFileUNARToDB(ByVal NamaFile As String, ByVal GroupID As String) As String

        Dim s As String = ""
        Dim ErrorMsg As String = ""
        Dim ErrorNomorUNAR As String = ""
        Dim i As Integer = 0
        Dim dt As New DataTable

        Try
            Dim strConn As String = MyExcelNewHeader(MyFileUpload() & NamaFile)
            Dim myData As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", strConn)
            myData.TableMappings.Add("Table", "ExcelTest")
            myData.Fill(dt)

            With dt
                If .Rows.Count > 0 Then
                    For i = 1 To .Rows.Count - 1
                        '--- Definisi Parameter Umum ---
                        'GroupID = Left(NamaFile, Len(NamaFile) - 4)
                        Dim NomorUNAR As String = ""
                        Dim Nama As String = ""
                        Dim PS As String = "0"
                        Dim TR As String = "0"
                        Dim PR As String = "0"
                        Dim BI As String = "0"
                        Dim KM As String = "0"
                        Dim Teori As String = "0"
                        Dim Jumlah As String = "0"
                        Dim Konstanta As String = "0"
                        Dim Nilai As String = "0"
                        Dim Hasil As String = ""
                        Dim Keterangan As String = ""
                        Dim KMKirim As String = "0"
                        Dim KMTerima As String = "0"

                        '--- Baca Data dari File Excel ---
                        If .Rows(i)("NomorUNAR") IsNot DBNull.Value Then NomorUNAR = Trim(.Rows(i)("NomorUNAR"))
                        If .Rows(i)("Nama") IsNot DBNull.Value Then Nama = Trim(.Rows(i)("Nama"))
                        If .Rows(i)("PS") IsNot DBNull.Value Then PS = Trim(.Rows(i)("PS"))
                        If .Rows(i)("TR") IsNot DBNull.Value Then TR = Trim(.Rows(i)("TR"))
                        If .Rows(i)("PR") IsNot DBNull.Value Then PR = Trim(.Rows(i)("PR"))
                        If .Rows(i)("BI") IsNot DBNull.Value Then BI = Trim(.Rows(i)("BI"))
                        If .Rows(i)("KM") IsNot DBNull.Value Then KM = Trim(.Rows(i)("KM"))
                        If .Rows(i)("Teori") IsNot DBNull.Value Then Teori = Trim(.Rows(i)("Teori"))
                        If .Rows(i)("Jumlah") IsNot DBNull.Value Then Jumlah = Trim(.Rows(i)("Jumlah"))
                        If .Rows(i)("Konstanta") IsNot DBNull.Value Then Konstanta = Trim(.Rows(i)("Konstanta"))
                        If .Rows(i)("Nilai") IsNot DBNull.Value Then Nilai = Trim(.Rows(i)("Nilai"))
                        If .Rows(i)("Hasil") IsNot DBNull.Value Then Hasil = UCase(Trim(.Rows(i)("Hasil")))
                        If .Rows(i)("Keterangan") IsNot DBNull.Value Then Keterangan = Trim(.Rows(i)("Keterangan"))
                        If .Rows(i)("KMKirim") IsNot DBNull.Value Then KMKirim = Trim(.Rows(i)("KMKirim"))
                        If .Rows(i)("KMTerima") IsNot DBNull.Value Then KMTerima = Trim(.Rows(i)("KMTerima"))

                        '/// Insert Data Proses
                        Dim Values As String = ""
                        '--- Update Hasil UNAR
                        s = "UPDATE [HasilUNAR] SET PS='" & PS & "',TR='" & TR & "',PR='" & _
                                    PR & "',BI='" & BI & "',KM='" & KM & "',Teori='" & _
                                    Teori & "',Jumlah='" & Jumlah & "',Konstanta='" & _
                                    Konstanta & "',Nilai='" & Nilai & "',Hasil='" & _
                                    UCase(Hasil) & "',Keterangan='" & Keterangan & "',KMKirim='" & _
                                    KMKirim & "',KMTerima='" & KMTerima & _
                                    "' WHERE NomorUNAR = '" & NomorUNAR & "'"
                        ErrorMsg = InsertDataProcess(s)
                        If ErrorMsg <> "" Then
                            ErrorNomorUNAR = String.Format("{0}, {1}", NomorUNAR, ErrorNomorUNAR)
                        Else
                            '--- Get Proses ID ---
                            Dim ProsesID As String = ""
                            Dim cn As New OleDbConnection(MyDataProses)
                            Dim da1 As New OleDbDataAdapter(String.Format("SELECT * FROM DataProses WHERE NomorUNAR='{0}'", NomorUNAR), cn)
                            Dim dt1 As New DataTable
                            da1.Fill(dt1)
                            With dt1
                                If .Rows.Count > 0 Then
                                    ProsesID = .Rows(0)("ProsesID")
                                End If
                            End With
                            s = String.Format("UPDATE DataProses SET HasilUNAR='{0}' WHERE ProsesID='{1}'", Hasil, ProsesID)
                            s = InsertDataProcess(s)
                            s = qUpdateDataLog("Hasil UNAR", "UserHasilUNAR", Session("UserID"), "DateHasilUNAR", ProsesID)
                            s = InsertDataProcess(s)
                        End If
                    Next
                    If ErrorNomorUNAR <> "" Then
                        Message = String.Format("Mohon dicek Nomor UNAR: {0} tidak ditemukan nomor yang sama!", ErrorNomorUNAR)
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                    s = qUpdateFile(NamaFile, Session("UserID"))
                    s = InsertDataProcess(s)
                Else
                    Message = "[Import 021]: Data tidak ditemukan dalam file..."
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            End With
        Catch ex As Exception
            Message = String.Format("Baris ke-{0}. Pesan Error: {1}", i, ex.Message)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        Return s

    End Function

    Function InsertCSVToDB(ByVal NamaFile As String, ByVal GroupID As String) As String

        Dim s As String = ""
        Dim Field As String = ""
        Dim Values As String = ""
        Dim ProsesID_ As String = ""
        Dim ProsesLevel_ As String = ""
        Dim GroupID_ As String = ""
        DecryptFile(MyFileUpload() & NamaFile, String.Format("{0}{1}x", MyFileUpload(), NamaFile), "pUpUtN!4")
        Using reader As New TextFieldParser(String.Format("{0}{1}x", MyFileUpload(), NamaFile))
            reader.TextFieldType = FieldType.Delimited
            reader.Delimiters = New String() {"~"}
            Dim currentRow As String()
            Dim DataRow As String = ""
            Dim DataColom As String = ""
            Dim DataHeader As String = ""
            Dim a As Integer = 0
            While Not reader.EndOfData
                Try
                    a = a + 1
                    currentRow = reader.ReadFields()
                    For i As Integer = 0 To 126 'currentRow.Length
                        If a = 1 Then
                            DataHeader = String.Format("{0},{1}", DataHeader, currentRow(i))
                        Else
                            Select Case i
                                Case 0 '--- GroupID
                                    GroupID_ = currentRow(i)
                                    DataColom = String.Format("{0},'{1}'", DataColom, currentRow(i))
                                Case 1 '--- ProsesID
                                    ProsesID_ = currentRow(i)
                                    DataColom = String.Format("{0},'{1}'", DataColom, currentRow(i))
                                Case 2 '--- ProsesLevel
                                    ProsesLevel_ = currentRow(i)
                                    DataColom = DataColom & ",'" & currentRow(i) + 1 & "'"
                                Case 11, 30, 33, 35, 37, 39, 65, 67, 69, 71, 77, 79, 81, 83, 85, 87, 91, 93, 95, 97, 101, 103, 105, 107, 109, 113, 115, 117, 120 '--- Format Tanggal
                                    If currentRow(i) = "" Then
                                        DataColom = DataColom & ",#1/1/1900#"
                                    Else
                                        DataColom = String.Format("{0},#{1}#", DataColom, currentRow(i))
                                    End If
                                Case 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 72, 88, 98, 110, 121, 122 '--- Format True/False
                                    DataColom = String.Format("{0},{1}", DataColom, currentRow(i))
                                Case 74 '--- User Postel Yang Import File
                                    DataColom = String.Format("{0},'{1}'", DataColom, Session("UserID"))
                                Case 75 '--- Tanggal Postel Import File
                                    DataColom = String.Format("{0},#{1}#", DataColom, Date.Now)
                                Case Else
                                    DataColom = String.Format("{0},'{1}'", DataColom, currentRow(i))
                            End Select
                        End If
                    Next
                    If a = 1 Then
                        Field = Left(Right(DataHeader, Len(DataHeader) - 1), Len(DataHeader) - 1)
                    Else
                        s = GetMemberList(String.Format(" WHERE ProsesID = '{0}' ", ProsesID_))
                        If s = "1" Then
                            s = qDeleteDataProses(ProsesID_)
                            s = InsertDataProcess(s)
                        End If
                        DataRow = Left(Right(DataColom, Len(DataColom) - 1), Len(DataColom) - 1)
                        s = qInsertDataProses2(Field, DataRow)
                        s = InsertDataProcess(s)
                        's = qUpdateDataLevel("Orari")
                        's = InsertDataProcess(s)

                        '---------------------
                        ' Insert Data Log
                        '---------------------
                        Dim FieldLog As String = "GroupID,ProsesID,Organisasi,UserImportFile1Postel,DateImportFile1Postel,ProsesData"
                        Dim DataRowLog As String = " '" & GroupID_ & "','" & ProsesID_ + 1 & "','" & Session("Organisasi") & "','" & Session("UserID") & "',#" & Date.Now & "#,1"
                        s = qInsertDataLog(FieldLog, DataRowLog)
                        s = InsertDataProcess(s)
                        s = qUpdateDataLog("Import File", "UserProses", Session("UserID"), "DateProses", ProsesID_)
                        s = InsertDataProcess(s)

                    End If
                Catch ex As MalformedLineException
                    MsgBox(String.Format("Line {0} is invalid.  Skipping", ex.Message))
                End Try
                DataColom = ""
                DataRow = ""
            End While
            s = qUpdateFile(NamaFile, Session("UserID"))
            s = InsertDataProcess(s)
        End Using

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

    Sub DecryptFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()

    End Sub

    Protected Sub CbxNewGroupID_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxNewGroupID.CheckedChanged
        If CbxNewGroupID.Checked = True Then
            TbxGroupID.Enabled = False
            TbxGroupID.Text = ""
        Else
            TbxGroupID.Enabled = True
        End If
    End Sub
End Class
