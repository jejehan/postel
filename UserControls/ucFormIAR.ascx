<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFormIAR.ascx.vb" Inherits="UserControls_ucForm" %>
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

<link href="../layout.css" rel="stylesheet" type="text/css" />
<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
</dx:ASPxCallback>
<table style="width: 990px;">
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
        <td style="width: 40%">
        </td>
        <td>
            &nbsp;
        </td>
        <td style="width: 40%">
        </td>
    </tr>
    <tr>
        <td class="font-Title" colspan="7">
            DATA ANGGOTA
        </td>
    </tr>
    <tr>
        <td colspan="7">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="7">
            <table>
                <tr>
                    <td>
                        <dx:ASPxButton ID="BtnCetak" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Cetak Ulang" Width="130px" Wrap="False">
                            <Image Url="~/Images/Print-16x16.gif">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnCancel" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Kembali" Width="130px" Wrap="False">
                            <Image Url="~/Images/Undo-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td style="width: 90%; text-align: left;">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="7">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td valign="top" colspan="2" align="center">
            <asp:Image ID="ImgFoto" runat="server" BorderColor="#000099" BorderStyle="Solid"
                BorderWidth="2px" Height="150px" ImageUrl="~/file/04125315.jpg" Width="120px" />
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" style="text-align: center" class="font-header">
                        Data Pemohon
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Nama Anggota :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxNamaAnggota" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tempat Lahir :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTempatLahir" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal Lahir :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTanggalLahir" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Jenis Permohonan :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxJenisPermohonan" runat="server" CssClass="TextBox-Flat-Blue"
                            Width="200px" Height="17px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top">
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
                    <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                        <tr>
                            <td colspan="2" style="text-align: center" class="font-header">
                                Data Kartu
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                Nama Kartu :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxNamaDiKartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                Alamat 1:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat1Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                &nbsp;Alamat 2:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat2Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                &nbsp;Alamat 3:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat3Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td colspan="7">
        </td>
    </tr>
</table>
<table style="width: 99%;">
    <tr>
        <td valign="top">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header" style="text-align: center">
                        Data Pribadi
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor KTP :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrKTP" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Jenis Kelamin :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxJenisKelamin" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Alamat :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxAlamat" runat="server" CssClass="TextBox-Flat-Blue" Height="40px"
                            TextMode="MultiLine" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Kota :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxKota" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Provinsi :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxProvinsi" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Kode Pos :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxKodePos" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Agama :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxAgama" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Golongan Darah :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxGol" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Pekerjaan :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxPekerjaan" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor Telepon :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrTelepon" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            ToolTip="Hanya Angka, Contoh: 021555555" Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        e-Mail Address :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxEmail" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header" style="text-align: center">
                        Data Organisasi
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Orari Daerah&nbsp;:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxOrda" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Orari Lokal :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxOrlok" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor IAR :</td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrIAR" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Masa Berlaku IAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTglBerlakuIAR" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;CallSign :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxCallSign" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px" MaxLength="4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor SKAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrSKAR" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal Terbit SKAR :</td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTanggalTerbitSKAR" runat="server" CssClass="TextBox-Flat-Blue"
                            Width="250px" Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tingkat :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTingkat" runat="server" CssClass="TextBox-Flat-Blue" Width="250px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    </table>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
    Modal="True">
</dx:ASPxLoadingPanel>
<dx:ASPxCallback ID="ASPxCallback2" runat="server">
</dx:ASPxCallback>
