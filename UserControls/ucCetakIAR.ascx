<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCetakIAR.ascx.vb" Inherits="UserControls_ucCetakIAR" %>
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
</style>
<table style="width: 980px;" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td colspan="3" class="style1" style="text-align: center">
            Sertifikat Kecakapan Amatir Radio (IAR)
        </td>
    </tr>
    <tr>
        <td align="left">
            <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 100%;"
                border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td style="text-align: center;">
                        <dx:ASPxButton ID="btnEditData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Edit Data" Width="150px" Wrap="False" Checked="True" HorizontalAlign="Left">
                            <Image Url="~/Images/application_edit.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td align="left">
                        <dx:ASPxButton ID="btnCetakData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Cetak Data" Width="150px" Wrap="False" HorizontalAlign="Left">
                            <Image Url="~/Images/printer.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td align="left">
                        <dx:ASPxButton ID="btnTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" GroupName="CetakIAR" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Tutup Data" Width="150px" Wrap="False" HorizontalAlign="Left">
                            <Image Url="~/Images/db_lock.gif">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td width="60%">
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<br />
<div id="divPreviewIAR" runat="server" visible="false">
    <table style="width: 980px;" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="2" style="width: 630px;">
                <!---------------------->
                <!--- Edit Grid View --->
                <!---------------------->
                <dx:ASPxGridView ID="gvDataIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIAR"
                    ClientInstanceName="gvDataIAR" Width="630px" SettingsBehavior-AutoExpandAllGroups="True"
                    OnCustomColumnDisplayText="gvDataIAR_CustomColumnDisplayText" EnableRowsCache="False"
                    Visible="False" Font-Size="Small" Font-Names="Calibri">
                    <SettingsBehavior AutoExpandAllGroups="True"></SettingsBehavior>
                    <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                        <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                        </Header>
                        <LoadingPanel ImageSpacing="10px">
                        </LoadingPanel>
                    </Styles>
                    <SettingsPager Visible="False" AlwaysShowPager="True" PageSize="50" Position="Top">
                        <FirstPageButton Visible="True">
                        </FirstPageButton>
                        <LastPageButton Visible="True">
                        </LastPageButton>
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
                        <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" Width="25px"
                            FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                            <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                            <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                            <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewCommandColumn ButtonType="Image" Caption="Edit" Width="30px" VisibleIndex="1" FixedStyle="Left" CellStyle-BackColor="#ffffd6" Visible="false" ShowEditButton="True">
                            <HeaderStyle HorizontalAlign="Center"/>
                            <CellStyle HorizontalAlign="Center"/>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataColumn Caption="Lihat" Width="30px" VisibleIndex="2" FixedStyle="Left"
                            CellStyle-BackColor="#ffffd6" ReadOnly="True">
                            <EditFormSettings Visible="False" />
                            <HeaderStyle HorizontalAlign="Center" />
                            <CellStyle HorizontalAlign="Center" />
                            <DataItemTemplate>
                                <asp:ImageButton ID="btnPilih" runat="server" AlternateText="Pilih" OnClick="btnPilih_Click"
                                    ImageUrl="~/images/Card-Preview.jpg" />
                                <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                                <asp:Literal runat="server" ID="ltrlTingkat" Text='<%# Eval("Tingkat") %>' Visible="false" />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID" VisibleIndex="3"
                            ReadOnly="True" CellStyle-HorizontalAlign="Left">
                            <Settings AllowHeaderFilter="True" />
                            <EditFormSettings Visible="False" />
                            <CellStyle BackColor="#FFFFD6">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="Orda" VisibleIndex="4"
                            ReadOnly="True" Width="150px" CellStyle-HorizontalAlign="Left">
                            <Settings AllowHeaderFilter="True" />
                            <EditFormSettings Visible="False" />
                            <CellStyle BackColor="#FFFFD6">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Nama" Width="150px" VisibleIndex="5" FixedStyle="Left"
                            CellStyle-BackColor="#ffffd6" CellStyle-HorizontalAlign="Left">
                            <CellStyle BackColor="#FFFFD6" Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Tingkat" Width="80px" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="6" CellStyle-HorizontalAlign="Left">
                            <Settings AllowHeaderFilter="True" />
                            <EditFormSettings Visible="False" />

<CellStyle HorizontalAlign="Left"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Class" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="7" Visible="False" CellStyle-HorizontalAlign="Left">
                            <EditFormSettings Visible="False" />

