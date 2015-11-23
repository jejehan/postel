<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucHasilUNAR.ascx.vb"
    Inherits="UserControls_ucHasilUNAR" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraPivotGrid.Web" TagPrefix="dx" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>


<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx1" %>
<link href="../default.css" rel="stylesheet" type="text/css" />
<link href="../layout.css" rel="stylesheet" type="text/css" />

<script type='text/javascript'>
    function cancelClick() {
    }
</script>

<style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
        font-family: Arial, Helvetica, sans-serif;
        color: Navy;
        font-size: large;
        font-weight: bold;
        height: 34px;
    }
</style>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td colspan="3">
        </td>
    </tr>
    <tr>
        <td class="style7" colspan="3" align="center">
            HASIL UNAR
        </td>
    </tr>
    <tr>
        <td style="text-align: left" colspan="3">
            <table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnProsesUNAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Proses UNAR" Width="150px" Wrap="False">
                            <Image Url="~/Images/proses-16x16.gif">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnExportExcell" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Ekspor Excell" Width="150px" Wrap="False">
                            <Image Url="~/Images/Export-XLS-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnRefreshData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Perbaharui Data" Width="150px" Wrap="False">
                            <Image Url="~/Images/Refresh2-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td style="width: 90%">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td valign="top">
                        <dx:ASPxGridView ID="gvHasilUNAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" KeyFieldName="NomorUNAR" DataSourceID="dsDataUNAR"
                            ClientInstanceName="gvDataUNAR" Width="990px" SettingsBehavior-AutoExpandAllGroups="True"
                            EnableRowsCache="False" 
                            OnCustomColumnDisplayText="gvHasilUNAR_CustomColumnDisplayText" 
                            Font-Size="XX-Small">
                            <SettingsEditing Mode="PopupEditForm" EditFormColumnCount="2" PopupEditFormWidth="400px" />
                            <SettingsBehavior AutoExpandAllGroups="True" />
                            <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px" HorizontalAlign="Left">
                                </Header>
                                <LoadingPanel ImageSpacing="10px">
                                </LoadingPanel>
                            </Styles>
                            <SettingsPager Visible="False" />
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
                                    FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0" Visible="False">
                                    <EditFormSettings Visible="False" />
                                    <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                        AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                                    <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                                    <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewCommandColumn Caption="Edit" ButtonType="Image" FixedStyle="Left" VisibleIndex="0" Width="30px" ShowEditButton="True">
                                    <CellStyle BackColor="#FFFFD6">
                                    </CellStyle>
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" VisibleIndex="0" FieldName="ProsesID" Visible="False">
                                    <EditFormSettings Visible="False" />
                                    <CellStyle BackColor="#FFFFD6">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn CellStyle-BackColor="#ffffd6" VisibleIndex="1" FieldName="LokasiUNAR"
                                    FixedStyle="Left" Width="100px">
                                    <EditFormSettings Visible="False" />
                                    <Settings AllowHeaderFilter="True" />
                                    <CellStyle BackColor="#FFFFD6" HorizontalAlign="Left">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="NomorUNAR" FixedStyle="Left" ReadOnly="True"
                                    VisibleIndex="2" Width="140px">
                                    <EditFormSettings Visible="False" />
                                    <CellStyle BackColor="#FFFFD6">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Nama" VisibleIndex="3" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                                    ReadOnly="True" Width="150px">
                                    <EditFormSettings Visible="False" />
                                    <CellStyle Wrap="False" HorizontalAlign="Left">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Tingkat" VisibleIndex="4" GroupIndex="0">
                                    <Settings AllowHeaderFilter="True" />
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="PS" VisibleIndex="5" Width="40px" Caption="PS">
                                    <EditFormSettings VisibleIndex="0" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="TR" VisibleIndex="6" Width="40px" Caption="TR">
                                    <EditFormSettings VisibleIndex="1" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="PR" VisibleIndex="7" Width="40px" Caption="PR">
                                    <EditFormSettings VisibleIndex="3" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="BI" VisibleIndex="8" Width="40px" Caption="BI">
                                    <EditFormSettings VisibleIndex="4" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="KM" VisibleIndex="9" Width="40px" Caption="KM">
                                    <EditFormSettings Visible="True" VisibleIndex="5" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Teori" VisibleIndex="10" Width="50px">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Jumlah" VisibleIndex="11" Width="50px">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Konstanta" VisibleIndex="12" Width="70px" Visible="False">
                                    <EditFormSettings Visible="True" VisibleIndex="6" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Nilai" VisibleIndex="13" Width="50px">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Hasil" VisibleIndex="14" Width="100px">
                                    <Settings AllowHeaderFilter="True" />
                                    <EditFormSettings Visible="False" />
                                    <CellStyle HorizontalAlign="Left" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Keterangan" VisibleIndex="15" Width="150px"
                                    Caption="Ket.">
                                    <Settings AllowHeaderFilter="True" />
                                    <EditFormSettings Visible="True" VisibleIndex="7" />
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="KMKirim" VisibleIndex="16" Width="70px">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="KMTerima" VisibleIndex="17" Width="70px">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="GroupID" VisibleIndex="18" Visible="false">
                                    <Settings AllowHeaderFilter="True" />
                                    <EditFormSettings Visible="False" />
                                    <EditCellStyle BackColor="Gray">
                                    </EditCellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Orda" VisibleIndex="19" Visible="false">
                                    <Settings AllowHeaderFilter="True" />
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="Orlok" VisibleIndex="20" Visible="false">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <SettingsPager Mode="ShowAllRecords" />
                            <SettingsText Title="Hasil UNAR" />
                            <Settings ShowTitlePanel="true" ShowGroupPanel="True" ShowHeaderFilterButton="False"
                                ShowFilterRowMenu="False" ShowVerticalScrollBar="True" 
                                ShowHorizontalScrollBar="True" VerticalScrollableHeight="300" />
                            <GroupSummary>
                                <dx:ASPxSummaryItem FieldName="NomorUNAR" SummaryType="Count" />
                            </GroupSummary>
                            <StylesEditors>
                                <ProgressBar Height="25px">
                                </ProgressBar>
                            </StylesEditors>
                            <StylesEditors>
                                <ProgressBar Height="25px">
                                </ProgressBar>
                            </StylesEditors>
                            <SettingsCommandButton>
                                <EditButton>
                                    <Image AlternateText="Edit" Url="~/Images/Edit-16x16.gif">
                                    </Image>
                                </EditButton>
                                <CancelButton>
                                    <Image Url="~/Images/Undo-16x16.png">
                                    </Image>
                                </CancelButton>
                                <UpdateButton>
                                    <Image Url="~/Images/Save-16x16.png">
                                    </Image>
                                </UpdateButton>
                            </SettingsCommandButton>
                        </dx:ASPxGridView>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:AccessDataSource ID="dsDataUNAR" runat="server" DataFile="~/App_Data/DataProses.mdb"
                SelectCommand="SELECT * FROM [HasilUNAR]" UpdateCommand="UPDATE [HasilUNAR] SET [PS] = ?, [TR] = ?, [PR] = ?, [BI] = ?, [KM] = ?, [Konstanta] = ?, [Keterangan] = ? WHERE [NomorUNAR] = ?">
                <UpdateParameters>
                    <asp:Parameter Name="PS" Type="Decimal" />
                    <asp:Parameter Name="TR" Type="Decimal" />
                    <asp:Parameter Name="PR" Type="Decimal" />
                    <asp:Parameter Name="BI" Type="Decimal" />
                    <asp:Parameter Name="KM" Type="Decimal" />
                    <asp:Parameter Name="Konstanta" Type="Decimal" />
                    <asp:Parameter Name="Keterangan" Type="String" />
                </UpdateParameters>
            </asp:AccessDataSource>
            <dx:ASPxGridViewExporter ID="ExportAll" runat="server" GridViewID="gvHasilUNAR">
            </dx:ASPxGridViewExporter>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
</table>
