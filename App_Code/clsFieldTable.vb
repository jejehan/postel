Imports Microsoft.VisualBasic
Imports System

Public Class clsFieldTable

    Public Shared Function dbFileUpload() As String

        Dim s As String = ""
        Try
            s = "IDPermohonan,TypeFile,FileName,FileSize,Organisasi,DateUpload,UserIDUpload,Proses,DateProses,UserIDProses"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbDataPribadi() As String

        Dim s As String = ""
        Try
            s = "NRI,Organisasi,Nama,JenisKelamin,TempatLahir,TanggalLahir," & _
                "KodeAgama,Gol,ProsesUpdate,IDPermohonan,UserID,TanggalUpdate"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbDataAlamat() As String

        Dim s As String = ""
        Try
            s = "IDPermohonan,NRI,NomorKTP,Alamat,Kota,Provinsi,KodePos,Pekerjaan," & _
                "NomorTelepon,EMail,KodeOrgDaerah,KodeOrgLokal,UserID,TanggalUpdate"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbDataAnggota() As String

        Dim s As String = ""
        Try
            s = "IDPermohonan,NRI,CallSign,NomorUNAR,UPTPostelNama," & _
                "TingkatKecakapan,Hasil,TanggalUjian,NomorIAR,MasaBerlakuIAR," & _
                "NomorSKAR,TanggalTerbitSKAR,UserIDProses,UserIDSetuju," & _
                "UserIDCetak,TanggalProses,TanggalSetuju,TanggalCetak"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbDataBiaya() As String

        Dim s As String = ""
        Try
            s = "IDPermohonan,NRI,PeriodeTahun,TanggalBayar," & _
                "PNBP,Iuran,UangPangkal,Administrasi,PilihCS," & _
                "ValidasiBank,UserID,TanggalUpdate"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbPermohonan() As String

        Dim s As String = ""
        Try
            s = "LevelPermohonan,NRI,JenisPermohonan,Tingkat," & _
                "PilihCallSign,F1,F2,F3,F4,F5,F6,Foto,IAR,KTA,KTP,SKAR,SKCK,SKOT," & _
                "UserID,TanggalUpdate"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function dbUser() As String

        Dim s As String = ""
        Try
            s = "UserID,Nama,Password,Admin,Aktif,ORARI,RAPI "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

End Class
