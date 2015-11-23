Imports System.Data
Imports System.Data.OleDb
Imports clsGeneral
Imports clsDataBase

Partial Class usercontrols_ucLogin
    Inherits System.Web.UI.UserControl

    Protected Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click

        Dim ErrorPasswordBaru As String = "User/Password yang Anda masukkan tidak cocok/tidak ditemukan. Huruf besar dan kecil berbeda."
        Dim Message As String = ""
        Dim Password As String = ""
        Dim Where As String = " WHERE [UserID] = '" & LCase(Session("UserID")) & "'"
        Dim s As String = ""
        Try
            Dim cn As New OleDbConnection(MyDatabase)
            Dim da As New OleDbDataAdapter(qSelectUserPassword() & Where, cn)
            Dim dt As New DataTable

            da.Fill(dt)
            da.Dispose()
            cn.Dispose()

            If dt.Rows.Count > 0 Then
                If Trim(tbxPasswordLama.Text) = dt.Rows(0)("KataSandi") Then
                    If tbxPasswordBaru1.Text = tbxPasswordBaru2.Text Then
                        s = qUpdateUserPassword(Session("UserID"), tbxPasswordBaru2.Text, Session("UserID"))
                        s = InsertDataBase(s)
                        If s = "" Then
                            Message = "Ganti Password berhasil..."
                            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                        End If
                    Else
                        Message = "Kata Baru tidak sama dengan Kata Sandi Konfirmasi."
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                    End If
                Else
                    tbxPasswordBaru1.Text = ""
                    Message = "[Login 002]:" & ErrorPasswordBaru
                    ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
                End If
            Else
                tbxPasswordBaru1.Text = ""
                Message = "[Login 003]:" & ErrorPasswordBaru
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
            End If
        Catch ex As Exception
            Message = "[Login 004]:" & ex.Message
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alert", String.Format("alert('{0}');", Message.Replace("'", "")), True)
        End Try

    End Sub

    Protected Sub BtnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Response.Redirect("~/Pages/Default.aspx")
    End Sub
End Class
