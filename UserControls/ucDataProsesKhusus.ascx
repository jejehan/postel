<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDataProsesKhusus.ascx.vb"
    Inherits="UserControls_ucDataProsesKhusus" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraPivotGrid.Web" TagPrefix="dx" %>




<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<link href="../default.css" rel="stylesheet" type="text/css" />
<link href="../layout.css" rel="stylesheet" type="text/css" />

<script type='text/javascript'>
    function cancelClick() {
    }
</script>

<style type="text/css">
    .style1
    {
        font-size: large;
        font-weight: bold;
        color: #000099;
    }
</style>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td colspan="3">
        </td>
    </tr>
    <tr>
        <td class="style1" colspan="3">
            DATA&nbsp;<asp:Label ID="lblMenuAwal" runat="server" />&nbsp;DALAM PROSES
        </td>
    </tr>
</table>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td style="text-align: left" colspan="3">
            <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 100%;"
                border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnSave" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Ekspor Excel" Wrap="False" Width="100px">
                            <Image Url="~/Images/Export-XLS-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnRefresh" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Perbaharui Data" Width="100px" Wrap="False">
                            <Image Url="~/Images/Refresh2-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td style="width: 80%">
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td colspan="3" valign="top" style="width: 150px;">
            <table style="width: 150px;" border="0" cellpadding="0" cellspacing="0" align="center">
                <tr>
                    <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_left.gif');
                        background-repeat: no-repeat; font-size: xx-small;">
                    </td>
                    <td style="height: 31px; background-image: url('/images/box/box3_top_mid.gif');"
                        class="font-bold">
                        Data Proses
                    </td>
                    <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_right.gif');
                        background-repeat: no-repeat; font-size: xx-small;">
                    </td>
                </tr>
                <tr>
                    <td style="width: 10px; height: 10px; background-image: url('/images/box/box3_mid_left.gif');">
                    </td>
                    <td style="background-color: #ddecfe;">
                        <!--- Left Menu -->
                        <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="BtnDataAll" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Semua Data" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="line-height: 5px">
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="btnTinjauData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Tinjau Data" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="btnHasilUNAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Hasil" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="btnPersetujuan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Persetujuan" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="btnCetak" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Cetak" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="btnExport" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Ekspor" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="line-height: 5px">
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="BtnDataProses" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Berkas Diproses" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft" Visible="False">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="BtnDataKembali" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Berkas Dikembalikan" Width="130px" Wrap="False" HorizontalAlign="Left"
                                        CausesValidation="False" GroupName="menuLeft" Visible="False">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="line-height: 5px">
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="BtnLulusUNAR2" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Lulus" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dx:ASPxButton ID="BtnGagalUNAR2" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Text="Tidak Lulus" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                        GroupName="menuLeft">
                                    </dx:ASPxButton>
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
        </td>
        <td>
        </td>
        <td>
            <!---------------------->
            <!----- Filter Box ----->
            <!---------------------->
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%; background-color: #EBF2F4">
                <tr>
                    <td>
                        <table border="0" cellpadding="2" cellspacing="0" style="width: 100%; background-color: #EBF2F4">
                            <tr style="height: 25px;">
                                <td class="tabel-right-font-small" nowrap="nowrap">
                                    <asp:Label ID="lblOrda" runat="server" />
                                </td>
                                <td class="tabel-left-font-xsmall">
                                    <dx:ASPxComboBox ID="DdlOrda" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                        CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
                                        ValueType="System.String" Width="150px">
                                        <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                        </LoadingPanelImage>
                                        <DropDownButton>
                                            <Image>
                                                <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                            </Image>
                                        </DropDownButton>
                                        <ValidationSettings>
                                            <ErrorFrameStyle ImageSpacing="4px">
                                                <ErrorTextPaddings PaddingLeft="4px" />
                                            </ErrorFrameStyle>
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                                </td>
                                <td class="tabel-left-font-xsmall">
                                    &nbsp;
                                </td>
                                <td class="tabel-right-font-small" nowrap="nowrap">
                                    <asp:Label ID="lblTingkat" runat="server" Text="Tingkat: "></asp:Label>
                                </td>
                                <td class="tabel-left-font-xsmall">
                                    <dx:ASPxComboBox ID="DdlTingkat" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                                        CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css"
                                        ValueType="System.String" Width="150px">
                                        <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                        </LoadingPanelImage>
                                        <DropDownButton>
                                            <Image>
                                                <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                            </Image>
                                        </DropDownButton>
                                        <ValidationSettings>
                                            <ErrorFrameStyle ImageSpacing="4px">
                                                <ErrorTextPaddings PaddingLeft="4px" />
                                            </ErrorFrameStyle>
                                        </ValidationSettings>
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <dx:ASPxGridView ID="GvListAnggota" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" Width="830px" ClientInstanceName="GvListAnggota"
                EnableRowsCache="False" OnCustomColumnDisplayText="GvListAnggota_CustomColumnDisplayText"
                KeyFieldName="Callsign" OnHtmlRowPrepared="GvListAnggota_HtmlRowPrepared" Font-Size="Small"
                Font-Names="Calibri">
                <SettingsBehavior AllowFocusedRow="True" AllowMultiSelection="True" AutoExpandAllGroups="True" />
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <Header ImageSpacing="5px" SortingImageSpacing="5px" Wrap="True" VerticalAlign="Middle"
                        HorizontalAlign="Center" />
                    <LoadingPanel ImageSpacing="10px" />
                    <Cell HorizontalAlign="Left" />
                </Styles>
                <SettingsPager ShowEmptyDataRows="True" AlwaysShowPager="True" PageSize="20" 
                    Position="Top" >
                    <FirstPageButton Visible="True">
                    </FirstPageButton>
                    <LastPageButton Visible="True">
                    </LastPageButton>
                </SettingsPager>
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif" />
                </ImagesFilterControl>
                <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif" />
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif" />
                </Images>
                <SettingsText EmptyDataRow="Data tidak ditemukan" Title="Data Dalam Proses" />
                <Columns>
                    <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" VisibleIndex="0"
                        Width="30px" FixedStyle="Left">
                        <Settings AllowAutoFilter="False" AllowHeaderFilter="False" />
                        <CellStyle BackColor="#FFFFD6" HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Nama" VisibleIndex="1" Width="200px" FixedStyle="Left">
                        <Settings AllowAutoFilter="False" AllowSort="False" AllowHeaderFilter="False" AllowAutoFilterTextInputTimer="False"
                            ShowFilterRowMenu="False" />
                        <CellStyle BackColor="#FFFFD6" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Callsign" VisibleIndex="2" FieldName="Callsign"
                        Width="60px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tingkat" VisibleIndex="3" FieldName="Tingkat"
                        Width="80px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Tahapan" Caption="Tahapan Proses" VisibleIndex="4" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Orari Daerah" VisibleIndex="5" FieldName="OrdaName"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Orari Lokal" VisibleIndex="6" FieldName="OrlokName"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Rapi Daerah" VisibleIndex="7" FieldName="RapiDaerahName"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Jenis Permohonan" VisibleIndex="8" FieldName="JenisPermohonan" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Nomor UNAR" VisibleIndex="9" FieldName="NomorUNAR"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal UNAR" VisibleIndex="10" FieldName="TanggalUNAR"
                        Width="120px" UnboundType="DateTime">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Hasil UNAR" VisibleIndex="11" FieldName="HasilUNAR"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Nomor SKAR" VisibleIndex="12" FieldName="NomorSKAR"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Terbit SKAR" FieldName="TanggalTerbitSKAR"
                        Width="130px" UnboundType="DateTime" VisibleIndex="13">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn VisibleIndex="14" FieldName="NomorIAR" Width="120px" Caption="Nomor IAR">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Masa Berlaku IAR" VisibleIndex="15" FieldName="MasaBerlakuIAR"
                        Width="130px" UnboundType="DateTime">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorIKRAP" VisibleIndex="16" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="MasaBerlakuIKRAP" VisibleIndex="17" Width="140px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Impor Data" VisibleIndex="18" FieldName="UserProses" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Impor" VisibleIndex="19" FieldName="DateProses" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tinjau Data" FieldName="UserTinjauData" VisibleIndex="20" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Tinjau Data" FieldName="DateTinjauData"
                        VisibleIndex="21" Width="130px">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Hasil UNAR" FieldName="UserHasilUNAR" VisibleIndex="22" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Hasil UNAR" FieldName="DateHasilUNAR"
                        VisibleIndex="23" Width="130px">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Persetujuan" FieldName="UserPersetujuan" VisibleIndex="24" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Persetujuan" FieldName="DatePersetujuan"
                        VisibleIndex="25" Width="140px">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Cetak Kartu" FieldName="UserPrint" VisibleIndex="26" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Cetak" FieldName="DatePrint" VisibleIndex="27" Width="120px">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Kirim Data" FieldName="ProsesKirimKeOrganisasi"
                        VisibleIndex="28" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tanggal Kirim" FieldName="DateKirimKeOrganisasi"
                        VisibleIndex="29" Width="120px">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="File ID" VisibleIndex="30" FieldName="GroupID"
                        Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn Caption="Data Diproses?" FieldName="ProsesData" VisibleIndex="31" Width="120px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="True" AllowSort="True" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="ProsesID" VisibleIndex="32" Visible="false" />
                </Columns>
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="Nama" SummaryType="Count" />
                </GroupSummary>
                <Settings ShowHorizontalScrollBar="True" ShowVerticalScrollBar="True" ShowTitlePanel="True"
                    VerticalScrollableHeight="300" />
                <StylesEditors>
                    <ProgressBar Height="25px" />
                </StylesEditors>
            </dx:ASPxGridView>
        </td>
    </tr>
</table>
<dx:ASPxGridViewExporter ID="GvListAnggota_ExportAll" runat="server" GridViewID="GvListAnggota">
</dx:ASPxGridViewExporter>
