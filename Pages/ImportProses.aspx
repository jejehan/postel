<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ImportProses.aspx.vb" Inherits="Pages_ImportProses" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../layout.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin-top: 0; margin-left: 0; margin-right: 0; background-color: #cef1ff;">
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <table style="width: 300px;" border="0" cellpadding="0" cellspacing="0" align="left">
            <tr>
                <td colspan="3">
                    <asp:FileUpload ID="DocFileUpload" runat="server" Width="300px" ToolTip="Unggah File untuk diproses"
                        CssClass="TextBox-Flat-Blue" />
                    <!--- Error Message -->
                    <span id="UploadErrorDetail" style="color: Red" runat="Server" /><strong>&nbsp;&nbsp;<span
                        id="UploadStatus" style="color: Red" runat="Server" /> </strong>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="left" class="font-normal2">
                    Nama File:
                </td>
                <td>
                    &nbsp;
                </td>
                <td style="width: 70%" align="left">
                    <asp:Label ID="LblFileName" runat="server" CssClass="font-normal2" />
                </td>
            </tr>
            <tr>
                <td align="left" class="font-normal2">
                    Ukuran File:
                </td>
                <td>
                    &nbsp;
                </td>
                <td align="left">
                    <asp:Label ID="LblFileSize" runat="server" CssClass="font-normal2" />
                </td>
            </tr>
            <tr>
                <td align="left" class="font-normal2" valign="top">
                    Kelompok:
                </td>
                <td>
                    &nbsp;
                </td>
                <td align="left">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:CheckBox ID="CbxNewGroupID" runat="server" AutoPostBack="true" Text="Buat Kelompok Baru"
                                Checked="true" CssClass="font-xSmall" ToolTip="Jika Anda pilih System akan membuat Kelompok Baru secara otomatis dari Nama File." /><br />
                            <asp:TextBox ID="TbxGroupID" runat="server" CssClass="TextBox-Flat-Blue" Width="200px" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td align="left" valign="top">
                    <asp:Label ID="lblHasilUNAR" Text="Hasil UNAR:" runat="server" class="font-normal2"
                        Visible="false" />
                </td>
                <td>
                    &nbsp;
                </td>
                <td style="width: 70%">
                    <asp:CheckBox ID="cbxHasilUNAR" runat="server" CssClass="font-xSmall" Text="Hasil UNAR"
                        Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 5px; font-size: xx-small;">
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Image ID="imgProses" runat="server" Height="11px" 
                        ImageUrl="~/Images/ajax-loader.gif" Visible="False" Width="16px" />
                </td>
                <td align="center">
                    <asp:Button ID="BtnUpload" runat="server" Text="   Unggah   " />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
