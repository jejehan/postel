
Partial Class _Default
    Inherits System.Web.UI.Page
    Public Shared Menu As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserID") Is Nothing Then
            Response.Redirect("~/login.aspx")
        End If

        Menu = Request.QueryString("menu")

        If Menu = "" Then Menu = "User"
        Select Case Menu
            Case "User"
                Pengaturan.Visible = True
                PengaturanEmail.Visible = False
                PengaturanSetting.Visible = False
            Case "eMail"
                Pengaturan.Visible = False
                PengaturanEmail.Visible = True
                PengaturanSetting.Visible = False
        End Select
    End Sub

End Class
