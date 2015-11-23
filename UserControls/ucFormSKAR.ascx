<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFormSKAR.ascx.vb" Inherits="UserControls_ucFormSKAR" %>
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
        <td style="width: 40%">
        </td>
    </tr>
    <tr>
        <td class="font-Title" colspan="6">
            DATA ANGGOTA
        </td>
    </tr>
    <tr>
        <td colspan="6">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="6">
            <table style="text-align: center; font-weight: bold;" class="font-header-small">
                <tr>
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
        <td colspan="6">
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
        <td valign="top" colspan="2">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" style="text-align: center; font-weight: bold;" 
                        class="font-header-small">
                        Data Di Sertifikat
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2" style="width: 200px">
                        Nama Anggota :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxNama" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Alamat :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxAlamat" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Tempat Tanggal Lahir :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxTempatTanggalLahir" runat="server" CssClass="TextBox-Flat-Blue"
                            Width="400px" Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Tingkat :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxTingkat" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Orari Daerah :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxOrda" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Orari Lokal :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxOrlok" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="4">
        </td>
        <td colspan="2">
        </td>
    </tr>
    <tr>
        <td colspan="4">
        </td>
        <td colspan="2">
        <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header-small" 
                        style="text-align: center; font-weight: bold;">
                        Data UNAR &amp; SKAR
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2" style="width: 200px">
                        Nomor UNAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrUNAR" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal UNAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTglUNAR" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Lokasi UNAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxLokasiUNAR" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor SKAR :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrSKAR" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal SKAR:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTglSKAR" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="4">
        </td>
        <td colspan="2">
        </td>
    </tr>
    <tr>
        <td colspan="4">
        </td>
        <td colspan="2">
        
            <table border="1" cellpadding="0" cellspacing="0" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="8" class="font-header-small" 
                        style="text-align: center; font-weight: bold;">
                        Hasil UNAR
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-center-small" align="center">
                        PS
                    </td>
                    <td class="font-tabel-center-small">
                        TR
                    </td>
                    <td class="font-tabel-center-small">
                        PR
                    </td>
                    <td class="font-tabel-center-small">
                        BI
                    </td>
                    <td class="font-tabel-center-small">
                        KM
                    </td>
                    <td class="font-tabel-center-small">
                        Teori
                    </td>
                    <td class="font-tabel-center-small">
                        Jumlah
                    </td>
                    <td class="font-tabel-center-small">
                        Nilai
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lblPS" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblTR" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblPR" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblBI" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblKM" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblTeori" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblJumlah" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="lblNilai" runat="server" CssClass="font-tabel-left-xsmall2"></asp:Label>
                    </td>
                </tr>
            </table>
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td class="font-tabel-right-small2" style="width: 200px">
                        Hasil&nbsp;:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxHasil" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Keterangan&nbsp;:</td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxKeterangan" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        User Update
                        :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxUserUpdate" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal Update&nbsp;:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTglUpdate" runat="server" CssClass="TextBox-Flat-Blue" Width="400px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
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
