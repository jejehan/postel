<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="DataProsesKhusus.aspx.vb" Inherits="_DataProsesKhusus" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucDataProsesKhusus.ascx" TagName="DataProsesKhusus" TagPrefix="ucDataProsesKhusus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucDataProsesKhusus:DataProsesKhusus ID="DataProsesKhusus" runat="server" />
</asp:Content>
