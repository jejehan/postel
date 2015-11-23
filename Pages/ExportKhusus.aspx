<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="false"
    CodeFile="ExportKhusus.aspx.vb" Inherits="_Default" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucExportDataKhusus.ascx" TagName="ExportDataKhusus" TagPrefix="ucExportDataKhusus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucExportDataKhusus:ExportDataKhusus ID="ExportDataKhusus" runat="server" />
</asp:Content>
