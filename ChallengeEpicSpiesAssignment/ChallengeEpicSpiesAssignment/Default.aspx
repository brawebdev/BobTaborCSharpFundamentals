<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

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
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <p class="auto-style1">
            <strong>Spy New Assignment Form</strong></p>
        <p>
            Spy Code Name:
            <asp:TextBox ID="CodeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Calendar ID="previousAssignmentCalendar" runat="server" Caption="End Date of Previous Assignment:" CaptionAlign="Left"></asp:Calendar>
        </p>
        <asp:Calendar ID="newAssignmentCalendar" runat="server" Caption="Start Date of New Assignment:" CaptionAlign="Left"></asp:Calendar>
        <br />
        <asp:Calendar ID="endOfNewAssignmentCalendar" runat="server" Caption="Project End Date of New Assignment:" CaptionAlign="Left"></asp:Calendar>
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
