<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPengaturan.ascx.vb"
    Inherits="UserControls_ucPengaturan" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>




<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<link href="../default.css" rel="stylesheet" type="text/css" />

<script type="text/javascript"><!--
    function OnGridFocusedRowChanged() {
        GvUserList.GetRowValues(GvUserList.GetFocusedRowIndex(), 'UserID;Nama;eMail;KataSandi;Aktif;Admin;ORARI;RAPI;UserIDCreate;DateCreate;UserIDUpdate;DateUpdate', OnGetRowValues);
    }
    function OnGetRowValues(values) {
        TbxUserID.SetText(values[0]);
        TbxNama.SetText(values[1]);
        TbxEmail.SetText(values[2]);
        TbxPassword.SetText(values[3]);
        CbxAktif.SetChecked(values[4]);
        CbxAdmin.SetChecked(values[5]);
        CbxOrari.SetChecked(values[6]);
        CbxRapi.SetChecked(values[7]);
    }
    --></script>

<br />
<table style="width: 800px;">
    <tr>
        <td colspan="9" class="font-Title">
            Pengaturan Pengguna Aplikasi &nbsp;<br />
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxButton ID="BtnUserBaru" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="User Baru" Wrap="False">
                <Image Url="~/Images/Baru-16x16.png">
                </Image>
            </dx:ASPxButton>
        </td>
        <td align="right" valign="middle">
            <dx:ASPxButton ID="BtnSave" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                ToolTip="Save Perubahan Data" Text="Simpan" Wrap="False">
                <Image Url="~/Images/Save-16x16.png">
                </Image>
            </dx:ASPxButton>
        </td>
        <td>
            <dx:ASPxButton ID="BtnExportExcel" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Text="Ekspor Excel" Wrap="False">
                <Image Url="~/Images/Export-XLS-16x16.png">
                </Image>
            </dx:ASPxButton>
        </td>
        <td style="width: 90%">
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
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="9">
            &nbsp;
        </td>
    </tr>
