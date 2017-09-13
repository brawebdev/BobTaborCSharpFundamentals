<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Value:
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        <br />
        Second Value:
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;<asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#66CCFF" Font-Bold="True" Font-Size="Larger"></asp:Label>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
