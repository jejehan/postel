Public Class rptCetakIARKhusus
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblNomorIZIN As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents LblJakarta As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents dsDataIARKhusus1 As dsDataIARKhusus
    Private WithEvents dataIARKhususTableAdapter1 As dsDataIARKhususTableAdapters.DataIARKhususTableAdapter
    Private WithEvents xrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents LblDirjenPostel As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptCetakIARKhusus.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptCetakIARKhusus.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel43 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel60 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel62 = New DevExpress.XtraReports.UI.XRLabel
        Me.LblJakarta = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel61 = New DevExpress.XtraReports.UI.XRLabel
        Me.LblDirjenPostel = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel59 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel58 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel57 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel56 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel55 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel54 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel53 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel52 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel48 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel46 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel45 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNomorIZIN = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataIARKhusus1 = New dsDataIARKhusus
        Me.dataIARKhususTableAdapter1 = New dsDataIARKhususTableAdapters.DataIARKhususTableAdapter
        CType(Me.dsDataIARKhusus1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel43, Me.xrLabel60, Me.xrLabel62, Me.LblJakarta, Me.xrLabel61, Me.LblDirjenPostel, Me.xrLabel59, Me.xrLabel58, Me.xrLabel57, Me.xrLabel56, Me.xrLabel55, Me.xrLabel54, Me.xrLabel53, Me.xrLabel52, Me.xrLabel51, Me.xrLabel50, Me.xrLabel49, Me.xrLabel48, Me.xrLabel47, Me.xrLabel46, Me.xrLabel45, Me.xrLabel42, Me.xrLabel41, Me.xrLabel40, Me.xrLabel39, Me.xrLabel38, Me.xrLabel37, Me.xrLabel35, Me.xrLabel36, Me.lblNomorIZIN, Me.xrLabel34, Me.xrLabel33, Me.xrLabel32, Me.xrLabel31, Me.xrLabel30, Me.xrLabel29, Me.xrLabel28, Me.xrLabel27, Me.xrLabel26, Me.xrPictureBox2, Me.xrLabel25, Me.xrLabel24, Me.xrLabel23, Me.xrLabel22, Me.xrLabel21, Me.xrLabel20, Me.xrLabel19, Me.xrLabel18, Me.xrLabel17, Me.xrLabel16, Me.xrLabel15, Me.xrLabel14, Me.xrLabel13, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLine1, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1, Me.xrPictureBox3})
        Me.Detail.HeightF = 1015.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel43
        '
        Me.xrLabel43.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 23.91669!)
        Me.xrLabel43.Multiline = True
        Me.xrLabel43.Name = "xrLabel43"
        Me.xrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel43.SizeF = New System.Drawing.SizeF(600.4583!, 21.29167!)
        Me.xrLabel43.StylePriority.UseFont = False
        Me.xrLabel43.Text = "DIREKTORAT JENDERAL SUMBER DAYA DAN PERANGKAT POS DAN INFORMATIKA"
        '
        'xrLabel60
        '
        Me.xrLabel60.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel60.CanGrow = False
        Me.xrLabel60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.TanggalSurat")})
        Me.xrLabel60.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(486.4581!, 728.0!)
        Me.xrLabel60.Name = "xrLabel60"
        Me.xrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel60.SizeF = New System.Drawing.SizeF(142.1251!, 22.99994!)
        Me.xrLabel60.StylePriority.UseBackColor = False
        Me.xrLabel60.StylePriority.UseFont = False
        Me.xrLabel60.StylePriority.UseTextAlignment = False
        Me.xrLabel60.Text = "lblTanggalSurat"
        Me.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrLabel60.WordWrap = False
        '
        'xrLabel62
        '
        Me.xrLabel62.AutoWidth = True
        Me.xrLabel62.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel62.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(326.5!, 750.9999!)
        Me.xrLabel62.Multiline = True
        Me.xrLabel62.Name = "xrLabel62"
        Me.xrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel62.SizeF = New System.Drawing.SizeF(387.4999!, 48.14294!)
        Me.xrLabel62.StylePriority.UseBackColor = False
        Me.xrLabel62.StylePriority.UseFont = False
        Me.xrLabel62.StylePriority.UseTextAlignment = False
        Me.xrLabel62.Text = "A.N. DIREKTUR JENDERAL SUMBER DAYA DAN PERANGKAT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "POS DAN INFORMATIKA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIREKTUR " & _
            "OPERASI SUMBER DAYA"
        Me.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrLabel62.WordWrap = False
        '
        'LblJakarta
        '
        Me.LblJakarta.AutoWidth = True
        Me.LblJakarta.BackColor = System.Drawing.Color.Transparent
        Me.LblJakarta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LblJakarta.LocationFloat = New DevExpress.Utils.PointFloat(429.1665!, 728.0!)
        Me.LblJakarta.Name = "LblJakarta"
        Me.LblJakarta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LblJakarta.SizeF = New System.Drawing.SizeF(57.29156!, 22.99994!)
        Me.LblJakarta.StylePriority.UseBackColor = False
        Me.LblJakarta.StylePriority.UseFont = False
        Me.LblJakarta.StylePriority.UseTextAlignment = False
        Me.LblJakarta.Text = "Jakarta,"
        Me.LblJakarta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.LblJakarta.WordWrap = False
        '
        'xrLabel61
        '
        Me.xrLabel61.AutoWidth = True
        Me.xrLabel61.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(411.4583!, 892.0711!)
        Me.xrLabel61.Name = "xrLabel61"
        Me.xrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel61.SizeF = New System.Drawing.SizeF(284.8333!, 13.58331!)
        Me.xrLabel61.StylePriority.UseBackColor = False
        Me.xrLabel61.StylePriority.UseFont = False
        Me.xrLabel61.StylePriority.UseTextAlignment = False
        Me.xrLabel61.Text = "NIP. : 19590217 198703 1002"
        Me.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrLabel61.WordWrap = False
        '
        'LblDirjenPostel
        '
        Me.LblDirjenPostel.AutoWidth = True
        Me.LblDirjenPostel.BackColor = System.Drawing.Color.Transparent
        Me.LblDirjenPostel.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.LblDirjenPostel.LocationFloat = New DevExpress.Utils.PointFloat(411.4583!, 866.7499!)
        Me.LblDirjenPostel.Name = "LblDirjenPostel"
        Me.LblDirjenPostel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LblDirjenPostel.SizeF = New System.Drawing.SizeF(284.8334!, 23.99994!)
        Me.LblDirjenPostel.StylePriority.UseBackColor = False
        Me.LblDirjenPostel.StylePriority.UseFont = False
        Me.LblDirjenPostel.StylePriority.UseTextAlignment = False
        Me.LblDirjenPostel.Text = "Ir. RACHMAT WIDAYANA, SE, MM"
        Me.LblDirjenPostel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.LblDirjenPostel.WordWrap = False
        '
        'xrLabel59
        '
        Me.xrLabel59.CanGrow = False
        Me.xrLabel59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.Alamat")})
        Me.xrLabel59.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 666.0417!)
        Me.xrLabel59.Multiline = True
        Me.xrLabel59.Name = "xrLabel59"
        Me.xrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel59.SizeF = New System.Drawing.SizeF(483.7917!, 51.125!)
        Me.xrLabel59.StylePriority.UseFont = False
        Me.xrLabel59.Text = "lblAlamat"
        '
        'xrLabel58
        '
        Me.xrLabel58.CanGrow = False
        Me.xrLabel58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.Pekerjaan")})
        Me.xrLabel58.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 643.0417!)
        Me.xrLabel58.Name = "xrLabel58"
        Me.xrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel58.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel58.StylePriority.UseFont = False
        Me.xrLabel58.Text = "lblPekerjaan"
        '
        'xrLabel57
        '
        Me.xrLabel57.CanGrow = False
        Me.xrLabel57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.TempatTglLahir")})
        Me.xrLabel57.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 620.0416!)
        Me.xrLabel57.Name = "xrLabel57"
        Me.xrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel57.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel57.StylePriority.UseFont = False
        Me.xrLabel57.Text = "lblTempatTglLahir"
        '
        'xrLabel56
        '
        Me.xrLabel56.CanGrow = False
        Me.xrLabel56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.JenisKelamin")})
        Me.xrLabel56.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 597.0417!)
        Me.xrLabel56.Name = "xrLabel56"
        Me.xrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel56.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel56.StylePriority.UseFont = False
        Me.xrLabel56.Text = "lblJenisKelamin"
        '
        'xrLabel55
        '
        Me.xrLabel55.CanGrow = False
        Me.xrLabel55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.NamaPanggilan")})
        Me.xrLabel55.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 574.0417!)
        Me.xrLabel55.Name = "xrLabel55"
        Me.xrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel55.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel55.StylePriority.UseFont = False
        Me.xrLabel55.Text = "lblCallSign"
        '
        'xrLabel54
        '
        Me.xrLabel54.CanGrow = False
        Me.xrLabel54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.NamaLengkap")})
        Me.xrLabel54.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 551.0417!)
        Me.xrLabel54.Name = "xrLabel54"
        Me.xrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel54.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel54.StylePriority.UseFont = False
        Me.xrLabel54.Text = "lblNamaLengkap"
        '
        'xrLabel53
        '
        Me.xrLabel53.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 666.0417!)
        Me.xrLabel53.Name = "xrLabel53"
        Me.xrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel53.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel53.StylePriority.UseFont = False
        Me.xrLabel53.Text = ":"
        '
        'xrLabel52
        '
        Me.xrLabel52.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 643.0417!)
        Me.xrLabel52.Name = "xrLabel52"
        Me.xrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel52.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel52.StylePriority.UseFont = False
        Me.xrLabel52.Text = ":"
        '
        'xrLabel51
        '
        Me.xrLabel51.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 620.0416!)
        Me.xrLabel51.Name = "xrLabel51"
        Me.xrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel51.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel51.StylePriority.UseFont = False
        Me.xrLabel51.Text = ":"
        '
        'xrLabel50
        '
        Me.xrLabel50.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 597.0416!)
        Me.xrLabel50.Name = "xrLabel50"
        Me.xrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel50.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel50.StylePriority.UseFont = False
        Me.xrLabel50.Text = ":"
        '
        'xrLabel49
        '
        Me.xrLabel49.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 574.0416!)
        Me.xrLabel49.Name = "xrLabel49"
        Me.xrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel49.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel49.StylePriority.UseFont = False
        Me.xrLabel49.Text = ":"
        '
        'xrLabel48
        '
        Me.xrLabel48.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 551.0417!)
        Me.xrLabel48.Name = "xrLabel48"
        Me.xrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel48.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel48.StylePriority.UseFont = False
        Me.xrLabel48.Text = ":"
        '
        'xrLabel47
        '
        Me.xrLabel47.AutoWidth = True
        Me.xrLabel47.CanShrink = True
        Me.xrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.MasaBerlaku")})
        Me.xrLabel47.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 458.0835!)
        Me.xrLabel47.Name = "xrLabel47"
        Me.xrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel47.SizeF = New System.Drawing.SizeF(483.7918!, 23.0!)
        Me.xrLabel47.StylePriority.UseFont = False
        Me.xrLabel47.Text = "lblMasaBerlaku"
        Me.xrLabel47.WordWrap = False
        '
        'xrLabel46
        '
        Me.xrLabel46.CanGrow = False
        Me.xrLabel46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.KelasEmisi")})
        Me.xrLabel46.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 435.0834!)
        Me.xrLabel46.Name = "xrLabel46"
        Me.xrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel46.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel46.StylePriority.UseFont = False
        Me.xrLabel46.Text = "lblKelasEmisi"
        '
        'xrLabel45
        '
        Me.xrLabel45.CanGrow = False
        Me.xrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.BandFrekuensi")})
        Me.xrLabel45.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 412.0833!)
        Me.xrLabel45.Name = "xrLabel45"
        Me.xrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel45.SizeF = New System.Drawing.SizeF(483.7917!, 22.99997!)
        Me.xrLabel45.StylePriority.UseFont = False
        Me.xrLabel45.Text = "lblBrandFrekuensi"
        '
        'xrLabel42
        '
        Me.xrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.DayaDiatas30")})
        Me.xrLabel42.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(344.2083!, 343.0831!)
        Me.xrLabel42.Name = "xrLabel42"
        Me.xrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel42.SizeF = New System.Drawing.SizeF(369.7915!, 23.0!)
        Me.xrLabel42.StylePriority.UseFont = False
        Me.xrLabel42.Text = "lblDiatas30MHz"
        Me.xrLabel42.WordWrap = False
        '
        'xrLabel41
        '
        Me.xrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.DayaDibawah30")})
        Me.xrLabel41.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(360.8749!, 320.0834!)
        Me.xrLabel41.Name = "xrLabel41"
        Me.xrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel41.SizeF = New System.Drawing.SizeF(353.1249!, 23.0!)
        Me.xrLabel41.StylePriority.UseFont = False
        Me.xrLabel41.Text = "lblDibawah30MHz"
        Me.xrLabel41.WordWrap = False
        '
        'xrLabel40
        '
        Me.xrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.PenggunaanStasiun")})
        Me.xrLabel40.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(230.2081!, 366.0833!)
        Me.xrLabel40.Multiline = True
        Me.xrLabel40.Name = "xrLabel40"
        Me.xrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel40.SizeF = New System.Drawing.SizeF(483.7917!, 46.00006!)
        Me.xrLabel40.StylePriority.UseFont = False
        Me.xrLabel40.Text = "xrLabel40"
        '
        'xrLabel39
        '
        Me.xrLabel39.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 343.0833!)
        Me.xrLabel39.Name = "xrLabel39"
        Me.xrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel39.SizeF = New System.Drawing.SizeF(114.0!, 23.0!)
        Me.xrLabel39.StylePriority.UseFont = False
        Me.xrLabel39.Text = "Di atas 30 MHz"
        '
        'xrLabel38
        '
        Me.xrLabel38.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 320.0834!)
        Me.xrLabel38.Name = "xrLabel38"
        Me.xrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel38.SizeF = New System.Drawing.SizeF(130.6667!, 23.0!)
        Me.xrLabel38.StylePriority.UseFont = False
        Me.xrLabel38.Text = "Di bawah 30 MHz"
        '
        'xrLabel37
        '
        Me.xrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.AlamatStasiun")})
        Me.xrLabel37.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 274.0833!)
        Me.xrLabel37.Multiline = True
        Me.xrLabel37.Name = "xrLabel37"
        Me.xrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel37.SizeF = New System.Drawing.SizeF(483.7917!, 46.0!)
        Me.xrLabel37.StylePriority.UseFont = False
        Me.xrLabel37.Text = "lblAlamatStasiun"
        '
        'xrLabel35
        '
        Me.xrLabel35.CanGrow = False
        Me.xrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.NamaPanggilanKhusus")})
        Me.xrLabel35.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 251.0834!)
        Me.xrLabel35.Name = "xrLabel35"
        Me.xrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel35.SizeF = New System.Drawing.SizeF(483.7917!, 23.0!)
        Me.xrLabel35.StylePriority.UseFont = False
        Me.xrLabel35.Text = "lblCallSignKhusus"
        Me.xrLabel35.WordWrap = False
        '
        'xrLabel36
        '
        Me.xrLabel36.CanGrow = False
        Me.xrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.NomorIZIN")})
        Me.xrLabel36.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(230.2082!, 228.0833!)
        Me.xrLabel36.Name = "xrLabel36"
        Me.xrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel36.SizeF = New System.Drawing.SizeF(483.7917!, 23.0!)
        Me.xrLabel36.StylePriority.UseFont = False
        Me.xrLabel36.Text = "lblNomorIZIN"
        Me.xrLabel36.WordWrap = False
        '
        'lblNomorIZIN
        '
        Me.lblNomorIZIN.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblNomorIZIN.LocationFloat = New DevExpress.Utils.PointFloat(217.7083!, 458.0833!)
        Me.lblNomorIZIN.Name = "lblNomorIZIN"
        Me.lblNomorIZIN.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNomorIZIN.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.lblNomorIZIN.StylePriority.UseFont = False
        Me.lblNomorIZIN.Text = ":"
        '
        'xrLabel34
        '
        Me.xrLabel34.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 435.0833!)
        Me.xrLabel34.Name = "xrLabel34"
        Me.xrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel34.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel34.StylePriority.UseFont = False
        Me.xrLabel34.Text = ":"
        '
        'xrLabel33
        '
        Me.xrLabel33.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 251.0834!)
        Me.xrLabel33.Name = "xrLabel33"
        Me.xrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel33.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel33.StylePriority.UseFont = False
        Me.xrLabel33.Text = ":"
        '
        'xrLabel32
        '
        Me.xrLabel32.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 274.0833!)
        Me.xrLabel32.Name = "xrLabel32"
        Me.xrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel32.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel32.StylePriority.UseFont = False
        Me.xrLabel32.Text = ":"
        '
        'xrLabel31
        '
        Me.xrLabel31.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 320.0833!)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel31.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel31.StylePriority.UseFont = False
        Me.xrLabel31.Text = ":"
        '
        'xrLabel30
        '
        Me.xrLabel30.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(217.7083!, 412.0833!)
        Me.xrLabel30.Name = "xrLabel30"
        Me.xrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel30.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel30.StylePriority.UseFont = False
        Me.xrLabel30.Text = ":"
        '
        'xrLabel29
        '
        Me.xrLabel29.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(217.7082!, 366.0833!)
        Me.xrLabel29.Name = "xrLabel29"
        Me.xrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel29.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel29.StylePriority.UseFont = False
        Me.xrLabel29.Text = ":"
        '
        'xrLabel28
        '
        Me.xrLabel28.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(217.7083!, 228.0833!)
        Me.xrLabel28.Name = "xrLabel28"
        Me.xrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel28.SizeF = New System.Drawing.SizeF(12.49997!, 23.0!)
        Me.xrLabel28.StylePriority.UseFont = False
        Me.xrLabel28.Text = ":"
        '
        'xrLabel27
        '
        Me.xrLabel27.CanGrow = False
        Me.xrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIARKhusus.NamaLengkap")})
        Me.xrLabel27.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 867.7499!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(222.9167!, 23.0!)
        Me.xrLabel27.StylePriority.UseFont = False
        Me.xrLabel27.Text = "lblNamaLengkap2"
        '
        'xrLabel26
        '
        Me.xrLabel26.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(99.99987!, 750.9999!)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel26.SizeF = New System.Drawing.SizeF(181.25!, 23.0!)
        Me.xrLabel26.StylePriority.UseFont = False
        Me.xrLabel26.Text = "PENANGGUNG JAWAB"
        '
        'xrPictureBox2
        '
        Me.xrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "DataIARKhusus.FileFotoBitmap")})
        Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 750.9999!)
        Me.xrPictureBox2.Name = "xrPictureBox2"
        Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(100.0!, 139.75!)
        Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLabel25
        '
        Me.xrLabel25.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 666.0416!)
        Me.xrLabel25.Name = "xrLabel25"
        Me.xrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel25.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel25.StylePriority.UseFont = False
        Me.xrLabel25.Text = "ALAMAT"
        '
        'xrLabel24
        '
        Me.xrLabel24.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 643.0417!)
        Me.xrLabel24.Name = "xrLabel24"
        Me.xrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel24.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel24.StylePriority.UseFont = False
        Me.xrLabel24.Text = "PEKERJAAN"
        '
        'xrLabel23
        '
        Me.xrLabel23.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 620.0416!)
        Me.xrLabel23.Name = "xrLabel23"
        Me.xrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel23.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel23.StylePriority.UseFont = False
        Me.xrLabel23.Text = "TEMPAT, TANGGAL LAHIR"
        '
        'xrLabel22
        '
        Me.xrLabel22.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 597.0416!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel22.StylePriority.UseFont = False
        Me.xrLabel22.Text = "JENIS KELAMIN"
        '
        'xrLabel21
        '
        Me.xrLabel21.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 574.0416!)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel21.StylePriority.UseFont = False
        Me.xrLabel21.Text = "NAMA PANGGILAN"
        '
        'xrLabel20
        '
        Me.xrLabel20.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 551.0417!)
        Me.xrLabel20.Name = "xrLabel20"
        Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel20.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel20.StylePriority.UseFont = False
        Me.xrLabel20.Text = "NAMA LENGKAP"
        '
        'xrLabel19
        '
        Me.xrLabel19.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 500.0!)
        Me.xrLabel19.Multiline = True
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(714.0!, 28.58334!)
        Me.xrLabel19.StylePriority.UseFont = False
        Me.xrLabel19.StylePriority.UseTextAlignment = False
        Me.xrLabel19.Text = "DATA PENANGGUNG JAWAB"
        Me.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel18
        '
        Me.xrLabel18.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 458.0833!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel18.StylePriority.UseFont = False
        Me.xrLabel18.Text = "BERLAKU DARI"
        '
        'xrLabel17
        '
        Me.xrLabel17.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 435.0833!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel17.StylePriority.UseFont = False
        Me.xrLabel17.Text = "KELAS EMISI"
        '
        'xrLabel16
        '
        Me.xrLabel16.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 412.0833!)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel16.StylePriority.UseFont = False
        Me.xrLabel16.Text = "BAND FREKUENSI"
        '
        'xrLabel15
        '
        Me.xrLabel15.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 389.0833!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel15.StylePriority.UseFont = False
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 366.0833!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "PENGGUNAAN STASIUN"
        '
        'xrLabel13
        '
        Me.xrLabel13.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 343.0833!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel13.StylePriority.UseFont = False
        '
        'xrLabel12
        '
        Me.xrLabel12.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 320.0834!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel12.StylePriority.UseFont = False
        Me.xrLabel12.Text = "DAYA"
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 297.0833!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel11.StylePriority.UseFont = False
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 274.0833!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "ALAMAT STASIUN"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 251.0834!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "NAMA PANGGILAN"
        '
        'xrLabel8
        '
        Me.xrLabel8.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 228.0833!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.Text = "NOMOR IZIN"
        '
        'xrLabel7
        '
        Me.xrLabel7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 185.5!)
        Me.xrLabel7.Multiline = True
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(714.0!, 28.58334!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.StylePriority.UseTextAlignment = False
        Me.xrLabel7.Text = "DATA STASIUN AMATIR RADIO KHUSUS"
        Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel6
        '
        Me.xrLabel6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 141.2916!)
        Me.xrLabel6.Multiline = True
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(714.0!, 28.58334!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.StylePriority.UseTextAlignment = False
        Me.xrLabel6.Text = "IZIN KHUSUS AMATIR RADIO"
        Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 118.2916!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(714.0!, 23.0!)
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(607.7499!, 95.29165!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(106.25!, 23.0!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.StylePriority.UseForeColor = False
        Me.xrLabel5.Text = "www.postel.go.id"
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 95.29165!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(494.2083!, 23.0!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseForeColor = False
        Me.xrLabel4.Text = "Jl. Medan Merdeka Barat No. 17, Jakarta 10110 Telp. 021-3835931, 3835959 Fax. 021" & _
            "-3860754, 3844036"
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel3.ForeColor = System.Drawing.Color.Navy
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.29164!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 15.70831!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.Text = "KEMENKOMINFO"
        '
        'xrLabel2
        '
        Me.xrLabel2.Font = New System.Drawing.Font("Mistral", 20.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 46.91665!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(600.4583!, 48.375!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "Menuju Masyarakat Informasi Indonesia"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 0.0!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(600.4583!, 23.375!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "KEMENTERIAN KOMUNIKASI DAN INFORMATIKA RI"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(99.16666!, 96.74998!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrPictureBox3
        '
        Me.xrPictureBox3.ImageUrl = "~\Images\kartu\SKAR2012.jpg"
        Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(379.2777!, 770.9761!)
        Me.xrPictureBox3.Name = "xrPictureBox3"
        Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(269.2708!, 132.6783!)
        Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dsDataIARKhusus1
        '
        Me.dsDataIARKhusus1.DataSetName = "dsDataIARKhusus"
        Me.dsDataIARKhusus1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataIARKhususTableAdapter1
        '
        Me.dataIARKhususTableAdapter1.ClearBeforeFill = True
        '
        'rptCetakIARKhusus
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataIARKhususTableAdapter1
        Me.DataMember = "DataIARKhusus"
        Me.DataSource = Me.dsDataIARKhusus1
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "9.3"
        CType(Me.dsDataIARKhusus1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class