</table>
<table style="width: 600px;">
    <tr>
        <td class="font-tabel-center-small" style="width: 75px">
            Nama Pengenal
        </td>
        <td class="font-tabel-center-small" style="width: 150px">
            Nama Lengkap
        </td>
        <td class="font-tabel-center-small" style="width: 150px">
            Alamat e-Mail
        </td>
        <td class="font-tabel-center-small" style="width: 75px">
            Kata Kunci</td>
        <td class="font-tabel-center-small" style="width: 75px">
            Aktif
        </td>
        <td class="font-tabel-center-small" style="width: 75px">
            Admin
        </td>
        <td class="font-tabel-center-small" style="width: 75px">
            ORARI
        </td>
        <td class="font-tabel-center-small" style="width: 75px">
            RAPI
        </td>
    </tr>
    <tr>
        <td valign="middle">
            <dx:ASPxTextBox ID="TbxUserID" runat="server" Width="75px" ClientInstanceName="TbxUserID"
                ReadOnly="True">
            </dx:ASPxTextBox>
        </td>
        <td valign="middle">
            <dx:ASPxTextBox ID="TbxNama" runat="server" Width="150px" ClientInstanceName="TbxNama">
            </dx:ASPxTextBox>
        </td>
        <td valign="middle">
            <dx:ASPxTextBox ID="TbxEmail" runat="server" Width="150px" ClientInstanceName="TbxEmail">
            </dx:ASPxTextBox>
        </td>
        <td valign="middle">
            <dx:ASPxTextBox ID="TbxPassword" runat="server" Width="75px" ClientInstanceName="TbxPassword"
                Password="True">
            </dx:ASPxTextBox>
        </td>
        <td valign="middle">
            <dx:ASPxCheckBox ID="CbxAktif" runat="server" ClientInstanceName="CbxAktif" ValueChecked="1"
                ValueUnchecked="0" ValueType="System.String">
            </dx:ASPxCheckBox>
        </td>
        <td>
            <dx:ASPxCheckBox ID="CbxAdmin" runat="server" ClientInstanceName="CbxAdmin" ValueChecked="1"
                ValueType="System.String" ValueUnchecked="0">
            </dx:ASPxCheckBox>
        </td>
        <td>
            <dx:ASPxCheckBox ID="CbxOrari" runat="server" ClientInstanceName="CbxOrari" ValueChecked="1"
                ValueType="System.String" ValueUnchecked="0">
            </dx:ASPxCheckBox>
        </td>
        <td>
            <dx:ASPxCheckBox ID="CbxRapi" runat="server" ClientInstanceName="CbxRapi" ValueChecked="1"
                ValueType="System.String" ValueUnchecked="0">
            </dx:ASPxCheckBox>
        </td>
    </tr>
    <tr>
        <td colspan="8">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="8">
        </td>
    </tr>
    <tr>
        <td colspan="8">
            <dx:ASPxGridView ID="GvUserList" ClientInstanceName="GvUserList" runat="server" KeyFieldName="UserID"
                AutoGenerateColumns="False" EnableRowsCache="False" Width="820px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" 
                OnCustomColumnDisplayText="GvUserList_CustomColumnDisplayText" 
                Font-Size="Small" Font-Names="Calibri">
                <Columns>
                    <dx:GridViewDataTextColumn Caption="No." ReadOnly="True" UnboundType="String" VisibleIndex="0"
                        Width="20px">
                        <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" AllowDragDrop="False"
                            AllowGroup="False" AllowHeaderFilter="False" AllowSort="False" />
                        <HeaderStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Middle"></HeaderStyle>
                        <CellStyle HorizontalAlign="Center" Wrap="False" VerticalAlign="Middle">
                        </CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn FieldName="UserID" VisibleIndex="1" Caption="Nama Pengenal"
                        HeaderStyle-Wrap="True" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="Nama" Caption="Nama Lengkap" HeaderStyle-Wrap="True"
                        VisibleIndex="2" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="eMail" Caption="Alamat e-Mail" HeaderStyle-Wrap="True"
                        VisibleIndex="3" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataCheckColumn FieldName="Aktif" Caption="Aktif" VisibleIndex="4" Width="50px">
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataCheckColumn FieldName="Admin" Caption="Admin" VisibleIndex="5" Width="50px">
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataCheckColumn FieldName="ORARI" Caption="ORARI" VisibleIndex="7" Width="50px">
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataCheckColumn FieldName="RAPI" Caption="RAPI" VisibleIndex="8" Width="50px">
                        <Settings AllowAutoFilter="True" AllowAutoFilterTextInputTimer="False" AllowDragDrop="True"
                            AllowGroup="True" AllowHeaderFilter="True" AllowSort="True" />
                        <HeaderStyle HorizontalAlign="Left" />
                        <CellStyle HorizontalAlign="Left" Wrap="False" />
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewDataColumn FieldName="UserIDCreate" Caption="Nama Pembuat" VisibleIndex="9" 
                        HeaderStyle-Wrap="True" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="DateCreate" Caption="Tanggal Dibuat" VisibleIndex="10" 
                        HeaderStyle-Wrap="True" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="UserIDUpdate" Caption="Nama Pembaharuan" VisibleIndex="11" 
                        HeaderStyle-Wrap="True" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="DateUpdate" Caption="Tanggal Diperbaharui" VisibleIndex="12" 
                        HeaderStyle-Wrap="True" >
<HeaderStyle Wrap="True"></HeaderStyle>
                    </dx:GridViewDataColumn>
                </Columns>
                <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                    <LoadingPanel ImageSpacing="10px">
                    </LoadingPanel>
                </Styles>
                <SettingsPager Mode="ShowAllRecords">
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
                <ClientSideEvents FocusedRowChanged="function(s, e) { OnGridFocusedRowChanged(); }" />
                <StylesEditors>
                    <ProgressBar Height="25px">
                    </ProgressBar>
                </StylesEditors>
            </dx:ASPxGridView>
        </td>
    </tr>
    <tr>
        <td colspan="8">
            <dx:ASPxGridViewExporter ID="GvUserList_ExportAll" runat="server" GridViewID="GvUserList"
                Landscape="True">
            </dx:ASPxGridViewExporter>
        </td>
    </tr>
</table>
