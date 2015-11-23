Public Class rptPreviewSKAR
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
    Private WithEvents dsDataSKAR1 As dsDataSKAR
    Private WithEvents dataProsesTableAdapter1 As dsDataSKARTableAdapters.DataSKARTableAdapter
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents LblJakarta As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents LblNomor As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents nmrSKAR As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents LblDirjenPostel As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptPreviewSKAR.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptPreviewSKAR.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.LblDirjenPostel = New DevExpress.XtraReports.UI.XRLabel
        Me.LblJakarta = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.LblNomor = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataSKAR1 = New dsDataSKAR
        Me.dataProsesTableAdapter1 = New dsDataSKARTableAdapters.DataSKARTableAdapter
        Me.nmrSKAR = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.dsDataSKAR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Empty
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel9, Me.LblDirjenPostel, Me.LblJakarta, Me.xrLabel8, Me.xrPictureBox2, Me.LblNomor, Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 2072.645!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel9
        '
        Me.xrLabel9.AutoWidth = True
        Me.xrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel9.Dpi = 254.0!
        Me.xrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1230.249!, 1298.295!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(669.396!, 34.50159!)
        Me.xrLabel9.StylePriority.UseBackColor = False
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.StylePriority.UseTextAlignment = False
        Me.xrLabel9.Text = "NIP. : 196312231986031015"
        Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrLabel9.WordWrap = False
        '
        'LblDirjenPostel
        '
        Me.LblDirjenPostel.AutoWidth = True
        Me.LblDirjenPostel.BackColor = System.Drawing.Color.Transparent
        Me.LblDirjenPostel.Dpi = 254.0!
        Me.LblDirjenPostel.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.LblDirjenPostel.LocationFloat = New DevExpress.Utils.PointFloat(1198.499!, 1234.795!)
        Me.LblDirjenPostel.Name = "LblDirjenPostel"
        Me.LblDirjenPostel.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.LblDirjenPostel.SizeF = New System.Drawing.SizeF(669.3959!, 60.95984!)
        Me.LblDirjenPostel.StylePriority.UseBackColor = False
        Me.LblDirjenPostel.StylePriority.UseFont = False
        Me.LblDirjenPostel.StylePriority.UseTextAlignment = False
        Me.LblDirjenPostel.Text = "DR. MUHAMMAD BUDI SETIAWAN"
        Me.LblDirjenPostel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.LblDirjenPostel.WordWrap = False
        '
        'LblJakarta
        '
        Me.LblJakarta.AutoWidth = True
        Me.LblJakarta.BackColor = System.Drawing.Color.Transparent
        Me.LblJakarta.Dpi = 254.0!
        Me.LblJakarta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LblJakarta.LocationFloat = New DevExpress.Utils.PointFloat(1277.937!, 960.2737!)
        Me.LblJakarta.Name = "LblJakarta"
        Me.LblJakarta.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.LblJakarta.SizeF = New System.Drawing.SizeF(145.5206!, 58.41986!)
        Me.LblJakarta.StylePriority.UseBackColor = False
        Me.LblJakarta.StylePriority.UseFont = False
        Me.LblJakarta.StylePriority.UseTextAlignment = False
        Me.LblJakarta.Text = "Jakarta,"
        Me.LblJakarta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.LblJakarta.WordWrap = False
        '
        'xrLabel8
        '
        Me.xrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.xrLabel8.CanGrow = False
        Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.TanggalSKAR", "{0}")})
        Me.xrLabel8.Dpi = 254.0!
        Me.xrLabel8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1423.458!, 960.2737!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(309.5!, 58.41998!)
        Me.xrLabel8.StylePriority.UseBackColor = False
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.StylePriority.UseTextAlignment = False
        Me.xrLabel8.Text = "LblTanggalSKAR"
        Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrLabel8.WordWrap = False
        '
        'xrPictureBox2
        '
        Me.xrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "DataSKAR.FileFotoBitmap")})
        Me.xrPictureBox2.Dpi = 254.0!
        Me.xrPictureBox2.Image = CType(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image)
        Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(298.4975!, 797.0783!)
        Me.xrPictureBox2.Name = "xrPictureBox2"
        Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(288.3958!, 389.1492!)
        Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.xrPictureBox2.StylePriority.UseBorders = False
        '
        'LblNomor
        '
        Me.LblNomor.AutoWidth = True
        Me.LblNomor.Dpi = 254.0!
        Me.LblNomor.Font = New System.Drawing.Font("Bernard MT Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomor.LocationFloat = New DevExpress.Utils.PointFloat(1364.72!, 182.625!)
        Me.LblNomor.Name = "LblNomor"
        Me.LblNomor.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.LblNomor.SizeF = New System.Drawing.SizeF(145.521!, 58.41997!)
        Me.LblNomor.StylePriority.UseFont = False
        Me.LblNomor.StylePriority.UseTextAlignment = False
        Me.LblNomor.Text = "Nomor :"
        Me.LblNomor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.LblNomor.WordWrap = False
        '
        'xrLabel7
        '
        Me.xrLabel7.AutoWidth = True
        Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.LokasiUNAR", "{0}")})
        Me.xrLabel7.Dpi = 254.0!
        Me.xrLabel7.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(751.0!, 922.3746!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(492.1248!, 58.41998!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.Text = "LblLokasiUNAR"
        Me.xrLabel7.WordWrap = False
        '
        'xrLabel6
        '
        Me.xrLabel6.AutoWidth = True
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.TanggalUNAR", "{0}")})
        Me.xrLabel6.Dpi = 254.0!
        Me.xrLabel6.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1409.7!, 867.5159!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(579.4377!, 58.41992!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.Text = "LblTanggalUNAR"
        Me.xrLabel6.WordWrap = False
        '
        'xrLabel5
        '
        Me.xrLabel5.AutoWidth = True
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.NomorSKAR")})
        Me.xrLabel5.Dpi = 254.0!
        Me.xrLabel5.Font = New System.Drawing.Font("Bernard MT Condensed", 11.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1510.241!, 182.625!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(439.7375!, 58.41997!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "xrLabel5"
        Me.xrLabel5.WordWrap = False
        '
        'xrLabel4
        '
        Me.xrLabel4.AutoWidth = True
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.Tingkat", "{0}")})
        Me.xrLabel4.Dpi = 254.0!
        Me.xrLabel4.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1050.333!, 719.0833!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(828.1455!, 58.41986!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.Text = "LblTingkat"
        Me.xrLabel4.WordWrap = False
        '
        'xrLabel3
        '
        Me.xrLabel3.CanGrow = False
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.Alamat", "{0}")})
        Me.xrLabel3.Dpi = 254.0!
        Me.xrLabel3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1050.333!, 629.7708!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(828.1456!, 58.41998!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = "LblAlamat"
        Me.xrLabel3.WordWrap = False
        '
        'xrLabel2
        '
        Me.xrLabel2.AutoWidth = True
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.TempatTanggalLahir", "{0}")})
        Me.xrLabel2.Dpi = 254.0!
        Me.xrLabel2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1050.333!, 541.4586!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(682.625!, 58.41986!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "LblTempatTanggalLahir"
        Me.xrLabel2.WordWrap = False
        '
        'xrLabel1
        '
        Me.xrLabel1.AutoWidth = True
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataSKAR.Nama", "{0}")})
        Me.xrLabel1.Dpi = 254.0!
        Me.xrLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1050.333!, 452.9776!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(682.625!, 58.42001!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "LblNama"
        Me.xrLabel1.WordWrap = False
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrPictureBox1.Dpi = 254.0!
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(1248.833!, 1072.658!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(484.125!, 225.6371!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.xrPictureBox1.StylePriority.UseBorders = False
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dsDataSKAR1
        '
        Me.dsDataSKAR1.DataSetName = "dsDataSKAR"
        Me.dsDataSKAR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataProsesTableAdapter1
        '
        Me.dataProsesTableAdapter1.ClearBeforeFill = True
        '
        'nmrSKAR
        '
        Me.nmrSKAR.Name = "nmrSKAR"
        Me.nmrSKAR.Value = """"""
        '
        'rptPreviewSKAR
        '
        Me.BackColor = System.Drawing.Color.Empty
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataProsesTableAdapter1
        Me.DataMember = "DataSKAR"
        Me.DataSource = Me.dsDataSKAR1
        Me.Dpi = 254.0!
        Me.FilterString = "[NomorSKAR] Like ?nmrSKAR"
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 1500
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.nmrSKAR})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 31.75!
        Me.Version = "9.3"
        Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch
        CType(Me.dsDataSKAR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class