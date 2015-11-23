<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Form.aspx.vb" Inherits="_Form" %>
<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/UserControls/ucForm.ascx" TagPrefix="ucMenuUtama" TagName="ucForm" %>

<%--<%@ Register Src="~/usercontrols/ucForm.ascx" TagName="Form1" TagPrefix="ucForm1" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
  <%--  <ucForm1:Form1 ID="Form1" runat="server" />--%>
    <ucMenuUtama:ucForm runat="server" ID="ucForm" />
</asp:Content>
