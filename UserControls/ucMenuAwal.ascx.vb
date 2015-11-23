Partial Class UserControls_ucMenuAwal
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Organisasi As String = Session("Organisasi")
        Dim Reason As String
        Session.Remove("MenuAwal")
        Select Case Organisasi
            Case "Orari"
                BtnUNAR.Visible = True
                BtnIAR.Visible = True
                BtnIARKhusus.Visible = False
                BtnIKRAP.Visible = False
            Case "Rapi"
                BtnIKRAP.Visible = True
                BtnUNAR.Visible = False
                BtnIAR.Visible = False
                BtnIARKhusus.Visible = False
        End Select
        Reason = Request.QueryString("reason")
        Select Case Reason
            Case "sessiontimeout"
                Dim Message As String = "Mohon maaf, tapi batas waktu Anda sudah habis. Silakan memulai lagi dari awal."
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Select
    End Sub

    Protected Sub BtnUNAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUNAR.Click
        Session("MenuAwal") = "SKAR"
        Session("MenuUtama") = "DataProses"
        BtnUNAR.Checked = True
        Response.Redirect("~/Pages/DataProses.aspx")
    End Sub

    Protected Sub BtnIAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIAR.Click
        Session("MenuAwal") = "IAR"
        Session("MenuUtama") = "DataProses"
        BtnIAR.Checked = True
        Response.Redirect("~/Pages/DataProses.aspx")
    End Sub

    Protected Sub BtnIKRAP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIKRAP.Click
        Session("MenuAwal") = "IKRAP"
        Session("MenuUtama") = "DataProses"
        BtnIKRAP.Checked = True
        Response.Redirect("~/Pages/DataProses.aspx")
    End Sub

    Protected Sub BtnLaporan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLaporan.Click
        Session("MenuAwal") = "Laporan"
        Session("MenuUtama") = "Laporan"
        BtnLaporan.Checked = True
        Response.Redirect("~/Pages/Laporan.aspx")
    End Sub

    Protected Sub BtnPengaturan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPengaturan.Click
        Session("MenuAwal") = "Pengaturan"
        Session("MenuUtama") = "Pengaturan"
        BtnPengaturan.Checked = True
        Response.Redirect("~/Pages/Pengaturan.aspx")
    End Sub

    Protected Sub BtnIARKhusus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIARKhusus.Click
        Session("MenuAwal") = "IARKHUSUS"
        Session("MenuUtama") = "DataProsesKhusus"
        BtnIARKhusus.Checked = True
        Response.Redirect("~/Pages/DataProsesKhusus.aspx")
    End Sub

End Class
