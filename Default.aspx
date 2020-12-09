<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master1.Master" CodeBehind="Default.aspx.vb" Inherits="GraffitiWall._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contentContainer">
        <div class="graffitiWall">
            <asp:Label ID="lblGraffiti" runat="server" CssClass="graffitiText"></asp:Label>
        </div>
        <div class="buttonsContainer">
            <asp:Button ID="btnShowGraffiti" runat="server" Text="More" CssClass="specialButton" />
            <asp:Button ID="btnAddGraffiti" runat="server" Text="Add Graffiti" CssClass="specialButton" />
        </div>



    </div>
</asp:Content>
    