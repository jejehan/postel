<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucTinjauDataKhusus.ascx.vb"
    Inherits="UserControls_ucTinjauDataKhusus" %>
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

<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
</dx:ASPxCallback>
<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>--%>
<table style="width: 990px;" border="0" cellpadding="0" cellspacing="5">
    <tr>
        <td class="font-Title" align="center" valign="top">
            TINJAU DATA&nbsp;<asp:Label ID="lblJudul" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="text-align: center;">
            <table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 100%;"
                border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td style="text-align: center;">
                        <asp:CheckBox ID="cbxPilihSemua" runat="server" AutoPostBack="True" Text="Pilih Semua"
                            Width="100px" ToolTip="Pilih Semua Data" BorderStyle="Ridge" BorderWidth="1px"
                            Font-Names="Calibri" Font-Overline="False" Font-Size="Small" />
                    </td>
                    <td style="text-align: center;">
                        <dx:ASPxButton ID="BtnNew" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Data Baru" Wrap="False" Width="100px" ToolTip="Buat Data Baru Manual" HorizontalAlign="Center">
                            <Image Url="~/Images/Baru-16x16.png" />
                        </dx:ASPxButton>
                    </td>
                    <td style="text-align: center;">
                        <dx:ASPxButton ID="BtnProses" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Proses" Wrap="False" Width="100px" ToolTip="Proses Data untuk Mendapat Persetujuan"
                            AutoPostBack="False" HorizontalAlign="Center">
                            <Image Url="~/Images/proses-16x16.gif" />
                            <ClientSideEvents Click="function(s, e) {
                                                 Callback.PerformCallback();
                                                 LoadingPanel.Show();
                                             }" />
                        </dx:ASPxButton>
                    </td>
                    <td style="text-align: center;">
                        <dx:ASPxButton ID="BtnSave" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Ekspor" Wrap="False" Width="100px" ToolTip="Ekspor Data ke File Excel"
                            HorizontalAlign="Center">
                            <Image Url="~/Images/Export-XLS-16x16.png" />
                        </dx:ASPxButton>
                    </td>
                    <td style="text-align: center;">
                        <dx:ASPxButton ID="BtnHapusData" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Hapus" Width="100px" Wrap="False" ToolTip="Hapus Data" HorizontalAlign="Center">
                            <Image Url="~/Images/Delete-16x16.gif" />
                        </dx:ASPxButton>
                        <ajaxToolKit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server" TargetControlID="BtnHapusData"
                            OnClientCancel="cancelClick" DisplayModalPopupID="ModalPopupExtender1" />
                        <ajaxToolKit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="BtnHapusData"
                            PopupControlID="PNL" OkControlID="ButtonOk" CancelControlID="ButtonCancel" BackgroundCssClass="modalBackground" />
                        <asp:Panel ID="PNL" runat="server" Style="display: none; width: 200px; background-color: White;
                            border-width: 2px; border-color: Black; border-style: solid; padding: 20px;">
                            Anda yakin ingin menghapus data yang dipilih secara permanen?
                            <br />
                            <br />
                            <div style="text-align: right;">
                                <asp:Button ID="ButtonOk" runat="server" Text="  Ya  " />
                                <asp:Button ID="ButtonCancel" runat="server" Text=" Tidak " />
                            </div>
                        </asp:Panel>
                    </td>
                    <td align="left">
                        <dx:ASPxButton ID="BtnRefresh" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Perbaharui" Width="100px" Wrap="False" ToolTip="Perbaharui Data" HorizontalAlign="Center">
                            <Image Url="~/Images/Refresh2-16x16.png" />
                        </dx:ASPxButton>
                    </td>
                    <td style="width: 60%">
                        <asp:HyperLink ID="lnkDataError" runat="server" CssClass="font-error" Visible="False">Data Error</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 100%;" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td valign="top">
                        <dx:ASPxGridView ID="GvListAnggota" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" Width="990px" KeyFieldName="ProsesID" ClientInstanceName="GvListAnggota"
                            OnCustomColumnDisplayText="GvListAnggota_CustomColumnDisplayText" OnHtmlRowPrepared="GvListAnggota_HtmlRowPrepared"
                            Font-Size="Small" Font-Names="Calibri" SettingsBehavior-AllowFocusedRow="True"
                            SettingsBehavior-AllowMultiSelection="True">
                            <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                                <Header ImageSpacing="5px" SortingImageSpacing="5px" />
                                <LoadingPanel ImageSpacing="10px" />
                            </Styles>
                            <SettingsPager ShowEmptyDataRows="True" PageSize="50" Position="Top">
                                <FirstPageButton Visible="True" />
                                <LastPageButton Visible="True" />
                            </SettingsPager>
                            <SettingsText EmptyDataRow="Data tidak ditemukan" Title="Tinjau Data" />
                            <ImagesFilterControl>
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif" />
                            </ImagesFilterControl>
                            <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif" />
                                <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif" />
                            </Images>
                            <Columns>
                                <dx:GridViewDataTextColumn UnboundType="String" ReadOnly="True" FixedStyle="Left"
                                    Width="25px" Caption="No." VisibleIndex="0">
                                    <Settings AllowDragDrop="False" AllowAutoFilterTextInputTimer="False" AllowAutoFilter="False"
                                        AllowHeaderFilter="False" AllowSort="False" AllowGroup="False" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" BackColor="#FFFFD6" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Pilih" Width="30px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                                    VisibleIndex="1">
                                    <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                                        AllowGroup="False" AllowHeaderFilter="False" AllowSort="False" />
                                    <CellStyle BackColor="#FFFFD6" />
                                    <DataItemTemplate>
                                        <asp:CheckBox ID="CxItem" runat="server" ToolTip="Pilih 1 Baris" />
                                    </DataItemTemplate>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataColumn Caption="Tindakan" Width="50px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                                    VisibleIndex="2">
                                    <DataItemTemplate>
                                        <asp:ImageButton ID="btnDelete" runat="server" AlternateText="Delete" OnClick="btnDelete_Click"
                                            ImageUrl="~/images/Delete-16x16.gif" />&nbsp;
                                        <asp:ImageButton ID="btnEdit" runat="server" AlternateText="Edit" OnClick="btnEdit_Click"
                                            ImageUrl="~/images/Edit-16x16.gif" />
                                        <asp:Literal runat="server" ID="ltrlProsesID" Text='<%# Eval("ProsesID") %>' Visible="false" />
                                        <asp:Label ID="LblStatusUpdate" runat="server" Text="" />
                                    </DataItemTemplate>
                                    <CellStyle BackColor="#FFFFD6" />
                                </dx:GridViewDataColumn>
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
                            <Settings ShowFilterRowMenu="True" ShowHorizontalScrollBar="True" ShowPreview="True"
                                ShowVerticalScrollBar="True" VerticalScrollableHeight="340" />
                            <StylesEditors>
                                <ProgressBar Height="25px" />
                            </StylesEditors>
                        </dx:ASPxGridView>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<%--    </ContentTemplate>
</asp:UpdatePanel>
--%><dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
    Modal="True" Text="Proses&hellip;" />
<dx:ASPxGridViewExporter ID="GvListAnggota_ExportAll" runat="server" GridViewID="GvListAnggota" />
