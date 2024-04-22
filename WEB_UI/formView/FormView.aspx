<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FormView.aspx.cs" Inherits="WEB_UI.formView.FormView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="myHead" runat="server">
    <script src="formView.js"></script>
        <asp:Label ID="nombreFormulario" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
        <div id="idFormulario" runat="server"></div>
       
</asp:Content>
