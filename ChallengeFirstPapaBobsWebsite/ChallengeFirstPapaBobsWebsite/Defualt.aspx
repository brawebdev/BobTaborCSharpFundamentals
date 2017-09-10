<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
&nbsp;<strong><span class="auto-style1">Papa Bob&#39;s Pizza and Software</span></strong></div>
        <br />
        <asp:RadioButton ID="babyRadioButton" runat="server" Text="Baby Bob Size(10&quot;)- $10" />
        <br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" Text="Mama Bob Size(13&quot;)- $13" />
        <br />
        <asp:RadioButton ID="papaRadioButton" runat="server" Text="Papa Bob Size(16&quot;)- $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadioButton" runat="server" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadioButton" runat="server" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <br />
        Papa Bob&#39;s Special Deal<br />
        <br />
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        Total: $<asp:Label ID="totalLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only... we need a better website!</form>
</body>
</html>
