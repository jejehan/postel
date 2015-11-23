<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Import.aspx.vb" Inherits="Pages_Import" %>

<%@ Register Src="~/usercontrols/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/usercontrols/ucImportFile.ascx" TagName="ImportFile" TagPrefix="ucImportFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript"><!--
        function GvFileList_SelectionChanged(s, e) {
            btnUpload.SetEnabled(false);
        }
    --></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <ucImportFile:ImportFile ID="ImportFile" runat="server" />
</asp:Content>
