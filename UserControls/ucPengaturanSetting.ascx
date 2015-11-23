<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPengaturanSetting.ascx.vb"
    Inherits="UserControls_ucPengaturanSetting" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
    Namespace="System.Web.UI.WebControls" TagPrefix="asp" %>
<%@ Register Assembly="DevExpress.Xpo.v15.1, Version=15.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<br />
<br />
<dx:ASPxGridView ID="gvSetting" runat="server" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css"
    CssPostfix="Office2003Blue" DataSourceID="dsSetting" AutoGenerateColumns="False"
    KeyFieldName="ID" Width="600px">
    <Styles CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue">
        <Header ImageSpacing="5px" SortingImageSpacing="5px">
        </Header>
        <LoadingPanel ImageSpacing="10px">
        </LoadingPanel>
    </Styles>
    <SettingsPager Visible="False">
    </SettingsPager>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/Office2003Blue/Editors/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Images SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css">
        <LoadingPanelOnStatusBar Url="~/App_Themes/Office2003Blue/GridView/gvLoadingOnStatusBar.gif">
        </LoadingPanelOnStatusBar>
        <LoadingPanel Url="~/App_Themes/Office2003Blue/GridView/Loading.gif">
        </LoadingPanel>
    </Images>
    <Columns>
        <dx:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True"/>
        <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="1">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Parameter" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Isi" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="TanggalUpdate" VisibleIndex="4">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="UserUpdate" VisibleIndex="5">
        </dx:GridViewDataTextColumn>
    </Columns>
    <StylesEditors>
        <ProgressBar Height="25px">
        </ProgressBar>
    </StylesEditors>
</dx:ASPxGridView>
<br />
<asp:AccessDataSource ID="dsSetting" runat="server" ConflictDetection="CompareAllValues"
    DataFile="~/App_Data/DataProses.mdb" DeleteCommand="DELETE FROM [Setting] WHERE [ID] = ? AND (([Parameter] = ?) OR ([Parameter] IS NULL AND ? IS NULL)) AND (([Isi] = ?) OR ([Isi] IS NULL AND ? IS NULL)) AND (([TanggalUpdate] = ?) OR ([TanggalUpdate] IS NULL AND ? IS NULL)) AND (([UserUpdate] = ?) OR ([UserUpdate] IS NULL AND ? IS NULL))"
    InsertCommand="INSERT INTO [Setting] ([ID], [Parameter], [Isi], [TanggalUpdate], [UserUpdate]) VALUES (?, ?, ?, ?, ?)"
    OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Setting]"
    UpdateCommand="UPDATE [Setting] SET [Isi] = ? WHERE [ID] = ? ">
    <UpdateParameters>
        <asp:Parameter Name="Isi" Type="String" />
    </UpdateParameters>
</asp:AccessDataSource>
