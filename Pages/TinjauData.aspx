<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="TinjauData.aspx.vb" Inherits="_Default" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucTinjauData.ascx" TagName="TinjauData" TagPrefix="ucTinjauData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucTinjauData:TinjauData ID="TinjauData" runat="server" />
</asp:Content>
