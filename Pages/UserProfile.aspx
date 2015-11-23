<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="UserProfile.aspx.vb" Inherits="_Default" %>

<%@ Register Src="~/UserControls/ucUserProfile.ascx" TagPrefix="uc1" TagName="ucUserProfile" %>

<%--<%@ Register Src="~/usercontrols/ucUserProfile.ascx" TagName="UserProfile" TagPrefix="ucUserProfile" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" Runat="Server">
<br />
    <table style="width: 800px; height:388px; background-image: url('/Images/bg_menu.jpg');">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
              <%--  <ucUserProfile:UserProfile ID="UserProfilePage" runat="server" />--%>
                <uc1:ucUserProfile runat="server" ID="ucUserProfile" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

