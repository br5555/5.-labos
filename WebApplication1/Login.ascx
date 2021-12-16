<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<asp:Panel ID="PanelLogin" runat="server" Height="305px">
    <h1>Welcome!<br /> Please enter username and password<br /></h1>
    <br />
    Username:&nbsp;&nbsp;
    <asp:TextBox ID="username" runat="server" BorderStyle="None" ForeColor="Black" BackColor="#CCFF99"></asp:TextBox>
    <br />
    <br />
    Password:&nbsp;&nbsp;
    <asp:TextBox ID="password" runat="server" BorderStyle="None" ForeColor="Black" Height="21px" BackColor="#CCFF99"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="Login" runat="server" Height="29px" Text="Login" OnClick="Login_Click" />
</asp:Panel>
<asp:Panel ID="PanelError" runat="server" style="margin-top: 58px" Visible="False">
    <i>Username or password not valid</i></asp:Panel>
<asp:Panel ID="PanelDisplay" runat="server" Height="154px" Width="981px" Visible="False">
    <asp:GridView ID="GridViewData" runat="server">
    </asp:GridView>
</asp:Panel>

