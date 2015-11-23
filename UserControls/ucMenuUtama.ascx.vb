
Partial Class usercontrol_ucMenuUtama
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim MenuUtama As String = ""
        MenuUtama = Session("MenuUtama")
        If Page.IsPostBack = False Then
            If Session("Admin") = False Then
                BtnPersetujuan.Visible = False
            End If
            Select Case MenuUtama
                Case "DataProses", "DataProsesKhusus"
                    BtnDataProses.Checked = True
                Case "ImportData"
                    BtnImportFile.Checked = True
                Case "TinjauData", "TinjauDataKhusus"
                    BtnTinjauData.Checked = True
                Case "HasilUNAR"
                    BtnHasilUNAR.Checked = True
                Case "Persetujuan", "PersetujuanKhusus"
                    BtnPersetujuan.Checked = True
                Case "ExportData", "ExportDataKhusus"
                    BtnExportData.Checked = True
                Case "CetakIKRAP"
                    BtnCetakIKRAP.Checked = True
                Case "CetakIAR"
                    BtnCetakIAR.Checked = True
                Case "CetakSKAR"
                    BtnCetakSKAR.Checked = True
                Case "CetakSKAR"
                    BtnCetakSKAR.Checked = True
                Case "Laporan"
                    BtnLaporan.Checked = True
                Case Else
                    btnMenuAwal.Checked = True
            End Select
        End If
        Select Case Session("MenuAwal")
            Case "SKAR"
                BtnHasilUNAR.Visible = True
                BtnCetakSKAR.Visible = True
            Case "IARKHUSUS"
                BtnTinjauData.Enabled = True
                BtnPersetujuan.Enabled = True
                BtnCetakIARKhusus.Visible = True
            Case Else
                If Session("Organisasi") = "Orari" Then
                    BtnCetakIAR.Visible = True
                Else
                    BtnCetakIKRAP.Visible = True
                End If
        End Select
    End Sub

    Protected Sub BtnImportFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnImportFile.Click
        Session("MenuUtama") = "ImportData"
        Response.Redirect("~/pages/Import.aspx")
    End Sub

    Protected Sub BtnTinjauData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTinjauData.Click
        If Session("MenuAwal") = "IARKHUSUS" Then
            Session("MenuUtama") = "TinjauDataKhusus"
            Response.Redirect("~/pages/TinjauDataKhusus.aspx")
        Else
            Session("MenuUtama") = "TinjauData"
            Response.Redirect("~/pages/TinjauData.aspx")
        End If
    End Sub

    Protected Sub BtnPersetujuan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPersetujuan.Click
        If Session("MenuAwal") = "IARKHUSUS" Then
            Session("MenuUtama") = "PersetujuanKhusus"
            Response.Redirect("~/pages/PersetujuanKhusus.aspx")
        Else
            Session("MenuUtama") = "Persetujuan"
            Response.Redirect("~/pages/Persetujuan.aspx")
        End If
    End Sub

    Protected Sub BtnCetakSKAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCetakSKAR.Click
        Session("MenuUtama") = "CetakSKAR"
        Response.Redirect("~/pages/CetakSKAR.aspx")
    End Sub

    Protected Sub BtnCetakIAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCetakIAR.Click
        Session("MenuUtama") = "CetakIAR"
        Response.Redirect("~/pages/CetakIAR.aspx")
    End Sub

    Protected Sub BtnCetakIKRAP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCetakIKRAP.Click
        Session("MenuUtama") = "CetakIKRAP"
        Response.Redirect("~/pages/CetakIKRAP.aspx")
    End Sub

    Protected Sub BtnCetakIARKhusus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCetakIARKhusus.Click
        Session("MenuUtama") = "CetakIARKhusus"
        Response.Redirect("~/pages/CetakIARKhusus.aspx")
    End Sub

    Protected Sub BtnExportData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExportData.Click
        If Session("MenuAwal") = "IARKHUSUS" Then
            Session("MenuUtama") = "ExportDataKhusus"
            Response.Redirect("~/pages/ExportKhusus.aspx")
        Else
            Session("MenuUtama") = "ExportData"
            Response.Redirect("~/pages/Export.aspx")
        End If

    End Sub

    Protected Sub btnMenuAwal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMenuAwal.Click
        Response.Redirect("~/Pages/Default.aspx")
    End Sub

    Protected Sub BtnDataProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDataProses.Click
        If Session("MenuAwal") = "IARKHUSUS" Then
            Session("MenuUtama") = "DataProsesKhusus"
            Response.Redirect("~/pages/DataProsesKhusus.aspx")
        Else
            Session("MenuUtama") = "DataProses"
            Response.Redirect("~/pages/DataProses.aspx")
        End If
    End Sub

    Protected Sub BtnHasilUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHasilUNAR.Click
        Session("MenuUtama") = "HasilUNAR"
        Response.Redirect("~/pages/HasilUNAR.aspx")
    End Sub

    Protected Sub BtnLaporan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLaporan.Click
        If Session("MenuAwal") = "IARKHUSUS" Then
            Session("MenuUtama") = "LaporanKhusus"
            Response.Redirect("~/pages/LaporanKhusus.aspx")
        Else
            Session("MenuUtama") = "Laporan"
            Response.Redirect("~/pages/Laporan.aspx")
        End If
    End Sub

End Class
