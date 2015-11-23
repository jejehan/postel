<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucLaporan.ascx.vb" Inherits="UserControls_ucLaporan" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>





<%@ Register Assembly="DevExpress.Xpo.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<%@ Register Assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
    Namespace="System.Web.UI.WebControls" TagPrefix="asp" %>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<link href="../default.css" rel="stylesheet" type="text/css" />
<br />
<table style="border: 1px solid #0033CC; background-color: #99CCFF; width: 990px;"
    border="0" cellpadding="2" cellspacing="0">
    <tr>
        <td rowspan="2">
            &nbsp;</td>
        <td class="font-tabel-center-xsmall" 
            style="border-style: none none solid solid; border-width: 1px; border-color: #000080;">
            Kriteria<br />
        </td>
        <td class="font-tabel-center-xsmall" 
            style="border-style: none solid solid solid; border-width: 1px; border-color: #000080;">
            Tahun<br />
        </td>
        <td class="font-tabel-center-xsmall" colspan="3" 
            style="border-style: none solid solid none; border-width: 1px; border-color: #000080;">
            Bulan</td>
        <td class="font-normal2" rowspan="2">
            <dx:ASPxButton ID="BtnExcel" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                CssPostfix="Aqua" Height="32px" HorizontalAlign="Center"
                ImageSpacing="5px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Text="Excel"
                ToolTip="Export to Excel File" Wrap="False" OnClick="btnXlsExport_Click" UseSubmitBehavior="False"
                Width="75px">
                <Image AlternateText="Export to Excel File" 
                    Url="~/Images/Export-XLS-16x16.png" />
                <Paddings Padding="0px" />
            </dx:ASPxButton>
        </td>
        <td class="font-normal2" rowspan="2">
            <dx:ASPxButton ID="BtnPdfFile" runat="server" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                CssPostfix="Aqua" Height="32px" HorizontalAlign="Center"
                ImageSpacing="5px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Text="  PDF"
                ToolTip="Ekspor ke File PDF" Wrap="False" OnClick="btnPdfExport_Click" UseSubmitBehavior="False"
                Width="75px">
                <Image AlternateText="Ekspor ke File PDF" Url="~/Images/Export-PDF-16x16.png" />
                <Paddings Padding="0px" />
            </dx:ASPxButton>
        </td>
        <td class="font-normal2" rowspan="2">
            <dx:ASPxButton ID="BtnRefresh" runat="server" AutoPostBack="False" CssFilePath="~/App_Themes/Aqua/{0}/styles.css"
                CssPostfix="Aqua" Height="32px" HorizontalAlign="Center"
                ImageSpacing="5px" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" SpriteImageUrl="~/images/Spreadsheet-32x32.gif"
                Text="Perbaharui" ToolTip="Refresh Data" UseSubmitBehavior="False" Width="100px"
                Wrap="True">
                <Image AlternateText="Refresh Data" Url="~/Images/Refresh2-16x16.png" />
                <Paddings Padding="0px" />
            </dx:ASPxButton>
        </td>
        <td>
            &nbsp;
        </td>
        <td colspan="3" 
            style="border-style: none none none solid; border-width: 1px; border-color: #000080;" 
            align="center">
            <asp:Label ID="lblCariData" runat="server" CssClass="font-normal2" Text="Cari Data"
                Width="70px" Height="16px"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="border-style: none none none solid; border-width: 1px; border-color: #000080;">
            <asp:DropDownList ID="ddlKriteria" runat="server" CssClass="TextBox-Flat-Blue">
                <asp:ListItem Text="Semua" Value="Semua" Enabled="true" Selected="True" />
                <asp:ListItem Text="Aktif" Value="Aktif" Enabled="true" />
                <asp:ListItem Text="Tidak Aktif" Value="InAktif" Enabled="true" />
                <asp:ListItem Text="Habis 1 Bulan" Value="1" Enabled="true" />
                <asp:ListItem Text="Habis 2 Bulan" Value="2" Enabled="true" />
                <asp:ListItem Text="Habis 3 Bulan" Value="3" Enabled="true" />
            </asp:DropDownList>
        </td>
        <td style="border-style: none solid none solid; border-width: 1px; border-color: #000080;">
            <asp:DropDownList ID="ddlTahun" runat="server" CssClass="TextBox-Flat-Blue">
            </asp:DropDownList>
        </td>
        <td style="border-style: none none none none; border-width: 1px; border-color: #000080;">
            <asp:DropDownList ID="ddlMonthStart" runat="server" CssClass="TextBox-Flat-Blue">
            </asp:DropDownList>
        </td>
        <td class="font-normal2">
            s/d</td>
        <td style="border-style: none solid none none; border-width: 1px; border-color: #000080;">
            <asp:DropDownList ID="ddlMonthEnd" runat="server" CssClass="TextBox-Flat-Blue">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td style="border-style: none none none solid; border-width: 1px; border-color: #000080;">
            <asp:DropDownList ID="ddlCariData" runat="server" class="DropDownList-Flat-xSmall"
                CssClass="TextBox-Flat-Blue">
                <asp:ListItem Selected="True" Text="CallSign" />
                <asp:ListItem Text="Nomor SKAR" />
                <asp:ListItem Text="Nama" />
                <asp:ListItem Text="Alamat" />
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="tbxCariData" runat="server" CssClass="TextBox-Flat-Blue" />
        </td>
        <td>
            <asp:ImageButton ID="btnCariData" runat="server" ImageUrl="~/Images/icon_search_16px.gif"
                Height="18px" Width="18px" />
        </td>
    </tr>
