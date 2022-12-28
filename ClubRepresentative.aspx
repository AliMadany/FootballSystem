<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubRepresentative.aspx.cs" Inherits="M3gogo.ClubRepresentative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h1>Club Representative Page</h1>
    <br />
    <form id="form1" runat="server" enableviewstate="false">
        <div id="signup" runat="server">
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
        </div>
        <div id="login" runat="server">
            <asp:Label>Name login</asp:Label>
            <asp:TextBox runat="server" id="TextBox1"></asp:TextBox>
            <asp:Button runat="server" ID="Button1" OnClick="signUp" />
        </div>

      

    <h4>Club Info</h4>
    <asp:DataGrid id="itemsGrid" runat="server"></asp:DataGrid>
     <h4>Upcoming Matches</h4>
    <asp:DataGrid id="itemsGrid2" runat="server"></asp:DataGrid>

            <div id="stadiums" runat="server">
            <br />
            DateTime
            <br />
            <asp:TextBox runat="server" ID="textBox2" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="Button2" OnClick="getStadiums" Text="show stadiums" />
                    <asp:DataGrid EnableViewState="false" id="itemsGrid3" runat="server"></asp:DataGrid>
        </div>

            </form>
</body>
</html>

