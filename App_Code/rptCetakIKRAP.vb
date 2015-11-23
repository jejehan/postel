Public Class rptCetakIKRAP
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
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Private WithEvents xrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText8 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents dsDataIKRAPCetak2 As dsDataIKRAPCetak
    Private WithEvents dataIKRAPTableAdapterCetak1 As dsDataIKRAPCetakTableAdapters.DataIKRAPTableAdapterCetak
    Private WithEvents xrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText6 As DevExpress.XtraReports.UI.XRRichText

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptCetakIKRAP.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptCetakIKRAP.ResourceManager
        Dim code93ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrRichText6 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText8 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.xrRichText5 = New DevExpress.XtraReports.UI.XRRichText
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
        Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataIKRAPCetak2 = New dsDataIKRAPCetak
        Me.dataIKRAPTableAdapterCetak1 = New dsDataIKRAPCetakTableAdapters.DataIKRAPTableAdapterCetak
        CType(Me.xrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDataIKRAPCetak2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText6, Me.xrRichText8, Me.xrPanel1, Me.xrRichText3, Me.xrLabel9, Me.xrLabel8, Me.lblNama, Me.xrBarCode1, Me.lblCallSign, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.lblAlamat1, Me.xrPictureBox1, Me.xrRichText1, Me.xrLine1})
        Me.Detail.HeightF = 226.3674!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrRichText6
        '
        Me.xrRichText6.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.xrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(154.2803!, 151.0275!)
        Me.xrRichText6.Name = "xrRichText6"
        Me.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString")
        Me.xrRichText6.SizeF = New System.Drawing.SizeF(183.7197!, 26.57971!)
        Me.xrRichText6.StylePriority.UseFont = False
        '
        'xrRichText8
        '
        Me.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText8.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.xrRichText8.LocationFloat = New DevExpress.Utils.PointFloat(174.5419!, 202.3674!)
        Me.xrRichText8.Name = "xrRichText8"
        Me.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString")
        Me.xrRichText8.SizeF = New System.Drawing.SizeF(162.8117!, 8.0!)
        Me.xrRichText8.StylePriority.UseBorders = False
        Me.xrRichText8.StylePriority.UseFont = False
        '
        'xrPanel1
        '
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText5, Me.xrRichText4})
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(52.73087!, 6.943075!)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(284.6227!, 51.87498!)
        '
        'xrRichText5
        '
        Me.xrRichText5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(3.999996!, 19.28643!)
        Me.xrRichText5.Name = "xrRichText5"
        Me.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString")
        Me.xrRichText5.SizeF = New System.Drawing.SizeF(279.095!, 26.58853!)
        Me.xrRichText5.StylePriority.UseFont = False
        '
        'xrRichText4
        '
        Me.xrRichText4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.xrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 3.999998!)
        Me.xrRichText4.Name = "xrRichText4"
        Me.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString")
        Me.xrRichText4.SizeF = New System.Drawing.SizeF(275.2066!, 15.28645!)
        Me.xrRichText4.StylePriority.UseFont = False
        '
        'xrRichText3
        '
        Me.xrRichText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(242.6111!, 83.49118!)
        Me.xrRichText3.Name = "xrRichText3"
        Me.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString")
        Me.xrRichText3.SizeF = New System.Drawing.SizeF(43.94487!, 12.99213!)
        Me.xrRichText3.StylePriority.UseFont = False
        '
        'xrLabel9
        '
        Me.xrLabel9.CanGrow = False
        Me.xrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(154.2803!, 137.4291!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(82.01575!, 12.59842!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.StylePriority.UsePadding = False
        Me.xrLabel9.Text = "/Valid Through"
        Me.xrLabel9.WordWrap = False
        '
        'xrLabel8
        '
        Me.xrLabel8.CanGrow = False
        Me.xrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(76.85902!, 137.4291!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(77.42126!, 12.59842!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.StylePriority.UsePadding = False
        Me.xrLabel8.Text = "Berlaku Sampai"
        Me.xrLabel8.WordWrap = False
        '
        'lblNama
        '
        Me.lblNama.CanGrow = False
        Me.lblNama.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.Nama")})
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNama.LocationFloat = New DevExpress.Utils.PointFloat(76.85822!, 84.67228!)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblNama.SizeF = New System.Drawing.SizeF(159.437!, 11.81103!)
        Me.lblNama.StylePriority.UseFont = False
        Me.lblNama.StylePriority.UsePadding = False
        Me.lblNama.Text = "lblNama"
        Me.lblNama.WordWrap = False
        '
        'xrBarCode1
        '
        Me.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.NomorIKRAP")})
        Me.xrBarCode1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(10.8977!, 178.0717!)
        Me.xrBarCode1.Module = 200.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(146.9775!, 29.52068!)
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        Me.xrBarCode1.Symbology = code93ExtendedGenerator1
        Me.xrBarCode1.Text = "xrBarCode1"
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblCallSign
        '
        Me.lblCallSign.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.CallSign")})
        Me.lblCallSign.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblCallSign.LocationFloat = New DevExpress.Utils.PointFloat(242.6111!, 96.48328!)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCallSign.SizeF = New System.Drawing.SizeF(85.32637!, 12.99212!)
        Me.lblCallSign.StylePriority.UseFont = False
        Me.lblCallSign.Text = "lblCallSign"
        Me.lblCallSign.WordWrap = False
        '
        'xrLabel4
        '
        Me.xrLabel4.CanGrow = False
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.TanggalBerlakuIKRAP")})
        Me.xrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(76.46531!, 151.2086!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(77.81498!, 11.811!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UsePadding = False
        Me.xrLabel4.Text = "xrLabel4"
        Me.xrLabel4.WordWrap = False
        '
        'xrLabel3
        '
        Me.xrLabel3.CanGrow = False
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.Alamat3")})
        Me.xrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(76.85902!, 121.6811!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(159.437!, 12.59842!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UsePadding = False
        Me.xrLabel3.Text = "xrLabel3"
        Me.xrLabel3.WordWrap = False
        '
        'xrLabel2
        '
        Me.xrLabel2.CanGrow = False
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.Alamat2")})
        Me.xrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(76.85902!, 109.0826!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(159.437!, 12.59843!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UsePadding = False
        Me.xrLabel2.Text = "xrLabel2"
        Me.xrLabel2.WordWrap = False
        '
        'lblAlamat1
        '
        Me.lblAlamat1.CanGrow = False
        Me.lblAlamat1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIKRAPCetak.Alamat1")})
        Me.lblAlamat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblAlamat1.LocationFloat = New DevExpress.Utils.PointFloat(76.85902!, 96.48327!)
        Me.lblAlamat1.Name = "lblAlamat1"
        Me.lblAlamat1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblAlamat1.SizeF = New System.Drawing.SizeF(159.437!, 12.59843!)
        Me.lblAlamat1.StylePriority.UseFont = False
        Me.lblAlamat1.StylePriority.UsePadding = False
        Me.lblAlamat1.Text = "lblAlamat1"
        Me.lblAlamat1.WordWrap = False
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "DataIAR.FileFotoBitmap")})
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(10.8977!, 77.3114!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(60.35719!, 80.04225!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrRichText1
        '
        Me.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText1.Font = New System.Drawing.Font("Arial", 5.0!, System.Drawing.FontStyle.Bold)
        Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(175.1883!, 193.0717!)
        Me.xrRichText1.Name = "xrRichText1"
        Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
        Me.xrRichText1.SizeF = New System.Drawing.SizeF(162.8117!, 8.0!)
        Me.xrRichText1.StylePriority.UseBorders = False
        Me.xrRichText1.StylePriority.UseFont = False
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(199.8647!, 200.3989!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(110.2362!, 2.0!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dsDataIKRAPCetak2
        '
        Me.dsDataIKRAPCetak2.DataSetName = "dsDataIKRAPCetak"
        Me.dsDataIKRAPCetak2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataIKRAPTableAdapterCetak1
        '
        Me.dataIKRAPTableAdapterCetak1.ClearBeforeFill = True
        '
        'rptCetakIKRAP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataIKRAPTableAdapterCetak1
        Me.DataMember = "DataIKRAPCetak"
        Me.DataSource = Me.dsDataIKRAPCetak2
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 213
        Me.PageWidth = 338
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 1.968504!
        Me.Version = "9.3"
        Me.Watermark.Image = CType(resources.GetObject("rptCetakIKRAP.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch
        Me.Watermark.TextTransparency = 0
        CType(Me.xrRichText6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDataIKRAPCetak2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class