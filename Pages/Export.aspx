<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="false"
    CodeFile="Export.aspx.vb" Inherits="_Default" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/UserControls/ucExportData.ascx" TagPrefix="ucMenuUtama" TagName="ucExportData" %>

<%--<%@ Register Src="~/usercontrols/ucExportData.ascx" TagName="ExportData" TagPrefix="ucExportData" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucMenuUtama:ucExportData runat="server" ID="ucExportData" />
<%--    <ucExportData:ExportData ID="ExportData" runat="server" />--%>
</asp:Content>
