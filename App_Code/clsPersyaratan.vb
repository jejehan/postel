Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports clsDataBase
Imports System

Public Class clsPersyaratan

    Public Shared Function CekPersyaratan(ByVal ProsesID As String, ByVal Company As String) As String

        Dim s As String = ""
        Try
            Dim Where As String = " WHERE (((DataProses.ProsesID)='" & Trim(ProsesID) & "'));"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectMemberProses(Where), cn)
            Dim dt As New DataTable
            da.Fill(dt)
            With dt
                '--- Persyaratan Umum ---
                If .Rows(0)("TanggalLahir") = "1/1/1900" Then
                    s = s & ",Tanggal Lahir"
                End If
                If .Rows(0)("NomorKTP") = "" Then
                    s = s & ",Nomor KTP"
                End If
                If .Rows(0)("JenisKelamin") = "" Then
                    s = s & ",Jenis Kelamin"
                End If
                If .Rows(0)("TempatLahir") = "" Then
                    s = s & ",Tempat Lahir"
                End If
                If .Rows(0)("Alamat") = "" Then
                    s = s & ",Alamat"
                End If
                If .Rows(0)("KodePos") = "" Then
                    s = s & ",Kode Pos"
                End If
                If .Rows(0)("Kota") = "" Then
                    s = s & ",Kota"
                End If
                If .Rows(0)("Provinsi") = "" Then
                    s = s & ",Provinsi"
                End If
                If .Rows(0)("Agama") = "" Then
                    s = s & ",Agama"
                End If
                If .Rows(0)("Gol") = "" Then
                    s = s & ",Golongan Darah"
                End If
                If .Rows(0)("FileFoto") = "" Then
                    s = s & ",File Foto"
                End If
                If .Rows(0)("UserTerimaBerkasAsli") = "" Then
                    s = s & ",User Terima Berkas Asli"
                End If
                If .Rows(0)("DateTerimaBerkasAsli") = "1/1/1900" Then
                    s = s & ",Tanggal Terima Berkas Asli"
                End If

                '--- Jika Callsign tidak kosong ---
                If .Rows(0)("Callsign") <> "" Then
                    If .Rows(0)("NomorSKAR") = "" Then
                        s = s & ",Nomor SKAR"
                    End If
                    If .Rows(0)("NomorIAR") = "" Then
                        s = s & ",Nomor IAR"
                    End If
                End If

                '--- Permohonan Baru ---
                If .Rows(0)("JenisPermohonan") = "BARU" Then
                    If .Rows(0)("NomorSKAR") = "" Then '--- Belum Ujian UNAR
                        If .Rows(0)("NomorUNAR") = "" Then
                            s = s & ",Nomor UNAR"
                        ElseIf .Rows(0)("TanggalUNAR") = "1/1/1900" Then
                            s = s & ",Tanggal UNAR"
                        End If
                    End If
                End If

                '--- Permohonan Naik Tingkat ---
                If .Rows(0)("JenisPermohonan") = "NAIK TINGKAT" Then
                    If .Rows(0)("Callsign") = "" Then
                        s = s & ",Call Sign"
                    End If
                    If .Rows(0)("NomorSKAR") = "" Then
                        s = s & ",Nomor SKAR"
                    End If
                    If .Rows(0)("NomorIAR") = "" Then
                        s = s & ",Nomor IAR"
                    End If
                End If

            End With

        Catch ex As Exception
            s = ex.Message
        End Try

        Return s


    End Function
End Class
