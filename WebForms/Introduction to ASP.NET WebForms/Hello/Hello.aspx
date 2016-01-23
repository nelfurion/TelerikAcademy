<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="Hello.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello</title>
</head>
<body>
    <ul ID="eventsList" runat="server" />
    <form id="form_hello" runat="server">
        <div>
            <asp:label ID="greetLabel" runat="server">Type your name in the box</asp:label>
            <asp:TextBox ID="nameTextBox" runat="server" />
            <asp:Button OnClick="Greet" runat="server" ID="sumButton" Text="Submit"/>
        </div>
    </form>
</body>
</html>
