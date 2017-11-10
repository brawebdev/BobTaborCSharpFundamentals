<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <span class="auto-style2">Simple Calculator</span></div>
        <p>
            First Value:
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:
            <asp:TextBox ID="secondTextBox" runat="server" CssClass="auto-style3" Width="129px"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;<asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="x" />
&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
