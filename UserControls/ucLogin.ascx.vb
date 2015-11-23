Imports System.Data
Imports System.Data.OleDb
Imports clsGeneral
Imports clsDataBase

Partial Class usercontrols_ucLogin
    Inherits System.Web.UI.UserControl

    Protected Sub BtnMasuk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMasuk.Click

        Dim ErrorPassword As String = "User/Password yang Anda masukkan tidak cocok/tidak ditemukan. Huruf besar dan kecil berbeda."
        Dim Message As String = ""
        Dim Password As String = ""
        Dim Where As String = " WHERE [UserID] = '" & LCase(tbxUserID.Text) & "'"

        Try
            Session("Company") = MyCompany()
            If Session("Company") = "Orari" Then
                CmbOrganisasi.Enabled = False
            End If

            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(qSelectUserPassword() & Where, cn)
            Dim dt As New DataTable
            da.Fill(dt)
            da.Dispose()
            cn.Dispose()

            If dt.Rows.Count > 0 Then
                If Trim(tbxPassword.Text) = dt.Rows(0)("KataSandi") Then
                    If dt.Rows(0)("Aktif") = "True" Then
                        Session("UserID") = UCase(tbxUserID.Text)
                        Session("Admin") = dt.Rows(0)("Admin")
                        Session("Organisasi") = CmbOrganisasi.Value
                        Response.Redirect("~/Pages/Default.aspx")
                    Else
                        Message = "[Login 001]: User yang Anda masukkan sudah tidak aktif! Harap menghubungi Admin untuk bantuan."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                Else
                    tbxPassword.Text = ""
                    Message = "[Login 002]:" & ErrorPassword
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            Else
                tbxPassword.Text = ""
                Message = "[Login 003]:" & ErrorPassword
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As Exception
            Message = "[Login 004]:" & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Clear()
    End Sub
End Class
