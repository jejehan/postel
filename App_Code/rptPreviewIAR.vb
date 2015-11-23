Public Class rptPreviewIAR
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
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblCallSign As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents dsDataIAR1 As dsDataIAR
    Private WithEvents dataIARTableAdapter1 As dsDataIARTableAdapters.DataIARTableAdapter
    Public WithEvents _Tingkat As DevExpress.XtraReports.Parameters.Parameter
    Public WithEvents _CallSign As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents xrRichText12 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText11 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText10 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText9 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText8 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptPreviewIAR.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptPreviewIAR.ResourceManager
        Dim code39ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrRichText2 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText8 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrRichText12 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText11 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText10 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText9 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText3 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblNama = New DevExpress.XtraReports.UI.XRLabel
        Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode
        Me.lblCallSign = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlamat1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataIAR1 = New dsDataIAR
        Me.dataIARTableAdapter1 = New dsDataIARTableAdapters.DataIARTableAdapter
        Me._Tingkat = New DevExpress.XtraReports.Parameters.Parameter
        Me._CallSign = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDataIAR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText2, Me.xrRichText8, Me.xrRichText1, Me.xrLine1, Me.xrRichText12, Me.xrRichText11, Me.xrRichText10, Me.xrRichText9, Me.xrRichText3, Me.xrLabel10, Me.xrLabel1, Me.xrLabel9, Me.xrLabel8, Me.lblNama, Me.xrBarCode1, Me.lblCallSign, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.lblAlamat1, Me.xrPictureBox1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 559.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrRichText2
        '
        Me.xrRichText2.Dpi = 254.0!
        Me.xrRichText2.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.xrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(402.4232!, 403.0699!)
        Me.xrRichText2.Name = "xrRichText2"
        Me.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString")
        Me.xrRichText2.SizeF = New System.Drawing.SizeF(437.8126!, 59.83492!)
        Me.xrRichText2.StylePriority.UseFont = False
        '
        'xrRichText8
        '
        Me.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText8.Dpi = 254.0!
        Me.xrRichText8.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.xrRichText8.LocationFloat = New DevExpress.Utils.PointFloat(437.4232!, 518.0699!)
        Me.xrRichText8.Name = "xrRichText8"
        Me.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString")
        Me.xrRichText8.SizeF = New System.Drawing.SizeF(403.6014!, 20.32!)
        Me.xrRichText8.StylePriority.UseBorders = False
        Me.xrRichText8.StylePriority.UseFont = False
        '
        'xrRichText1
        '
        Me.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText1.Dpi = 254.0!
        Me.xrRichText1.Font = New System.Drawing.Font("Arial", 5.0!, System.Drawing.FontStyle.Bold)
        Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(437.4232!, 493.0699!)
        Me.xrRichText1.Name = "xrRichText1"
        Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
        Me.xrRichText1.SizeF = New System.Drawing.SizeF(403.606!, 20.32!)
        Me.xrRichText1.StylePriority.UseBorders = False
        Me.xrRichText1.StylePriority.UseFont = False
        '
        'xrLine1
        '
        Me.xrLine1.Dpi = 254.0!
        Me.xrLine1.LineWidth = 3
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(496.0307!, 513.3899!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(279.9999!, 5.080002!)
        '
        'xrRichText12
        '
        Me.xrRichText12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText12.Dpi = 254.0!
        Me.xrRichText12.Font = New System.Drawing.Font("Myriad", 9.45!)
        Me.xrRichText12.LocationFloat = New DevExpress.Utils.PointFloat(164.9398!, 8.65134!)
        Me.xrRichText12.Name = "xrRichText12"
        Me.xrRichText12.SerializableRtfString = resources.GetString("xrRichText12.SerializableRtfString")
        Me.xrRichText12.SizeF = New System.Drawing.SizeF(701.686!, 35.56!)
        Me.xrRichText12.StylePriority.UseBorders = False
        Me.xrRichText12.StylePriority.UseFont = False
        '
        'xrRichText11
        '
        Me.xrRichText11.Dpi = 254.0!
        Me.xrRichText11.Font = New System.Drawing.Font("News Gothic MT", 6.0!, System.Drawing.FontStyle.Italic)
        Me.xrRichText11.LocationFloat = New DevExpress.Utils.PointFloat(164.9398!, 38.65133!)
        Me.xrRichText11.Name = "xrRichText11"
        Me.xrRichText11.SerializableRtfString = resources.GetString("xrRichText11.SerializableRtfString")
        Me.xrRichText11.SizeF = New System.Drawing.SizeF(701.686!, 27.94!)
        Me.xrRichText11.StylePriority.UseFont = False
        '
        'xrRichText10
        '
        Me.xrRichText10.Dpi = 254.0!
        Me.xrRichText10.Font = New System.Drawing.Font("Myriad", 6.0!)
        Me.xrRichText10.LocationFloat = New DevExpress.Utils.PointFloat(164.9398!, 63.65133!)
        Me.xrRichText10.Name = "xrRichText10"
        Me.xrRichText10.SerializableRtfString = resources.GetString("xrRichText10.SerializableRtfString")
        Me.xrRichText10.SizeF = New System.Drawing.SizeF(701.6862!, 48.25999!)
        Me.xrRichText10.StylePriority.UseFont = False
        '
        'xrRichText9
        '
        Me.xrRichText9.Dpi = 254.0!
        Me.xrRichText9.Font = New System.Drawing.Font("News Gothic MT", 5.0!, System.Drawing.FontStyle.Italic)
        Me.xrRichText9.LocationFloat = New DevExpress.Utils.PointFloat(164.9398!, 108.6513!)
        Me.xrRichText9.Name = "xrRichText9"
        Me.xrRichText9.SerializableRtfString = resources.GetString("xrRichText9.SerializableRtfString")
        Me.xrRichText9.SizeF = New System.Drawing.SizeF(701.6862!, 48.26!)
        Me.xrRichText9.StylePriority.UseFont = False
        '
        'xrRichText3
        '
        Me.xrRichText3.Dpi = 254.0!
        Me.xrRichText3.Font = New System.Drawing.Font("News Gothic MT", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(618.8781!, 347.8842!)
        Me.xrRichText3.Name = "xrRichText3"
        Me.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString")
        Me.xrRichText3.SizeF = New System.Drawing.SizeF(111.62!, 33.0!)
        Me.xrRichText3.StylePriority.UseFont = False
        '
        'xrLabel10
        '
        Me.xrLabel10.CanGrow = False
        Me.xrLabel10.Dpi = 254.0!
        Me.xrLabel10.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(715.8573!, 245.0675!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(108.7731!, 30.0!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.StylePriority.UsePadding = False
        Me.xrLabel10.Text = "/Class"
        Me.xrLabel10.WordWrap = False
        '
        'xrLabel1
        '
        Me.xrLabel1.CanGrow = False
        Me.xrLabel1.Dpi = 254.0!
        Me.xrLabel1.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(618.8804!, 245.0675!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(96.97687!, 30.0!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.Text = "Tingkat"
        Me.xrLabel1.WordWrap = False
        '
        'xrLabel9
        '
        Me.xrLabel9.CanGrow = False
        Me.xrLabel9.Dpi = 254.0!
        Me.xrLabel9.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(391.8719!, 371.0699!)
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
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 371.0699!)
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
        Me.lblNama.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Nama")})
        Me.lblNama.Dpi = 254.0!
        Me.lblNama.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNama.LocationFloat = New DevExpress.Utils.PointFloat(195.2199!, 245.0676!)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.lblNama.SizeF = New System.Drawing.SizeF(404.97!, 30.0!)
        Me.lblNama.StylePriority.UseFont = False
        Me.lblNama.StylePriority.UsePadding = False
        Me.lblNama.Text = "Nama"
        Me.lblNama.WordWrap = False
        '
        'xrBarCode1
        '
        Me.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.NomorIAR")})
        Me.xrBarCode1.Dpi = 254.0!
        Me.xrBarCode1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(27.68015!, 470.0822!)
        Me.xrBarCode1.Module = 508.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(364.1918!, 74.98251!)
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        code39ExtendedGenerator1.WideNarrowRatio = 2.2!
        Me.xrBarCode1.Symbology = code39ExtendedGenerator1
        Me.xrBarCode1.Text = "xrBarCode1"
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblCallSign
        '
        Me.lblCallSign.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.CallSign")})
        Me.lblCallSign.Dpi = 254.0!
        Me.lblCallSign.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblCallSign.LocationFloat = New DevExpress.Utils.PointFloat(730.498!, 347.8842!)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblCallSign.SizeF = New System.Drawing.SizeF(126.38!, 33.0!)
        Me.lblCallSign.StylePriority.UseFont = False
        Me.lblCallSign.Text = "CallSign"
        Me.lblCallSign.WordWrap = False
        '
        'xrLabel6
        '
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Class")})
        Me.xrLabel6.Dpi = 254.0!
        Me.xrLabel6.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(618.8804!, 300.0675!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(238.0!, 25.0!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.StylePriority.UsePadding = False
        Me.xrLabel6.Text = "xrLabel6"
        Me.xrLabel6.WordWrap = False
        '
        'xrLabel5
        '
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Tingkat")})
        Me.xrLabel5.Dpi = 254.0!
        Me.xrLabel5.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(618.8781!, 275.0675!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(238.0!, 25.0!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.StylePriority.UsePadding = False
        Me.xrLabel5.Text = "xrLabel5"
        Me.xrLabel5.WordWrap = False
        '
        'xrLabel4
        '
        Me.xrLabel4.CanGrow = False
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.TanggalBerlakuIAR")})
        Me.xrLabel4.Dpi = 254.0!
        Me.xrLabel4.Font = New System.Drawing.Font("News Gothic MT", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(194.2219!, 403.0699!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(176.4369!, 30.0!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UsePadding = False
        Me.xrLabel4.Text = "xrLabel4"
        Me.xrLabel4.WordWrap = False
        '
        'xrLabel3
        '
        Me.xrLabel3.CanGrow = False
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat3")})
        Me.xrLabel3.Dpi = 254.0!
        Me.xrLabel3.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 339.0699!)
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
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat2")})
        Me.xrLabel2.Dpi = 254.0!
        Me.xrLabel2.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 307.0699!)
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
        Me.lblAlamat1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat1")})
        Me.lblAlamat1.Dpi = 254.0!
        Me.lblAlamat1.Font = New System.Drawing.Font("News Gothic MT", 7.0!)
        Me.lblAlamat1.LocationFloat = New DevExpress.Utils.PointFloat(195.2219!, 275.0675!)
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
        'dsDataIAR1
        '
        Me.dsDataIAR1.DataSetName = "dsDataIAR"
        Me.dsDataIAR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataIARTableAdapter1
        '
        Me.dataIARTableAdapter1.ClearBeforeFill = True
        '
        '_Tingkat
        '
        Me._Tingkat.Name = "_Tingkat"
        Me._Tingkat.Value = ""
        '
        '_CallSign
        '
        Me._CallSign.Name = "_CallSign"
        Me._CallSign.Value = ""
        '
        'rptPreviewIAR
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataIARTableAdapter1
        Me.DataMember = "DataIAR"
        Me.DataSource = Me.dsDataIAR1
        Me.Dpi = 254.0!
        Me.FilterString = "[Tingkat] Like ?_Tingkat And [CallSign] Like ?_CallSign"
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 559
        Me.PageWidth = 876
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me._Tingkat, Me._CallSign})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 5.0!
        Me.Version = "9.3"
        Me.Watermark.Image = CType(resources.GetObject("rptPreviewIAR.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch
        Me.Watermark.TextTransparency = 0
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDataIAR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class