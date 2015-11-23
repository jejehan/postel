<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm.ascx.vb" Inherits="UserControls_ucForm" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<script type='text/javascript'>
    function cancelClick() {
    }
    //    function OnOrdaChanged(CmbOrda) {
    //        cmbOrlok.PerformCallback(CmbOrda.GetValue().toString());
    //    }
</script>

<style type="text/css">
    .style6
    {
        width: 100%;
    }
</style>
<link href="../layout.css" rel="stylesheet" type="text/css" />
<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback">
    <ClientSideEvents CallbackComplete="function(s, e) { LoadingPanel.Hide(); }" />
</dx:ASPxCallback>
<table style="width: 990px;">
    <tr>
        <td>
            &nbsp;
        </td>
        <td style="width: 125px">
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td style="width: 40%" colspan="2">
        </td>
        <td>
            &nbsp;
        </td>
        <td style="width: 40%" colspan="2">
        </td>
    </tr>
    <tr>
        <td class="font-Title" colspan="9">
            DATA ANGGOTA
        </td>
    </tr>
    <tr>
        <td colspan="9">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="9">
            <table>
                <tr>
                    <td>
                        <dx:ASPxButton ID="BtnNew" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Baru" Width="130px" Wrap="False">
                            <Image Url="~/Images/Baru-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnSave" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Simpan" Width="130px" Wrap="False">
                            <Image Url="~/Images/Save-16x16.png">
                            </Image>
                            <ClientSideEvents Click="function(s, e) {
                                 Callback.PerformCallback();
                                 LoadingPanel.Show();
                             }" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnSaveProses" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Simpan &amp; Proses" Width="130px" Wrap="False">
                            <Image Url="~/Images/Save-16x16.png">
                            </Image>
                            <ClientSideEvents Click="function(s, e) {
                                 Callback.PerformCallback();
                                 LoadingPanel.Show();
                             }" />
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="BtnCancel" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Text="Kembali" Width="130px" Wrap="False">
                            <Image Url="~/Images/Undo-16x16.png">
                            </Image>
                        </dx:ASPxButton>
                    </td>
                    <td style="width: 90%; text-align: left;">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="9">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td valign="top" colspan="2" align="center">
            <asp:Image ID="ImgFoto" runat="server" BorderColor="#000099" BorderStyle="Solid"
                BorderWidth="2px" Height="150px" ImageUrl="~/file/04125315.jpg" Width="120px" />
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top" colspan="2">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" style="text-align: center" class="font-header">
                        Data Pemohon
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Nama Anggota :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TbxNamaAnggota" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px" BackColor="Yellow"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        Jenis Permohonan :
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="ddlJenisPermohonan" runat="server" Width="200px">
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbJenisPermohonan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" ClientInstanceName="CmbJenisPermohonan"
                            AutoPostBack="True" BackColor="Yellow">
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                            <ClientSideEvents BeginCallback="function(s, e)
                                    { loadingPanel.Show(); }" EndCallback="function(s, e)
                                    { loadingPanel.Hide(); }"></ClientSideEvents>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        &nbsp;
                    </td>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="font-tabel-right-small2">
                        &nbsp;
                    </td>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top" colspan="2">
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
                    <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                        <tr>
                            <td colspan="2" style="text-align: center" class="font-header">
                                <asp:Label ID="lblDataKartu" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                Nama Kartu :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxNamaDiKartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px" BackColor="Yellow"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                Alamat 1:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat1Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px" BackColor="Yellow"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                &nbsp;Alamat 2:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat2Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px" BackColor="Yellow"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="font-tabel-right-small2">
                                &nbsp;Alamat 3:
                            </td>
                            <td align="left">
                                <asp:TextBox ID="TbxAlamat3Kartu" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                    Height="17px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Label ID="LblNamaFoto" runat="server" CssClass="font-tabel-center"></asp:Label>
            &nbsp;
        </td>
        <td>
            <dx:ASPxButton ID="BtnSaveFoto" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                Width="30px" Wrap="False" ToolTip="Simpan">
                <Image Url="~/Images/Save-16x16.png">
                </Image>
                <ClientSideEvents Click="function(s, e) {
                                 Callback.PerformCallback();
                                 LoadingPanel.Show();
                             }" />
            </dx:ASPxButton>
        </td>
        <td>
            &nbsp;
        </td>
        <td align="right" class="font-tabel-right-small2">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td class="font-tabel-right-small2">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td colspan="2">
            <asp:FileUpload ID="FotoUpload" runat="server" Width="215px" />
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td align="right" class="font-tabel-right-small2">
            Data Diproses :
        </td>
        <td align="left">
            <asp:CheckBox ID="CbxProsesData" runat="server" />
        </td>
        <td>
            &nbsp;
        </td>
        <td class="font-tabel-right-small2">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="9">
        </td>
    </tr>
