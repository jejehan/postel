<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Src="~/usercontrols/ucMenuAwal.ascx" TagName="MenuAwal" TagPrefix="ucMenuAwal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" Runat="Server">
<br />
    <table style="width: 980px; height:388px; background-image: url('/Images/bg_menu.jpg');">
        <tr>
            <td>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <ucMenuAwal:MenuAwal ID="MenuAwalPage" runat="server" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
            </td>
        </tr>
    </table>
    
</asp:Content>