<CellStyle HorizontalAlign="Left"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CallSign" Width="80px" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="8">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat1" Width="180px" VisibleIndex="9" CellStyle-HorizontalAlign="Left">
                            <CellStyle Wrap="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat2" Width="180px" EditFormCaptionStyle-Wrap="False"
                            EditCellStyle-Wrap="False" CellStyle-Wrap="False" VisibleIndex="10" CellStyle-HorizontalAlign="Left">
                            <EditCellStyle Wrap="False" />
                            <EditFormCaptionStyle Wrap="False" />
                            <CellStyle Wrap="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat3" Width="180px" CellStyle-Wrap="False"
                            EditFormCaptionStyle-Wrap="False" VisibleIndex="11" CellStyle-HorizontalAlign="Left">
                            <EditFormCaptionStyle Wrap="False" />
                            <CellStyle Wrap="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="TanggalBerlakuIAR" ReadOnly="True" CellStyle-HorizontalAlign="Left"
                            GroupFooterCellStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left"
                            ShowInCustomizationForm="False" VisibleIndex="12">
                            <EditFormSettings Visible="False" />
                            <HeaderStyle HorizontalAlign="Left" />
                            <CellStyle HorizontalAlign="Left" />
                            <GroupFooterCellStyle HorizontalAlign="Left" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NomorIAR" ReadOnly="True" ShowInCustomizationForm="False"
                            VisibleIndex="13">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                    <SettingsPager Mode="ShowAllRecords" />
                    <SettingsText Title="Edit Data IAR" EmptyDataRow="Data tidak ditemukan" />
                    <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                        ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" ShowVerticalScrollBar="True"
                        VerticalScrollableHeight="300" />
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="NomorIAR" SummaryType="Count" />
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
                            <Image Url="~/Images/Undo-16x16.png">
                            </Image>
                        </CancelButton>
                        <UpdateButton Text="Simpan">
                            <Image Url="~/Images/Save-16x16.png">
                            </Image>
                        </UpdateButton>
                    </SettingsCommandButton>
                </dx:ASPxGridView>
            </td>
            <td style="width: 300px;">
                <dx1:ReportViewer ID="rptEditIAR" runat="server" Report="<%# New rptPreviewIAR() %>"
                    ReportName="rptPreviewIAR" ClientInstanceName="ViewerIAR" Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
            </td>
        </tr>
    </table>
</div>
<div id="divCetakIAR" runat="server" visible="false">
    <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 980px;
        height: 100%;" border="0" cellpadding="2" cellspacing="0">
        <tr>
            <td>
                <!----------------------->
                <!--- Cetak Grid View --->
                <!----------------------->
                <dx:ASPxButton ID="btnIARPemula" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Pemula" Width="100px" Wrap="False" GroupName="CetakIAR">
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="btnIARSiaga" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Siaga" Width="100px" Wrap="False" GroupName="CetakIAR">
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="btnIARPenggalang" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Penggalang" Width="100px" Wrap="False" GroupName="CetakIAR">
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="btnIARPenegak" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Penegak" Width="100px" Wrap="False" GroupName="CetakIAR">
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="btnIARKhusus" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Khusus" Width="100px" Wrap="False" GroupName="CetakIAR" Visible="False">
                </dx:ASPxButton>
            </td>
            <td>
            </td>
            <td>
                &nbsp;
            </td>
            <td width="50%">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="8" align="left">
                <dx:ReportToolbar ID="rptToolbarPemula" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                    ItemSpacing="2px" ReportViewer="<%# rptCetakIARPemula %>" SeparatorHeight="14px"
                    SeparatorWidth="1px" ShowDefaultButtons="False" Visible="False">
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
                <dx:ReportToolbar ID="rptToolbarPenggalang" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                    ItemSpacing="2px" ReportViewer="<%# rptCetakIARPenggalang %>" SeparatorHeight="14px"
                    SeparatorWidth="1px" ShowDefaultButtons="False" Visible="False">
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
                <dx:ReportToolbar ID="rptToolbarSiaga" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                    ItemSpacing="2px" ReportViewer="<%# rptCetakIARSiaga %>" SeparatorHeight="14px"
                    SeparatorWidth="1px" ShowDefaultButtons="False" Visible="False">
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
                <dx:ReportToolbar ID="rptToolbarPenegak" runat="server" Font-Names="Tahoma" Font-Size="9pt"
                    ItemSpacing="2px" ReportViewer="<%# rptCetakIARPenegak %>" SeparatorHeight="14px"
                    SeparatorWidth="1px" ShowDefaultButtons="False" Visible="False">
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
            <td colspan="4" align="left">
                <dx1:ReportViewer ID="rptCetakIARPemula" runat="server" Report="<%# New rptCetakIARPemula() %>"
                    ReportName="rptCetakIARPemula" ClientInstanceName="CetakIARPemula" Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
                <dx1:ReportViewer ID="rptCetakIARPenggalang" runat="server" Report="<%# New rptCetakIARPenggalang() %>"
                    ReportName="rptCetakIARPenggalang" ClientInstanceName="CetakIARPenggalang" Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
                <dx1:ReportViewer ID="rptCetakIARSiaga" runat="server" Report="<%# New rptCetakIARSiaga() %>"
                    ReportName="rptCetakIARSiaga" ClientInstanceName="CetakIARSiaga" Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
                <dx1:ReportViewer ID="rptCetakIARPenegak" runat="server" Report="<%# New rptCetakIARPenegak() %>"
                    ReportName="rptCetakIARPenegak" ClientInstanceName="CetakIARPenegak" Visible="False">
                    <Paddings PaddingBottom="5px" />
                    <Border BorderColor="Maroon" BorderStyle="Solid" BorderWidth="1px" />
                </dx1:ReportViewer>
            </td>
            <td colspan="4">
                <asp:Image ID="ImgKartu" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="8">
                <p>
                    &nbsp;</p>
            </td>
        </tr>
    </table>
