<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCetakIARKhusus.ascx.vb"
    Inherits="UserControls_ucCetakIARKhusus" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx1" %>

<%@ Register Assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
    Namespace="System.Web.UI.WebControls" TagPrefix="asp" %>


<link href="../layout.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .dxmMenu, .dxmVerticalMenu
    {
        font: 9pt Tahoma;
        color: black;
        background-color: #F0F0F0;
        border: solid 1px #A8A8A8;
        padding: 2px 2px 2px 2px;
    }
    .dxmMenuItem, .dxmMenuItemWithImage
    {
        padding-top: 4px;
        padding-right: 8px;
        padding-bottom: 5px;
        padding-left: 8px;
    }
    .dxmMenuItem, .dxmMenuItemWithImage, .dxmMenuItemWithPopOutImage, .dxmMenuItemWithImageWithPopOutImage, .dxmVerticalMenuItem, .dxmVerticalMenuItemWithImage, .dxmVerticalMenuItemWithPopOutImage, .dxmVerticalMenuItemWithImageWithPopOutImage, .dxmMenuLargeItem, .dxmMenuLargeItemWithImage, .dxmMenuLargeItemWithPopOutImage, .dxmMenuLargeItemWithImageWithPopOutImage, .dxmVerticalMenuLargeItem, .dxmVerticalMenuLargeItemWithImage, .dxmVerticalMenuLargeItemWithPopOutImage, .dxmVerticalMenuLargeItemWithImageWithPopOutImage
    {
        font: 9pt Tahoma;
        color: black;
        white-space: nowrap;
    }
    .dxmMenuSeparator, .dxmMenuVerticalSeparator
    {
        background-color: #A8A8A8;
    }
    .style1
    {
        color: #000099;
        font-weight: bold;
        font-size: large;
    }
    .style6
    {
        width: 100%;
    }
