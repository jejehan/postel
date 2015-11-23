<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="CetakSKAR.aspx.vb" Inherits="_Default" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucCetakSKAR.ascx" TagName="CetakSKAR" TagPrefix="ucCetakSKAR" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucCetakSKAR:CetakSKAR ID="CetakSKAR" runat="server" />
</asp:Content>
