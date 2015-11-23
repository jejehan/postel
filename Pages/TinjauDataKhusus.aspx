<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="TinjauDataKhusus.aspx.vb" Inherits="_DefaultKhusus" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucTinjauDataKhusus.ascx" TagName="TinjauDataKhusus" TagPrefix="ucTinjauDataKhusus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucTinjauDataKhusus:TinjauDataKhusus ID="TinjauDataKhusus" runat="server" />
</asp:Content>
