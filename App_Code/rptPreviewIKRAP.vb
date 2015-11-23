Public Class rptPreviewIKRAP
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
    Private WithEvents lblNama As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents lblAlamat1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblCallSign As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Private WithEvents xrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText6 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText8 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents dsDataIKRAP1 As dsDataIKRAP
    Private WithEvents dataIKRAPTableAdapter1 As dsDataIKRAPTableAdapters.DataIKRAPTableAdapter
    Public WithEvents _CallSign As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptPreviewIKRAP.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptPreviewIKRAP.ResourceManager
        Dim code39ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrRichText8 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.xrRichText6 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText4 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText3 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNama = New DevExpress.XtraReports.UI.XRLabel
        Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode
        Me.lblCallSign = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlamat1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrRichText2 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataIKRAP1 = New dsDataIKRAP
        Me.dataIKRAPTableAdapter1 = New dsDataIKRAPTableAdapters.DataIKRAPTableAdapter
        Me._CallSign = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDataIKRAP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText8, Me.xrPanel1, Me.xrRichText3, Me.xrLabel9, Me.xrLabel8, Me.lblNama, Me.xrBarCode1, Me.lblCallSign, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.lblAlamat1, Me.xrPictureBox1, Me.xrRichText2, Me.xrRichText1, Me.xrLine1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 559.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrRichText8
        '
        Me.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText8.Dpi = 254.0!
        Me.xrRichText8.Font = New System.Drawing.Font("News Gothic MT", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrRichText8.LocationFloat = New DevExpress.Utils.PointFloat(401.003!, 523.2532!)
        Me.xrRichText8.Name = "xrRichText8"
        Me.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString")
        Me.xrRichText8.SizeF = New System.Drawing.SizeF(455.875!, 25.4256!)
        Me.xrRichText8.StylePriority.UseBorders = False
        Me.xrRichText8.StylePriority.UseFont = False
        '
        'xrPanel1
        '
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText6, Me.xrRichText4})
        Me.xrPanel1.Dpi = 254.0!
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(151.5753!, 17.63541!)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(724.4247!, 131.7625!)
        '
        'xrRichText6
        '
        Me.xrRichText6.Dpi = 254.0!
        Me.xrRichText6.Font = New System.Drawing.Font("Myriad", 6.0!)
        Me.xrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 35.93044!)
        Me.xrRichText6.Name = "xrRichText6"
        Me.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString")
        Me.xrRichText6.SizeF = New System.Drawing.SizeF(719.0613!, 70.83206!)
        Me.xrRichText6.StylePriority.UseFont = False
        '
        'xrRichText4
        '
        Me.xrRichText4.Dpi = 254.0!
        Me.xrRichText4.Font = New System.Drawing.Font("Myriad", 9.45!)
        Me.xrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrRichText4.Name = "xrRichText4"
        Me.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString")
        Me.xrRichText4.SizeF = New System.Drawing.SizeF(719.0637!, 35.93042!)
        Me.xrRichText4.StylePriority.UseFont = False
        '
        'xrRichText3
        '
        Me.xrRichText3.Dpi = 254.0!
        Me.xrRichText3.Font = New System.Drawing.Font("News Gothic MT", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(616.2322!, 212.0676!)
        Me.xrRichText3.Name = "xrRichText3"
        Me.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString")
        Me.xrRichText3.SizeF = New System.Drawing.SizeF(111.62!, 33.0!)
        Me.xrRichText3.StylePriority.UseFont = False
        '
        'xrLabel9
        '
        Me.xrLabel9.CanGrow = False
        Me.xrLabel9.Dpi = 254.0!
        Me.xrLabel9.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(391.8719!, 349.0699!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(208.32!, 32.0!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.StylePriority.UsePadding = False
        Me.xrLabel9.Text = "/Valid Through"
        Me.xrLabel9.WordWrap = False
        '
        'xrLabel8
        '
        Me.xrLabel8.CanGrow = False
        Me.xrLabel8.Dpi = 254.0!
        Me.xrLabel8.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 349.0699!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(196.65!, 32.0!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.StylePriority.UsePadding = False
        Me.xrLabel8.Text = "Berlaku Sampai"
        Me.xrLabel8.WordWrap = False
        '
        'lblNama
        '
        Me.lblNama.CanGrow = False
        Me.lblNama.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.Nama")})
        Me.lblNama.Dpi = 254.0!
        Me.lblNama.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNama.LocationFloat = New DevExpress.Utils.PointFloat(195.2199!, 215.0676!)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.lblNama.SizeF = New System.Drawing.SizeF(404.97!, 30.0!)
        Me.lblNama.StylePriority.UseFont = False
        Me.lblNama.StylePriority.UsePadding = False
        Me.lblNama.Text = "lblNama"
        Me.lblNama.WordWrap = False
        '
        'xrBarCode1
        '
        Me.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.NomorIKRAP")})
        Me.xrBarCode1.Dpi = 254.0!
        Me.xrBarCode1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(27.68015!, 470.0822!)
        Me.xrBarCode1.Module = 508.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(364.1918!, 74.98251!)
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        code39ExtendedGenerator1.WideNarrowRatio = 3.0!
        Me.xrBarCode1.Symbology = code39ExtendedGenerator1
        Me.xrBarCode1.Text = "xrBarCode1"
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblCallSign
        '
        Me.lblCallSign.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.CallSign")})
        Me.lblCallSign.Dpi = 254.0!
        Me.lblCallSign.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblCallSign.LocationFloat = New DevExpress.Utils.PointFloat(616.2322!, 245.0676!)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblCallSign.SizeF = New System.Drawing.SizeF(126.38!, 33.0!)
        Me.lblCallSign.StylePriority.UseFont = False
        Me.lblCallSign.Text = "lblCallSign"
        Me.lblCallSign.WordWrap = False
        '
        'xrLabel4
        '
        Me.xrLabel4.CanGrow = False
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.TanggalBerlakuIKRAP")})
        Me.xrLabel4.Dpi = 254.0!
        Me.xrLabel4.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(194.2219!, 384.0699!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(165.914!, 29.99997!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UsePadding = False
        Me.xrLabel4.Text = "xrLabel4"
        Me.xrLabel4.WordWrap = False
        '
        'xrLabel3
        '
        Me.xrLabel3.CanGrow = False
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.Alamat3")})
        Me.xrLabel3.Dpi = 254.0!
        Me.xrLabel3.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 309.0699!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(404.97!, 32.0!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UsePadding = False
        Me.xrLabel3.Text = "xrLabel3"
        Me.xrLabel3.WordWrap = False
        '
        'xrLabel2
        '
        Me.xrLabel2.CanGrow = False
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.Alamat2")})
        Me.xrLabel2.Dpi = 254.0!
        Me.xrLabel2.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 277.0699!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(404.97!, 32.0!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UsePadding = False
        Me.xrLabel2.Text = "xrLabel2"
        Me.xrLabel2.WordWrap = False
        '
        'lblAlamat1
        '
        Me.lblAlamat1.CanGrow = False
        Me.lblAlamat1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAP.Alamat1")})
        Me.lblAlamat1.Dpi = 254.0!
        Me.lblAlamat1.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.lblAlamat1.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 245.0675!)
        Me.lblAlamat1.Name = "lblAlamat1"
        Me.lblAlamat1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.lblAlamat1.SizeF = New System.Drawing.SizeF(404.97!, 32.0!)
        Me.lblAlamat1.StylePriority.UseFont = False
        Me.lblAlamat1.StylePriority.UsePadding = False
        Me.lblAlamat1.Text = "lblAlamat1"
        Me.lblAlamat1.WordWrap = False
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "DataIAR.FileFotoBitmap")})
        Me.xrPictureBox1.Dpi = 254.0!
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(27.68015!, 191.1846!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(150.0!, 200.0!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrRichText2
        '
        Me.xrRichText2.Dpi = 254.0!
        Me.xrRichText2.Font = New System.Drawing.Font("News Gothic MT", 5.0!)
        Me.xrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(370.6588!, 402.5698!)
        Me.xrRichText2.Name = "xrRichText2"
        Me.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString")
        Me.xrRichText2.SizeF = New System.Drawing.SizeF(486.2192!, 67.51248!)
        Me.xrRichText2.StylePriority.UseFont = False
        '
        'xrRichText1
        '
        Me.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText1.Dpi = 254.0!
        Me.xrRichText1.Font = New System.Drawing.Font("News Gothic MT", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(401.003!, 495.2533!)
        Me.xrRichText1.Name = "xrRichText1"
        Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
        Me.xrRichText1.SizeF = New System.Drawing.SizeF(455.875!, 23.0!)
        Me.xrRichText1.StylePriority.UseBorders = False
        Me.xrRichText1.StylePriority.UseFont = False
        '
        'xrLine1
        '
        Me.xrLine1.Dpi = 254.0!
        Me.xrLine1.LineWidth = 3
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(489.6564!, 518.2532!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(280.0!, 5.0!)
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
        'dsDataIKRAP1
        '
        Me.dsDataIKRAP1.DataSetName = "dsDataIKRAP"
        Me.dsDataIKRAP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataIKRAPTableAdapter1
        '
        Me.dataIKRAPTableAdapter1.ClearBeforeFill = True
        '
        '_CallSign
        '
        Me._CallSign.Name = "_CallSign"
        Me._CallSign.Value = ""
        '
        'rptPreviewIKRAP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataIKRAPTableAdapter1
        Me.DataMember = "DataIKRAP"
        Me.DataSource = Me.dsDataIKRAP1
        Me.Dpi = 254.0!
        Me.FilterString = "[CallSign] Like Concat(?_CallSign, '%')"
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 559
        Me.PageWidth = 876
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me._CallSign})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 5.0!
        Me.Version = "9.3"
        Me.Watermark.TextTransparency = 0
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDataIKRAP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class