Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports clsDataBase
Imports System
Imports System.Configuration

Public Class clsGeneral

    '--- Get Folder File Upload
    Public Shared Function MySMTP() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("SMTPServer")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Folder File Upload
    Public Shared Function MyFileUpload() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("FileUpload")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Folder File Foto
    Public Shared Function MyFileFoto() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("FileFoto")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Folder File Foto Proses
    Public Shared Function MyFileFotoProses() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("FileFotoProses")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Folder File Temp
    Public Shared Function MyFileExport() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("FileExport")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Folder File Error
    Public Shared Function MyFileError() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("FileError")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Organisasi
    Public Shared Function MyOrganisasi() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("Organisasi")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Company
    Public Shared Function MyCompany() As String
        Dim s As String = ""
        Try
            s = ConfigurationManager.AppSettings("Company")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--- Get Last Nomor Urut
    Public Shared Function GetNomorUrut(ByVal ProsesID As String, ByVal TypeData As String) As String

        Dim cn As New OleDbConnection(MyDataProses)
        Dim s As String = ""
        Dim Nomor As String = ""
        Try
            '--- Get Nomor Urut ---
            Dim Query As String = "SELECT * FROM NomorUrut WHERE TypeData='" & UCase(TypeData) & "'"
            Dim da As New OleDbDataAdapter(Query, cn)
            Dim dt As New DataTable
            da.Fill(dt)
            s = dt.Rows(0)("Nomor")
            Nomor = s + 1
            '--- Update Nomor Urut ---
            Dim Update As String = "UPDATE NomorUrut SET Nomor ='" & Nomor & "' WHERE TypeData='" & UCase(TypeData) & "'"
            s = InsertDataProcess(Update)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return Nomor

    End Function

    Public Shared Function GetNomorSKAR(ByVal ProsesID As String, ByVal NomorUrutSKAR As String) As String

        Dim Tingkat As String = ""
        Dim Bulan As String = ""
        Dim cn As New OleDbConnection(MyDataProses)

        'NomorUrutSKAR = GetNomorUrut(ProsesID, "SKAR")

        '--- Tingkat
        Dim da2 As New OleDbDataAdapter(qSelectDataProses("Tingkat", ProsesID, "Orari"), cn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        With dt2
            Tingkat = .Rows(0)("Tingkat")
        End With
        Select Case Tingkat
            Case "", "BARU", "PEMULA"
                Tingkat = "SGA"
            Case "SIAGA"
                Tingkat = "SGA"
            Case "PENGGALANG"
                Tingkat = "PGL"
            Case "PENEGAK"
                Tingkat = "PGK"
        End Select

        '--- Bulan
        Bulan = Date.Now.Month
        Select Case Bulan
            Case "1"
                Bulan = "I"
            Case "2"
                Bulan = "II"
            Case "3"
                Bulan = "III"
            Case "4"
                Bulan = "IV"
            Case "5"
                Bulan = "V"
            Case "6"
                Bulan = "VI"
            Case "7"
                Bulan = "VII"
            Case "8"
                Bulan = "VIII"
            Case "9"
                Bulan = "IX"
            Case "10"
                Bulan = "X"
            Case "11"
                Bulan = "XI"
            Case "12"
                Bulan = "XII"
        End Select

        Dim NomorSKAR As String = NomorUrutSKAR & "/SKAR/" & Tingkat & "/" & Bulan & "/" & Date.Now.Year

        Return NomorSKAR

    End Function

    Public Shared Function GetNomorIAR(ByVal ProsesID As String, ByVal NomorUrutIAR As String) As String

        Dim Tingkat As String = ""
        Dim KodeTingkat As String = ""
        Dim OrdaCode As String = ""
        Dim Organisasi As String = ""
        Dim CallArea As String = ""
        Dim Bulan As String = ""
        Dim Tahun As String = ""
        Dim JenisPermohonan As String = ""
        Dim KodeJenisPermohonan As String = ""
        Dim cn As New OleDbConnection(MyDataProses)

        Dim da2 As New OleDbDataAdapter(qSelectDataProses("*", ProsesID, "Orari"), cn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        With dt2
            Organisasi = .Rows(0)("Organisasi")
            Tingkat = .Rows(0)("Tingkat")
            OrdaCode = .Rows(0)("OrdaCode")
            JenisPermohonan = .Rows(0)("JenisPermohonan")
        End With

        '--- Call Area (1 Digit)
        Dim da3 As New OleDbDataAdapter(qSelectCallArea("*", OrdaCode), cn)
        Dim dt3 As New DataTable
        da3.Fill(dt3)
        With dt3
            CallArea = .Rows(0)("KodeIAR")
        End With

        '--- Jenis Pemohonan ---
        Select Case JenisPermohonan
            Case "BARU"
                KodeJenisPermohonan = "1"
            Case "PERPANJANGAN", "SEUMUR HIDUP"
                KodeJenisPermohonan = "2"
            Case "PEMBAHARUAN"
                KodeJenisPermohonan = "3"
            Case "NAIK TINGKAT"
                KodeJenisPermohonan = "4"
            Case "KHUSUS"
                KodeJenisPermohonan = "5"
            Case "KEHORMATAN"
                KodeJenisPermohonan = "6"
            Case "ASING"
                KodeJenisPermohonan = "7"
        End Select

        '--- Tingkat (1 Huruf)
        Select Case Tingkat
            Case "BARU", "PEMULA"
                KodeTingkat = "H"
            Case "SIAGA"
                KodeTingkat = "D"
            Case "PENGGALANG"
                KodeTingkat = "C"
            Case "PENEGAK"
                KodeTingkat = "B"
        End Select

        '--- Bulan & Tahun
        Bulan = ConvertDigit(Date.Now.Month, 2)
        Tahun = Right(Date.Now.Year, 2)
        Dim NomorIAR As String = NomorUrutIAR & CallArea & KodeJenisPermohonan & KodeTingkat & Bulan & Tahun

        Return NomorIAR

    End Function

    Public Shared Function GetNomorIKRAP(ByVal ProsesID As String, ByVal NomorUrutIKRAP As String) As String

        Dim Tingkat As String = ""
        Dim Orda As String = ""
        Dim Organisasi As String = ""
        Dim CallArea As String = ""
        Dim Bulan As String = ""
        Dim Tahun As String = ""
        Dim JenisPermohonan As String = ""
        Dim KodeJenisPermohonan As String = ""
        Dim cn As New OleDbConnection(MyDataProses)

        Dim da2 As New OleDbDataAdapter(qSelectDataProses("*", ProsesID, "Rapi"), cn)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        With dt2
            Organisasi = .Rows(0)("Organisasi")
            Tingkat = .Rows(0)("Tingkat")
            Orda = .Rows(0)("RapiDaerahName")
            JenisPermohonan = .Rows(0)("JenisPermohonan")
        End With

        '--- Jenis Pemohonan ---
        Select Case JenisPermohonan
            Case "BARU"
                KodeJenisPermohonan = "1"
            Case "PERPANJANGAN"
                KodeJenisPermohonan = "2"
            Case "PEMBAHARUAN"
                KodeJenisPermohonan = "3"
            Case "KEHORMATAN"
                KodeJenisPermohonan = "4"
            Case "ASING"
                KodeJenisPermohonan = "5"
        End Select

        '--- Call Area (1 Digit)
        Dim da3 As New OleDbDataAdapter(qSelectCallAreaRapi("*", Orda), cn)
        Dim dt3 As New DataTable
        da3.Fill(dt3)
        With dt3
            CallArea = .Rows(0)("KodeIKRAP")
        End With

        '--- Bulan & Tahun
        Bulan = ConvertDigit(Date.Now.Month, 2)
        Tahun = Right(Date.Now.Year, 2)
        Dim NomorIKRAP As String = NomorUrutIKRAP & CallArea & KodeJenisPermohonan & Bulan & Tahun

        Return NomorIKRAP

    End Function

    Public Shared Function FindTingkat(ByVal ProsesID As String) As String

        Dim s As String = ""
        Dim Tingkat As String = ""
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectDataProses("Tingkat", ProsesID, "Orari"), cn)
            Dim dt As New DataTable
            da.Fill(dt)
            With dt
                s = .Rows(0)("Tingkat")
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function ConvertDate(ByVal Value As String) As String

        Dim s As String = ""
        Try
            If Len(Value) = 10 Then
                Dim Tanggal As String = Left(Value, 2)
                Dim Bulan As String = Mid(Value, 4, 2)
                Dim Tahun As String = Right(Value, 4)
                s = Bulan & "/" & Tanggal & "/" & Tahun
            Else
                s = "Format Tanggal Salah (Tanggal-Bulan-Tahun, contoh: 30-01-2010)"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function ConvertBulan(ByVal Value As String) As String

        Dim s As String = ""
        Try
            Select Case Value
                Case "1"
                    s = "Januari"
                Case "2"
                    s = "Pebruari"
                Case "3"
                    s = "Maret"
                Case "4"
                    s = "April"
                Case "5"
                    s = "Mei"
                Case "6"
                    s = "Juni"
                Case "7"
                    s = "Juli"
                Case "8"
                    s = "Agustus"
                Case "9"
                    s = "September"
                Case "10"
                    s = "Oktober"
                Case "11"
                    s = "Nopember"
                Case "12"
                    s = "Desember"
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function ConvertTingkat(ByVal Value As String) As String

        Dim s As String = ""
        Try
            Select Case UCase(Value)
                Case "PEMULA"
                    s = "Novice"
                Case "PENGGALANG"
                    s = "Advance"
                Case "SIAGA"
                    s = "General"
                Case "PENEGAK"
                    s = "Amateur Extra"
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function ConvertDigit(ByVal Value As String, ByVal Digit As Integer, Optional ByVal Character As String = "0") As String
        Dim s As String = ""
        Dim i As Integer = 0
        Try
            If Len(Value) < Digit Then
                For i = Len(Value) To Digit - 1
                    Value = Character & Value
                Next
            Else
                Value = Value
            End If
        Catch ex As Exception
            Value = ex.Message
        End Try
        Return Value
    End Function

End Class
