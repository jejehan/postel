<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucUserProfile.ascx.vb" Inherits="usercontrols_ucLogin" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<table style="width: 400px;" border="0" cellpadding="0" cellspacing="0" align="center">
    <tr>
        <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_left.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
        <td style="height: 31px; background-image: url('/images/box/box3_top_mid.gif');" class="font-bold">
            User Profile
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
                        Kata Sandi Lama:</td>
                    <td align="left" colspan="2">
                        <asp:TextBox ID="tbxPasswordLama" runat="server" CssClass="TextBox-Flat-Blue" 
                            Width="150px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="font-normal2">
                        Kata Sandi Baru:</td>
                    <td align="left" colspan="2">
                        <asp:TextBox ID="tbxPasswordBaru1" runat="server" CssClass="TextBox-Flat-Blue" TextMode="Password"
                            Width="150px"></asp:TextBox>
                        <cc1:PasswordStrength ID="tbxPasswordBaru1_PasswordStrength" runat="server" 
                            Enabled="True" TargetControlID="tbxPasswordBaru1" PreferredPasswordLength="5" PrefixText="Tingkat Keamanan:" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1">
                        </cc1:PasswordStrength>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="font-normal2">
                        Ulangi Kata Sandi Baru:</td>
                    <td align="left"  colspan="2">
                        <asp:TextBox ID="tbxPasswordBaru2" runat="server" CssClass="TextBox-Flat-Blue" TextMode="Password"
                            Width="150px"></asp:TextBox>
                        <cc1:PasswordStrength ID="tbxPasswordBaru2_PasswordStrength" runat="server" 
                            Enabled="True" TargetControlID="tbxPasswordBaru2" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="1" PrefixText="Tingkat Keamanan:">
                        </cc1:PasswordStrength>
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="3">
                    </td>
                </tr>
                <tr>
                    <td align="left">
                    </td>
                    <td align="right">
                        <dx:ASPxButton ID="BtnSimpan" runat="server" Text="Simpan" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnBatal" runat="server" Text="Batal" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                        </dx:ASPxButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="left" class="font-normal2">
                        Beberapa ketentuan kata sandi:<br />
                        - Huruf Besar dan Kecil berbeda<br />
                        - Panjang kata sandi minimal 5 karakter<br />
                        - Kata sandi yang bagus terdiri dari kombinasi Huruf, Angka, Lambang dan 
                        Karakter. Misal: P0$t3l
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
