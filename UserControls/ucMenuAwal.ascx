<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuAwal.ascx.vb" Inherits="UserControls_ucMenuAwal" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<table style="width: 970px;">
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td align="right">
            <dx:ASPxButton ID="BtnUNAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="SKAR" ToolTip="Data Mengurus SKAR" Width="200px" Height="50px">
                <Image Url="~/Images/Cetak-SKAR-32x32.png" />
            </dx:ASPxButton>
        </td>
        <td>
        </td>
        <td align="left">
            <dx:ASPxButton ID="BtnIAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="IAR" ToolTip="Data Mengurus IAR" Width="200px" Height="50px">
                <Image Url="~/Images/IAR-32x32.png" />
            </dx:ASPxButton>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td></td>
        <td></td>
        <td style="text-align: center">
            &nbsp;</td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
        </td>
        <td align="right">
            <dx:ASPxButton ID="BtnIARKhusus" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="IAR Khusus" ToolTip="Data Mengurus IAR Khusus" Width="200px" 
                Height="50px" Visible="False">
                <Image Url="~/Images/IARKhusus-32x32.gif" />
            </dx:ASPxButton>
            <dx:ASPxButton ID="BtnIKRAP" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="IKRAP" ToolTip="Data Mengurus IKRAP" Width="200px" Height="50px">
                <Image Url="~/Images/IKRAP-32x32.gif" />
            </dx:ASPxButton>
        </td>
        <td></td>
        <td align="left">
            <dx:ASPxButton ID="BtnPengaturan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Pengaturan" ToolTip="Pengaturan Aplikasi" Width="200px" AllowFocus="False"
                Height="50px">
                <Image Url="~/Images/Pengaturan-32x32.png" />
            </dx:ASPxButton>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td align="left" style="text-align: right">
            <dx:ASPxButton ID="BtnLaporan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Laporan" ToolTip="Laporan Keseluruhan" Width="200px" Height="50px" 
                Visible="False">
                <Image Url="~/Images/Laporan-32x32.png" />
            </dx:ASPxButton>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
