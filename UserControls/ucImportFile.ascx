<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucImportFile.ascx.vb"
    Inherits="usercontrols_ucImportFileUNAR" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>



<link href="../layout.css" rel="stylesheet" type="text/css" />
<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
</dx:ASPxCallback>

<script type='text/javascript'>
    function cancelClick() {
    }
</script>

<style type="text/css">
    .style6
    {
        width: 100%;
    }
</style>
<br />
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="0" align="center">
    <tr>
        <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_left.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
        <td style="height: 31px; background-image: url('/images/box/box3_top_mid.gif');"
            class="font-bold">
            Impor Data
        </td>
        <td style="width: 10px; height: 31px; background-image: url('/images/box/box3_top_right.gif');
            background-repeat: no-repeat; font-size: xx-small;">
        </td>
    </tr>
    <tr>
        <td style="width: 10px; height: 10px; background-image: url('/images/box/box3_mid_left.gif');">
        </td>
        <td style="background-color: #cef1ff;">
            <table>
                <tr>
                    <td align="left">
                        <iframe name="frmImportFile" src="../Pages/ImportProses.aspx" width="350px" height="200px"
                            frameborder="0" scrolling="no" id="frmImportFile"></iframe>
                    </td>
                    <td style="width: 5px" align="left">
                    </td>
                    <td align="left" class="font-normal2">
                        <b>PETUNJUK</b>
                        <br />
                        Format file yang diupload untuk data anggota harus dalam file Excel (.XLS) pada
                        Sheet 1. Adapun kolom-kolom yang harus ada pada file ini sama seperti pada file
                        contoh di bawah ini:<br />
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td>
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Export-XLS-16x16.png" />
                                    &nbsp;<dx:ASPxHyperLink ID="LnkFileSKAR" runat="server" Text="File Daftar SKAR" NavigateUrl="~/Help/SKAR.xls" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Export-XLS-16x16.png" />
                                    &nbsp;<dx:ASPxHyperLink ID="LnkFileUNAR" runat="server" Text="File Hasil UNAR" NavigateUrl="~/Help/Hasil_UNAR.xls" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Export-XLS-16x16.png" />
                                    &nbsp;<dx:ASPxHyperLink ID="LnkFileIAR" runat="server" Text="File Daftar IAR" NavigateUrl="~/Help/IAR.xls" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Export-XLS-16x16.png" />
                                    &nbsp;<dx:ASPxHyperLink ID="LnkFileIARKhusus" runat="server" Text="File Daftar IAR Khusus"
                                        NavigateUrl="~/Help/IAR_KHUSUS.xls" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/Export-XLS-16x16.png" />
                                    &nbsp;<dx:ASPxHyperLink ID="LnkFileIKRAP" runat="server" Text="File Daftar IKRAP"
                                        NavigateUrl="~/Help/IAR.xls" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/7ZIP-16x16.gif" />
                                    &nbsp;<dx:ASPxHyperLink ID="File7ZIP" runat="server" Text="File 7ZIP v9.2" NavigateUrl="~/Help/7ZIP-920.exe" />
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: left">
                        &nbsp;<asp:CheckBox ID="CbxSemuaData" runat="server" AutoPostBack="True" CssClass="font-normal2"
                            Text="Lihat Semua Data" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <dx:ASPxGridView ID="GvFileList" ClientInstanceName="GvFileList" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                    KeyFieldName="FileName" CssPostfix="Office2003Blue" SettingsPager-PageSize="20"
                                    Width="960px" OnHtmlRowPrepared="GvFileList_HtmlRowPrepared" Font-Size="Small"
                                    Font-Names="Calibri" AutoGenerateColumns="False">
                                    <Columns>
                                        <dx:GridViewDataColumn Caption="Tindakan" Width="75px">
                                            <DataItemTemplate>
                                                <asp:ImageButton ID="btnDelete" runat="server" AlternateText="Hapus" OnClick="btnDelete_Click"
                                                    ImageUrl="~/images/Delete-16x16.gif" ToolTip="Hapus File" />&nbsp;
                                                <asp:ImageButton ID="btnFile" runat="server" AlternateText="Unduh File" OnClick="btnFile_Click"
                                                    ImageUrl="~/images/Save-16x16.png" ToolTip="Unduh File" />&nbsp;
                                                <asp:Literal runat="server" ID="ltrlFileName" Text='<%# Eval("FileName") %>' Visible="false" />
                                                <asp:Literal runat="server" ID="ltrlTypeFile" Text='<%# Eval("TypeFile") %>' Visible="false" />
                                                <ajaxToolKit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server" TargetControlID="btnDelete"
                                                    OnClientCancel="cancelClick" DisplayModalPopupID="ModalPopupExtender1" />
                                                <ajaxToolKit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="btnDelete"
                                                    PopupControlID="PNL" OkControlID="ButtonOk" CancelControlID="ButtonCancel" BackgroundCssClass="modalBackground" />
                                                <asp:Panel ID="PNL" runat="server" Style="display: none; width: 200px; background-color: White;
                                                    border-width: 2px; border-color: Black; border-style: solid; padding: 20px;"
                                                    HorizontalAlign="Left">
                                                    PERHATIAN!<br></br>
                                                    Jika Anda menghapus file ini maka semua data yang sedang diproses dari file ini
                                                    akan ikut terhapus.<br></br>
                                                    Anda yakin ingin menghapus permanen file ini?
                                                    <br />
                                                    <br />
                                                    <div style="text-align: right;">
                                                        <asp:Button ID="ButtonOk" runat="server" Text="  Ya  " />
                                                        <asp:Button ID="ButtonCancel" runat="server" Text="Tidak" />
                                                    </div>
                                                </asp:Panel>
                                                <asp:Label ID="LblStatusUpdate" runat="server" Text="" />
                                            </DataItemTemplate>
                                        </dx:GridViewDataColumn>
                                        <dx:GridViewDataCheckColumn FieldName="Proses" Width="50px">
                                        </dx:GridViewDataCheckColumn>
                                        <dx:GridViewDataTextColumn FieldName="GroupID" Caption="Kelompok" Width="200px">
                                            <CellStyle HorizontalAlign="Left" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="FileName" Caption="Nama File" Width="200px">
                                            <CellStyle HorizontalAlign="Left" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn FieldName="TypeFile" Caption="Jenis File" Width="100px">
                                            <CellStyle HorizontalAlign="Right" />
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataDateColumn FieldName="FileSize" Caption="Ukuran File (KB)" Width="100px">
                                            <CellStyle HorizontalAlign="Right" />
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataDateColumn FieldName="Organisasi" Width="100px">
                                            <CellStyle HorizontalAlign="Center" />
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn FieldName="UserIDUpload" Caption="Nama Pengunggah" Width="150px">
                                            <PropertiesTextEdit DisplayFormatString="N0" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="DateUpload" Caption="Tanggal Unggah" Width="150px"
                                            UnboundType="DateTime">
                                            <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy hh:mm:ss" />
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="UserIDProses" Caption="Nama Pemproses" Width="150px">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="DateProses" Caption="Tanggal Proses" Width="150px"
                                            UnboundType="DateTime">
                                            <PropertiesTextEdit DisplayFormatString="dd-MMM-yyyy hh:mm:ss" />
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <SettingsText Title="Daftar File Impor" EmptyDataRow="Data tidak ditemukan" />
                                    <ClientSideEvents SelectionChanged="GvFileList_SelectionChanged" />
                                    <SettingsPager PageSize="20" ShowEmptyDataRows="True" />
                                    <Settings ShowTitlePanel="True" ShowHorizontalScrollBar="True" />
                                    <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                        <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif" />
                                        <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif" />
                                    </Images>
                                    <ImagesFilterControl>
                                        <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif" />
                                    </ImagesFilterControl>
                                    <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                        <LoadingPanel ImageSpacing="10px" />
                                        <Header ImageSpacing="5px" SortingImageSpacing="5px" />
                                        <AlternatingRow Enabled="true" />
                                    </Styles>
                                    <StylesEditors>
                                        <ProgressBar Height="25px" />
                                    </StylesEditors>
                                </dx:ASPxGridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
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
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
    Modal="True">
</dx:ASPxLoadingPanel>
