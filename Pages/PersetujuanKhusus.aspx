﻿<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="PersetujuanKhusus.aspx.vb" Inherits="_DefaultKhusus" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucPersetujuanKhusus.ascx" TagName="PersetujuanKhusus" TagPrefix="ucPersetujuanKhusus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucPersetujuanKhusus:PersetujuanKhusus ID="PersetujuanKhusus" runat="server" />
</asp:Content>