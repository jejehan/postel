Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Security.Cryptography
Imports System.Drawing
Imports System.Drawing.Imaging
Imports clsFieldTable
Imports clsGeneral
Imports System.Configuration
Imports System.Web.UI
Imports System.Collections
Imports System.Web.UI.WebControls

'====================================================================
' Class Name        : clsDatabase
' Project Name      : Dirjen Pos & Telekomunikasi Republik Indonesia
' Application Name  : Aplikasi Tata Kelola Amatir Radio dan KRAP
' Author Name       : Cahya Darmawan
' Date Create       : January 1, 2011
' Last Update       : January 22, 2011
'====================================================================
Public Class clsDataBase

#Region "--- Connection String ---"
    '----------------------------------------------------------
    ' Database digunakan untuk menyimpan data yang sudah FINAL 
    '----------------------------------------------------------
    Public Shared Function MyDatabase() As String
        Dim s As String = ""
        Dim Database As String = ""
        Try
            Database = ConfigurationManager.AppSettings("Database")
            s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Database & ";User Id=;Jet OLEDB:Database Password=p05t3l"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '--------------------------------------------------------------------------------------- 
    ' Dataproses digunakan untuk menyimpan data sementara yang masih diproses.
    ' Jika semua proses sudah selesai maka data akan disimpan di file: Database dan Datalog
    '---------------------------------------------------------------------------------------
    Public Shared Function MyDataProses() As String
        Dim s As String = ""
        Dim DataProses As String = ""
        Try
            DataProses = ConfigurationManager.AppSettings("DataProses")
            s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataProses & ";User Id=;Jet OLEDB:Database Password="
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    '----------------------------------------------------------------
    ' Datalog digunakan untuk menyimpan semua yang bersifat history.
    '----------------------------------------------------------------
    Public Shared Function MyDatalog() As String
        Dim s As String = ""
        Dim Database As String = ""
        Try
            Database = ConfigurationManager.AppSettings("Datalog")
            s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Database & ";User Id=;Jet OLEDB:Database Password=p05t3l"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function MyExcelNewHeader(ByVal FileName As String) As String
        Dim s As String = ""
        Try
            s = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Data Source=" & FileName & ";" & _
                "Extended Properties=""Excel 12.0;HDR=YES"";"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "--- Table Master ---"

    Public Shared Function qFindListUPT() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT * FROM [mstUPT] ORDER BY Kota"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qFindKodeAgama(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT ID FROM [mstAgama] WHERE Agama = '{0}'", Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            s = dt.Rows(0)("ID")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectCallArea(ByVal NamaField As String, ByVal OrdaCode As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT {0} FROM [mstOrariDaerah] WHERE Kode = '{1}'", NamaField, OrdaCode)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectCallAreaRapi(ByVal NamaField As String, ByVal RapiDaerah As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT {0} FROM [mstRapiDaerah] WHERE Nama = '{1}'", NamaField, RapiDaerah)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindKodeOrariDaerah(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT Kode FROM [mstOrariDaerah] WHERE Nama = '{0}'", Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("Kode")
            Else
                s = "0"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindDistintOrariDaerah() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT DISTINCT(OrdaName), OrdaCode from DATAPROSES ORDER BY OrdaName"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qFindListOrariLokal(ByVal Orda As String) As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT * FROM [mstOrariLokal] WHERE Orda='{0}' ", Orda)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qFindKodeOrariLokal(ByVal Orda As String, ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT Kode FROM [mstOrariLokal] WHERE Orda='{0}' AND Nama='{1}'", Orda, Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("Kode")
            Else
                s = "0"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindListOrariDaerah() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT * FROM [mstOrariDaerah] ORDER BY Nama"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qFindListRapiDaerah() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT * FROM [mstRapiDaerah]"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qFindKodeRapiDaerah(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT KodeIKRAP FROM [mstRapiDaerah] WHERE Nama = '{0}'", Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            s = dt.Rows(0)("KodeIKRAP")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindDistintRapiDaerah() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT DISTINCT(RapiDaerahName), RapiDaerahCode from DATAPROSES ORDER BY RapiDaerahName"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

#End Region

#Region "--- Delete Row ---"

    Public Shared Function qDeleteTemp(ByVal Table As String, ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [{0}] SET ProsesData = No WHERE {1}", Table, Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qDelete(ByVal Table As String, ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("DELETE FROM [{0}] WHERE {1}", Table, Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "--- Halaman Pengaturan ---"

    Public Shared Function qSelectUserPassword() As String
        Dim s As String = ""
        Try
            s = "SELECT * FROM [UserLogin] "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateDataEmail(ByVal Company As String, ByVal EmailFrom As String, _
                                             ByVal EmailTo As String, ByVal EmailCc As String, _
                                             ByVal EmailSubject As String, ByVal EmailBody As String, _
                                             ByVal ModifiedBy As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [mstEmail] SET EmailFrom='{0}',EmailTo='{1}',EmailCc='{2}',EmailSubject='{3}',EmailBody='{4}',ModifiedBy='{5}',ModifiedDate=#{6}# WHERE Company='{7}'", EmailFrom, EmailTo, EmailCc, EmailSubject, EmailBody, ModifiedBy, Date.Now, Company)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "--- Halaman Import File ---"

    Public Shared Function GetListFile(ByVal Where As String) As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectFiles(Where), cn)
            da.Fill(dt)
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

    Public Shared Function qSelectFileExcel() As String
        Dim s As String = ""
        Try
            s = "SELECT * FROM [Files] "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function InsertFileToDB(ByVal strGroupID As String, ByVal strFileUpload As String, ByVal strFileSize As String, _
                                   ByVal TypeFile As String, ByVal UserIDUpload As String, _
                                   ByVal Organisasi As String, ByVal Proses As String) As String
        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim cmd As New OleDbCommand
            With cmd
                .CommandText = qInsertFilesUpload(strGroupID, strFileUpload, TypeFile, CStr(CInt(strFileSize / 1024)), UserIDUpload, Organisasi, "")
                .Connection = cn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
                .Dispose()
            End With
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qSelectFiles(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [Files] {0} ORDER BY DateProses DESC ", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertFilesUpload(ByVal GroupID As String, ByVal FileName As String, ByVal TypeFile As String, _
                                        ByVal FileSize As String, ByVal UserIDUpload As String, _
                                        ByVal Organisasi As String, ByVal UserIDProses As String) As String
        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [Files] (GroupID,TypeFile,FileName,FileSize,Organisasi,DateUpload,UserIDUpload,Proses,DateProses,UserIDProses) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',0,'1/1/1900','{7}')", GroupID, TypeFile, FileName, FileSize, Organisasi, Date.Now, UserIDUpload, UserIDProses)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertFilesUploadLog(ByVal GroupID As String, ByVal FileName As String, ByVal TypeFile As String, _
                                        ByVal FileSize As String, ByVal UserIDUpload As String, _
                                        ByVal Organisasi As String, ByVal UserIDProses As String) As String
        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataLog] (GroupID,TypeFile,FileName,FileSize,Organisasi,DateUpload,UserIDUpload,Proses,DateProses,UserIDProses) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',0,'1/1/1900','{7}')", GroupID, TypeFile, FileName, FileSize, Organisasi, Date.Now, UserIDUpload, UserIDProses)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateFile(ByVal FileName As String, ByVal UserIDProses As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [Files] SET Proses = '1',UserIDProses = '{0}',DateProses = #{1}# WHERE FileName = '{2}'", UserIDProses, Date.Now, FileName)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qDisableFile(ByVal GroupID As String, ByVal Status As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [Files] SET Proses = {0} WHERE GroupID = '{1}'", Status, GroupID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateFileFoto(ByVal FileName As String, ByVal ProsesID As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET FileFoto = '{0}' WHERE ProsesID = '{1}'", FileName, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qGetLatestProsesID() As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT Nomor FROM [NomorUrut] WHERE TypeData='ProsesID' "
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("Nomor")
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindFileProses(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT Proses FROM [Files] WHERE FileName = '{0}'", Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("Proses")
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "--- Halaman Persetujuan ---"

    Public Shared Function qSaveImageToDB(ByRef FileFoto As String, ByVal ProsesID As String, ByVal NamaTable As String) As Boolean
        Dim s As String = ""
        Try
            Dim DataProses As String = ""
            Dim conn As New OleDbConnection
            Dim cmd As OleDbCommand
            DataProses = ConfigurationManager.AppSettings("DataProses")
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataProses & ";User Id=;Jet OLEDB:Database Password="
            conn.Open()

            cmd = conn.CreateCommand()
            Select Case NamaTable
                Case "DataSKAR"
                    cmd.CommandText = String.Format("UPDATE {0} SET FileFotoBitmap=@FileFotoBitmap WHERE ProsesID='{1}'", NamaTable, ProsesID)
                Case "DataIAR"
                    cmd.CommandText = String.Format("UPDATE {0} SET FileFotoBitmap=@FileFotoBitmap WHERE ProsesID='{1}'", NamaTable, ProsesID)
                Case "DataIARKhusus"
                    cmd.CommandText = String.Format("UPDATE {0} SET FileFotoBitmap=@FileFotoBitmap WHERE ProsesID='{1}'", NamaTable, ProsesID)
                Case "DataIKRAP"
                    cmd.CommandText = String.Format("UPDATE {0} SET FileFotoBitmap=@FileFotoBitmap WHERE ProsesID='{1}'", NamaTable, ProsesID)
            End Select
            Try
                '--- Insert File Foto to DB ---
                Dim imgByteArrayFoto() As Byte
                Dim streamFoto As New MemoryStream
                Dim bmpFoto As New Bitmap(FileFoto)
                bmpFoto.Save(streamFoto, ImageFormat.Jpeg)
                imgByteArrayFoto = streamFoto.ToArray()
                streamFoto.Close()
                cmd.Parameters.AddWithValue("@FileFotoBitmap", imgByteArrayFoto)
                If DirectCast(cmd.ExecuteNonQuery(), Integer) > 0 Then
                    Return True
                End If
            Catch ex As Exception
                s = ex.Message
                Return False
            End Try

            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            s = ex.Message
            Return False
        End Try
    End Function

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
                    'MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
            End If

            reader.Close()
            conn.Close()

            cmd.Dispose()
            conn.Dispose()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        Return Nothing

    End Function

#End Region

#Region "--- Halaman File Export ---"

    Public Shared Function qSelectFilesExport(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [FilesExport] {0} ORDER BY DateUpload DESC ", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertFilesExport(ByVal GroupID As String, ByVal TypeFile As String, _
                                              ByVal FileName As String, ByVal Organisasi As String, _
                                              ByVal UserIDUpload As String, ByVal TypeData As String) As String
        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [FilesExport] (GroupID,TypeFile,TypeData,FileName,Organisasi,DateUpload,UserIDUpload) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", GroupID, TypeFile, TypeData, FileName, Organisasi, Date.Now, UserIDUpload)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateFileExport(ByVal FileName As String, ByVal UserIDProses As String) As String

        Dim s As String = ""
        Try
            s = "UPDATE [FilesExport] SET SendMail = Yes, UserIDProses = '" & UserIDProses & "'," & _
                "DateProses = #" & Date.Now & "# WHERE FileName = '" & FileName & "'"
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qSelectSendEmail(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [mstEmail] {0}", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "--- Table Proses ---"

    Public Shared Function qSelectDataProses(ByVal NamaField As String, ByVal ProsesID As String, ByVal Organisasi As String) As String

        Dim s As String = ""
        Try
            s = String.Format("SELECT {0} FROM [DataProses] WHERE ProsesID = '{1}' AND Organisasi='{2}' ", NamaField, ProsesID, Organisasi)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qInsertDataProses(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataProses] (GroupID,ProsesID,ProsesLevel,Organisasi,Callsign,CallsignLama,Nama,NamaKartu,NRI,NomorKTP,JenisKelamin,TempatLahir,TanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu,Alamat3Kartu,KodePos,Kota,Provinsi,Agama,Gol,Pekerjaan,NomorTelepon,EMail,OrdaCode,OrdaName,OrlokCode,OrlokName,RapiDaerahCode,RapiDaerahName,JenisPermohonan,Tingkat,NomorUNAR,TanggalUNAR,LokasiUNAR,HasilUNAR,NomorSKAR,TanggalTerbitSKAR,NomorIAR,MasaBerlakuIAR,NomorIKRAP,MasaBerlakuIKRAP,ValidasiBank,TanggalBayar,PNBP,FileFoto,ProsesData) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateProsesID(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [NomorUrut] SET Nomor='{0}' WHERE TypeData='PROSESID' ", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataLama(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataLama] (GroupID,ProsesID,Organisasi,Callsign,NomorSKAR,NomorIAR,NomorIKRAP,UserUpdate,DateUpdate) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateDataHasilUNAR(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataProses] (GroupID,ProsesID,ProsesLevel,Organisasi,Callsign,CallsignLama,Nama,NamaKartu,NRI,NomorKTP,JenisKelamin,TempatLahir,TanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu,Alamat3Kartu,KodePos,Kota,Provinsi,Agama,Gol,Pekerjaan,NomorTelepon,EMail,OrdaCode,OrdaName,OrlokCode,OrlokName,RapiDaerahCode,RapiDaerahName,JenisPermohonan,Tingkat,NomorUNAR,TanggalUNAR,LokasiUNAR,HasilUNAR,NomorSKAR,TanggalTerbitSKAR,NomorIAR,MasaBerlakuIAR,NomorIKRAP,MasaBerlakuIKRAP,ValidasiBank,TanggalBayar,PNBP,FileFoto,ProsesData) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "Insert Data to Print"

    Public Shared Function qInsertDataSKAR(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataSKAR] (GroupID,ProsesID,Nama,TempatTanggalLahir,Alamat,Tingkat,TanggalUNAR,LokasiUNAR,NomorSKAR,TanggalSKAR,FileFoto,CallSign,Orda) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataIAR(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataIAR] (GroupID,ProsesID,Nama,Tingkat,Class,CallSign,Alamat1,Alamat2,Alamat3,TanggalBerlakuIAR,NomorIAR,FileFoto,Orda) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataIARSemua() As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataIARSemua] SELECT * FROM [DataIAR]")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataIKRAP(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataIKRAP] (GroupID,ProsesID,Nama,CallSign,Alamat1,Alamat2,Alamat3,TanggalBerlakuIKRAP,NomorIKRAP,FileFoto,RapiDaerah) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataIKRAPSemua() As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataIKRAPSemua] SELECT * FROM [DataIKRAP]")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qInsertDataProses2(ByVal Field As String, ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataProses] ({0}) VALUES ({1})", Field, Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qDeleteDataProses(ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("DELETE FROM [DataProses] WHERE ProsesID='{0}'", ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateDataProses(ByVal ProsesID As String, ByVal ProsesLevel As String, _
                                             Optional ByVal FileName As String = "") As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET ProsesLevel='{0}' WHERE ProsesID='{1}'", ProsesLevel, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataProsesTinjauData(ByVal ProsesLevel As String, ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET ProsesLevel='{0}' WHERE ProsesID='{1}'", ProsesLevel, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataErrorTinjauData(ByVal ProsesData As String, ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET ProsesData={0} WHERE ProsesID='{1}'", ProsesData, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataIAR(ByVal NomorIAR As String, ByVal ProsesID As String, Optional ByVal MasaBerlakuIAR As String = "1/1/1900") As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET NomorIAR='{0}', MasaBerlakuIAR='{1}' WHERE ProsesID='{2}'", NomorIAR, MasaBerlakuIAR, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataIKRAP(ByVal NomorIKRAP As String, ByVal ProsesID As String, Optional ByVal MasaBerlakuIKRAP As String = "1/1/1900") As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET NomorIKRAP='{0}', MasaBerlakuIKRAP=#{1}# WHERE ProsesID='{2}'", NomorIKRAP, MasaBerlakuIKRAP, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataUNAR(ByVal HasilUNAR As String, ByVal NomorSKAR As String, _
                                            ByVal ProsesLevel As String, ByVal ProsesID As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET HasilUNAR='{0}',NomorSKAR='{1}',TanggalTerbitSKAR=#{2}#,ProsesLevel='{3}' WHERE ProsesID='{4}'", HasilUNAR, NomorSKAR, Date.Now, ProsesLevel, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "Data Log"

    Public Shared Function qInsertDataLog(ByVal Field As String, ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataLog] ({0}) VALUES ({1})", Field, Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataLog(ByVal Tahapan As String, ByVal FieldName As String, ByVal UserName As String, _
                                             ByVal FieldDate As String, ByVal ProsesID As String, _
                                             Optional ByVal FileName As String = "") As String
        Dim s As String = ""
        Dim ProsesKirim As String = ""
        Try
            s = String.Format("UPDATE [DataLog] SET Tahapan='{0}',{1}='{2}',{3}=#{4}#  WHERE ProsesID='{5}'", Tahapan, FieldName, UserName, FieldDate, Date.Now, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qDeleteDataLog(ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("DELETE FROM [DataLog] WHERE ProsesID='{0}'", ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "Nomor SKAR & IAR"

    Public Shared Function qSelectNomorIAR(ByVal ProsesID As String) As String

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT * FROM [DataProses] WHERE ProsesID='{0}'", ProsesID)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = dt.Rows(0)("NomorIAR")
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateSKARNumber(ByVal HasilUNAR As String, ByVal ProsesID As String, ByVal Organisasi As String, _
                           ByVal UserID As String, ByVal ProsesLevel As String) As String

        Dim s As String = ""
        Dim Where As String = ""
        Dim NomorUrutSKAR As String = ""
        Dim NomorSKAR As String = ""
        Dim Tingkat As String = ""
        Dim Bulan As String = ""
        Try
            NomorUrutSKAR = InsertSKARNumber(Organisasi, ProsesID, UserID)
            NomorSKAR = GetNomorSKAR(ProsesID, NomorUrutSKAR)
            s = qUpdateDataUNAR("LULUS", NomorSKAR, ProsesLevel + 1, ProsesID)
            s = InsertDataProcess(s)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return NomorSKAR

    End Function

    Public Shared Function qGetMasaBerlakuIAR(ByVal tingkat As String) As String

        Dim s As String = ""
        Dim TahunTingkat As Integer = 0
        Try
            Select Case tingkat
                Case "ASING"
                    TahunTingkat = 1
                Case "BARU", "PEMULA"
                    TahunTingkat = 2
                Case "SIAGA"
                    TahunTingkat = 3
                Case "PENGGALANG", "PENEGAK", "KEHORMATAN"
                    TahunTingkat = 5
            End Select
        Catch ex As Exception
            s = ex.Message
        End Try
        s = String.Format("{0}/{1}/{2}", ConvertDigit(Date.Now.Day.ToString, 2), ConvertDigit(Date.Now.Month.ToString, 2), Date.Now.Year + TahunTingkat)

        Return s

    End Function

    Public Shared Function qGetMasaBerlakuIKRAP() As String

        Dim s As String = ""
        Dim TahunTingkat As Integer = 0
        Try
            s = String.Format("{0}/{1}/{2}", ConvertDigit(Date.Now.Day.ToString, 2), ConvertDigit(Date.Now.Month.ToString, 2), Date.Now.Year + 5)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "--- Find Data ---"

    

    Public Shared Function qFindIDPermohonan(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = String.Format("SELECT IDPermohonan FROM [Permohonan] WHERE NRI = '{0}' ORDER BY IDPermohonan", Value)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            s = dt.Rows(0)("IDPermohonan")
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindNRI(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            s = String.Format("SELECT * FROM [DataAnggota] WHERE NRI = '{0}'", Value)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = "1"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qFindKota(ByVal Value As String) As String
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            s = String.Format("SELECT * FROM [DataAnggota] WHERE NRI = '{0}'", Value)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                s = "1"
            End If
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    

    
#End Region

#Region "--- View Data ---"

    Public Shared Function qSelectAllMember(ByVal TableName As String, ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM {0} {1} ORDER BY DateUpdate DESC, Nama ASC", TableName, Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectAllMemberKhusus(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM DataIARKhusus {1} ORDER BY DateUpdate DESC, Nama ASC", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectMemberDetail(ByVal TableName As String, ByVal Where As String) As DataTable
        Dim s As String = ""
        Dim dt As DataTable = Nothing
        Try
            s = String.Format("SELECT * FROM {0} {1} ", TableName, Where)
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qSelectMemberProses(ByVal Where As String, Optional ByVal ProsesLevel As String = "") As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [DataProses] {0} ORDER BY ProsesData", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectDataLog(ByVal Where As String, Optional ByVal ProsesLevel As String = "") As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT p.GroupID,p.ProsesID, p.Organisasi, p.Callsign, p.Nama, " & _
                              "p.OrdaName, p.OrlokName, p.RapiDaerahName, p.JenisPermohonan, p.Tingkat, " & _
                              "p.NomorUNAR, p.HasilUNAR, p.NomorSKAR, p.TanggalTerbitSKAR, " & _
                              "p.NomorIAR, p.MasaBerlakuIAR, p.NomorIKRAP, p.MasaBerlakuIKRAP, " & _
                              "l.Tahapan, l.UserProses, l.DateProses, " & _
                              "l.UserTinjauData, l.DateTinjauData, l.UserPersetujuan, " & _
                              "l.DatePersetujuan, l.UserHasilUNAR, l.DateHasilUNAR, l.UserNomor, " & _
                              "l.DateNomor, l.UserPrint, l.DatePrint, l.DateKirimKeOrganisasi, " & _
                              "l.ProsesKirimKeOrganisasi, l.NamaFileOrganisasi, l.UserTerimaBerkasAsli, " & _
                              "l.DateTerimaBerkasAsli, l.KirimFile, l.NamaFile, p.ProsesData, p.ProsesLevel " & _
                              "FROM DataProses p LEFT JOIN DataLog l ON p.ProsesID=l.ProsesID {0}", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectDataSyarat(ByVal ProsesID As String, ByVal Organisasi As String, ByVal JenisPermohonan As String, ByVal MenuAwal As String) As String
        Dim s As String = ""
        Dim Query As String = ""
        Dim dt As New DataTable

        Try
            Query = String.Format("SELECT * FROM [DataProses] WHERE ProsesID='{0}' AND Organisasi='{1}' ", ProsesID, Organisasi)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(Query, cn)
            da.Fill(dt)
            '--- Persyaratan Umum ---
            With dt
                If .Rows.Count > 0 Then
                    JenisPermohonan = .Rows(0)("JenisPermohonan")
                    If .Rows(0)("NamaKartu") = "" Then s = s & "Nama Kartu,"
                    If .Rows(0)("Alamat1Kartu") = "" Then s = s & "Alamat1Kartu,"
                    If MenuAwal <> "SKAR" Then
                        If .Rows(0)("Alamat2Kartu") = "" Then s = s & "Alamat2Kartu,"
                    End If
                    If .Rows(0)("TempatLahir") = "" Then s = s & "Tempat Lahir,"
                    If .Rows(0)("TanggalLahir") = "1/1/1900" Then s = s & "Tanggal Lahir,"
                    'If .Rows(0)("NomorKTP") = "" Then s = s & "Nomor KTP,"
                    'If .Rows(0)("Alamat") = "" Then s = s & "Alamat,"
                    'If .Rows(0)("Provinsi") = "" Then s = s & "Provinsi,"
                    If .Rows(0)("FileFoto") = "" Then s = s & "File Foto,"
                    Dim FileFoto As String = dt.Rows(0)("FileFoto")
                    If Organisasi = "Orari" Then
                        If .Rows(0)("Tingkat") = "" Then s = s & "Tingkat,"
                        If .Rows(0)("OrdaCode") = "0" Then s = s & "Kode Orda Tidak Ketemu,"
                        If .Rows(0)("OrdaName") = "" Then s = s & "Nama Orda,"
                        If MenuAwal = "SKAR" Then
                            If .Rows(0)("NomorUNAR") = "" Then s = s & "Nomor UNAR,"
                            If .Rows(0)("TanggalUNAR") = "1/1/1900" Then s = s & "Tanggal UNAR,"
                            If .Rows(0)("LokasiUNAR") = "" Then s = s & "Lokasi UNAR,"
                            'If JenisPermohonan = "NAIK TINGKAT" Then
                            '    If .Rows(0)("CallSignLama") = "" Then s = s & "Call Sign,"
                            '    'If .Rows(0)("NomorIAR") = "" Then s = s & "Nomor IAR,"
                            '    'If .Rows(0)("MasaBerlakuIAR") = "1/1/1900" Then s = s & "Masa Berlaku IAR,"
                            'End If
                        Else '--- Urus IAR kemungkinan: "PEMBAHARUAN", "HILANG", "RUSAK", "MUTASI", "GANTI", "PILIH CALLSIGN", "SEUMUR HIDUP"
                            'If JenisPermohonan = "BARU" Then
                            '    'If .Rows(0)("NomorSKAR") = "" Then s = s & "Nomor SKAR,"
                            '    'If .Rows(0)("TanggalTerbitSKAR") = "1/1/1900" Then s = s & "TanggalTerbitSKAR,"
                            'Else
                            '    'If .Rows(0)("NomorIAR") = "" Then s = s & "Nomor IAR,"
                            '    'If .Rows(0)("MasaBerlakuIAR") = "1/1/1900" Then s = s & "Masa Berlaku IAR,"
                            'End If
                        End If
                    Else '--- RAPI
                        If .Rows(0)("RapiDaerahCode") = "0" Then s = s & "Kode Rapi Daerah Tidak Ketemu,"
                        If .Rows(0)("RapiDaerahName") = "" Then s = s & "Nama Rapi Daerah,"
                        'If JenisPermohonan <> "BARU" Then
                        '    If .Rows(0)("CallSignLama") = "" Then s = s & "Call Sign,"
                        '    'If .Rows(0)("NomorIKRAP") = "" Then s = s & "Nomor IKRAP,"
                        '    'If .Rows(0)("MasaBerlakuIKRAP") = "1/1/1900" Then s = s & "Masa Berlaku IKRAP,"
                        'End If
                    End If
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateDataError(ByVal ProsesID As String, ByVal Organisasi As String, ByVal UpdateProses As String) As String
        Dim s As String = ""
        Dim dt As New DataTable

        Try
            s = String.Format("UPDATE [DataProses] SET ProsesData={0} WHERE ProsesID='{1}' AND Organisasi='{2}' ", UpdateProses, ProsesID, Organisasi)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectMemberExport(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM DataProses {0}", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectMemberExportKhusus(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM DataProsesKhusus {0}", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Shared Function ViewDatabase(ByVal Query As String) As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(Query, cn)
            da.Fill(dt)
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

    Shared Function ViewDataProses(ByVal Query As String) As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(Query, cn)
            da.Fill(dt)
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

#End Region

#Region "--- Pengaturan ---"

    Public Shared Function qInsertUserLogin(ByVal UserID As String, ByVal Nama As String, _
                                        ByVal eMail As String, ByVal KataSandi As String, _
                                        ByVal Admin As String, ByVal Aktif As String, _
                                        ByVal ORARI As String, ByVal RAPI As String, _
                                        ByVal UserIDCreate As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [UserLogin] (UserID,Nama,eMail,KataSandi,Admin,Aktif,ORARI,RAPI,UserIDCreate,UserIDUpdate) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", UserID, Nama, eMail, KataSandi, Admin, Aktif, ORARI, RAPI, UserIDCreate, UserIDCreate)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateUserLogin(ByVal UserID As String, ByVal Nama As String, _
                                        ByVal eMail As String, ByVal KataSandi As String, _
                                        ByVal Admin As String, ByVal Aktif As String, _
                                        ByVal ORARI As String, _
                                        ByVal RAPI As String, ByVal UserIDUpdate As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [UserLogin] SET Nama = '{0}', eMail = '{1}', KataSandi = '{2}', Admin = '{3}', Aktif = '{4}', ORARI = '{5}', RAPI = '{6}', UserIDUpdate = '{7}', DateUpdate = #{8}# WHERE UserID = '{9}'", Nama, eMail, KataSandi, Admin, Aktif, ORARI, RAPI, UserIDUpdate, Date.Now, UserID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateUserPassword(ByVal UserID As String, ByVal KataSandi As String, _
                                               ByVal UserIDUpdate As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [UserLogin] SET KataSandi = '{0}', UserIDUpdate = '{1}', DateUpdate = #{2}# WHERE UserID = '{3}'", KataSandi, UserIDUpdate, Date.Now, UserID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "--- String to Access Database ---"

    Public Shared Function InsertDataBase(ByVal Value As String) As String

        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            Dim cmd As New OleDbCommand
            With cmd
                .Parameters.Clear()
                .CommandText = Value
                .Connection = cn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
                .Dispose()
            End With
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function InsertDataProcess(ByVal Value As String) As String

        Dim s As String = ""
        Dim Row As Integer = 0
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim cmd As New OleDbCommand
            With cmd
                .Parameters.Clear()
                .CommandText = Value
                .Connection = cn
                .Connection.Open()
                Row = cmd.ExecuteNonQuery()
                If Row = 0 Then
                    s = "Failed"
                End If
                .Connection.Close()
                .Dispose()
            End With
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function InsertDataSKAR(ByVal Value As String) As String

        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim cmd As New OleDbCommand
            With cmd
                .Parameters.Clear()
                .CommandText = Value
                .Connection = cn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
                .Dispose()
            End With
            cn.Dispose()
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "SKAR Number"
    Public Shared Function InsertSKARNumber(ByVal Organisasi As String, ByVal ProsesID As String, ByVal UserID As String) As String

        Dim s As String
        Dim NomorAkhir As String = ""
        Dim NomorUrutSKAR As String = ""
        Dim dt As New DataTable
        Try
            NomorAkhir = "SELECT Nomor FROM [NomorUrut] WHERE TypeData='SKAR'"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(NomorAkhir, cn)
            da.Fill(dt)
            With dt
                NomorUrutSKAR = .Rows(0)("Nomor") + 1
            End With
            s = String.Format("UPDATE [NomorUrut] SET Nomor='{0}',DateCreate=#{1}#,UserCreate='{2}' WHERE TypeData='SKAR'", NomorUrutSKAR, Date.Now, UserID)
            s = InsertDataProcess(s)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return NomorUrutSKAR

    End Function

    Public Shared Function PrintSKARNumber(ByVal Values As String) As String

        Dim s As String
        Try
            s = String.Format("INSERT INTO [DataSKAR] (GroupID,ProsesID,ProsesLevel,Organisasi,Nama,NamaKartu,TempatLahir,TanggalLahir,Alamat,Alamat1Kartu,Alamat2Kartu,Alamat3Kartu,Tingkat,NomorSKAR,TanggalTerbitSKAR) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function
#End Region

#Region "IAR Number"

    Public Shared Function InsertIARNumber(ByVal Organisasi As String, ByVal ProsesID As String, ByVal UserID As String) As String

        Dim s As String
        Dim NomorAkhir As String = ""
        Dim NomorUrutIAR As String = ""
        Try
            NomorAkhir = "SELECT NomorUrut FROM [NomorIAR] ORDER BY NomorUrut DESC"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(NomorAkhir, cn)
            Dim dt As New DataTable
            da.Fill(dt)
            With dt
                NomorUrutIAR = .Rows(0)("NomorUrut") + 1
            End With
            s = String.Format("UPDATE [NomorUrut] SET Nomor='{0}',DateCreate=#{1}#,UserCreate='{2}' WHERE TypeData='IAR'", NomorUrutIAR, Date.Now, UserID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return NomorUrutIAR

    End Function

#End Region

#Region "CallSign"

    Public Shared Function CekCallSign(ByVal CallSign As String, ByVal Type As String) As String

        Dim s As String = ""
        Dim qCallSign As String
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Try
            Select Case Type
                Case "IAR"
                    '--- Check Data Anggota Orari Lama ---
                    qCallSign = "SELECT * FROM [DataIAR] WHERE CallSign ='" & CallSign & "'"
                    Dim cn As New OleDbConnection(MyDatabase)
                    Dim da As New OleDbDataAdapter(qCallSign, cn)
                    da.Fill(dt)
                    With dt
                        If .Rows.Count > 0 Then
                            s = .Rows(0)("NomorIAR")
                        End If
                    End With
                Case "IKRAP"
                    '--- Check Data Anggota RAPI Lama ---
                    qCallSign = "SELECT * FROM [DataIKRAP] WHERE CallSign ='" & CallSign & "'"
                    Dim cn2 As New OleDbConnection(MyDatabase)
                    Dim da2 As New OleDbDataAdapter(qCallSign, cn2)
                    da2.Fill(dt2)
                    With dt2
                        If .Rows.Count > 0 Then
                            s = .Rows(0)("NomorIKRAP")
                        End If
                    End With
            End Select

            '--- Check Data Anggota Baru ---
            'qCallSign1 = "SELECT * FROM [DataProses] WHERE CallSign ='" & CallSign & "'"
            'Dim cn1 As New OleDbConnection(MyDataProses)
            'Dim da1 As New OleDbDataAdapter(qCallSign1, cn1)
            'da1.Fill(dt1)
            'With dt1
            '    If .Rows.Count > 0 Then
            '        If Type = "IAR" Then
            '            s = .Rows(0)("NomorIAR")
            '        Else
            '            s = .Rows(0)("NomorIKRAP")
            '        End If
            '    End If
            'End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function getCSSuffix(ByVal KodeOrda_Tingkat As String, ByVal Seq As String) As DataTable

        Dim s As String = ""
        Dim dt As New DataTable
        Try
            Dim Query As String = "SELECT * FROM [nomorcallsignsuffix] WHERE KodeOrda_Tingkat ='" & KodeOrda_Tingkat & _
                                        "' AND Seq='" & Seq & "'"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(Query, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt

    End Function

#End Region

#Region "DataSKAR"

    Public Shared Function qFindDataSKAR() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT * FROM [DataSKAR]"
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qDeleteDataSKAR(ByVal NomorSKAR As String) As String
        Dim s As String = ""
        Try
            s = "DELETE FROM [DataSKAR] WHERE NomorSKAR='" & NomorSKAR & "' "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

#End Region

#Region "DataIAR"

    Public Shared Function qFindDataIAR(Optional ByVal Tingkat As String = "") As DataTable
        Dim s As String = ""
        Dim Where As String = ""
        Dim dt As New DataTable
        Try
            If Tingkat <> "" Then
                Where = " WHERE Tingkat='" & Tingkat & "' "
            End If
            s = "SELECT * FROM [DataIAR] " & Where
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qDeleteDataIAR(ByVal CallSign As String) As String
        Dim s As String = ""
        Try
            s = "DELETE FROM [DataProses] WHERE CallSign='" & CallSign & "' "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "DataIKRAP"

    Public Shared Function qFindDataIKRAP() As DataTable
        Dim s As String = ""
        Dim dt As New DataTable
        Try
            s = "SELECT * FROM [DataIKRAP] "
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qDeleteDataIKRAP(ByVal CallSign As String) As String
        Dim s As String = ""
        Try
            s = "DELETE FROM [DataIKRAP] WHERE CallSign='" & CallSign & "' "
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region


#Region "HasilUNAR"

    Public Shared Function qInsertHasilUNAR(ByVal ProsesID As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO HasilUNAR (GroupID,ProsesID,Tingkat,NomorUNAR,Nama,LokasiUNAR,Orda,Orlok) SELECT GroupID, ProsesID,Tingkat,NomorUNAR,Nama,LokasiUNAR,OrdaName,OrlokName FROM DataProses WHERE ProsesID='{0}'", ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qSelectHasilUNAR() As DataTable

        Dim dt As New DataTable
        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDataProses)
            s = "SELECT * FROM [HasilUNAR]"
            Dim da As New OleDbDataAdapter(s, cn)
            da.Fill(dt)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return dt
    End Function

    Public Shared Function qUpdateHasilUNAR(ByVal NomorUNAR As String, ByVal Jumlah As String, _
                                        ByVal Hasil As String, ByVal UserIDUpdate As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [HasilUNAR] SET Jumlah = '{0}', Hasil = '{1}', UserIDUpdate = '{2}' WHERE NomorUNAR = '{3}'", Jumlah, Hasil, UserIDUpdate, NomorUNAR)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataProsesHasilUNAR(ByVal NomorUNAR As String, ByVal HasilUNAR As String) As String

        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProses] SET HasilUNAR = '{0}' WHERE NomorUNAR = '{1}'", HasilUNAR, NomorUNAR)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qDeleteHasilUNAR(ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("DELETE FROM [HasilUNAR] WHERE ProsesID='{0}'", ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region

#Region "IAR Khusus"

    Public Shared Function qInsertDataIARKhusus(ByVal Values As String) As String

        Dim s As String = ""
        Try
            s = String.Format("INSERT INTO [DataProsesKhusus] (ProsesLevel,GroupID,ProsesID,NomorIZIN,NamaPanggilanKhusus,AlamatStasiun,DayaDibawah30,DayaDiatas30,PenggunaanStasiun,BandFrekuensi,KelasEmisi,BerlakuMulai,BerlakuAkhir,Orda,OrdaCode,Orlok,OrlokCode,NamaLengkap,NamaPanggilan,JenisKelamin,TempatLahir,TanggalLahir,Pekerjaan,Alamat,FileFoto,ProsesData,TanggalSurat) VALUES ({0})", Values)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectIARKhusus(ByVal Where As String, Optional ByVal ProsesLevel As String = "") As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [DataProsesKhusus] {0} ", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qUpdateDataKhusus(ByVal ProsesLevel As String, ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProsesKhusus] SET ProsesLevel='{0}' WHERE ProsesID='{1}'", ProsesLevel, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qUpdateDataKhususError(ByVal ProsesData As String, ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("UPDATE [DataProsesKhusus] SET ProsesData={0} WHERE ProsesID='{1}'", ProsesData, ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s

    End Function

    Public Shared Function qDeleteDataProsesKhusus(ByVal ProsesID As String) As String
        Dim s As String = ""
        Try
            s = String.Format("DELETE FROM [DataProsesKhusus] WHERE ProsesID='{0}'", ProsesID)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectDataSyaratKhusus(ByVal ProsesID As String) As String
        Dim s As String = ""
        Dim Query As String = ""
        Dim dt As New DataTable

        Try
            Query = String.Format("SELECT * FROM [DataProsesKhusus] WHERE ProsesID='{0}'", ProsesID)
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(Query, cn)
            da.Fill(dt)
            '--- Persyaratan Umum ---
            With dt
                If .Rows.Count > 0 Then
                    If Trim(.Rows(0)("NomorIZIN")) = "" Then s = "Nomor IZIN,"
                    If Trim(.Rows(0)("NamaPanggilanKhusus")) = "" Then s = s & "NamaPanggilanKhusus,"
                    If Trim(.Rows(0)("AlamatStasiun")) = "" Then s = s & "AlamatStasiun,"
                    If Trim(.Rows(0)("DayaDibawah30")) = "" Then s = s & "DayaDibawah30,"
                    If Trim(.Rows(0)("DayaDiatas30")) = "" Then s = s & "DayaDiatas30,"
                    If Trim(.Rows(0)("PenggunaanStasiun")) = "" Then s = s & "PenggunaanStasiun,"
                    If Trim(.Rows(0)("BandFrekuensi")) = "" Then s = s & "BandFrekuensi,"
                    If Trim(.Rows(0)("KelasEmisi")) = "" Then s = s & "KelasEmisi,"
                    If Trim(.Rows(0)("BerlakuMulai")) = "" Then s = s & "BerlakuMulai,"
                    If Trim(.Rows(0)("BerlakuAkhir")) = "" Then s = s & "BerlakuAkhir,"
                    If Trim(.Rows(0)("Orda")) = "" Then s = s & "Orda,"
                    If Trim(.Rows(0)("NamaLengkap")) = "" Then s = s & "NamaLengkap,"
                    If Trim(.Rows(0)("NamaPanggilan")) = "" Then s = s & "NamaPanggilan,"
                    If Trim(.Rows(0)("JenisKelamin")) = "" Then s = s & "JenisKelamin,"
                    If Trim(.Rows(0)("TempatLahir")) = "" Then s = s & "TempatLahir,"
                    If Trim(.Rows(0)("TanggalLahir")) = "" Then s = s & "TanggalLahir,"
                    If Trim(.Rows(0)("Pekerjaan")) = "" Then s = s & "Pekerjaan,"
                    If Trim(.Rows(0)("Alamat")) = "" Then s = s & "Alamat,"
                    If Trim(.Rows(0)("FileFoto")) = "" Then s = s & "FileFoto,"
                    If Trim(.Rows(0)("TanggalSurat")) = "" Then s = s & "TanggalSurat,"
                End If
            End With
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

    Public Shared Function qSelectFilesExportKhusus(ByVal Where As String) As String
        Dim s As String = ""
        Try
            s = String.Format("SELECT * FROM [FilesExport] {0} ORDER BY DateUpload DESC ", Where)
        Catch ex As Exception
            s = ex.Message
        End Try
        Return s
    End Function

#End Region
End Class
