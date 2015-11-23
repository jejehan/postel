<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCetakIKRAP.ascx.vb" Inherits="UserControls_ucCetakIKRAP" %>
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
            Sertifikat Kecakapan Amatir Radio (IKRAP)
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
                CssPostfix="Office2003Blue" GroupName="CetakIKRAP" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Edit Data" Width="150px" Wrap="False" Checked="True" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnCetakData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakIKRAP" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Cetak Data" Width="150px" Wrap="False" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakIKRAP" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
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
            <div id="divPreviewIKRAP" runat="server" visible="false">
                <dx:ASPxGridView ID="gvDataIKRAP" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIKRAP"
                    ClientInstanceName="gvDataIKRAP" Width="830px" SettingsBehavior-AutoExpandAllGroups="True"
                    OnCustomColumnDisplayText="gvDataIKRAP_CustomColumnDisplayText"
                    EnableRowsCache="False" Visible="False" Font-Size="Small" 
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
                            FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                            <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                            <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                            <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewCommandColumn ButtonType="Image" Caption="Edit" Width="40px" VisibleIndex="1" FixedStyle="Left" CellStyle-BackColor="#ffffd6" ShowEditButton="True">
                            <HeaderStyle HorizontalAlign="Center"/>
                            <CellStyle HorizontalAlign="Center"/>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataColumn Caption="Lihat" Width="40px" VisibleIndex="2" FixedStyle="Left"
                            CellStyle-BackColor="#ffffd6" ReadOnly="True">
                            <EditFormSettings Visible="False" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <CellStyle HorizontalAlign="Center" />
                            <DataItemTemplate>
                                <asp:ImageButton ID="btnPilih" runat="server" AlternateText="Pilih" OnClick="btnPilih_Click"
                                    ImageUrl="~/images/Card-Preview.jpg" />
                                <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID" VisibleIndex="4"
                            ReadOnly="True">
                            <Settings AllowHeaderFilter="True" />
                            <EditFormSettings Visible="False" />
                            <CellStyle BackColor="#FFFFD6">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Nama" Width="180px" VisibleIndex="3" FixedStyle="Left"
                            CellStyle-BackColor="#ffffd6">
                            <CellStyle BackColor="#FFFFD6" Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CallSign" Width="80px" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="5">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat1"
                            VisibleIndex="6" Width="180px">
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat2" Width="180px" EditFormCaptionStyle-Wrap="False"
                            EditCellStyle-Wrap="False" CellStyle-Wrap="False" VisibleIndex="7">
                            <EditCellStyle Wrap="False">
                            </EditCellStyle>
                            <EditFormCaptionStyle Wrap="False">
                            </EditFormCaptionStyle>
                            <HeaderStyle HorizontalAlign="Left" />
                            <CellStyle HorizontalAlign="Left">
                            </CellStyle>
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat3" Width="180px" VisibleIndex="8">
                            <EditFormCaptionStyle Wrap="False">
                            </EditFormCaptionStyle>
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="TanggalBerlakuIKRAP" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="9">
                            <EditFormSettings Visible="False" />
                            <GroupFooterCellStyle HorizontalAlign="Left">
                            </GroupFooterCellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NomorIKRAP" CellStyle-Wrap="False"
                            EditFormCaptionStyle-Wrap="False" VisibleIndex="10" ReadOnly="True" 
                            ShowInCustomizationForm="False">
                            <EditFormSettings Visible="False" />

<EditFormCaptionStyle Wrap="False"></EditFormCaptionStyle>

