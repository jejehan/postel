﻿<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Pengaturan.aspx.vb" Inherits="_Default" Debug="true" ValidateRequest="false" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>





<%@ Register Src="~/UserControls/ucMenuUtama.ascx" TagName="MenuUtama" TagPrefix="ucMenuUtama" %>
<%@ Register Src="~/UserControls/ucPengaturan.ascx" TagName="Pengaturan" TagPrefix="ucPengaturan" %>
<%@ Register Src="~/UserControls/ucPengaturanEmail.ascx" TagName="PengaturanEmail" TagPrefix="ucPengaturanEmail" %>
<%@ Register Src="~/UserControls/ucPengaturanSetting.ascx" TagName="PengaturanSetting" TagPrefix="ucPengaturanSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentUtama" runat="Server">
    <ucMenuUtama:MenuUtama ID="MenuUtama" runat="server" />
    <table>
        <tr>
            <td valign="top">
                &nbsp;<br />
                &nbsp;<br />
                <dx:ASPxMenu ID="MenuPengaturan" runat="server" BorderBetweenItemAndSubMenu="HideRootOnly"
                    CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue"
                    ItemLinkMode="TextAndImage" ItemSpacing="1px" MaximumDisplayLevels="1" Orientation="Vertical"
                    SeparatorColor="Transparent" SeparatorHeight="14px" SeparatorWidth="2px" ShowPopOutImages="True"
                    SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                    <Items>
                        <dx:MenuItem NavigateUrl="~/Pages/Pengaturan.aspx?menu=User" 
                            Text="Daftar Pemakai" Name="User">
                            <Image Url="~/Images/Persons2-32x32.gif">
                            </Image>
                        </dx:MenuItem>
                        <dx:MenuItem NavigateUrl="~/Pages/Pengaturan.aspx?menu=eMail" 
                            Text="Pengaturan eMail" Name="eMail">
                            <Image Url="~/Images/Mail-32x32.gif">
                            </Image>
                        </dx:MenuItem>
                    </Items>
                    <ItemStyle HorizontalAlign="Left" />
                    <ItemSubMenuOffset FirstItemX="2" LastItemX="2" X="2" />
                    <SubMenuStyle GutterWidth="17px" />
                    <SeparatorPaddings PaddingBottom="1px" PaddingRight="0px" />
                    <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                    </LoadingPanelImage>
                </dx:ASPxMenu>
            </td>
            <td>
            </td>
            <td>
                <ucPengaturan:Pengaturan ID="Pengaturan" runat="server" />
                <ucPengaturanEmail:PengaturanEmail ID="PengaturanEmail" runat="server" />
                <ucPengaturanSetting:PengaturanSetting ID="PengaturanSetting" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
