Public Class rptCetakIARPenegak
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
    Private WithEvents lblAlamat2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblAlamat3 As DevExpress.XtraReports.UI.XRLabel
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
    Private WithEvents xrRichText8 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Private WithEvents dsDataIARPenegak1 As dsDataIARPenegak
    Private WithEvents dataIARPenegak1 As dsDataIARPenegakTableAdapters.DataIARPenegak
    Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Private WithEvents xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "rptCetakIARPenegak.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.rptCetakIARPenegak.ResourceManager
        Dim code93ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrRichText8 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText2 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText
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
        Me.lblAlamat3 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlamat2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblAlamat1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dsDataIARPenegak1 = New dsDataIARPenegak
        Me.dataIARPenegak1 = New dsDataIARPenegakTableAdapters.DataIARPenegak
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDataIARPenegak1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1, Me.xrRichText8, Me.xrRichText2, Me.xrLine1, Me.xrRichText1, Me.xrRichText3, Me.xrLabel10, Me.xrLabel1, Me.xrLabel9, Me.xrLabel8, Me.lblNama, Me.xrBarCode1, Me.lblCallSign, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.lblAlamat3, Me.lblAlamat2, Me.lblAlamat1, Me.xrPictureBox1})
        Me.Detail.HeightF = 206.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrPanel1
        '
        Me.xrPanel1.BackColor = System.Drawing.Color.Black
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox2})
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(338.0!, 63.95833!)
        Me.xrPanel1.StylePriority.UseBackColor = False
        '
        'xrPictureBox2
        '
        Me.xrPictureBox2.BackColor = System.Drawing.Color.Black
        Me.xrPictureBox2.Image = CType(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image)
        Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox2.Name = "xrPictureBox2"
        Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(338.0!, 62.91667!)
        Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.xrPictureBox2.StylePriority.UseBackColor = False
        '
        'xrRichText8
        '
        Me.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText8.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.xrRichText8.LocationFloat = New DevExpress.Utils.PointFloat(175.4553!, 194.8356!)
        Me.xrRichText8.Name = "xrRichText8"
        Me.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString")
        Me.xrRichText8.SizeF = New System.Drawing.SizeF(158.8982!, 10.0!)
        Me.xrRichText8.StylePriority.UseBorders = False
        Me.xrRichText8.StylePriority.UseFont = False
        '
        'xrRichText2
        '
        Me.xrRichText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.xrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(163.4454!, 154.3!)
        Me.xrRichText2.Name = "xrRichText2"
        Me.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString")
        Me.xrRichText2.SizeF = New System.Drawing.SizeF(174.5546!, 32.1143!)
        Me.xrRichText2.StylePriority.UseFont = False
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(199.5667!, 193.8356!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(110.2362!, 2.0!)
        '
        'xrRichText1
        '
        Me.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrRichText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Bold)
        Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(175.4535!, 186.4143!)
        Me.xrRichText1.Name = "xrRichText1"
        Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
        Me.xrRichText1.SizeF = New System.Drawing.SizeF(158.9!, 9.0!)
        Me.xrRichText1.StylePriority.UseBorders = False
        Me.xrRichText1.StylePriority.UseFont = False
        '
        'xrRichText3
        '
        Me.xrRichText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(243.6537!, 131.0!)
        Me.xrRichText3.Name = "xrRichText3"
        Me.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString")
        Me.xrRichText3.SizeF = New System.Drawing.SizeF(41.23415!, 12.65741!)
        Me.xrRichText3.StylePriority.UseFont = False
        '
        'xrLabel10
        '
        Me.xrLabel10.CanGrow = False
        Me.xrLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(281.8335!, 96.5!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(42.82404!, 11.8!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.StylePriority.UsePadding = False
        Me.xrLabel10.Text = "/Class"
        Me.xrLabel10.WordWrap = False
        '
        'xrLabel1
        '
        Me.xrLabel1.CanGrow = False
        Me.xrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(243.6536!, 96.5!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(38.17986!, 11.8!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.Text = "Tingkat"
        Me.xrLabel1.WordWrap = False
        '
        'xrLabel9
        '
        Me.xrLabel9.CanGrow = False
        Me.xrLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(150.8193!, 142.5!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(70.44168!, 11.8!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.StylePriority.UsePadding = False
        Me.xrLabel9.Text = "/Valid Through"
        Me.xrLabel9.WordWrap = False
        '
        'xrLabel8
        '
        Me.xrLabel8.CanGrow = False
        Me.xrLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(73.86112!, 142.5!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(76.95826!, 11.8!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.StylePriority.UsePadding = False
        Me.xrLabel8.Text = "Berlaku Sampai"
        Me.xrLabel8.WordWrap = False
        '
        'lblNama
        '
        Me.lblNama.CanGrow = False
        Me.lblNama.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Nama")})
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNama.LocationFloat = New DevExpress.Utils.PointFloat(73.86109!, 96.5!)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblNama.SizeF = New System.Drawing.SizeF(165.6!, 11.8!)
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
        Me.xrBarCode1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(9.322893!, 177.857!)
        Me.xrBarCode1.Module = 200.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(149.69!, 25.97858!)
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        Me.xrBarCode1.Symbology = code93ExtendedGenerator1
        Me.xrBarCode1.Text = "xrBarCode1"
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblCallSign
        '
        Me.lblCallSign.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.CallSign")})
        Me.lblCallSign.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.0!)
        Me.lblCallSign.LocationFloat = New DevExpress.Utils.PointFloat(284.8878!, 131.0!)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCallSign.SizeF = New System.Drawing.SizeF(53.11212!, 11.79999!)
        Me.lblCallSign.StylePriority.UseFont = False
        Me.lblCallSign.Text = "CallSign"
        Me.lblCallSign.WordWrap = False
        '
        'xrLabel6
        '
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Class")})
        Me.xrLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(243.6537!, 119.5!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(90.6998!, 11.8!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.StylePriority.UsePadding = False
        Me.xrLabel6.Text = "xrLabel6"
        Me.xrLabel6.WordWrap = False
        '
        'xrLabel5
        '
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Tingkat")})
        Me.xrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(243.6537!, 108.0!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(90.7007!, 11.8!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.StylePriority.UsePadding = False
        Me.xrLabel5.Text = "xrLabel5"
        Me.xrLabel5.WordWrap = False
        '
        'xrLabel4
        '
        Me.xrLabel4.CanGrow = False
        Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.TanggalBerlakuIAR")})
        Me.xrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(73.8611!, 154.0!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(85.15179!, 11.8!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UsePadding = False
        Me.xrLabel4.Text = "xrLabel4"
        Me.xrLabel4.WordWrap = False
        '
        'lblAlamat3
        '
        Me.lblAlamat3.CanGrow = False
        Me.lblAlamat3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat3")})
        Me.lblAlamat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblAlamat3.LocationFloat = New DevExpress.Utils.PointFloat(73.86112!, 131.0!)
        Me.lblAlamat3.Name = "lblAlamat3"
        Me.lblAlamat3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblAlamat3.SizeF = New System.Drawing.SizeF(165.6042!, 11.8!)
        Me.lblAlamat3.StylePriority.UseFont = False
        Me.lblAlamat3.StylePriority.UsePadding = False
        Me.lblAlamat3.Text = "lblAlamat3"
        Me.lblAlamat3.WordWrap = False
        '
        'lblAlamat2
        '
        Me.lblAlamat2.CanGrow = False
        Me.lblAlamat2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat2")})
        Me.lblAlamat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblAlamat2.LocationFloat = New DevExpress.Utils.PointFloat(73.86113!, 119.5!)
        Me.lblAlamat2.Name = "lblAlamat2"
        Me.lblAlamat2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblAlamat2.SizeF = New System.Drawing.SizeF(165.6042!, 11.8!)
        Me.lblAlamat2.StylePriority.UseFont = False
        Me.lblAlamat2.StylePriority.UsePadding = False
        Me.lblAlamat2.Text = "lblAlamat1"
        Me.lblAlamat2.WordWrap = False
        '
        'lblAlamat1
        '
        Me.lblAlamat1.CanGrow = False
        Me.lblAlamat1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DataIAR.Alamat1")})
        Me.lblAlamat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblAlamat1.LocationFloat = New DevExpress.Utils.PointFloat(73.86111!, 108.0!)
        Me.lblAlamat1.Name = "lblAlamat1"
        Me.lblAlamat1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblAlamat1.SizeF = New System.Drawing.SizeF(165.6!, 11.8!)
        Me.lblAlamat1.StylePriority.UseFont = False
        Me.lblAlamat1.StylePriority.UsePadding = False
        Me.lblAlamat1.Text = "lblAlamat1"
        Me.lblAlamat1.WordWrap = False
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "DataIAR.FileFotoBitmap")})
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(12.32289!, 75.63173!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(59.05512!, 78.74016!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dsDataIARPenegak1
        '
        Me.dsDataIARPenegak1.DataSetName = "dsDataIARPenegak"
        Me.dsDataIARPenegak1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataIARPenegak1
        '
        Me.dataIARPenegak1.ClearBeforeFill = True
        '
        'rptCetakIARPenegak
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.dataIARPenegak1
        Me.DataMember = "DataIAR"
        Me.DataSource = Me.dsDataIARPenegak1
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 213
        Me.PageWidth = 338
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PrinterName = "Datacard Printer"
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 1.968504!
        Me.Version = "9.3"
        Me.Watermark.Image = CType(resources.GetObject("rptCetakIARPenegak.Watermark.Image"), System.Drawing.Image)
        Me.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch
        Me.Watermark.TextTransparency = 0
        CType(Me.xrRichText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDataIARPenegak1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class