<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucLogin.ascx.vb" Inherits="usercontrols_ucLogin" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<table style="width: 300px;" border="0" cellpadding="0" cellspacing="0" align="center">
    <tr>
        <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_left.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
        <td style="height: 31px; background-image: url('/images/box/box3_top_mid.gif');" class="font-bold">
            Masuk Aplikasi
        </td>
        <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_right.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
    </tr>
    <tr>
        <td style="width: 10px; height: 10px; background-image: url('/images/box/box3_mid_left.gif');">
        </td>
        <td style="background-color: #ddecfe;">
            <table cellpadding="0" cellspacing="5">
                <tr>
                    <td align="left" class="font-normal2">
                        Nama Pengenal:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="tbxUserID" runat="server" CssClass="TextBox-Flat-Blue" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="font-normal2">
                        Kata Sandi:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="tbxPassword" runat="server" CssClass="TextBox-Flat-Blue" TextMode="Password"
                            Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="font-normal2">
                        Organisasi:
                    </td>
                    <td align="left">
                        <dx:ASPxComboBox ID="CmbOrganisasi" runat="server" CssFilePath="/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SelectedIndex="0" SpriteCssFilePath="/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="150px">
                            <Items>
                                <dx:ListEditItem Selected="True" Text="Orari" Value="Orari" />
                                <dx:ListEditItem Text="Rapi" Value="Rapi" />
                            </Items>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif" />
                            <ButtonStyle Width="13px" />
                        </dx:ASPxComboBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="2">
                    </td>
                </tr>
                <tr>
                    <td align="left">
                    </td>
                    <td align="right">
                        <dx:ASPxButton ID="BtnMasuk" runat="server" Text="Masuk" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                        </dx:ASPxButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="left">
                    </td>
                </tr>
            </table>
        </td>
        <td style="width: 10px; background-image: url('/images/box/box3_mid_right.gif');">
        </td>
    </tr>
    <tr>
        <td style="width: 10px; height: 10px; background-image: url('/images/box/box3_btm_left.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
        <td style="height: 10px; background-image: url('/images/box/box3_btm_mid.gif'); font-size: xx-small;">
        </td>
        <td style="width: 10px; height: 10px; background-image: url('/images/box/box3_btm_right.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
    </tr>
</table>
