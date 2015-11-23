<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="FormIAR.aspx.vb" Inherits="_Form" %>
<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/UserControls/ucFormIAR.ascx" TagPrefix="ucMenuUtama" TagName="ucFormIAR" %>

<%--<%@ Register Src="~/usercontrols/ucFormIAR.ascx" TagName="Form1" TagPrefix="ucForm1" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
<%--    <ucForm1:Form1 ID="Form1" runat="server" />--%>
    <ucMenuUtama:ucFormIAR runat="server" ID="ucFormIAR" />
</asp:Content>
