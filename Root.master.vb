
Partial Class Root
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        ASPxLabel2.Text = Date.Now.Year.ToString() + Server.HtmlDecode(" &copy; Copyright by [Postel 2015]")
    End Sub
End Class

