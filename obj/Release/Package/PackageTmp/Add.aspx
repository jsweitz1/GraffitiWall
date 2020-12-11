<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master1.Master" CodeBehind="Add.aspx.vb" Inherits="GraffitiWall.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contentContainer">
        <div class="addGraffitiWall">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="100"></asp:Timer>
                
                        <asp:Label ID="lblGraffitiAdd" runat="server" CssClass="addGaffitiText"></asp:Label>
                
                </ContentTemplate>

            </asp:UpdatePanel>
        </div>
        <div class="statusDiv">
            <asp:Label ID="lblStatus" runat="server" CssClass="statusLabel"></asp:Label>
        </div>
        <div class="addButtonsContainer">
            
            <asp:Button ID="btnAdd" runat="server" Text=" Add " CssClass="addSpecialButton" />

            

                <asp:TextBox ID="tbAdd" runat="server" CssClass="specialTextBox" placeholder="Type graffiti here!" TextMode="MultiLine" MaxLength="200"></asp:TextBox>

            
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="addSpecialButton" />

        </div>
    </div>

</asp:Content>