</table>
<table style="width: 100%;" border="0">
    <tr>
        <td>
            <!--- Data SKAR --->
            <dx:ASPxGridView ID="GvDataSKAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" Width="990px" OnCustomColumnDisplayText="GvDataSKAR_CustomColumnDisplayText"
                KeyFieldName="NomorSKAR" ClientInstanceName="GvDataSKAR" Visible="False" Font-Names="Calibri"
                Font-Size="Small">
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <LoadingPanel ImageSpacing="10px" />
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                </Styles>
                <SettingsPager PageSize="20" ShowEmptyDataRows="True" />
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif" />
                </ImagesFilterControl>
                <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif" />
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif" />
                </Images>
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="Nama" SummaryType="Count" />
                </GroupSummary>
                <SettingsText Title="Data SKAR" />
                <Columns>
                    <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" Width="30px"
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn Caption="Cetak" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnCetakSKAR" runat="server" AlternateText="Cetak Ulang SKAR"
                                OnClick="btnCetakSKAR_Click" ImageUrl="~/images/Print-16x16.gif" />
                            <asp:Literal runat="server" ID="ltrlNomorSKAR" Text='<%# Eval("NomorSKAR") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn Caption="Lihat" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnLihatSKAR" runat="server" AlternateText="Lihat Data SKAR"
                                OnClick="btnLihatSKAR_Click" ImageUrl="~/images/Reports-16x16.png" />
                            <asp:Literal runat="server" ID="ltrlNomorID" Text='<%# Eval("ID") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="CallSign" Width="75px" FixedStyle="Left" Name="CallSign">
                        <CellStyle BackColor="#FFFFD6" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Nama" FixedStyle="Left" Width="200px">
                        <CellStyle BackColor="#FFFFD6" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Tingkat">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TempatTanggalLahir" Width="250px" />
                    <dx:GridViewDataTextColumn FieldName="Alamat" Width="250px" />
                    <dx:GridViewDataTextColumn FieldName="Tingkat">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="OrdaName">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="OrlokName">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Hasil">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorUNAR" Width="150px" />
                    <dx:GridViewDataTextColumn FieldName="TanggalUNAR" UnboundType="DateTime" Width="100px">
                        <Settings AllowHeaderFilter="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="LokasiUNAR">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorSKAR" Width="150px" />
                    <dx:GridViewDataTextColumn FieldName="TanggalSKAR" UnboundType="DateTime" Width="100px">
                        <Settings AllowHeaderFilter="True" />
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Keterangan" />
                    <dx:GridViewDataTextColumn FieldName="FileFoto" />
                    <dx:GridViewDataTextColumn FieldName="UserUpdate">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DateUpdate" Caption="Tanggal Diperbaharui"
                        Width="100px" UnboundType="DateTime" HeaderStyle-Wrap="True">
                        <PropertiesTextEdit DisplayFormatString="dd-MM-yyyy" />
                        <Settings AllowHeaderFilter="True" />
                        <HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="GroupID">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="ID" Visible="false" />
                </Columns>
                <Settings ShowGroupPanel="True" ShowFilterRow="False" ShowFilterRowMenu="True" ShowHorizontalScrollBar="True"
                    VerticalScrollableHeight="350" ShowVerticalScrollBar="True" ShowTitlePanel="True" />
                <StylesEditors>
                    <ProgressBar Height="25px" />
                </StylesEditors>
            </dx:ASPxGridView>
            <!--- Data IAR --->
            <dx:ASPxGridView ID="GvDataIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" Width="990px" OnCustomColumnDisplayText="GvDataIAR_CustomColumnDisplayText"
                KeyFieldName="ID" ClientInstanceName="GvDataIAR" Visible="False" Font-Names="Calibri"
                Font-Size="Small">
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <LoadingPanel ImageSpacing="10px" />
                    <Header ImageSpacing="5px" SortingImageSpacing="5px" Wrap="True">
                    </Header>
                </Styles>
                <SettingsPager PageSize="20" ShowEmptyDataRows="True" />
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif" />
                </ImagesFilterControl>
                <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif" />
                    <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif" />
                </Images>
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="Nama" SummaryType="Count" />
                </GroupSummary>
                <SettingsText Title="Data IAR" />
                <Columns>
                    <dx:GridViewDataTextColumn Caption="NO." ReadOnly="True" UnboundType="String" Width="30px"
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn Caption="Cetak" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnCetakIAR" runat="server" AlternateText="Cetak Ulang IAR"
                                OnClick="btnCetakIAR_Click" ImageUrl="~/images/Print-16x16.gif" />
                            <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn Caption="Lihat" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnLihatIAR" runat="server" AlternateText="Lihat Data IAR" OnClick="btnLihatIAR_Click"
                                ImageUrl="~/images/Reports-16x16.png" />
                            <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn Caption="CALLSIGN" FieldName="Callsign" Width="75px" FixedStyle="Left">
                        <CellStyle BackColor="#FFFFD6" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="NAMA" FieldName="Nama" FixedStyle="Left" Width="200px"
                        CellStyle-HorizontalAlign="Left">
                        <CellStyle BackColor="#FFFFD6" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="TEMPAT LAHIR" FieldName="TempatLahir">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn Caption="TANGGAL LAHIR" FieldName="TanggalLahir" />
                    <dx:GridViewDataTextColumn Caption="ORARI DAERAH" FieldName="OrdaName">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="ALAMAT" FieldName="Alamat" Width="250px" />
                    <dx:GridViewDataTextColumn Caption="KAB/KOTA" FieldName="Kota">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="NO. IAR/BARCODE" FieldName="NomorIAR" />
                    <dx:GridViewDataTextColumn Caption="TINGKAT" FieldName="Tingkat">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="DateUpdate">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="GroupID">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                </Columns>
                <Settings ShowGroupPanel="True" ShowFilterRow="False" ShowFilterRowMenu="True" ShowHorizontalScrollBar="True"
                    VerticalScrollableHeight="350" ShowVerticalScrollBar="True" ShowTitlePanel="True" />
                <StylesEditors>
                    <ProgressBar Height="25px" />
                </StylesEditors>
            </dx:ASPxGridView>
            <!---                    <dx:GridViewDataTextColumn FieldName="NomorKTP" Width="120px" 
                        VisibleIndex="10" />
                    <dx:GridViewDataTextColumn FieldName="JenisKelamin" Width="50px" Name="Kel." 
                        VisibleIndex="11">
                        <Settings AllowHeaderFilter="True" />
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="KodePos" VisibleIndex="12" />
                    <dx:GridViewDataTextColumn FieldName="Provinsi" VisibleIndex="14">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Agama" VisibleIndex="15">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Gol" VisibleIndex="16">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Pekerjaan" VisibleIndex="17" />
                    <dx:GridViewDataTextColumn FieldName="NomorTelepon" VisibleIndex="18" />
                    <dx:GridViewDataTextColumn FieldName="EMail" VisibleIndex="19" />
                    <dx:GridViewDataTextColumn Caption="Orari Lokal" FieldName="OrlokName">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Jenis Permohonan" FieldName="JenisPermohonan" HeaderStyle-Wrap="True">
                        <Settings AllowHeaderFilter="True" />
                        <HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorSKAR" />
                    <dx:GridViewDataDateColumn FieldName="TanggalTerbitSKAR" HeaderStyle-Wrap="True">
                        <Settings AllowHeaderFilter="True" />
                        <HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="MasaBerlakuIAR" HeaderStyle-Wrap="True">
                        <Settings AllowHeaderFilter="True" />
                        <HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FileFoto" />
                    <dx:GridViewDataCheckColumn FieldName="StatusData">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="UserUpdate">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
