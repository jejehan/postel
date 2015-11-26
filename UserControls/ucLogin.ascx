<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucLogin.ascx.vb" Inherits="usercontrols_ucLogin" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<div class="form-group has-feedback">
  <asp:TextBox ID="tbxUserID" runat="server" CssClass="form-control" ></asp:TextBox>
  <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
</div>

<div class="form-group has-feedback">
  <asp:TextBox ID="tbxPassword" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>
  <span class="glyphicon glyphicon-lock form-control-feedback"></span>
</div>

<div class="form-group has-feedback">
    <dx:ASPxComboBox ID="CmbOrganisasi" CssClass="form-control" runat="server" ValueType="System.String" >
        <Items>
            <dx:ListEditItem Selected="True" Text="Orari" Value="Orari" />
            <dx:ListEditItem Text="Rapi" Value="Rapi" />
        </Items>
        <LoadingPanelImage Url="~/App_Themes/Office2003Blue/Web/Loading.gif" />
        <ButtonStyle Width="13px" />
    </dx:ASPxComboBox>
  <span class="glyphicon glyphicon-lock form-control-feedback"></span>
</div>

<div class="row">
  <div class="col-xs-8">
  </div><!-- /.col -->
  
  <div class="col-xs-4">
    <dx:ASPxButton ID="BtnMasuk" CssClass="btn btn-primary btn-block btn-flat" runat="server" Text="Masuk" ></dx:ASPxButton>
  </div><!-- /.col -->
</div>
