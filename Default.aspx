<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" Height="63px" OnClick="Button1_Click" Text="Button" Width="344px" />
    <asp:TextBox ID="TextBox1" runat="server" Height="95px" OnTextChanged="TextBox1_TextChanged" Width="272px"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="273px"></asp:TextBox>
</asp:Content>
