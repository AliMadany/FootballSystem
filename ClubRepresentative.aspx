<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubRepresentative.aspx.cs" Inherits="M3gogo.ClubRepresentative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h1>Club Representative Page</h1>
    <br />
    <form id="form1" runat="server">
        <dive id="signup" runat="server">
            <br />
            Name
            <br />
            <asp:TextBox runat="server" id="name"></asp:TextBox>
                        <br />
            Club Name
            <br />
            <asp:TextBox runat="server" id="clubName"></asp:TextBox>
                        <br />
            Username
            <br />
            <asp:TextBox runat="server" id="username"></asp:TextBox>
                        <br />
            Password
            <br />
            <asp:TextBox runat="server" id="password"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="submit" OnClick="signUp" Text="Register!" />
        </dive>
        <div id="login" runat="server">
            <asp:Label>Name login</asp:Label>
            <asp:TextBox runat="server" id="TextBox1"></asp:TextBox>
            <asp:Button runat="server" ID="Button1" OnClick="signUp" />
        </div>
      
    </form>
    <asp:DataGrid id="itemsGrid" runat="server"></asp:DataGrid>


</body>
</html>

