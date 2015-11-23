<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFormKhusus.ascx.vb"
    Inherits="UserControls_ucFormKhusus" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<script type='text/javascript'>
    function cancelClick() {
    }
    function OnOrdaChanged(CmbOrda) {
        cmbOrlok.PerformCallback(CmbOrda.GetValue().toString());
    }
</script>

<style type="text/css">
    .style7
    {
        width: 700px;
    }
    .style8
    {
        font-family: Arial, Helvetica, sans-serif;
        font-weight: bold;
        text-align: center;
        color: #000066;
    }
    .style9
    {
        font-size: xx-small;
    }
</style>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
</dx:ASPxCallback>
<table style="width: 980px;" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td style="width: 140px;">
            &nbsp;
        </td>
        <td align="center">
            <table style="width: 700px;" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td style="width: 125px">
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td style="width: 40%" colspan="2">
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td style="width: 40%" colspan="2">
                    </td>
                </tr>
                <tr>
                    <td class="font-Title" colspan="9" align="center">
                        DATA IAR KHUSUS</td>
                </tr>
                <tr>
                    <td colspan="9">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="9">
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxButton ID="BtnNew" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Baru" Width="130px" Wrap="False">
                                        <Image Url="~/Images/Baru-16x16.png">
                                        </Image>
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="BtnSave" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Simpan" Width="130px" Wrap="False">
                                        <Image Url="~/Images/Save-16x16.png">
                                        </Image>
                                        <ClientSideEvents Click="function(s, e) {
                                 Callback.PerformCallback();
                                 LoadingPanel.Show();
                             }" />
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="BtnCancel" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Kembali" Width="130px" Wrap="False">
                                        <Image Url="~/Images/Undo-16x16.png">
                                        </Image>
                                    </dx:ASPxButton>
                                    <dx:ASPxButton ID="BtnSaveProses" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Simpan &amp; Proses" Width="130px" Wrap="False" Visible="False">
                                        <Image Url="~/Images/Save-16x16.png">
                                        </Image>
                                        <ClientSideEvents Click="function(s, e) {
                                 Callback.PerformCallback();
                                 LoadingPanel.Show();
                             }" />
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    &nbsp;</td>
                                <td style="width: 90%; text-align: left;">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="9">
                        <table cellpadding="0" cellspacing="5" class="style7">
                            <tr>
                                <td class="style8" colspan="2">
                                    DATA STASIUN AMATIR RADIO KHUSUS
                                </td>
                            </tr>
                            <tr>
                                <td class="style9">
                                    &nbsp;
                                </td>
                                <td class="style9">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    NOMOR IZIN:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxNomorIzin" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    NAMA PANGGILAN KHUSUS:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxCallSignKhusus" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2" valign="top">
                                    ALAMAT STASIUN:<br />
                                    &nbsp;
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxAlamatStasiun" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="40px" MaxLength="255" Rows="2" TextMode="MultiLine" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    DAYA:
                                </td>
                                <td class="font-tabel-left">
                                    Di bawah 30 MHz
                                    <asp:TextBox ID="tbxDayaDiBawah30" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td class="font-tabel-left">
                                    Di atas 30 MHz
                                    <asp:TextBox ID="tbxDayaDiAtas30" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    PENGGUNAAN STASIUN:<br />
                                    &nbsp;
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxPenggunaanStasiun" runat="server" CssClass="TextBox-Flat-Blue"
                                        Width="400px" Height="40px" MaxLength="255" Rows="2" TextMode="MultiLine" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    BAND FREKUENSI:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxBandFrekuensi" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    KELAS EMISI:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxKelasEmisi" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    BERLAKU DARI:
                                </td>
                                <td align="left">
                                    <table cellpadding="0" cellspacing="0" style="width: 400px;">
                                        <tr>
                                            <td>
                                                <dx:ASPxDateEdit ID="dateTanggalAwal" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                                    <ButtonStyle Width="13px">
                                                    </ButtonStyle>
                                                </dx:ASPxDateEdit>
                                            </td>
                                            <td class="font-tabel-center-xsmall" style="width: 40px;">
                                                s/d
                                            </td>
                                            <td>
                                                <dx:ASPxDateEdit ID="dateTanggalAkhir" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                                    <ButtonStyle Width="13px">
                                                    </ButtonStyle>
                                                </dx:ASPxDateEdit>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    ORARI DAERAH:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddlOrda" runat="server" Width="200px" CssClass="TextBox-Flat-Blue">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    ORARI LOKAL:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddlOrlok" runat="server" Width="200px" CssClass="TextBox-Flat-Blue">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="style8" colspan="2">
                                    DATA PENANGGUNG JAWAB
                                </td>
                            </tr>
                            <tr>
                                <td class="style9">
                                    &nbsp;
                                </td>
                                <td class="style9">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    NAMA LENGKAP:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxNamaLengkap" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    NAMA PANGGILAN:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxCallSign" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    JENIS KELAMIN:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddlKelamin" runat="server" Width="170px" CssClass="TextBox-Flat-Blue">
                                        <asp:ListItem Selected="True">Laki-Laki</asp:ListItem>
                                        <asp:ListItem>Perempuan</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    TEMPAT LAHIR:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxTempatLahir" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    TANGGAL LAHIR:
                                </td>
                                <td align="left">
                                    <dx:ASPxDateEdit ID="dateTanggalLahir" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                        <ButtonStyle Width="13px">
                                        </ButtonStyle>
                                    </dx:ASPxDateEdit>
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    PEKERJAAN:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxPekerjaan" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="20px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    ALAMAT:<br />
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxAlamat" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                                        Height="40px" MaxLength="255" Rows="2" TextMode="MultiLine" />
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    FOTO PENANGGUNG JAWAB:<br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                </td>
                                <td align="left">
                                    <asp:Image ID="ImgFoto" runat="server" BorderColor="#000099" BorderStyle="Solid"
                                        BorderWidth="2px" Height="150px" ImageUrl="../FileFoto/_Blank.jpg" Width="120px" />
                                    <br />
                                    <asp:Label ID="LblNamaFoto" runat="server" CssClass="font-tabel-center"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td align="left">
                                    <asp:FileUpload ID="FotoUpload" runat="server" Width="215px" />
                                    &nbsp;<asp:Button ID="btnSimpan" runat="server" Text="Simpan" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="font-tabel-right-small2">
                                    TANGGAL SURAT:
                                </td>
                                <td align="left">
                                    <dx:ASPxDateEdit ID="dateTanggalSurat" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                        <ButtonStyle Width="13px">
                                        </ButtonStyle>
                                    </dx:ASPxDateEdit>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
        <td style="width: 140px;">
            &nbsp;
        </td>
    </tr>
</table>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
    Modal="True">
</dx:ASPxLoadingPanel>
<dx:ASPxCallback ID="ASPxCallback2" runat="server">
</dx:ASPxCallback>
