Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports clsDataBase
Imports clsGeneral

Partial Class UserControls_ucTinjauDataKhusus
    Inherits UserControl
    Public Shared TypeData As String = ""
    Public Shared TypeExport As String = ""
    Public Shared NRI As String = ""
    Public Shared NomorKTP As String = ""
    Public Shared Callsign As String = ""
    Public Shared ProsesID As String = ""
    Public Shared ProsesLevel As String = ""
    Public Shared Message As String = ""
    Public Shared MenuAwal As String = ""
    Public Shared PostBack As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cxItem As CheckBox
        Dim cxItemArray As String = ""
        Dim s As String = ""
        Dim cxAllAwal As String = ""
        Dim cxAllAkhir As String = ""
        Dim StartIndex As Integer = 0
        Dim StartEnd As Integer = 0
        Dim StartMod As Integer = 0
        MenuAwal = "IARKHUSUS"

        'ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnNew)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnProses)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnSave)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnHapusData)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnRefresh)

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        End If

        If Page.IsPostBack = False Then
            lblJudul.Text = MenuAwal
            GetMemberList("WHERE ProsesLevel='13'")
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
                        Session("CheckItemTinjauData") = Right(cxItemArray, Len(cxItemArray) - 1)
                    End If
                End If
            End With
            GetMemberList("WHERE ProsesLevel='13'")
            If cxItemArray <> "" Then
                s = setCheckedItem(Session("CheckItemTinjauData"))
            End If
        End If

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

    Sub GetMemberList(ByVal Where As String)

        Try
            Dim cn As New OleDbConnection(MyDataProses)
            Dim da As New OleDbDataAdapter(qSelectIARKhusus(Where, ProsesLevel), cn)
            Dim dt As New DataTable
            da.Fill(dt)
            GvListAnggota.DataSource = dt
            GvListAnggota.DataBind()
            da.Dispose()
            cn.Dispose()
        Catch ex As Exception
            Message = ex.Message.ToString
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    Protected Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        GvListAnggota_ExportAll.WriteXlsToResponse()
    End Sub

    Protected Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Dim s As String
        Session("CheckAllTinjauData") = ""

        If cbxPilihSemua.Checked = True Then
            s = setCheckedAll("True")
            Session("CheckAllTinjauData") = "True"
        Else
            s = setCheckedAll("False")
            Session("CheckAllTinjauData") = "False"
        End If
        GC.Collect()
    End Sub

    Protected Sub BtnHapusData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapusData.Click

        Dim s As String = ""
        Dim ProsesID As String = ""
        Dim ArlTs As New ArrayList

        Try
            For i As Integer = 0 To GvListAnggota.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    s = qDelete("DataProsesKhusus", " ProsesID='" & ProsesID & "'")
                    s = InsertDataProcess(s)
                End If
            Next
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        GetMemberList("WHERE ProsesLevel='13'")
        If cbxPilihSemua.Checked = True Then
            cbxPilihSemua.Checked = False
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
        Response.Redirect(String.Format("~/Pages/FormKhusus.aspx?ProsesID={0}&returnurl={1}", ltrlProsesID.Text, "PersetujuanKhusus.aspx"))

    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ltrlProsesID As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlProsesID"), Literal)
        Dim s As String = ""

        Try
            ProsesID = ltrlProsesID.Text
            If ProsesID <> "" Then
                s = qDeleteTemp("DataProsesKhusus", String.Format(" ProsesID='{0}'", ProsesID))
                s = InsertDataProcess(s)
            End If
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        GetMemberList("WHERE ProsesLevel='13'")
        If cbxPilihSemua.Checked = True Then
            cbxPilihSemua.Checked = False
        End If

    End Sub

    Protected Sub BtnProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Dim s As String = ""
        Dim CallSign As String = ""
        Dim row As Integer = 0
        Dim FileError As String = ""
        Dim dt As New DataTable
        Dim Split As String = Chr(34)
        Dim SplitMiddle As String = Chr(34) & "," & Chr(34)
        Dim myString As New StringBuilder()
        Dim bFirstRecord As Boolean = True

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

        PostBack = "False"
        Try
            FileError = MenuAwal & "_Error_" & Date.Now.Year & ConvertDigit(Date.Now.Month, 2) & ConvertDigit(Date.Now.Day, 2) & "_" & ConvertDigit(Date.Now.Hour, 2) & ConvertDigit(Date.Now.Minute, 2) & ConvertDigit(Date.Now.Second, 2) & ".csv"
            Dim myWriter As New System.IO.StreamWriter(MyFileError() & FileError)
            myString.Append(Split + "No." + SplitMiddle + "Orda" + SplitMiddle + "CallSign" + SplitMiddle + "Nama" + Split + "," + "Kekurangan")
            myString.Append(vbCr & vbLf)
            For i As Integer = 0 To GvListAnggota.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    's = qSelectDataSyarat(ProsesID, Session("Organisasi"), "", MenuAwal)
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
                    Dim DataIAR As String = ""
                    If s = "" Then '--- Jika tidak ada error ---
                        s = "INSERT INTO DataIARKhusus SELECT * FROM DataProsesKhusus WHERE ProsesID='" & ProsesID & "'"
                        s = InsertDataProcess(s)
                        s = String.Format("UPDATE DataIARKhusus SET BerlakuMulai='{0}', BerlakuAkhir='{1}', TanggalLahir='{2}'," & _
                            "TanggalSurat='{3}' WHERE ProsesID='{4}'", BerlakuMulaiStr, BerlakuAkhirStr, TanggalLahirStr, TanggalSuratStr, ProsesID)
                        s = InsertDataProcess(s)
                        Dim NamaFoto As String = MapPath("~/FileFotoProses/") & Trim(FileFoto)
                        s = qSaveImageToDB(NamaFoto, ProsesID, "DataIARKhusus")
                        s = qUpdateDataKhusus("14", ProsesID)
                        s = InsertDataProcess(s)
                    Else
                        row = row + 1
                        myString.Append(Split + row.ToString + SplitMiddle + Orda + SplitMiddle + Replace(CallSign, "Ø", "0") + SplitMiddle + NamaLengkap + Split + "," + s)
                        myString.Append(vbCr & vbLf)
                        s = qUpdateDataKhususError("False", ProsesID)
                        s = InsertDataProcess(s)
                    End If
                End If
            Next
            If row <> 0 Then
                myWriter.WriteLine(myString)
                myWriter.Close()
                lnkDataError.Visible = True
                lnkDataError.NavigateUrl = "../FileError/" & FileError
                Dim Message As String = "Ada " & row & " data yang belum lengkap persyaratannya!"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            Else
                Dim Message As String = "Proses Tinjau Data Berhasil..."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        GetMemberList("WHERE ProsesLevel='13'")
        If cbxPilihSemua.Checked = True Then
            cbxPilihSemua.Checked = False
        End If
    End Sub

    Protected Sub cbxPilihSemua_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxPilihSemua.CheckedChanged
        Dim s As String
        Dim cx As CheckBox
        cx = sender
        PostBack = "False"
        If cx.Checked = True Then
            s = setCheckedAll("True")
        Else
            s = setCheckedAll("False")
        End If
        cx = Nothing
        GC.Collect()
    End Sub

End Class