</table>
<table style="width: 99%;">
    <tr>
        <td valign="top">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header" style="text-align: center">
                        Data Pribadi
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor KTP :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrKTP" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px" BackColor="Yellow"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Jenis Kelamin :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlKelamin" runat="server" Width="200px">
                            <asp:ListItem Value="L">LAKI-LAKI</asp:ListItem>
                            <asp:ListItem Value="P">PEREMPUAN</asp:ListItem>
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbKelamin" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" SelectedIndex="0">
                            <Items>
                                <dx:ListEditItem Selected="True" Text="Laki-Laki" Value="L" />
                                <dx:ListEditItem Text="Perempuan" Value="P" />
                            </Items>
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tempat Lahir :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxTempatLahir" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal Lahir :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <dx:ASPxDateEdit ID="DateTglLahir" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Width="200px">
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Alamat :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxAlamat" runat="server" CssClass="TextBox-Flat-Blue" Height="40px"
                            TextMode="MultiLine" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Kota :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxKota" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Provinsi :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxProvinsi" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Kode Pos :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxKodePos" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Agama :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlAgama" runat="server">
                            <asp:ListItem Text="ISLAM" Value="ISLAM" />
                            <asp:ListItem Text="KRISTEN" Value="KRISTEN" />
                            <asp:ListItem Text="KATOLIK" Value="KATOLIK" />
                            <asp:ListItem Text="HINDU" Value="HINDU" />
                            <asp:ListItem Text="BUDHA" Value="BUDHA" />
                            <asp:ListItem Text="KEPERCAYAAN" Value="KEPERCAYAAN" />
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbAgama" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" SelectedIndex="0">
                            <Items>
                                <dx:ListEditItem Selected="True" Text="Islam" Value="Islam" />
                                <dx:ListEditItem Text="Kristen" Value="Kristen" />
                                <dx:ListEditItem Text="Katolik" Value="Katolik" />
                                <dx:ListEditItem Text="Hindu" Value="Hindu" />
                                <dx:ListEditItem Text="Budha" Value="Budha" />
                                <dx:ListEditItem Text="Kepercayaan" Value="Kepercayaan" />
                            </Items>
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Golongan Darah :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlGolDarah" runat="server">
                            <asp:ListItem Text="O" Value="O" />
                            <asp:ListItem Text="A" Value="A" />
                            <asp:ListItem Text="B" Value="B" />
                            <asp:ListItem Text="AB" Value="AB" />
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbGolDarah" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="50px" SelectedIndex="0">
                            <Items>
                                <dx:ListEditItem Selected="True" Text="O" Value="O" />
                                <dx:ListEditItem Text="A" Value="A" />
                                <dx:ListEditItem Text="B" Value="B" />
                                <dx:ListEditItem Text="AB" Value="AB" />
                            </Items>
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Pekerjaan :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxPekerjaan" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Nomor Telepon :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrTelepon" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            ToolTip="Hanya Angka, Contoh: 021555555" Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        e-Mail Address :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxEmail" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top">
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header" style="text-align: center">
                        Data Organisasi
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblOrda" runat="server"></asp:Label>&nbsp;:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlOrda" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbOrda" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" BackColor="Yellow">
                            <ClientSideEvents SelectedIndexChanged="function(s, e) { OnOrdaChanged(s); }"></ClientSideEvents>
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;<asp:Label ID="LblNomorIAR" runat="server"></asp:Label>
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrIAR" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblMasaBerlakuIAR" runat="server"></asp:Label>
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td style="width: 160px">
                                    <asp:TextBox ID="TbxTglBerlakuIAR" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                        Height="17px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;CallSign :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <table cellpadding="0" cellspacing="2" class="style6">
                            <tr>
                                <td>
                                    <asp:DropDownList ID="ddlCS1" runat="server">
                                    </asp:DropDownList>
                                    <%--<dx:ASPxComboBox ID="CmbCS1" runat="server" Width="50px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        ValueType="System.String">
                                        <ButtonStyle Width="13px">
                                        </ButtonStyle>
                                        <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                                        </LoadingPanelImage>
                                    </dx:ASPxComboBox>--%>
                                </td>
                                <td>
                                    <asp:TextBox ID="TbxCS2" runat="server" CssClass="TextBox-Flat-Blue" ReadOnly="True"
                                        Width="30px" Height="17px" MaxLength="1"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="TbxCS3" runat="server" CssClass="TextBox-Flat-Blue" Width="50px"
                                        Height="17px" MaxLength="4"></asp:TextBox>
                                    <cc1:FilteredTextBoxExtender ID="TbxCS3_FilteredTextBoxExtender" runat="server" Enabled="True"
                                        FilterType="UppercaseLetters" TargetControlID="TbxCS3">
                                    </cc1:FilteredTextBoxExtender>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="BtnCheck" runat="server" Text="Check" Width="50px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Height="17px">
                                    </dx:ASPxButton>
                                </td>
                                <td style="width: 40%">
                                    <asp:Image ID="ImgSuccess" runat="server" ImageUrl="~/Images/smallsuccess-16x16.png"
                                        Visible="False" />
                                    <asp:Image ID="ImgWarning" runat="server" ImageUrl="~/Images/warning-16x16.gif" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblOrlok" runat="server" Text="ORARI Lokal :"></asp:Label>
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlOrlok" runat="server">
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbOrlok" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" ClientInstanceName="cmbOrlok" OnCallback="CmbOrlok_Callback">
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblNomorSKAR" runat="server" Text="Nomor SKAR :"></asp:Label>
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrSKAR" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px" ReadOnly="True"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblTglSKAR" runat="server" Text="Tanggal Terbit SKAR :"></asp:Label>
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <dx:ASPxDateEdit ID="DateTglTerbitSKAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Width="200px" ReadOnly="True">
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblTingkat" runat="server" Text="Tingkat :"></asp:Label>
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td style="width: 160px">
                                    <asp:DropDownList ID="ddlTingkat" runat="server" AutoPostBack="True">
                                        <asp:ListItem Text="PEMULA" Value="PEMULA" />
                                        <asp:ListItem Text="SIAGA" Value="SIAGA" />
                                        <asp:ListItem Text="PENGGALANG" Value="PENGGALANG" />
                                        <asp:ListItem Text="PENEGAK" Value="PENEGAK" />
                                    </asp:DropDownList>
                                    <%--<dx:ASPxComboBox ID="CmbTingkat" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        ValueType="System.String" Width="200px" AutoPostBack="True">
                                        <Items>
                                            <dx:ListEditItem Text="Pemula" Value="PEMULA" />
                                            <dx:ListEditItem Text="Siaga" Value="SIAGA" />
                                            <dx:ListEditItem Text="Penggalang" Value="PENGGALANG" />
                                            <dx:ListEditItem Text="Penegak" Value="PENEGAK" />
                                            <dx:ListEditItem Text="Asing" Value="ASING" />
                                            <dx:ListEditItem Text="Seumur Hidup" Value="SEUMUR HIDUP" />
                                        </Items>
                                        <ButtonStyle Width="13px">
                                        </ButtonStyle>
                                        <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                                        </LoadingPanelImage>
                                    </dx:ASPxComboBox>--%>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblNomorUNAR" runat="server" Text="Nomor UNAR :"></asp:Label>
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxNmrUNAR" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblLokasiUNAR" runat="server" Text="Lokasi UNAR :"></asp:Label>
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlUPT" runat="server" Width="200px">
                                </asp:DropDownList>
                                <%--<dx:ASPxComboBox ID="CmbUPT" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                    CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                    ValueType="System.String" Width="200px" AutoPostBack="True">
                                    <ButtonStyle Width="13px">
                                    </ButtonStyle>
                                    <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                                    </LoadingPanelImage>
                                </dx:ASPxComboBox>--%>
                                <asp:TextBox ID="tbxUPTLainnya" runat="server" CssClass="TextBox-Flat-Blue" Visible="False"
                                    Width="200px"></asp:TextBox>&nbsp;<asp:ImageButton ID="btnTambahUPT" runat="server"
                                        AlternateText="Simpan UPT" ImageAlign="Middle" ImageUrl="~/Images/Add-16x16.png"
                                        ToolTip="Simpan UPT" Visible="False" Style="width: 9px" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        <asp:Label ID="LblTanggalUNAR" runat="server" Text="Tanggal UNAR :"></asp:Label>
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td style="width: 160px">
                                    <dx:ASPxDateEdit ID="DateTglUNAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                        CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                        Width="200px">
                                        <ButtonStyle Width="13px">
                                        </ButtonStyle>
                                    </dx:ASPxDateEdit>
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;<asp:Label ID="LblHasilUNAR" runat="server" Text="Hasil UNAR :"></asp:Label>
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:DropDownList ID="ddlHasilUNAR" runat="server">
                            <asp:ListItem Text="LULUS" Value="LULUS" />
                            <asp:ListItem Text="TIDAK LULUS" Value="TIDAK LULUS" />
                        </asp:DropDownList>
                        <%--<dx:ASPxComboBox ID="CmbHasilUNAR" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            ValueType="System.String" Width="200px" AutoPostBack="True">
                            <Items>
                                <dx:ListEditItem Text=" --- Pilih Hasil UNAR ---" Value="0" />
                                <dx:ListEditItem Text="Lulus" Value="Lulus" />
                                <dx:ListEditItem Text="Tidak Lulus" Value="Tidak Lulus" />
                            </Items>
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                            <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                            </LoadingPanelImage>
                        </dx:ASPxComboBox>--%>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        &nbsp;
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        &nbsp;
                    </td>
                </tr>
            </table>
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
    <tr>
        <td valign="top">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td valign="top">
            <asp:Panel ID="PnlAsing" runat="server" Visible="false">
                <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                    <tr>
                        <td colspan="2" class="font-header" style="text-align: center">
                            Persyaratan Tambahan Asing
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Kewarganegaraan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:DropDownList ID="ddlKewarganegaraan" runat="server">
                            </asp:DropDownList>
                            <%--<dx:ASPxComboBox ID="cmbKewarganegaraan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                ValueType="System.String">
                                <ButtonStyle Width="13px">
                                </ButtonStyle>
                                <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                                </LoadingPanelImage>
                            </dx:ASPxComboBox>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Rekomendasi Dari Kedutaan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:CheckBox ID="CbxRekomendasi" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Surat Keterangan Izin Menetap:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:CheckBox ID="CbxSuratIjinMenetap" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Paspor:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:CheckBox ID="CbxPaspor" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PnlKehormatan" runat="server" Visible="false">
                <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                    <tr>
                        <td colspan="2" class="font-header" style="text-align: center">
                            Persyaratan Tambahan Anggota Kehormatan
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Surat Kep. Penetapan Anggota Kehormatan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:CheckBox ID="CbxKehormatan" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Tanggal SK Penetapan Anggota Kehormatan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <dx:ASPxDateEdit ID="DateSKKehormatan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
                                <ButtonStyle Width="13px">
                                </ButtonStyle>
                            </dx:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Nomor SK Penetapan Anggota Kehormatan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:TextBox ID="TbxSKKehormatan" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                Height="17px"></asp:TextBox>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PnlKhusus" runat="server" Visible="false">
                <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                    <tr>
                        <td colspan="2" class="font-header" style="text-align: center">
                            Persyaratan Tambahan Anggota Khusus
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Stasiun Kegiatan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:DropDownList ID="ddlStasiunKegiatan" runat="server" Width="200px">
                            </asp:DropDownList>
                            <%--<dx:ASPxComboBox ID="CmbStasiunKegiatan" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                ValueType="System.String" Width="200px">
                                <ButtonStyle Width="13px">
                                </ButtonStyle>
                                <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif">
                                </LoadingPanelImage>
                            </dx:ASPxComboBox>--%>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Jabatan Penanggung Jawab:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:TextBox ID="TbxJabatanPenanggungJawab" runat="server" CssClass="TextBox-Flat-Blue"
                                Width="200px" Height="17px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Mulai Berlaku:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <dx:ASPxDateEdit ID="DateTglMulaiKhusus" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                Width="200px">
                                <ButtonStyle Width="13px">
                                </ButtonStyle>
                            </dx:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Selesai Berlaku:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <dx:ASPxDateEdit ID="DateTglSelesaiKhusus" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                                CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                                Width="200px">
                                <ButtonStyle Width="13px">
                                </ButtonStyle>
                            </dx:ASPxDateEdit>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Nomor Ijin:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:TextBox ID="TbxNomorIjinKhusus" runat="server" CssClass="TextBox-Flat-Blue"
                                Width="200px" Height="17px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="font-tabel-right-small2">
                            Nama Panggilan:
                        </td>
                        <td class="font-tabel-left-xsmall2">
                            <asp:TextBox ID="TbxNamaPanggilan" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                                Height="17px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <table border="0" cellpadding="0" cellspacing="5" style="width: 100%" class="font-tabel-right-small2">
                <tr>
                    <td colspan="2" class="font-header" style="text-align: center">
                        Biaya-Biaya
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Validasi Bank:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <asp:TextBox ID="TbxValidasiBank" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        Tanggal Bayar:
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        <dx:ASPxDateEdit ID="DateTglBayar" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
                            CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"
                            Width="150px">
                            <ButtonStyle Width="13px">
                            </ButtonStyle>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
                <tr>
                    <td class="font-tabel-right-small2">
                        PNBP :
                    </td>
                    <td class="font-tabel-left-xsmall2">
                        Rp.
                        <asp:TextBox ID="TbxBiayaPNBP" runat="server" CssClass="TextBox-Flat-Blue" Width="200px"
                            Height="17px" BackColor="Yellow"></asp:TextBox>
                        <cc1:FilteredTextBoxExtender ID="TbxBiayaPNBP_FilteredTextBoxExtender" runat="server"
                            Enabled="True" FilterType="Numbers" TargetControlID="TbxBiayaPNBP">
                        </cc1:FilteredTextBoxExtender>
                        &nbsp;
                    </td>
                </tr>
            </table>
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
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
    Modal="True">
</dx:ASPxLoadingPanel>
<dx:ASPxCallback ID="ASPxCallback2" runat="server">
</dx:ASPxCallback>
