<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCetakSKAR.ascx.vb"
    Inherits="UserControls_ucCetakSKAR" %>
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
            Sertifikat Kecakapan Amatir Radio (SKAR)
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
                CssPostfix="Office2003Blue" GroupName="CetakSKAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Edit Data" Width="100px" Wrap="False" Checked="True" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnCetakData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakSKAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Cetak Data" Width="100px" Wrap="False" HorizontalAlign="Left">
            </dx:ASPxButton>
            <dx:ASPxButton ID="btnTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" GroupName="CetakSKAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Tutup Data" Width="100px" Wrap="False" HorizontalAlign="Left">
            </dx:ASPxButton>
            &nbsp; &nbsp; &nbsp;
        </td>
        <td>
            &nbsp; &nbsp; &nbsp;
        </td>
        <td align="left">
            <dx:ReportToolbar ID="ReportToolbar1" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                ItemSpacing="2px" ReportViewer="<%# ReportViewer2 %>" SeparatorHeight="14px"
                SeparatorWidth="1px" ShowDefaultButtons="False">
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
            <dx:ASPxButton ID="btnProsesTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Proses Tutup Data" Width="150px" Wrap="False">
            </dx:ASPxButton>
            <dx:ASPxGridView ID="gvDataSKAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" DataSourceID="dsDataSKAR" ClientInstanceName="gvDataSKAR"
                KeyFieldName="ProsesID" Width="880px" SettingsBehavior-AutoExpandAllGroups="True"
                OnCustomColumnDisplayText="gvDataSKAR_CustomColumnDisplayText" 
                Font-Size="Small" Font-Names="Calibri">
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
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6">
                        <EditFormSettings Visible="False" />
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewCommandColumn ButtonType="Image" Caption="Edit" Width="30px" FixedStyle="Left" ShowEditButton="True">
                        <HeaderStyle HorizontalAlign="Center"/>
                        <CellStyle HorizontalAlign="Center"/>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataColumn Caption="Lihat" Width="30px" FixedStyle="Left">
                        <EditFormSettings Visible="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnPilih" runat="server" AlternateText="Pilih" OnClick="btnPilih_Click"
                                ImageUrl="~/images/Card-Preview.jpg" />
                            <asp:Literal runat="server" ID="ltrlNomorSKAR" Text='<%# Eval("NomorSKAR") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="CallSign" Width="50px" ReadOnly="True">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Nama" Width="285px">
                        <EditFormSettings VisibleIndex="0" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorSKAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TanggalSKAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TempatTanggalLahir" EditFormCaptionStyle-Wrap="False"
                        EditCellStyle-Wrap="False" CellStyle-Wrap="False" Width="275px">
                        <EditFormSettings VisibleIndex="1" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <EditCellStyle Wrap="False">
                        </EditCellStyle>
                        <EditFormCaptionStyle Wrap="False">
                        </EditFormCaptionStyle>
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Alamat" CellStyle-Wrap="False" EditFormCaptionStyle-Wrap="False"
                        Width="270px">
                        <EditFormSettings VisibleIndex="2" ColumnSpan="2" Visible="True" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <EditFormCaptionStyle Wrap="False">
                        </EditFormCaptionStyle>
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Tingkat" SortOrder="Ascending" ReadOnly="True"
                        Width="275px" CellStyle-HorizontalAlign="Left" GroupFooterCellStyle-HorizontalAlign="Left"
                        HeaderStyle-HorizontalAlign="Left">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                        <GroupFooterCellStyle HorizontalAlign="Left">
                        </GroupFooterCellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TanggalUNAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="LokasiUNAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FileFoto" Width="150px">
                        <EditFormSettings VisibleIndex="3" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ProsesID" Visible="false" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                <SettingsPager Mode="ShowAllRecords" />
                <SettingsText Title="Edit Data SKAR" />
                <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                    ShowFilterRowMenu="False" ShowVerticalScrollBar="True" ShowHorizontalScrollBar="True"
                    ShowPreview="True" VerticalScrollableHeight="300" />
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="NomorSKAR" SummaryType="Count" />
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
            <!--------------------------->
            <!--- GridView Tutup SKAR --->
            <!--------------------------->
            <dx:ASPxGridView ID="gvTutupSKAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" DataSourceID="dsDataSKAR" ClientInstanceName="gvTutupSKAR"
                KeyFieldName="ProsesID" Width="880px" SettingsBehavior-AutoExpandAllGroups="True"
                OnCustomColumnDisplayText="gvTutupSKAR_CustomColumnDisplayText" EnableRowsCache="False"
                Font-Size="Small" Font-Names="Calibri">
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
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6">
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
                    <dx:GridViewDataTextColumn FieldName="NomorSKAR" ReadOnly="True" Width="150px" FixedStyle="Left">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TanggalSKAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Nama" Width="275px">
                        <EditFormSettings VisibleIndex="0" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TempatTanggalLahir" EditFormCaptionStyle-Wrap="False"
                        EditCellStyle-Wrap="False" CellStyle-Wrap="False" Width="275px">
                        <EditFormSettings VisibleIndex="1" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <EditCellStyle Wrap="False">
                        </EditCellStyle>
                        <EditFormCaptionStyle Wrap="False">
                        </EditFormCaptionStyle>
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Alamat" CellStyle-Wrap="False" EditFormCaptionStyle-Wrap="False"
                        Width="275px">
                        <EditFormSettings VisibleIndex="1" ColumnSpan="2" Visible="True" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <EditFormCaptionStyle Wrap="False">
                        </EditFormCaptionStyle>
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Tingkat" SortOrder="Ascending" ReadOnly="True"
                        Width="275px" CellStyle-HorizontalAlign="Left" GroupFooterCellStyle-HorizontalAlign="Left"
                        HeaderStyle-HorizontalAlign="Left">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <GroupFooterCellStyle HorizontalAlign="Left" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TanggalUNAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="LokasiUNAR" ReadOnly="True" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FileFoto" Width="150px">
                        <EditFormSettings VisibleIndex="3" />
                        <CellStyle Wrap="False" HorizontalAlign="Left" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ProsesID" Visible="false" Width="150px">
                        <EditFormSettings Visible="False" />
                        <CellStyle Wrap="False" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                <SettingsPager Mode="ShowAllRecords" />
                <SettingsText Title="Tutup Data SKAR" />
                <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                    ShowFilterRowMenu="False" ShowVerticalScrollBar="True" ShowHorizontalScrollBar="True"
                    ShowPreview="True" VerticalScrollableHeight="300" />
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="NomorSKAR" SummaryType="Count" />
                </GroupSummary>
                <StylesEditors>
                    <ProgressBar Height="25px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td align="left">
            <dx1:ReportViewer ID="ReportViewer2" runat="server" Report="<%# New rptCetakSKAR() %>"
                ReportName="rptCetakSKAR" ClientInstanceName="CetakSKAR" Visible="False">
                <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
            </dx1:ReportViewer>
            <dx1:ReportViewer ID="ReportViewer1" runat="server" Report="<%# New rptPreviewSKAR() %>"
                ReportName="rptPreviewSKAR" ClientInstanceName="ViewerSKAR">
                <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
            </dx1:ReportViewer>
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
</table>
<asp:AccessDataSource ID="dsDataSKAR" runat="server" DataFile="~/App_Data/DataProses.mdb"
    SelectCommand="SELECT * FROM [DataSKAR] ORDER BY [NomorSKAR]" UpdateCommand="UPDATE [DataSKAR] SET [Nama] = ?, [TempatTanggalLahir] = ?, [Alamat] = ?, [FileFoto] = ? WHERE [ProsesID] = ?">
    <UpdateParameters>
        <asp:Parameter Name="Nama" Type="String" />
        <asp:Parameter Name="TempatTanggalLahir" Type="String" />
        <asp:Parameter Name="Alamat" Type="String" />
        <asp:Parameter Name="FileFoto" Type="String" />
    </UpdateParameters>
</asp:AccessDataSource>
