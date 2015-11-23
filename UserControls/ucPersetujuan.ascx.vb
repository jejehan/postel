Imports System
Imports System.IO
Imports clsGeneral
Imports System.Data
Imports clsCallSign
Imports clsDataBase
Imports System.Web.UI
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Imports System.Drawing.Imaging
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports Microsoft.VisualBasic.DateAndTime

Partial Class UserControls_ucPersetujuan
    Inherits UserControl
    Public Shared TypeData As String
    Public Shared TypeExport As String
    Public Shared NRI, NomorKTP, Callsign As String
    Public Shared ProsesID As String
    Public Shared JenisPermohonan As String
    Public Shared ProsesLevel As String
    Public Shared Message As String = ""
    Public Shared MenuAwal As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cxItem As CheckBox
        Dim cxItemArray As String = ""
        Dim s As String = ""
        Dim cxAllAwal As String = ""
        Dim cxAllAkhir As String = ""
        Dim StartIndex As Integer = 0
        Dim StartEnd As Integer = 0
        Dim StartMod As Integer = 0

        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnProsesIAR)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnProsesLulusUNAR)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnProsesGagalUNAR)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnSave)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnHapusData)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnRefresh)

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        End If

        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            lblJudul.Text = MenuAwal
            GetData(MenuAwal)
            Tombol(MenuAwal)
        Else
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    StartIndex = .VisibleStartIndex
                    StartMod = .VisibleRowCount Mod 50
                    If StartIndex + 49 >= .VisibleRowCount Then
                        StartEnd = StartIndex + (StartMod - 1)
                    Else
                        StartEnd = StartIndex + 49
                    End If
                    For i = StartIndex To StartEnd
                        cxItem = .FindRowCellTemplateControl(i, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
                        If cxItem.Checked <> False Then
                            If cxItem.Checked = "True" Then
                                cxItemArray = String.Format("{0},{1}", cxItemArray, i)
                            End If
                        End If
                    Next
                    If cxItemArray <> "" Then
                        Session("CheckItemPersetujuan") = Right(cxItemArray, Len(cxItemArray) - 1)
                    End If
                End If
            End With
            GetData(MenuAwal)
            If cxItemArray <> "" Then
                s = setCheckedItem(Session("CheckItemPersetujuan"))
            End If
        End If

    End Sub

    Sub Tombol(ByVal MenuAwal As String)
        Select Case MenuAwal
            Case "SKAR"
                BtnProsesLulusUNAR.Visible = True
                BtnProsesGagalUNAR.Visible = True
            Case "IAR"
                BtnProsesIAR.Visible = True
            Case "IKRAP"
                BtnProsesIAR.Visible = True
                BtnProsesIAR.Text = "Proses IKRAP"
        End Select
    End Sub

    Sub GetData(ByVal MenuAwal As String)

        Select Case MenuAwal
            Case "SKAR"
                GetMemberList("WHERE Organisasi='Orari' AND ProsesLevel='5' AND HasilUNAR <> '' ")
            Case "IAR"
                GetMemberList("WHERE Organisasi='Orari' AND ProsesLevel='13'")
            Case "IKRAP"
                GetMemberList("WHERE Organisasi='Rapi' AND ProsesLevel='13'")
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

    Sub GetMemberList(ByVal Where As String)

        Try
            '--- Setting Layout GridView ---
            With GvListAnggota.Columns
                Select Case MenuAwal
                    Case "SKAR"
                        .Item(10).Visible = False 'rapi daerah
                        .Item(19).Visible = False 'nomor ikrap
                        .Item(20).Visible = False 'masa berlaku ikrap
                    Case "IAR"
                        .Item(10).Visible = False 'rapi daerah
                        .Item(12).Visible = False 'nomor unar
                        .Item(13).Visible = False 'tgl unar
                        .Item(14).Visible = False 'hasil unar
                        .Item(19).Visible = False 'nomor ikrap
                        .Item(20).Visible = False 'masa berlaku ikrap
                    Case "IKRAP"
                        .Item(7).Visible = False 'tingkat
                        .Item(8).Visible = False 'Orda
                        .Item(9).Visible = False 'Orlok
                        .Item(12).Visible = False 'nomor unar
                        .Item(13).Visible = False 'tgl unar
                        .Item(14).Visible = False 'hasil unar
                        .Item(15).Visible = False 'nomor skar
                        .Item(16).Visible = False 'tgl terbit skar
                        .Item(17).Visible = False 'nomor iar
                        .Item(18).Visible = False 'masa berlaku iar
                End Select
            End With

            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectMemberProses(Where, ProsesLevel), cn)
            Dim dt As New DataTable
            da.Fill(dt)
            GvListAnggota.DataSource = dt
            GvListAnggota.DataBind()
            'With dt
            '    If .Rows.Count = 0 Then
            '        GvListAnggota.Settings.ShowVerticalScrollBar = False
            '        GvListAnggota.SettingsPager.ShowEmptyDataRows = False
            '    Else
            '        GvListAnggota.Settings.ShowVerticalScrollBar = True
            '        GvListAnggota.SettingsPager.ShowEmptyDataRows = True
            '    End If
            'End With
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            Message = ex.Message.ToString
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    'Protected Sub GvListAnggota_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListAnggota.PageIndexChanged
    '    'GetData(MenuAwal)
    'End Sub

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        GvListAnggota_ExportAll.WriteXlsToResponse()
    End Sub

    Protected Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Dim s As String
        Session("CheckAllPersetujuan") = ""

        If cbxPilihSemua.Checked = True Then
            s = setCheckedAll("True")
            Session("CheckAllPersetujuan") = "True"
        Else
            s = setCheckedAll("False")
            Session("CheckAllPersetujuan") = "False"
        End If
        GC.Collect()
    End Sub

    Protected Sub BtnHapusData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapusData.Click

        Dim s As String = ""
        Dim NomorKTP As String = ""
        Dim ArlTs As New ArrayList

        Try
            For i As Integer = 0 To GvListAnggota.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    s = qDelete("DataProses", " ProsesID='" & ProsesID & "'")
                    s = InsertDataProcess(s)
                End If
            Next
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        GetData(MenuAwal)

    End Sub

    'Protected Sub CxAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    '    Dim s As String
    '    Dim cx As CheckBox

    '    cx = sender
    '    If cx.Checked = True Then
    '        s = setCheckedAll("True")
    '        Session("CheckAllPersetujuan") = "True"
    '    Else
    '        s = setCheckedAll("False")
    '        Session("CheckAllPersetujuan") = "False"
    '    End If
    '    cx = Nothing
    '    GC.Collect()

    'End Sub

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
        Dim Paging As Integer
        Try
            Paging = GvListAnggota.PageIndex * 50
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    For i = Paging To .VisibleRowCount - 1
                        cx = .FindRowCellTemplateControl(i, TryCast(GvListAnggota.Columns(1), GridViewDataColumn), "CxItem")
                        cx.Checked = NewVal
                    Next
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

    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlProsesID As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlProsesID"), Literal)
        Response.Redirect("~/pages/form.aspx?ProsesID=" & ltrlProsesID.Text & "&returnurl=Persetujuan.aspx")
    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ltrlProsesID As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlProsesID"), Literal)
        Dim s As String = ""
        Dim ProsesID As String = ""
        Try
            ProsesID = ltrlProsesID.Text
            If ProsesID <> "" Then
                s = qDeleteTemp("DataProses", " ProsesID='" & ProsesID & "'")
                s = InsertDataProcess(s)
            End If
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        GetData(MenuAwal)
    End Sub

    Private Function SaveImageToDB(ByRef FileFoto As String, ByVal FileHeader As String) As Boolean
        Try
            Dim DataProses As String = ""
            Dim conn As New OleDbConnection
            Dim cmd As OleDbCommand
            DataProses = ConfigurationManager.AppSettings("DataProses")
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataProses & ";User Id=;Jet OLEDB:Database Password="
            conn.Open()

            cmd = conn.CreateCommand()
            cmd.CommandText = "INSERT INTO DataSKAR(FileFoto, FileFotoBitmap) VALUES (@FileFoto, @FileFotoBitmap)"
            Dim imgByteArrayFoto() As Byte
            Try
                '--- Convert Foto to DB
                Dim streamFoto As New MemoryStream
                Dim bmpFoto As New Bitmap(FileFoto)
                bmpFoto.Save(streamFoto, ImageFormat.Jpeg)
                imgByteArrayFoto = streamFoto.ToArray()
                streamFoto.Close()

                cmd.Parameters.AddWithValue("@FileFoto", FileFoto)
                cmd.Parameters.AddWithValue("@FileFotoBitmap", imgByteArrayFoto)

                If DirectCast(cmd.ExecuteNonQuery(), Integer) > 0 Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try

            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            Return False
        End Try
    End Function

    'First save the image to the table
    Private Function SaveHeaderImageToDB(ByVal FileFoto As String) As Boolean
        Try
            Dim DataProses As String = ""
            Dim conn As New OleDbConnection
            Dim cmd As OleDbCommand
            DataProses = ConfigurationManager.AppSettings("DataProses")
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataProses & ";User Id=;Jet OLEDB:Database Password="
            conn.Open()

            cmd = conn.CreateCommand()
            cmd.CommandText = "INSERT INTO DataSKAR(FileFoto, FileFotoBitmap) VALUES (@FileFoto, @FileFotoBitmap)"
            Dim imgByteArray() As Byte
            Try
                Dim stream As New MemoryStream
                Dim bmp As New Bitmap(FileFoto)

                bmp.Save(stream, ImageFormat.Jpeg)
                imgByteArray = stream.ToArray()
                stream.Close()

                cmd.Parameters.AddWithValue("@FileFoto", FileFoto)
                cmd.Parameters.AddWithValue("@FileFotoBitmap", imgByteArray)

                If DirectCast(cmd.ExecuteNonQuery(), Integer) > 0 Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try

            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Retrieve image from table
    Public Function GetImageFromDB(ByRef FileFoto As String) As Bitmap
        Try
            Dim conn As New OleDbConnection
            Dim cmd As OleDbCommand
            Dim reader As OleDbDataReader
            Dim DataProses As String = ""

            DataProses = ConfigurationManager.AppSettings("DataProses")
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataProses & ";User Id=;Jet OLEDB:Database Password="
            conn.Open()

            cmd = conn.CreateCommand()
            cmd.CommandText = String.Format("SELECT FotoFileBitmap FROM DataSKAR WHERE FileFoto = '{0}'", FileFoto)

            reader = cmd.ExecuteReader

            If reader.Read Then
                Dim imgByteArray() As Byte

                Try
                    imgByteArray = CType(reader(0), Byte())
                    Dim stream As New MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Return Nothing
                End Try
            End If

            reader.Close()
            conn.Close()

            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Protected Sub BtnProsesLulusUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnProsesLulusUNAR.Click

        Dim s As String = ""
        Dim ProsesID As String = ""
        Dim Where As String = ""
        Try
            With GvListAnggota
                If (.VisibleRowCount > 0) Then
                    Dim cxArray() As String = Split(Session("CheckItemPersetujuan"), ",")
                    For i = 0 To cxArray.Length - 1
                        ProsesID = .GetRowValues(cxArray(i), New String() {.KeyFieldName}).ToString()
                        If ProsesID <> "" Then
                            Where = String.Format(" WHERE ProsesID='{0}' AND HasilUNAR='LULUS' ", Trim(ProsesID))
                            Dim cn As New OleDbConnection(MyDataProses)
                            Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
                            Dim dt As New DataTable
                            da.Fill(dt)
                            With dt
                                If .Rows.Count > 0 Then
                                    '--- Data Pemohon ---
                                    ProsesID = Trim(.Rows(0)("ProsesID"))
                                    ProsesLevel = Trim(.Rows(0)("ProsesLevel"))
                                    JenisPermohonan = Trim(.Rows(0)("JenisPermohonan"))
                                    Dim TheFile As FileInfo = New FileInfo(MapPath("~/FileFotoProses/") & Trim(.Rows(0)("FileFoto")))
                                    If TheFile.Exists Then
                                        '--- Cek Tingkat ---
                                        Dim Tingkat As String = FindTingkat(ProsesID)
                                        Select Case Tingkat
                                            Case "BARU", "PEMULA"
                                                Tingkat = "1"
                                            Case "SIAGA"
                                                Tingkat = "2"
                                            Case "PENGGALANG"
                                                Tingkat = "3"
                                            Case "PENEGAK"
                                                Tingkat = "4"
                                        End Select

                                        '--- Cek Jenis Permohonan ---
                                        Select Case JenisPermohonan
                                            Case "BARU"
                                                JenisPermohonan = "1"
                                            Case "PEMBAHARUAN", "HILANG", "RUSAK", "PINDAH", "GANTI CALLSIGN", "PILIH CALLSIGN"
                                                JenisPermohonan = "2"
                                            Case "NAIK TINGKAT"
                                                JenisPermohonan = "3"
                                            Case "KEHORMATAN"
                                                JenisPermohonan = "4"
                                            Case "KHUSUS", "ASING"
                                                JenisPermohonan = "5"
                                        End Select

                                        '--- Cek Kode Daerah ---
                                        Dim CallArea1 As String = CallArea(Trim(.Rows(0)("OrdaCode")))

                                        Select Case ProsesLevel
                                            Case "5" '--- Dapat Nomor SKAR ---
                                                s = qUpdateSKARNumber("LULUS", ProsesID, Session("Organisasi"), Session("UserID"), ProsesLevel)
                                                s = InsertDataSKAR(ProsesID)
                                                s = qUpdateDataProses(ProsesID, ProsesLevel)
                                                s = InsertDataProcess(s)
                                                s = qUpdateDataLog("Cetak", "UserPersetujuan", Session("UserID"), "DateNomor", ProsesID)
                                                s = InsertDataProcess(s)
                                            Case "13" '--- Dapat Nomor IAR/IKRAP ---
                                                s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                                                s = InsertDataProcess(s)
                                        End Select
                                    Else
                                        Dim Message As String = "Beberapa data gagal diproses karena belum ada foto..."
                                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                                    End If
                                End If
                            End With
                            da.Dispose()
                            cn.Dispose()
                            'End If
                        Else
                            Dim Message As String = "Beberapa data gagal diproses karena persyaratan masih kurang..."
                            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                        End If
                    Next
                End If
            End With
            If Session("cxAllAkhirPersetujuan") = True Then Session("cxAllAkhirPersetujuan") = False
            If cbxPilihSemua.Checked = True Then cbxPilihSemua.Checked = False
            GetData(MenuAwal)
        Catch ex As Exception
            's = ex.Message
            Dim Message As String = "Anda harus memilih data yang ingin di Proses..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    Function InsertDataSKAR(ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            Dim DataSKAR As String = ""
            Dim NomorSKAR As String = ""
            Dim Nama As String = ""
            Dim Tingkat As String = ""
            Dim GroupID As String = ""
            Dim TempatLahir As String = ""
            Dim TanggalLahir As Date
            Dim Alamat1Kartu As String = ""
            Dim Alamat2Kartu As String = ""
            Dim Alamat3Kartu As String = ""
            Dim TanggalUNAR As Date
            Dim LokasiUNAR As String = ""
            Dim FileFoto As String = ""
            Dim TanggalSKAR As Date
            Dim Orda As String = ""
            Dim Where As String = ""

            Where = String.Format(" WHERE ProsesID='{0}'", Trim(ProsesID))
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
                    Nama = Trim(.Rows(0)("NamaKartu"))
                    TempatLahir = Trim(.Rows(0)("TempatLahir"))
                    TanggalLahir = .Rows(0)("TanggalLahir")
                    Alamat1Kartu = .Rows(0)("Alamat1Kartu")
                    Alamat2Kartu = .Rows(0)("Alamat2Kartu")
                    Alamat3Kartu = .Rows(0)("Alamat3Kartu")
                    Tingkat = .Rows(0)("Tingkat")
                    TanggalUNAR = .Rows(0)("TanggalUNAR")
                    LokasiUNAR = .Rows(0)("LokasiUNAR")
                    FileFoto = .Rows(0)("FileFoto")
                    NomorSKAR = .Rows(0)("NomorSKAR")
                    TanggalSKAR = .Rows(0)("TanggalTerbitSKAR")
                    Callsign = .Rows(0)("Callsign")
                    Orda = .Rows(0)("OrdaName")
                End If
            End With
            DataSKAR = "'" & GroupID & "','" & ProsesID & "','" & Replace(Nama, "~", "`") & "','" & TempatLahir & ", " & Day(TanggalLahir) & _
                        " " & ConvertBulan(Month(TanggalLahir)) & " " & Year(TanggalLahir) & _
                        "','" & Alamat1Kartu & "','" & Tingkat & "','" & Day(TanggalUNAR) & _
                        " " & ConvertBulan(Month(TanggalUNAR)) & " " & Year(TanggalUNAR) & _
                        "','" & LokasiUNAR & "','" & NomorSKAR & "','" & Day(TanggalSKAR) & _
                        " " & ConvertBulan(Month(TanggalSKAR)) & " " & Year(TanggalSKAR) & _
                        "','" & FileFoto & "','" & Callsign & "','" & Orda & "' "
            s = qInsertDataSKAR(DataSKAR)
            s = InsertDataProcess(s)
            Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(FileFoto)
            s = qSaveImageToDB(NamaFoto, ProsesID, "DataSKAR")
        Catch ex As Exception
            s = ex.Message
            Dim Message As String = s
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        Return s
    End Function

    Protected Sub BtnProsesIAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnProsesIAR.Click
        Dim s As String = ""
        Dim ErrorStr As String = ""
        Dim ProsesID As String = ""
        Dim NomorUrutIAR As String = ""
        Dim NomorIAR As String = ""
        Dim NomorUrutIKRAP As String = ""
        Dim NomorIKRAP As String = ""
        Dim DataIAR As String = ""
        Dim DataIKRAP As String = ""
        Dim ProsesLevel As String = ""
        Dim i As Integer = 0
        Dim baris As Integer = 0
        Try
            For i = 0 To GvListAnggota.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    ErrorStr = qSelectDataSyarat(ProsesID, Session("Organisasi"), JenisPermohonan, MenuAwal)
                    If ErrorStr = "" Then
                        '--- Get Profile Data
                        Dim JenisPermohonan As String = ""
                        Dim Tingkat As String = ""
                        Dim GroupID As String = ""
                        Dim NamaKartu As String = ""
                        Dim Alamat1 As String = ""
                        Dim Alamat2 As String = ""
                        Dim Alamat3 As String = ""
                        Dim FileFoto As String = ""
                        Dim CallSign As String = ""
                        Dim Orda As String = ""
                        Dim RapiDaerah As String = ""
                        Dim MasaBerlakuIAR As String = ""
                        Dim MasaBerlakuIKRAP As String = ""
                        Dim cn As New OleDbConnection(MyDataProses)
                        Dim da As New OleDbDataAdapter("SELECT * FROM [DataProses] WHERE ProsesID='" & ProsesID & "' ", cn)
                        Dim dt As New DataTable

                        da.Fill(dt)
                        With dt
                            If .Rows.Count > 0 Then
                                GroupID = .Rows(0)("GroupID")
                                JenisPermohonan = .Rows(0)("JenisPermohonan")
                                Tingkat = .Rows(0)("Tingkat")
                                NomorIAR = .Rows(0)("NomorIAR")
                                NomorIKRAP = .Rows(0)("NomorIKRAP")
                                FileFoto = .Rows(0)("FileFoto")
                                CallSign = .Rows(0)("CallSign")
                                Select Case MenuAwal
                                    Case "SKAR", "IAR"
                                        If Left(CallSign, 2) = "JZ" Then
                                            s = s & "Data SKAR/IAR dengan Callsign IKRAP"
                                        End If
                                    Case "IKRAP"
                                        If Left(CallSign, 2) <> "JZ" Then
                                            s = s & "Data IKRAP dengan Callsign SKAR/IAR"
                                        End If
                                End Select
                                ProsesLevel = .Rows(0)("ProsesLevel")
                                NamaKartu = .Rows(0)("NamaKartu")
                                Alamat1 = .Rows(0)("Alamat1Kartu")
                                Alamat2 = .Rows(0)("Alamat2Kartu")
                                Alamat3 = .Rows(0)("Alamat3Kartu")
                                Orda = .Rows(0)("OrdaName")
                                RapiDaerah = .Rows(0)("RapiDaerahName")
                                If MenuAwal = "IAR" Then '--- Get New IAR Number
                                    If GroupID <> "CETAKULANG" Then
                                        If Left(.Rows(0)("MasaBerlakuIAR"), 6) <> "30/12/" Then
                                            NomorUrutIAR = GetNomorUrut(ProsesID, "IAR") '--- Nomor Urut (7 Digit)
                                            NomorIAR = GetNomorIAR(ProsesID, ConvertDigit(NomorUrutIAR, 7))
                                            MasaBerlakuIAR = qGetMasaBerlakuIAR(Tingkat)
                                            If JenisPermohonan = "SEUMUR HIDUP" Then MasaBerlakuIAR = "SEUMUR HIDUP"
                                        Else
                                            NomorIAR = .Rows(0)("NomorIAR")
                                            MasaBerlakuIAR = .Rows(0)("MasaBerlakuIAR")
                                        End If
                                    Else
                                        NomorIAR = .Rows(0)("NomorIAR")
                                        MasaBerlakuIAR = .Rows(0)("MasaBerlakuIAR")

                                    End If
                                    DataIAR = "'" & GroupID & "','" & ProsesID & "','" & Replace(NamaKartu, "~", "`") & "','" & Tingkat & _
                                                "','" & ConvertTingkat(Tingkat) & "','" & Replace(CallSign, "0", "Ø") & _
                                                "','" & Alamat1 & "','" & Alamat2 & "','" & Alamat3 & _
                                                "','" & MasaBerlakuIAR & "','" & NomorIAR & _
                                                "','" & FileFoto & "','" & Orda & "' "
                                    s = qInsertDataIAR(DataIAR)
                                    s = InsertDataProcess(s)
                                    Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(FileFoto)
                                    s = qSaveImageToDB(NamaFoto, ProsesID, "DataIAR")
                                    s = qUpdateDataIAR(NomorIAR, ProsesID, MasaBerlakuIAR)
                                    s = InsertDataProcess(s)
                                Else '--- IKRAP
                                    If GroupID <> "CETAKULANG" Then
                                        If Left(.Rows(0)("MasaBerlakuIKRAP"), 6) <> "30/12/" Then
                                            If Left(.Rows(0)("MasaBerlakuIKRAP"), 6) <> "31/12/" Then
                                                NomorUrutIKRAP = GetNomorUrut(ProsesID, "IKRAP")
                                                NomorIKRAP = GetNomorIKRAP(ProsesID, ConvertDigit(NomorUrutIKRAP, 7))
                                                MasaBerlakuIKRAP = qGetMasaBerlakuIKRAP()
                                                If JenisPermohonan = "SEUMUR HIDUP" Then MasaBerlakuIKRAP = "SEUMUR HIDUP"
                                            Else
                                                NomorIAR = .Rows(0)("NomorIKRAP")
                                                MasaBerlakuIKRAP = .Rows(0)("MasaBerlakuIKRAP")
                                            End If
                                        Else
                                            NomorIAR = .Rows(0)("NomorIKRAP")
                                            MasaBerlakuIKRAP = .Rows(0)("MasaBerlakuIKRAP")
                                        End If
                                    Else
                                        NomorIKRAP = .Rows(0)("NomorIKRAP")
                                        MasaBerlakuIKRAP = .Rows(0)("MasaBerlakuIKRAP")
                                    End If
                                    DataIKRAP = "'" & GroupID & "','" & ProsesID & "','" & Replace(NamaKartu, "~", "`") & "','" & Replace(CallSign, "0", "Ø") & _
                                                "','" & Alamat1 & "','" & Alamat2 & "','" & Alamat3 & _
                                                "','" & MasaBerlakuIKRAP & "','" & NomorIKRAP & _
                                                "','" & FileFoto & "','" & RapiDaerah & "' "
                                    s = qInsertDataIKRAP(DataIKRAP)
                                    s = InsertDataProcess(s)
                                    Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(FileFoto)
                                    s = qSaveImageToDB(NamaFoto, ProsesID, "DataIKRAP")
                                    s = qUpdateDataIKRAP(NomorIKRAP, ProsesID, MasaBerlakuIKRAP)
                                    s = InsertDataProcess(s)
                                End If
                            Else
                                Dim Message As String = "Data tidak ditemukan."
                                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                            End If
                        End With
                    End If
                End If
                If s = "" Then '--- Jika tidak ada error
                    If ProsesID <> "" Then
                        s = qUpdateDataProses(ProsesID, ProsesLevel + 1)
                        s = InsertDataProcess(s)
                        s = qUpdateDataLog("Persetujuan", "UserPersetujuan", Session("UserID"), "DatePersetujuan", ProsesID)
                        s = InsertDataProcess(s)
                        baris = baris + 1
                    End If
                Else
                    If baris <> 50 Then
                        Dim Message2 As String = "Data baris ke-" & baris.ToString & " error: " & s
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message2.Replace("'", "")), True)
                    End If
                End If
            Next
            Dim Message1 As String = baris.ToString & " data siap dicetak..."
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message1.Replace("'", "")), True)
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        GetData(MenuAwal)
        If cbxPilihSemua.Checked = True Then
            cbxPilihSemua.Checked = False
        End If

    End Sub

    Protected Sub BtnProsesGagalUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnProsesGagalUNAR.Click
        Dim s As String = ""
        Dim Where As String = ""
        Where = " WHERE HasilUNAR='TIDAK LULUS' "
        Dim cn As New OleDbConnection(MyDataProses)
        Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
        Dim dt As New DataTable
        da.Fill(dt)
        With dt
            If .Rows.Count > 0 Then
                For i = 0 To .Rows.Count - 1
                    '--- Data Pemohon ---
                    ProsesID = Trim(.Rows(i)("ProsesID"))
                    ProsesLevel = Trim(.Rows(i)("ProsesLevel"))
                    s = qUpdateDataProses(ProsesID, ProsesLevel + 2)
                    s = InsertDataProcess(s)
                    s = qUpdateDataLog("Persetujuan", "UserPersetujuan", Session("UserID"), "DatePersetujuan", ProsesID)
                    s = InsertDataProcess(s)
                Next
            End If
        End With
        If Session("cxAllAkhirPersetujuan") = True Then Session("cxAllAkhirPersetujuan") = False
        GetData(MenuAwal)
    End Sub

    Protected Sub cbxPilihSemua_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxPilihSemua.CheckedChanged
        Dim s As String
        Dim cx As CheckBox
        cx = sender
        If cx.Checked = True Then
            s = setCheckedAll("True")
        Else
            s = setCheckedAll("False")
        End If
        cx = Nothing
        GC.Collect()

    End Sub

End Class
