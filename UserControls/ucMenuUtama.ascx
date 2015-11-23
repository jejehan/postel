<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuUtama.ascx.vb"
    Inherits="usercontrol_ucMenuUtama" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>







<%@ Register Assembly="DevExpress.Xpo.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td colspan="3" align="center">
            <!---------------------->
            <!----- Panel Menu ----->
            <!---------------------->
            <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 990px;"
                border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td style="text-align: center;">
                        <dx:ASPxButton runat="server" ImagePosition="Top" ImageSpacing="0px" SpriteImageUrl="~/Images/Import-File-32x49.png"
                            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" HorizontalAlign="Center"
                            Wrap="False" Text="Menu Awal" CssPostfix="Aqua" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            Width="100px" Height="40px" ToolTip="Menu Awal" ID="btnMenuAwal" CausesValidation="False"
                            GroupName="menuUtama">
                            <Image AlternateText="Menu Awal" Height="32px" Width="32px" Url="~/Images/Home-32x32.png" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton runat="server" ImagePosition="Top" ImageSpacing="0px" SpriteImageUrl="~/Images/Import-File-32x49.png"
                            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" HorizontalAlign="Center"
                            Wrap="False" Text="Impor File" CssPostfix="Aqua" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            Width="100px" Height="40px" ToolTip="Import Data" ID="BtnImportFile" CausesValidation="False"
                            GroupName="menuUtama">
                            <Image AlternateText="Impor Data" Height="32px" Width="49px" Url="../Images/Import-File-32x49.png" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton runat="server" ImagePosition="Top" ImageSpacing="0px" SpriteImageUrl="~/Images/Edit-32x32.gif"
                            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" HorizontalAlign="Center"
                            Wrap="False" Text="Tinjau Data" CssPostfix="Aqua" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            Width="100px" Height="40px" ToolTip="Tinjau Data" ID="BtnTinjauData" CausesValidation="False"
                            GroupName="menuUtama">
                            <Image AlternateText="Tinjau Data" Height="32px" Width="32px" Url="../Images/Edit-32x32.gif" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnHasilUNAR" runat="server" CausesValidation="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" GroupName="menuUtama" Height="40px" HorizontalAlign="Center"
                            ImagePosition="Top" ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
                            SpriteImageUrl="~/Images/Reports-32x32.png" Text="Hasil UNAR" ToolTip="Hasil UNAR"
                            Visible="False" Width="100px" Wrap="False">
                            <Image AlternateText="Hasil UNAR" Height="32px" Url="../Images/Reports-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnPersetujuan" runat="server" CausesValidation="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" GroupName="menuUtama" Height="40px" HorizontalAlign="Center"
                            ImagePosition="Top" ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
                            SpriteImageUrl="~/Images/Persetujuan-32x32.png" Text="Persetujuan" ToolTip="Persetujuan"
                            Width="100px" Wrap="False">
                            <Image AlternateText="Persetujuan" Height="32px" Url="../Images/Persetujuan-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnCetakSKAR" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Cetak-SKAR-32x32.png"
                            Text="Cetak SKAR" ToolTip="Cetak SKAR" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama" Visible="false">
                            <Image AlternateText="Cetak Kartu" Height="32px" Url="~/Images/Cetak-SKAR-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="BtnCetakIAR" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Cetak-Kartu-32x32.png"
                            Text="Cetak IAR" ToolTip="Cetak IAR" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama" Visible="false">
                            <Image AlternateText="Cetak Kartu" Height="32px" Url="../Images/Cetak-Kartu-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="BtnCetakIARKhusus" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Cetak-Kartu-32x32.png"
                            Text="Cetak IAR Khusus" ToolTip="Cetak IAR Khusus" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama" Visible="false">
                            <Image AlternateText="Cetak Kartu" Height="32px" Url="../Images/Cetak-Kartu-32x32.png"
                                Width="32px" /> 
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="BtnCetakIKRAP" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Cetak-Kartu-32x32.png"
                            Text="Cetak IKRAP" ToolTip="Cetak IKRAP" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama" Visible="false">
                            <Image AlternateText="Cetak IKRAP" Height="32px" Url="../Images/Cetak-Kartu-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnExportData" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Pengaturan-32x32.png"
                            Text="Ekspor Data" ToolTip="Ekspor Data ke File" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama">
                            <Image AlternateText="Ekspor Data" Height="32px" Url="../Images/Export-File-32x32.gif"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnDataProses" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/list.png"
                            Width="100px" Wrap="False" CausesValidation="False" GroupName="menuUtama" Text="Data Proses">
                            <Image AlternateText="Daftar Proses" Height="32px" Url="~/Images/list.png" Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnDatabase" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Laporan-32x32.png"
                            Text="Database" ToolTip="Laporan" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama" Visible="False">
                            <Image AlternateText="Laporan Data" Height="32px" Url="../Images/Laporan-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnLaporan" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                            CssPostfix="Aqua" Height="40px" HorizontalAlign="Center" ImagePosition="Top"
                            ImageSpacing="0px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/Images/Laporan-32x32.png"
                            Text="Laporan" ToolTip="Laporan" Width="100px" Wrap="False" CausesValidation="False"
                            GroupName="menuUtama">
                            <Image AlternateText="Laporan Data" Height="32px" Url="../Images/Laporan-32x32.png"
                                Width="32px" />
                            <Paddings Padding="0px" />
                        </dx:ASPxButton>
                    </td>
                    <td style="width: 90%;">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
