<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPengaturanEmail.ascx.vb"
    Inherits="UserControls_ucPengaturanEmail" %>
    <%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>







<%@ Register Assembly="DevExpress.Xpo.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<%@ Register Assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
    Namespace="System.Web.UI.WebControls" TagPrefix="dx" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx1" %>
    <link href="../default.css" rel="stylesheet" type="text/css" />
<link href="../layout.css" rel="stylesheet" type="text/css" />
&nbsp;<br />
&nbsp;<br />
<dx:aspxroundpanel id="PnlSendEmail" runat="server" width="990px" backcolor="White"
    headertext="Pengaturan Email" font-bold="True" horizontalalign="Center">
                            <TopEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpTopEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </TopEdge>
                            <LeftEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpLeftEdge.gif" Repeat="RepeatY"
                                    VerticalPosition="Top" />
                            </LeftEdge>
                            <ContentPaddings Padding="0px" PaddingTop="5px" />
                            <RightEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpRightEdge.gif" Repeat="RepeatY"
                                    VerticalPosition="Top" />
                            </RightEdge>
                            <HeaderRightEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderRightEdge>
                            <Border BorderColor="#AECAF0" BorderStyle="Solid" BorderWidth="1px" />
                            <HeaderLeftEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderLeftEdge>
                            <HeaderStyle BackColor="#E0EDFF">
                                <BorderBottom BorderColor="#AECAF0" BorderStyle="Solid" BorderWidth="1px" />
                            </HeaderStyle>
                            <BottomEdge>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpBottomEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Bottom" />
                            </BottomEdge>
                            <HeaderContent>
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpHeaderBackground.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </HeaderContent>
                            <NoHeaderTopEdge BackColor="White">
                                <BackgroundImage ImageUrl="~/App_Themes/Aqua/Web/rpNoHeaderTopEdge.gif" Repeat="RepeatX"
                                    VerticalPosition="Top" />
                            </NoHeaderTopEdge>
                            <PanelCollection>
                                <dx:PanelContent ID="PanelContent2" runat="server">
                                    <table border="0" cellpadding="0" cellspacing="2" width="100%">
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
                                            <td>
                                                &nbsp;&nbsp;
                                            </td>
                                            <td style="width: 90%; text-align: left;">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                    <table border="0" cellpadding="0" cellspacing="2" style="width: 100%;">
                                        <tr>
                                            <td class="font-normal" style="width: 200px;">
                                                Email Pengirim:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailFrom" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal">
                                                Email Kepada:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailTo" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal" align="left">
                                                Email Salinan:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailCc" runat="server" CssClass="TextBox-Flat-Blue" Width="300px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal">
                                                Judul Email:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailSubject" runat="server" CssClass="TextBox-Flat-Blue" Width="600px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="font-normal" valign="top">
                                                Isi Email:
                                            </td>
                                            <td>
                                            </td>
                                            <td align="left">
                                                <asp:TextBox ID="TbxEmailBody" runat="server" CssClass="TextBox-Flat-Blue" Height="120px"
                                                    MaxLength="500" TextMode="MultiLine" Width="600px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                                <table>
                                                    <tr>
                                                        <td style="width: 80%">
                                                        </td>
                                                        <td>
                                                            <dx:ASPxButton ID="BtnSave" runat="server" Text="Rekam Perubahan" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                                CssPostfix="Office2003Blue" 
                                                                SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css" Wrap="False">
                                                            </dx:ASPxButton>
                                                        </td>
                                                        <td>
                                                            <dx:ASPxButton ID="BtnCancel" runat="server" Text="Batal" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                                            </dx:ASPxButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:aspxroundpanel>