-->
            <!--- Laporan IAR
            <dx:ASPxGridView ID="GvLaporanIAR" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" Width="990px" OnCustomColumnDisplayText="GvLaporanIAR_CustomColumnDisplayText"
                KeyFieldName="ID" ClientInstanceName="GvLaporanIAR" Visible="False">
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <LoadingPanel ImageSpacing="10px">
                    </LoadingPanel>
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                </Styles>
                <SettingsPager PageSize="20" ShowEmptyDataRows="True">
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
                    <dx:GridViewDataTextColumn Caption="NO." ReadOnly="True" UnboundType="String" Width="30px"
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="CALLSIGN" FieldName="Callsign" VisibleIndex="1" />
                    <dx:GridViewDataTextColumn Caption="NAME" FieldName="Nama" VisibleIndex="2" />
                    <dx:GridViewDataTextColumn Caption="TEMPAT LAHIR" FieldName="TempatLahir" VisibleIndex="3" />
                    <dx:GridViewDataDateColumn Caption="TANGGAL LAHIR" FieldName="TanggalLahir" VisibleIndex="4" />
                    <dx:GridViewDataTextColumn Caption="ORARI DAERAH" FieldName="OrdaName" VisibleIndex="5"
                        Width="50px">
                        <Settings AllowHeaderFilter="True" />
                        <HeaderStyle Wrap="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="ALAMAT" FieldName="Alamat" VisibleIndex="6" Width="200px" />
                    <dx:GridViewDataTextColumn Caption="KAB/KOTA" FieldName="Kota" VisibleIndex="7" />
                    <dx:GridViewDataTextColumn Caption="NO. IAR/BARCODE" FieldName="NomorIAR" VisibleIndex="8" />
                    <dx:GridViewDataTextColumn Caption="TINGKAT" FieldName="Tingkat" VisibleIndex="9">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="DateUpdate" VisibleIndex="10">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                </Columns>
                <Settings ShowFilterRowMenu="true" ShowHorizontalScrollBar="True" VerticalScrollableHeight="500"
                    ShowVerticalScrollBar="True" />
                <StylesEditors>
                    <ProgressBar Height="25px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
            -->
            <!--- Data IKRAP --->
            <dx:ASPxGridView ID="GvDataIKRAP" runat="server" AutoGenerateColumns="False" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" Width="990px" OnCustomColumnDisplayText="GvDataIKRAP_CustomColumnDisplayText"
                KeyFieldName="ID" ClientInstanceName="GvDataIKRAP" Visible="False" Font-Names="Calibri"
                Font-Size="Small">
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <LoadingPanel ImageSpacing="10px">
                    </LoadingPanel>
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                </Styles>
                <SettingsPager PageSize="20" ShowEmptyDataRows="True">
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
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="Nama" SummaryType="Count" />
                </GroupSummary>
                <SettingsText Title="Data IKRAP" />
                <Columns>
                    <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" Width="30px"
                        FixedStyle="Left" CellStyle-BackColor="#ffffd6" VisibleIndex="0">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle" />
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn Caption="Cetak" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnCetakIKRAP" runat="server" AlternateText="Cetak Ulang IKRAP"
                                OnClick="btnCetakIKRAP_Click" ImageUrl="~/images/Print-16x16.gif" />
                            <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn Caption="Lihat" Width="40px" FixedStyle="Left" CellStyle-BackColor="#ffffd6"
                        ReadOnly="True">
                        <HeaderStyle HorizontalAlign="Center" />
                        <CellStyle HorizontalAlign="Center" />
                        <DataItemTemplate>
                            <asp:ImageButton ID="btnLihatIKRAP" runat="server" AlternateText="Lihat Data IKRAP"
                                OnClick="btnLihatIKRAP_Click" ImageUrl="~/images/Reports-16x16.png" />
                            <asp:Literal runat="server" ID="ltrlCallSign" Text='<%# Eval("CallSign") %>' Visible="false" />
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="Callsign">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Nama" Width="150px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorKTP">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="JenisKelamin">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TempatLahir">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="TanggalLahir">
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataTextColumn FieldName="Alamat" Width="200px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="KodePos">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Kota">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Provinsi">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Agama">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Gol">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Pekerjaan">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NomorTelepon">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="EMail">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Rapi Daerah" FieldName="RapiDaerahName">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Jenis Permohonan" FieldName="JenisPermohonan"
                        HeaderStyle-Wrap="True">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Nomor IKRAP" FieldName="NomorIKRAP">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Masa Berlaku IKRAP" FieldName="MasaBerlakuIKRAP">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="FileFoto">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="StatusData">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataTextColumn FieldName="UserUpdate">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataDateColumn FieldName="DateUpdate">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataDateColumn FieldName="GroupID">
                        <Settings AllowHeaderFilter="True" />
                    </dx:GridViewDataDateColumn>
                </Columns>
                <Settings ShowGroupPanel="True" ShowFilterRow="False" ShowFilterRowMenu="true" ShowHorizontalScrollBar="True"
                    VerticalScrollableHeight="500" ShowVerticalScrollBar="True" ShowTitlePanel="True" />
                <StylesEditors>
                    <ProgressBar Height="25px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
            <dx:ASPxGridViewExporter ID="GvExportDataSKAR" runat="server" Landscape="True" GridViewID="GvDataSKAR" />
            <dx:ASPxGridViewExporter ID="GvExportDataIAR" runat="server" Landscape="True" GridViewID="GvDataIAR" />
            <dx:ASPxGridViewExporter ID="GvExportLaporanIAR" runat="server" Landscape="True"
                GridViewID="GvLaporanIAR" />
            <dx:ASPxGridViewExporter ID="GvExportDataIKRAP" runat="server" Landscape="True" GridViewID="GvDataIKRAP" />
        </td>
    </tr>
</table>