<CellStyle Wrap="False"></CellStyle>
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                    <SettingsPager Mode="ShowAllRecords" />
                    <SettingsText Title="Edit Data IKRAP" />
                    <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                        ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" />
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="NomorIKRAP" SummaryType="Count" />
                    </GroupSummary>
                    <StylesEditors>
                        <ProgressBar Height="25px">
                        </ProgressBar>
                    </StylesEditors>
                    <SettingsCommandButton>
                        <EditButton Text="Edit Data">
                            <Image Url="~/Images/Edit-16x16.gif">
                            </Image>
                        </EditButton>
                        <CancelButton Text="Batal">
                            <Image Url="~/Images/Undo-16x16.png">
                            </Image>
                        </CancelButton>
                        <UpdateButton Text="Simpan">
                            <Image Url="~/Images/Save-16x16.png">
                            </Image>
                        </UpdateButton>
                    </SettingsCommandButton>
                </dx:ASPxGridView>
                <dx1:ReportViewer ID="rptEditIKRAP" runat="server" Report="<%# New rptPreviewIKRAP() %>"
                    ReportName="rptPreviewIKRAP" ClientInstanceName="ViewerIKRAP" 
                    Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
            </div>
            <!----------------------->
            <!--- Cetak Grid View --->
            <!----------------------->
            <div id="divCetakIKRAP" runat="server" visible="false">
                <table border="0" cellpadding="0" cellspacing="0" class="style6" style="width: 600px">
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
                        <td width="50%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <dx:ReportToolbar ID="rptToolbar" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                                ItemSpacing="2px" ReportViewer="<%# rptCetakIKRAP %>" SeparatorHeight="14px"
                                SeparatorWidth="1px" ShowDefaultButtons="False" Visible="False">
                                <Items>
                                    <dx:ReportToolbarButton ItemKind="Search" />
                                    <dx:ReportToolbarSeparator />
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
                            <dx1:ReportViewer ID="rptCetakIKRAP" runat="server" Report="<%# New rptCetakIKRAP() %>"
                                ReportName="rptCetakIKRAP" ClientInstanceName="CetakIKRAP" 
                                Visible="False">
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
                <table cellpadding="0" cellspacing="0" class="style6">
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
                            <dx:ASPxGridView ID="gvTutupIKRAP" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIKRAP"
                                ClientInstanceName="gvTutupIKRAP" Width="830px" SettingsBehavior-AutoExpandAllGroups="True"
                                OnCustomColumnDisplayText="gvTutupIKRAP_CustomColumnDisplayText" 
                                EnableRowsCache="False" Font-Size="Small" Font-Names="Calibri">
                                <SettingsBehavior AutoExpandAllGroups="True"></SettingsBehavior>
                                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                    <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                                    </Header>
                                    <LoadingPanel ImageSpacing="10px">
                                    </LoadingPanel>
                                </Styles>
                                <SettingsPager Visible="False" Mode="ShowAllRecords" ShowEmptyDataRows="True">
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
                                    <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID" VisibleIndex="1">
                                        <Settings AllowHeaderFilter="True" />
                                        <CellStyle BackColor="#FFFFD6">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Nama" VisibleIndex="2" Width="200px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Class" EditFormCaptionStyle-Wrap="False" EditCellStyle-Wrap="False"
                                        CellStyle-Wrap="False" VisibleIndex="3" Visible="False">
                                        <EditCellStyle Wrap="False">
                                        </EditCellStyle>
                                        <EditFormCaptionStyle Wrap="False">
                                        </EditFormCaptionStyle>
                                        <CellStyle Wrap="False">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="CallSign" VisibleIndex="4">
                                        <EditFormCaptionStyle Wrap="False">
                                        </EditFormCaptionStyle>
                                        <CellStyle Wrap="False">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Alamat1" CellStyle-HorizontalAlign="Left" GroupFooterCellStyle-HorizontalAlign="Left"
                                        HeaderStyle-HorizontalAlign="Left" VisibleIndex="5" Width="250px">
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <CellStyle HorizontalAlign="Left">
                                        </CellStyle>
                                        <GroupFooterCellStyle HorizontalAlign="Left">
                                        </GroupFooterCellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Alamat2" CellStyle-Wrap="False" EditFormCaptionStyle-Wrap="False"
                                        VisibleIndex="6" Width="100px">
                                        <EditFormCaptionStyle Wrap="False">
                                        </EditFormCaptionStyle>
                                        <CellStyle Wrap="False">
                                        </CellStyle>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Alamat3" VisibleIndex="7" Width="200px">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="TanggalBerlakuIKRAP" VisibleIndex="8">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="NomorIKRAP" VisibleIndex="9">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                                <SettingsPager Mode="ShowAllRecords" />
                                <SettingsText Title="Tutup Data IKRAP" />
                                <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                                    ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" />
                                <GroupSummary>
                                    <dx:ASPxSummaryItem FieldName="NomorIKRAP" SummaryType="Count" />
                                </GroupSummary>
                                <StylesEditors>
                                    <ProgressBar Height="25px">
                                    </ProgressBar>
                                </StylesEditors>
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
</table>
<asp:AccessDataSource ID="dsDataIKRAP" runat="server" DataFile="~/App_Data/DataProses.mdb"
    SelectCommand="SELECT * FROM [DataIKRAP]" UpdateCommand="UPDATE [DataIKRAP] SET [Nama] = ?, [Alamat1] = ?, [Alamat2] = ?, [Alamat3] = ? WHERE [ProsesID] = ?">
    <UpdateParameters>
        <asp:Parameter Name="Nama" Type="String" />
        <asp:Parameter Name="Alamat1" Type="String" />
        <asp:Parameter Name="Alamat2" Type="String" />
        <asp:Parameter Name="Alamat3" Type="String" />
    </UpdateParameters>
</asp:AccessDataSource>
