<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucExportDataKhusus.ascx.vb"
    Inherits="UserControls_ucTinjauData" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>







<%@ Register Assembly="DevExpress.Xpo.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>



<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx1" %>
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
    .dxeBase
    {
        font-family: Tahoma;
        font-size: 9pt;
    }
</style>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td colspan="3"></td>
    </tr>
    <tr>
        <td class="style1" colspan="3">
            EKSPOR DATA <asp:Label ID="lblTitle" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="text-align: left" colspan="3">
            <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 100%;"
                border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td>
                        <dx:ASPxButton ID="BtnSaveSelected" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Ekspor Data" Wrap="False" Width="130px">
                            <Image Url="~/Images/Export-XLS-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnSaveAll" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Ekspor Data Semua" Wrap="False" Width="130px" Visible="False">
                            <Image Url="~/Images/Export-XLS-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="BtnRefresh" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Perbaharui Data" Width="130px" Wrap="False">
                            <Image Url="~/Images/Refresh2-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td align="left" style="width: 250px">
                        <asp:CheckBox ID="cbxPilihSemua" runat="server" AutoPostBack="True" 
                            CssClass="font-normal" Text="Pilih Semua" />
                    </td>
                    <td style="width: 60%">
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td valign="top" style="width: 150px;">
                        <dx:ASPxRoundPanel ID="PnlMenuLeft" runat="server" BackColor="#DDECFE" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" EnableDefaultAppearance="False" HeaderText="Lihat Data"
                            SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css" Width="150px">
                            <TopEdge>
                                <BackgroundImage HorizontalPosition="left" ImageUrl="~/App_Themes/Office2003Blue/Web/rpTopEdge.png"
                                    Repeat="RepeatX" VerticalPosition="top" />
                            </TopEdge>
                            <ContentPaddings Padding="2px" PaddingBottom="10px" PaddingTop="10px" />
                            <HeaderRightEdge>
                                <BackgroundImage HorizontalPosition="left" ImageUrl="~/App_Themes/Office2003Blue/Web/rpHeader.png"
                                    Repeat="RepeatX" VerticalPosition="top" />
                            </HeaderRightEdge>
                            <Border BorderColor="#002D96" BorderStyle="Solid" BorderWidth="1px" />
                            <HeaderLeftEdge>
                                <BackgroundImage HorizontalPosition="left" ImageUrl="~/App_Themes/Office2003Blue/Web/rpHeader.png"
                                    Repeat="RepeatX" VerticalPosition="top" />
                            </HeaderLeftEdge>
                            <HeaderStyle BackColor="#7BA4E0">
                                <Paddings Padding="0px" PaddingBottom="7px" PaddingLeft="2px" PaddingRight="2px" />
                                <BorderBottom BorderColor="#002D96" BorderStyle="Solid" BorderWidth="1px" />
                            </HeaderStyle>
                            <HeaderContent>
                                <BackgroundImage HorizontalPosition="left" ImageUrl="~/App_Themes/Office2003Blue/Web/rpHeader.png"
                                    Repeat="RepeatX" VerticalPosition="top" />
                            </HeaderContent>
                            <DisabledStyle ForeColor="Gray">
                            </DisabledStyle>
                            <NoHeaderTopEdge BackColor="#DDECFE">
                            </NoHeaderTopEdge>
                            <PanelCollection>
                                <dx:PanelContent ID="PanelContent3" runat="server">
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
                                                <dx:ASPxButton ID="BtnDataProses" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                                    Text="Berkas Diproses" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                                    GroupName="menuLeft">
                                                </dx:ASPxButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top">
                                                <dx:ASPxButton ID="BtnDataKembali" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                                    Text="Berkas Dikembalikan" Width="130px" Wrap="False" HorizontalAlign="Left"
                                                    CausesValidation="False" GroupName="menuLeft">
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
                                                    GroupName="menuLeft" Visible="False">
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
                                        <tr>
                                            <td valign="top" style="line-height: 5px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top">
                                                <dx:ASPxButton ID="BtnFileExport" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                                    Text="File Ekspor" Width="130px" Wrap="False" HorizontalAlign="Left" CausesValidation="False"
                                                    GroupName="menuLeft">
                                                </dx:ASPxButton>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td valign="top">
                        <!----------------------->
                        <!--- GV List Anggota --->
                        <!----------------------->
                        <dx:ASPxGridView ID="GvListAnggota" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" Width="830px" KeyFieldName="ProsesID" ClientInstanceName="GvListAnggota"
                            OnCustomColumnDisplayText="GvListAnggota_CustomColumnDisplayText" 
                            OnHtmlRowPrepared="GvListAnggota_HtmlRowPrepared" Font-Size="Small" 
                            Font-Names="Calibri">
                            <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" 
                                CssPostfix="Office2003Blue">
                                <Header HorizontalAlign="Center" ImageSpacing="5px" SortingImageSpacing="5px" 
                                    VerticalAlign="Middle">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                            </Styles>
                            <SettingsPager ShowEmptyDataRows="True" Mode="ShowAllRecords">
                            </SettingsPager>
                            <ImagesFilterControl>
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif">
                                </LoadingPanel>
                            </ImagesFilterControl>
                            <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif">
                                </LoadingPanelOnStatusBar>
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif">
                                </LoadingPanel>
                            </Images>
                            <SettingsText Title="Data Selesai Diproses" />
                            <Columns>
                                <dx:GridViewDataTextColumn UnboundType="String" ReadOnly="True" FixedStyle="Left"
                                    Width="30px" Caption="No." VisibleIndex="0">
                                    <Settings AllowDragDrop="False" AllowAutoFilterTextInputTimer="False" AllowAutoFilter="False"
                                        AllowHeaderFilter="False" AllowSort="True" AllowGroup="False"></Settings>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True"></HeaderStyle>
                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" BackColor="#FFFFD6">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="chkBox" UnboundType="Boolean" Width="30px"
                                    FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="1">
                                    <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                        AllowGroup="False" AllowHeaderFilter="False" AllowSort="False" />
                                    <CellStyle BackColor="#FFFFD6">
                                    </CellStyle>
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="CxAll" runat="server" AutoPostBack="True" OnCheckedChanged="CxAll_CheckedChanged" />
                                    </HeaderTemplate>
                                    <DataItemTemplate>
                                        <asp:CheckBox ID="CxItem" runat="server" />
                                    </DataItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Group ID" FieldName="GroupID" Width="110px" CellStyle-BackColor="#ffffd6"
                                    VisibleIndex="3">
                                    <Settings AllowHeaderFilter="True" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                                    <CellStyle BackColor="#FFFFD6" HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Nomor IZIN" FieldName="NomorIZIN" CellStyle-BackColor="#ffffd6"
                                    Width="120px" VisibleIndex="4">
                                    <Settings AllowHeaderFilter="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="CallSign Khusus" FieldName="NamaPanggilanKhusus"
                                    Width="60px" VisibleIndex="5" CellStyle-BackColor="#ffffd6">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="True" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Alamat Stasiun" FieldName="AlamatStasiun" Width="250px"
                                    VisibleIndex="6">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="True" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Left" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Daya Dibawah 30" FieldName="DayaDibawah30" Width="90px"
                                    VisibleIndex="7">
                                    <Settings AllowHeaderFilter="False" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Daya Diatas 30" FieldName="DayaDiatas30" Width="90px"
                                    VisibleIndex="8">
                                    <Settings AllowHeaderFilter="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Penggunaan Stasiun" FieldName="PenggunaanStasiun"
                                    Width="150px" VisibleIndex="9">
                                    <Settings AllowHeaderFilter="True" />
                                    <HeaderStyle HorizontalAlign="Left" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="BandFrekuensi" VisibleIndex="10" Width="150px"
                                    Caption="Rapi Daerah">
                                    <Settings AllowHeaderFilter="True" />
                                    <HeaderStyle HorizontalAlign="Left" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="KelasEmisi" Width="200px" VisibleIndex="11">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Berlaku Mulai" FieldName="BerlakuMulai" Width="100px"
                                    UnboundType="DateTime" VisibleIndex="12">
                                    <Settings AllowHeaderFilter="True" />
                                    <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Right" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Berlaku Akhir" FieldName="BerlakuAkhir" Width="100px"
                                    UnboundType="DateTime" VisibleIndex="13">
                                    <Settings AllowHeaderFilter="True" />
                                    <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Right" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="ORARI Daerah" FieldName="Orda" Width="200px"
                                    VisibleIndex="14">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="ORARI Lokal" FieldName="Orlok" Width="200px"
                                    VisibleIndex="15">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Nama Lengkap" FieldName="NamaLengkap" Width="200px"
                                    VisibleIndex="16">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="CallSign" FieldName="NamaPanggilan" Width="60px"
                                    VisibleIndex="17">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Jenis Kelamin" FieldName="JenisKelamin" Width="80px"
                                    UnboundType="DateTime" VisibleIndex="18">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                    <CellStyle HorizontalAlign="Left" Wrap="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Tempat Lahir" FieldName="TempatLahir" Width="130px"
                                    VisibleIndex="19">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Tanggal Lahir" FieldName="TanggalLahir" Width="100px"
                                    UnboundType="DateTime" VisibleIndex="20">
                                    <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy" />
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="True" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Right" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Pekerjaan" FieldName="Pekerjaan" Width="130px"
                                    VisibleIndex="21">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Alamat" FieldName="Alamat" Width="250px" VisibleIndex="22">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="File Foto" FieldName="FileFoto" Width="130px"
                                    VisibleIndex="23">
                                    <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                                        AllowGroup="True" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Left" Wrap="True" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Proses ID" FieldName="ProsesID" VisibleIndex="24"
                                    Visible="False">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="ProsesData" Caption="Proses Data" VisibleIndex="25"
                                    Width="100px">
                                    <Settings AllowHeaderFilter="True" />
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                            <GroupSummary>
                                <dx:ASPxSummaryItem FieldName="Nama" SummaryType="Count" />
                            </GroupSummary>
                            <Settings ShowFilterRowMenu="true" ShowHorizontalScrollBar="True" 
                                ShowPreview="True" ShowTitlePanel="True" ShowVerticalScrollBar="True" 
                                VerticalScrollableHeight="300" />
                            <StylesEditors>
                                <ProgressBar Height="25px">
                                </ProgressBar>
                            </StylesEditors>
                        </dx:ASPxGridView>
                        <!----------------------->
                        <!--- GV List File    --->
                        <!----------------------->
                        <dx:ASPxGridView ID="GvFileList" ClientInstanceName="GvFileList" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            KeyFieldName="FileName" CssPostfix="Office2003Blue" 
                            SettingsPager-PageSize="20" Width="830px"
                            OnHtmlRowPrepared="GvFileList_HtmlRowPrepared" Font-Size="Small" 
                            Font-Names="Calibri" AutoGenerateColumns="False">
                            <SettingsText Title="File Data" />
                            <Columns>
                                <dx:GridViewDataColumn Caption="Action" VisibleIndex="0" Width="80px">
                                    <DataItemTemplate>
                                        <asp:ImageButton ID="btnDeleteFile" runat="server" AlternateText="Hapus" OnClick="btnDeleteFile_Click"
                                            ImageUrl="~/images/Delete-16x16.gif" />
                                        <asp:ImageButton ID="btnSaveExcel" runat="server" AlternateText="Simpan File Excel"
                                            Visible="false" OnClick="btnSaveExcel_Click" ImageUrl="~/images/Export-XLS-16x16.png" />
                                        <asp:ImageButton ID="btnSaveFile" runat="server" AlternateText="Simpan File" OnClick="btnSaveFile_Click"
                                            ImageUrl="~/images/Save-16x16.png" />
                                        <asp:ImageButton ID="btnMailFile" runat="server" AlternateText="Kirim File" OnClick="btnMailFile_Click"
                                            ImageUrl="~/images/Mail-16x16.png" />
                                        <asp:Literal runat="server" ID="ltrlFileName" Text='<%# Eval("FileName") %>' Visible="false" />
                                        <ajaxToolKit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server" TargetControlID="btnDeleteFile"
                                            OnClientCancel="cancelClick" DisplayModalPopupID="ModalPopupExtender1" />
                                        <ajaxToolKit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="btnDeleteFile"
                                            PopupControlID="PNL" OkControlID="ButtonOk" CancelControlID="ButtonCancel" BackgroundCssClass="modalBackground" />
                                        <asp:Panel ID="PNL" runat="server" Style="display: none; width: 200px; background-color: White;
                                            border-width: 2px; border-color: Black; border-style: solid; padding: 20px;">
                                            Anda yakin ingin menghapus data ini?
                                            <br />
                                            <br />
                                            <div style="text-align: right;">
                                                <asp:Button ID="ButtonOk" runat="server" Text="  Ya  " />
                                                <asp:Button ID="ButtonCancel" runat="server" Text="Tidak" />
                                            </div>
                                        </asp:Panel>
                                        <asp:Label ID="LblStatusUpdate" runat="server" Text="" />
                                    </DataItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center"  Wrap="True" />
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="FileName" Caption="Nama File" VisibleIndex="1"
                                    Width="170px">
                                    <CellStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="UserIDUpload" VisibleIndex="4" Caption="Nama Pengunggah"
                                    Width="80px">
                                    <PropertiesTextEdit DisplayFormatString="N0" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="DateUpload" VisibleIndex="5" Caption="Tanggal Unggah"
                                    Width="100px" UnboundType="DateTime">
                                    <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy hh:mm:ss" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="UserIDProses" VisibleIndex="6" Caption="Nama Pemproses"
                                    Width="80px">
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="DateProses" VisibleIndex="7" Caption="Tanggal Proses"
                                    Width="100px" UnboundType="DateTime">
                                    <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy hh:mm:ss" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn FieldName="SendMail" VisibleIndex="8" Caption="Kirim Email"
                                    Width="60px" Visible="true">
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" />
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                            <Settings ShowHorizontalScrollBar="True" ShowTitlePanel="True" 
                                ShowVerticalScrollBar="True" VerticalScrollableHeight="300" />
                            <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif">
                                </LoadingPanelOnStatusBar>
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif">
                                </LoadingPanel>
                            </Images>
                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <ImagesFilterControl>
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif">
                                </LoadingPanel>
                            </ImagesFilterControl>
                            <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" 
                                CssPostfix="Office2003Blue">
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                                </Header>
                                <AlternatingRow Enabled="true" />
                            </Styles>
                            <StylesEditors>
                                <ProgressBar Height="25px">
                                </ProgressBar>
                            </StylesEditors>
                        </dx:ASPxGridView>
                        <!-------------------->
                        <!--- GV Send File --->
                        <!-------------------->
                        <dx:ASPxRoundPanel ID="PnlSendEmail" runat="server" Width="830px" BackColor="White"
                            HeaderText="Kirim Email" Font-Bold="True" HorizontalAlign="Center" Visible="False">
                            <TopEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpTopEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </TopEdge>
                            <LeftEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpLeftEdge.gif" Repeat="RepeatY"
                                    VerticalPosition="Top" />
                            </LeftEdge>
                            <ContentPaddings Padding="0px" PaddingTop="5px" />
                            <RightEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpRightEdge.gif" Repeat="RepeatY"
                                    VerticalPosition="Top" />
                            </RightEdge>
                            <HeaderRightEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderRightEdge>
                            <Border BorderColor="#AECAF0" BorderStyle="Solid" BorderWidth="1px" />
                            <HeaderLeftEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderLeftEdge>
                            <HeaderStyle BackColor="#E0EDFF">
                                <BorderBottom BorderColor="#AECAF0" BorderStyle="Solid" BorderWidth="1px" />
                            </HeaderStyle>
                            <BottomEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpBottomEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Bottom" />
                            </BottomEdge>
                            <HeaderContent>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderContent>
                            <NoHeaderTopEdge BackColor="White">
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpNoHeaderTopEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </NoHeaderTopEdge>
                            <PanelCollection>
                                <dx:PanelContent ID="PanelContent2" runat="server">
                                    <table border="0" cellpadding="0" cellspacing="2" width="100%">
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td>
                                                &nbsp;&nbsp;
                                            </td>
                                            <td style="width: 90%; text-align: left;">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                    <table border="0" cellpadding="0" cellspacing="2" style="width: 100%;">
                                        <tr>
                                            <td class="font-normal" style="width: 200px;">
                                                Email Pengirim:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailFrom" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal">
                                                Email Kepada:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailTo" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal" align="left">
                                                Email Salinan:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailCc" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal">
                                                File Disertakan:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:Label ID="LblFileAttachment" runat="server" CssClass="font-normal"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal">
                                                Judul Email:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailSubject" runat="server" CssClass="TextBox-Flat-Blue" Width="600px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal" valign="top">
                                                Isi Email:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailBody" runat="server" CssClass="TextBox-Flat-Blue" Height="120px"
                                                    MaxLength="500" TextMode="MultiLine" Width="600px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
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
                                            <td>
                                            </td>
                                            <td>
                                                <table>
                                                    <tr>
                                                        <td style="width: 80%">
                                                        </td>
                                                        <td>
                                                            <dx:ASPxButton ID="BtnSend" runat="server" Text="Kirim" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                                            </dx:ASPxButton>
                                                        </td>
                                                        <td>
                                                            <dx:ASPxButton ID="BtnCancel" runat="server" Text="Batal" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                                            </dx:ASPxButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxGridViewExporter ID="GvListAnggota_ExportAll" runat="server" GridViewID="GvListAnggota" />
            <dx:ASPxGridViewExporter ID="GvListAnggota_ExportSelected" runat="server" GridViewID="GvListAnggota"
                ExportedRowType="Selected" />
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
</table>