</style>
<table style="width: 990px;">
    <tr>
        <td class="style1" style="text-align: center">
            &nbsp;
        </td>
        <td class="style1" style="text-align: center">
            &nbsp;
        </td>
        <td class="style1" style="text-align: center">
            Sertifikat Kecakapan Amatir Radio (IAR)
        </td>
    </tr>
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
    </tr>
    <tr>
        <td valign="top" rowspan="2">
            <dx:ASPxButton ID="btnEditData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Edit Data" Width="150px" Wrap="False" Checked="True" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnCetakData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Cetak Data" Width="150px" Wrap="False" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Tutup Data" Width="150px" Wrap="False" HorizontalAlign="Left">
            </dx:ASPxButton>
            &nbsp; &nbsp; &nbsp;
        </td>
        <td>
            &nbsp; &nbsp; &nbsp;
        </td>
        <td align="left">
            <!---------------------->
            <!--- Edit Grid View --->
            <!---------------------->
            <div id="divPreviewIAR" runat="server" visible="false">
                <dx:ASPxGridView ID="gvDataIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIARKhusus"
                    ClientInstanceName="gvDataIAR" Width="830px" SettingsBehavior-AutoExpandAllGroups="True"
                    OnCustomColumnDisplayText="gvDataIAR_CustomColumnDisplayText" EnableRowsCache="False"
                    Visible="False" Font-Size="Small" Font-Names="Calibri">
                    <SettingsBehavior AutoExpandAllGroups="True"></SettingsBehavior>
                    <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                        <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                        </Header>
                        <LoadingPanel ImageSpacing="10px">
                        </LoadingPanel>
                    </Styles>
                    <SettingsPager Visible="False">
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
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" Width="30px"
                            FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                            <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                            <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                            <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewCommandColumn ButtonType="Image" Caption="Edit" Width="40px" FixedStyle="Left" ShowEditButton="True">
                            <HeaderStyle HorizontalAlign="Center"/>
                            <CellStyle HorizontalAlign="Center" BackColor="#ffffd6"/>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID" ReadOnly="True">
                            <Settings AllowHeaderFilter="True" />
                            <EditFormSettings Visible="False" />
                            <CellStyle BackColor="#FFFFD6" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NamaPanggilanKhusus" Width="80px" FixedStyle="Left">
                            <CellStyle BackColor="#FFFFD6" Wrap="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="AlamatStasiun" Width="180px">
                            <CellStyle Wrap="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="DayaDibawah30" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="DayaDiatas30" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="PenggunaanStasiun" Width="180px">
                            <CellStyle Wrap="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="BandFrekuensi" Width="100px" />
                        <dx:GridViewDataTextColumn FieldName="KelasEmisi" Width="100px" />
                        <dx:GridViewDataTextColumn FieldName="BerlakuMulai" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="BerlakuAkhir" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="Orda" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="Orlok" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="NamaLengkap" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="NamaPanggilan" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="JenisKelamin" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="TempatLahir" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="TanggalLahir" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="Pekerjaan" Width="80px" />
                        <dx:GridViewDataTextColumn FieldName="Alamat" Width="180px" />
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                    <SettingsPager Mode="ShowAllRecords" />
                    <SettingsText Title="Edit Data IAR Khusus" />
                    <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                        ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" ShowVerticalScrollBar="True"
                        VerticalScrollableHeight="300" />
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="NamaPanggilan" SummaryType="Count" />
                    </GroupSummary>
                    <StylesEditors>
                        <ProgressBar Height="25px">
                        </ProgressBar>
                    </StylesEditors>
                    <SettingsCommandButton>
                        <EditButton Text="Edit Data">
                            <Image Url="~/Images/Edit-16x16.gif"/>
                        </EditButton>
                        <CancelButton Text="Batal">
                            <Image Url="~/Images/Undo-16x16.png"/>
                        </CancelButton>
                        <UpdateButton Text="Simpan">
                            <Image Url="~/Images/Save-16x16.png"/>
                        </UpdateButton>
                    </SettingsCommandButton>
                </dx:ASPxGridView>
            </div>
            <!----------------------->
            <!--- Cetak Grid View --->
            <!----------------------->
            <div id="divCetakIAR" runat="server" visible="false">
                <table border="0" cellpadding="0" cellspacing="0" class="style6" style="width: 600px">
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
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td width="50%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <dx:ReportToolbar ID="rptToolbarKhusus" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                                ItemSpacing="2px" ReportViewer="<%# rptCetakIARKhusus %>" SeparatorHeight="14px"
                                SeparatorWidth="1px" ShowDefaultButtons="False" Visible="True">
                                <Items>
                                    <dx:ReportToolbarButton ItemKind="PrintReport" />
                                    <dx:ReportToolbarButton ItemKind="PrintPage" />
                                    <dx:ReportToolbarSeparator />
                                    <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                                    <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                                    <dx:ReportToolbarLabel ItemKind="PageLabel" />
                                    <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                                    </dx:ReportToolbarComboBox>
                                    <dx:ReportToolbarLabel ItemKind="OfLabel" />
                                    <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                                    <dx:ReportToolbarButton ItemKind="NextPage" />
                                    <dx:ReportToolbarButton ItemKind="LastPage" />
                                    <dx:ReportToolbarSeparator />
                                    <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                                    <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                                    <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                                        <Elements>
                                            <dx:ListElement Value="pdf" />
                                            <dx:ListElement Value="png" />
                                        </Elements>
                                    </dx:ReportToolbarComboBox>
                                </Items>
                                <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                </Images>
                                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                    <LabelStyle ForeColor="Black">
                                        <Margins MarginLeft="3px" MarginRight="3px" />
                                    </LabelStyle>
                                    <ComboBoxStyle>
                                        <Margins MarginLeft="3px" MarginRight="3px" />
                                    </ComboBoxStyle>
                                    <TextBoxStyle>
                                        <Margins MarginLeft="2px" MarginRight="2px" />
                                    </TextBoxStyle>
                                    <ButtonStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                    </ButtonStyle>
                                </Styles>
                            </dx:ReportToolbar>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <dx1:ReportViewer ID="rptCetakIARKhusus" runat="server" Report="<%# New rptCetakIARKhusus() %>"
                                ReportName="rptCetakIARKhusus" ClientInstanceName="CetakIARKhusus">
                                <Paddings PaddingBottom="5px" />
                                <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                            </dx1:ReportViewer>
                        </td>
                    </tr>
                </table>
            </div>
            <!---------------------------->
            <!--- Tutup Data Grid View --->
            <!---------------------------->
            <div id="divProsesTutupData" visible="false" runat="server">
                <table cellpadding="0" cellspacing="0" style="width: 830px;">
                    <tr>
                        <td>
                            <dx:ASPxButton ID="btnProsesTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                Text="Proses Tutup Data" Width="150px" Wrap="False">
                            </dx:ASPxButton>
                        </td>
                        <td width="90%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <dx:ASPxGridView ID="gvTutupIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIARKhusus"
                                ClientInstanceName="gvTutupIAR" Width="830px" SettingsBehavior-AutoExpandAllGroups="True"
                                OnCustomColumnDisplayText="gvTutupIAR_CustomColumnDisplayText" Font-Size="Small"
                                Font-Names="Calibri">
                                <SettingsBehavior AutoExpandAllGroups="True"></SettingsBehavior>
                                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                    <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                                    </Header>
                                    <LoadingPanel ImageSpacing="10px">
                                    </LoadingPanel>
                                </Styles>
                                <SettingsPager Visible="False">
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
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" Width="30px"
                                        FixedStyle="Left" CellStyle-BackColor="#ffffd6" >
                                        <EditFormSettings Visible="False" />
                                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataCheckColumn FieldName="chkBox" UnboundType="Boolean" Width="30px"
                                        FixedStyle="Left" CellStyle-BackColor="#ffffd6">
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
                                    <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID" ReadOnly="True">
                                        <Settings AllowHeaderFilter="True" />
                                        <EditFormSettings Visible="False" />
                                        <CellStyle BackColor="#FFFFD6" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="NamaPanggilanKhusus" Width="80px" FixedStyle="Left">
                                        <CellStyle BackColor="#FFFFD6" Wrap="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="AlamatStasiun" Width="180px">
                                        <CellStyle Wrap="True" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="DayaDibawah30" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="DayaDiatas30" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="PenggunaanStasiun" Width="180px">
                                        <CellStyle Wrap="False" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="BandFrekuensi" Width="100px" />
                                    <dx:GridViewDataTextColumn FieldName="KelasEmisi" Width="100px" />
                                    <dx:GridViewDataTextColumn FieldName="BerlakuMulai" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="BerlakuAkhir" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="Orda" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="Orlok" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="NamaLengkap" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="NamaPanggilan" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="JenisKelamin" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="TempatLahir" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="TanggalLahir" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="Pekerjaan" Width="80px" />
                                    <dx:GridViewDataTextColumn FieldName="Alamat" Width="180px" />
                                </Columns>
                                <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                                <SettingsPager Mode="ShowAllRecords" />
                                <SettingsText Title="Tutup Data IAR Khusus" />
                                <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                                    ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" />
                                <StylesEditors>
                                    <ProgressBar Height="25px">
                                    </ProgressBar>
                                </StylesEditors>
                            </dx:ASPxGridView>
                            <br />
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
</table>
<asp:AccessDataSource ID="dsDataIARKhusus" runat="server" DataFile="~/App_Data/DataProses.mdb"
    SelectCommand="SELECT * FROM [DataIARKhusus] ORDER BY [ProsesID]" UpdateCommand="UPDATE [DataIARKhusus] SET [NamaPanggilanKhusus] = ?, [AlamatStasiun] = ?, [DayaDibawah30] = ?, [DayaDiatas30] = ?, [PenggunaanStasiun] = ?, [BandFrekuensi] = ?, [KelasEmisi] = ?, [BerlakuMulai] = ?, [BerlakuAkhir] = ? WHERE [ProsesID] = ?">
    <UpdateParameters>
        <asp:Parameter Name="NamaPanggilanKhusus" Type="String" />
        <asp:Parameter Name="AlamatStasiun" Type="String" />
        <asp:Parameter Name="DayaDibawah30" Type="String" />
        <asp:Parameter Name="DayaDiatas30" Type="String" />
        <asp:Parameter Name="PenggunaanStasiun" Type="String" />
        <asp:Parameter Name="BandFrekuensi" Type="String" />
        <asp:Parameter Name="KelasEmisi" Type="String" />
        <asp:Parameter Name="BerlakuMulai" Type="String" />
        <asp:Parameter Name="BerlakuAkhir" Type="String" />
    </UpdateParameters>
</asp:AccessDataSource>
