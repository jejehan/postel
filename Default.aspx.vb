
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserID") Is Nothing Then
            Response.Redirect("login.aspx")
        Else
            Response.Redirect("~/pages/Default.aspx")
        End If
    End Sub
End Class
