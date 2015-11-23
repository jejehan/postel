Imports System
Imports System.IO
'Imports DevExpress.Web
Imports System.Data.OleDb
Imports clsDataBase
Imports clsGeneral
Imports clsPersyaratan
Imports clsCallSign
Imports System.Drawing
Imports System.Drawing.Imaging

Partial Class UserControls_ucFormSKAR
    Inherits System.Web.UI.UserControl
    Public Shared Callsign As String
    Public Shared GroupID As String = ""
    Public Shared NomorID As String = ""
    Public Shared ReturnUrl As String = ""
    Public Shared FileFoto As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dt As New DataTable

        If Page.IsPostBack = False Then
            NomorID = Request.QueryString("NomorID")
            ReturnUrl = Request.QueryString("returnurl")

            GetMemberList()
        End If

    End Sub

    Sub GetMemberList()

        Dim Query As String = ""
        Dim NmrID As Integer = Replace(NomorID, "'", "")
        Dim dt As DataTable
        Query = "SELECT * FROM DataSKAR WHERE ID=" & NmrID & ""
        dt = ViewDatabase(Query)
        With dt
            If .Rows.Count > 0 Then
                '--- Data Pemohon ---
                GroupID = Trim(.Rows(0)("GroupID"))
                FileFoto = .Rows(0)("FileFoto")
                If FileFoto <> "" Then
                    Dim TheFile As FileInfo = New FileInfo(MapPath("~\FileFoto\") & FileFoto)
                    If TheFile.Exists Then
                        ImgFoto.ImageUrl = "~/FileFoto/" & FileFoto
                    Else
                        ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                    End If
                Else
                    ImgFoto.ImageUrl = "~/Images/Persons-120x150.jpg"
                End If

                TbxNama.Text = Trim(.Rows(0)("Nama"))
                TbxAlamat.Text = Trim(.Rows(0)("Alamat"))
                TbxTempatTanggalLahir.Text = Trim(.Rows(0)("TempatTanggalLahir"))
                TbxTingkat.Text = Trim(.Rows(0)("Tingkat"))
                TbxOrda.Text = Trim(.Rows(0)("OrdaName"))
                TbxOrlok.Text = Trim(.Rows(0)("OrlokName"))

                TbxNmrUNAR.Text = Trim(.Rows(0)("NomorUNAR"))
                TbxTglUNAR.Text = Trim(.Rows(0)("TanggalUNAR"))
                TbxLokasiUNAR.Text = Trim(.Rows(0)("LokasiUNAR"))
                TbxNmrSKAR.Text = Trim(.Rows(0)("NomorSKAR"))
                TbxTglSKAR.Text = Trim(.Rows(0)("TanggalTerbitSKAR"))

                lblPS.Text = Trim(.Rows(0)("PS"))
                lblTR.Text = Trim(.Rows(0)("TR"))
                lblPR.Text = Trim(.Rows(0)("PR"))
                lblBI.Text = Trim(.Rows(0)("BI"))
                lblKM.Text = Trim(.Rows(0)("KM"))
                lblTeori.Text = Trim(.Rows(0)("Teori"))
                lblJumlah.Text = Trim(.Rows(0)("Jumlah"))
                lblNilai.Text = Trim(.Rows(0)("Nilai"))

                TbxHasil.Text = Trim(.Rows(0)("Hasil"))
                TbxKeterangan.Text = Trim(.Rows(0)("Keterangan"))
                TbxUserUpdate.Text = Trim(.Rows(0)("UserUpdate"))
                TbxTglUpdate.Text = Trim(.Rows(0)("DateUpdate"))

            End If
        End With

        'CheckKondisi(CmbJenisPermohonan.Value.ToString)

    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Response.Redirect("~/pages/Laporan.aspx")
    End Sub

End Class
