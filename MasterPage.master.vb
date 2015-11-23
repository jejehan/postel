Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserID") <> Nothing Then
            LnkNamaUser.Text = "Selamat Datang " & Session("UserID") & " | "
            LnkKeluar.Text = "Keluar"
        End If
        If Session("MenuAwal") <> Nothing Then
            LblMenuAwal.Text = "Data yang dikerjakan: " & Session("MenuAwal") & " "
        End If
    End Sub
End Class

