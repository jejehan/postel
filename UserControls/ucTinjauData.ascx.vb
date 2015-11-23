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

Partial Class UserControls_ucTinjauData
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

        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnNew)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnProses)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnSave)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnHapusData)
        ScriptManager.GetCurrent(Page).RegisterPostBackControl(BtnRefresh)

        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        End If

        If Page.IsPostBack = False Then
            MenuAwal = Session("MenuAwal")
            lblJudul.text = MenuAwal
            GetData(MenuAwal)
        Else
            If MenuAwal = "" Then
                Response.Redirect("~/Pages/Default.aspx?reason=sessiontimeout")
            End If
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
            GetData(MenuAwal)
            If cxItemArray <> "" Then
                s = setCheckedItem(Session("CheckItemTinjauData"))
            End If
        End If

    End Sub

    Sub GetData(ByVal MenuAwal As String)

        Select Case MenuAwal
            Case "SKAR"
                GetMemberList("WHERE Organisasi='Orari' AND ProsesLevel='4'")
            Case "IAR"
                GetMemberList("WHERE Organisasi='Orari' AND ProsesLevel='12'")
            Case "IKRAP"
                GetMemberList("WHERE Organisasi='Rapi' AND ProsesLevel='12'")
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
                    s = qDelete("DataProses", " ProsesID='" & ProsesID & "'")
                    s = InsertDataProcess(s)
                End If
            Next
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try
        GetData(MenuAwal)
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

    Protected Sub BtnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Response.Redirect("~/Pages/Form.aspx")
    End Sub

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
        Response.Redirect(String.Format("~/pages/form.aspx?ProsesID={0}&returnurl={1}", ltrlProsesID.Text, "TinjauData.aspx"))

    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ltrlProsesID As Literal = DirectCast(DirectCast(DirectCast(sender, ImageButton).Parent, GridViewDataItemTemplateContainer).FindControl("ltrlProsesID"), Literal)
        Dim s As String = ""

        Try
            ProsesID = ltrlProsesID.Text
            If ProsesID <> "" Then
                s = qDeleteTemp("DataProses", String.Format(" ProsesID='{0}'", ProsesID))
                s = InsertDataProcess(s)
            End If
        Catch ex As Exception
            Dim Message As String = ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

        GetData(MenuAwal)
        If cbxPilihSemua.Checked = True Then
            cbxPilihSemua.Checked = False
        End If

    End Sub

    Protected Sub BtnProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Dim s As String = ""
        Dim GroupID As String = ""
        Dim ProsesID As String = ""
        Dim FileFoto As String = ""
        Dim Nama As String = ""
        Dim Orda As String = ""
        Dim RapiDaerah As String = ""
        Dim CallSign As String = ""
        Dim NomorUNAR As String = ""
        Dim row As Integer = 0
        Dim FileError As String = ""
        Dim dt As New DataTable
        Dim Split As String = Chr(34)
        Dim SplitMiddle As String = Chr(34) & "," & Chr(34)
        Dim myString As New StringBuilder()
        Dim bFirstRecord As Boolean = True

        PostBack = "False"
        Try
            FileError = MenuAwal & "_Error_" & Date.Now.Year & ConvertDigit(Date.Now.Month, 2) & ConvertDigit(Date.Now.Day, 2) & "_" & ConvertDigit(Date.Now.Hour, 2) & ConvertDigit(Date.Now.Minute, 2) & ConvertDigit(Date.Now.Second, 2) & ".csv"
            Dim myWriter As New System.IO.StreamWriter(MyFileError() & FileError)
            If Session("Organisasi") = "Orari" Then
                If MenuAwal = "SKAR" Then
                    myString.Append(Split + "No." + SplitMiddle + "Orda" + SplitMiddle + "NomorUNAR" + SplitMiddle + "Nama" + Split + "," + "Kekurangan")
                Else
                    myString.Append(Split + "No." + SplitMiddle + "Orda" + SplitMiddle + "CallSign" + SplitMiddle + "Nama" + Split + "," + "Kekurangan")
                End If
            Else
                myString.Append(Split + "No." + SplitMiddle + "RapiDaerah" + SplitMiddle + "CallSign" + SplitMiddle + "Nama" + Split + "," + "Kekurangan")
            End If
            myString.Append(vbCr & vbLf)
            For i As Integer = 0 To GvListAnggota.VisibleRowCount - 1
                ProsesID = ArrayCheckList(i)
                If ProsesID <> "" Then
                    s = qSelectDataSyarat(ProsesID, Session("Organisasi"), "", MenuAwal)
                    dt = ViewDataProses("SELECT * FROM DataProses WHERE ProsesID='" & ProsesID & "' AND Organisasi='" & Session("Organisasi") & "'")
                    With dt
                        If .Rows.Count > 0 Then
                            GroupID = .Rows(0)("GroupID")
                            FileFoto = .Rows(0)("FileFoto")
                            Nama = .Rows(0)("Nama")
                            Orda = .Rows(0)("OrdaName")
                            RapiDaerah = .Rows(0)("RapiDaerahName")
                            CallSign = .Rows(0)("CallSign")
                            NomorUNAR = .Rows(0)("NomorUNAR")
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
                            If File.Exists(MapPath("~\FileFotoProses\") & FileFoto) Then
                                s = s & ""
                            Else
                                s = s & "File Foto Tidak Ditemukan"
                            End If
                        End If
                    End With

                    If s = "" Then '--- Jika tidak ada error ---
                        If MenuAwal = "SKAR" Then
                            s = qUpdateDataProsesTinjauData("5", ProsesID)
                        Else
                            s = qUpdateDataProsesTinjauData("13", ProsesID)
                        End If
                        s = InsertDataProcess(s)
                        s = qUpdateDataLog("Tinjau Data", "UserTinjauData", Session("UserID"), "DateTinjauData", ProsesID)
                        s = InsertDataProcess(s)
                        If Session("MenuAwal") = "SKAR" Then
                            s = qInsertHasilUNAR(ProsesID)
                            s = InsertDataProcess(s)
                        End If
                        s = qUpdateDataErrorTinjauData("True", ProsesID)
                        s = InsertDataProcess(s)
                    Else
                        row = row + 1
                        If Session("Organisasi") = "Orari" Then
                            If MenuAwal = "SKAR" Then
                                myString.Append(Split + row.ToString + SplitMiddle + Orda + SplitMiddle + NomorUNAR + SplitMiddle + Nama + Split + "," + s)
                            Else
                                myString.Append(Split + row.ToString + SplitMiddle + Orda + SplitMiddle + Replace(CallSign, "Ø", "0") + SplitMiddle + Nama + Split + "," + s)
                            End If
                        Else
                            myString.Append(Split + row.ToString + SplitMiddle + RapiDaerah + SplitMiddle + Replace(CallSign, "Ø", "0") + SplitMiddle + Nama + Split + "," + s)
                        End If
                        myString.Append(vbCr & vbLf)
                        s = qUpdateDataErrorTinjauData("False", ProsesID)
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
        GetData(MenuAwal)
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