</div>
<!---------------------------->
<!--- Tutup Data Grid View --->
<!---------------------------->
<div id="divProsesTutupData" visible="false" runat="server">
    <table cellpadding="0" cellspacing="0" style="width: 980px;" border="0">
        <tr>
            <td align="left">
                <dx:ASPxButton ID="btnProsesTutupData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                    Text="Proses Tutup Data" Width="150px" Wrap="False">
                </dx:ASPxButton>
            </td>
        </tr>
        <tr>
            <td style="line-height: 5px;">
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxGridView ID="gvTutupIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                    CssPostfix="Office2003Blue" KeyFieldName="ProsesID" DataSourceID="dsDataIAR"
                    ClientInstanceName="gvTutupIAR" Width="980px" SettingsBehavior-AutoExpandAllGroups="True"
                    OnCustomColumnDisplayText="gvTutupIAR_CustomColumnDisplayText" Font-Size="Small"
                    Font-Names="Calibri">
                    <SettingsBehavior AutoExpandAllGroups="True"></SettingsBehavior>
                    <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                        <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                        </Header>
                        <LoadingPanel ImageSpacing="10px">
                        </LoadingPanel>
                    </Styles>
                    <SettingsPager Visible="False" ShowEmptyDataRows="True">
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
                        <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" FieldName="GroupID">
                            <Settings AllowHeaderFilter="True" />
                            <CellStyle BackColor="#FFFFD6">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Nama">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Tingkat">
                            <Settings AllowHeaderFilter="True" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Class" EditFormCaptionStyle-Wrap="False" EditCellStyle-Wrap="False"
                            CellStyle-Wrap="False" Visible="False">
                            <EditCellStyle Wrap="False">
                            </EditCellStyle>
                            <EditFormCaptionStyle Wrap="False">
                            </EditFormCaptionStyle>
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CallSign">
                            <EditFormCaptionStyle Wrap="False">
                            </EditFormCaptionStyle>
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat1" CellStyle-HorizontalAlign="Left" GroupFooterCellStyle-HorizontalAlign="Left"
                            HeaderStyle-HorizontalAlign="Left">
                            <HeaderStyle HorizontalAlign="Left" />
                            <CellStyle HorizontalAlign="Left">
                            </CellStyle>
                            <GroupFooterCellStyle HorizontalAlign="Left">
                            </GroupFooterCellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat2" CellStyle-Wrap="False" EditFormCaptionStyle-Wrap="False">
                            <EditFormCaptionStyle Wrap="False">
                            </EditFormCaptionStyle>
                            <CellStyle Wrap="False">
                            </CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Alamat3">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="TanggalBerlakuIAR">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NomorIAR">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormWidth="600px" />
                    <SettingsPager Mode="ShowAllRecords" />
                    <SettingsText Title="Tutup Data IAR" EmptyDataRow="Data tidak ditemukan" />
                    <Settings ShowTitlePanel="true" ShowFilterRow="False" ShowHeaderFilterButton="False"
                        ShowFilterRowMenu="False" ShowHorizontalScrollBar="True" ShowPreview="True"
                        VerticalScrollableHeight="300" />
                    <GroupSummary>
                        <dx:ASPxSummaryItem FieldName="NomorIAR" SummaryType="Count" />
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
<asp:AccessDataSource ID="dsDataIAR" runat="server" DataFile="~/App_Data/DataProses.mdb"
    SelectCommand="SELECT * FROM [DataIAR] ORDER BY [NomorIAR]" UpdateCommand="UPDATE [DataIAR] SET [Nama] = ?, [Alamat1] = ?, [Alamat2] = ?, [Alamat3] = ? WHERE [ProsesID] = ?">
    <UpdateParameters>
        <asp:Parameter Name="Nama" Type="String" />
        <asp:Parameter Name="Alamat1" Type="String" />
        <asp:Parameter Name="Alamat2" Type="String" />
        <asp:Parameter Name="Alamat3" Type="String" />
    </UpdateParameters>
</asp:AccessDataSource>
