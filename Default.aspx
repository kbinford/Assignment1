<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Assignment1Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> Tip Calculator</h1>
        <p>
            <asp:Label ID="Label1" runat="server"  Text="Enter the amount"></asp:Label>&nbsp;

            <asp:TextBox ID="txtAmount" placeholder="Enter the amount" runat="server"></asp:TextBox>

        </p>
        <asp:RadioButtonList ID="rdbPercentage" runat="server">
            <asp:ListItem Text="10%" Value=".1"></asp:ListItem>
            <asp:ListItem Text="15%" Value=".15"></asp:ListItem>
            <asp:ListItem Text="20%" Value=".2"></asp:ListItem>
            <asp:ListItem Text="other" Value="0"></asp:ListItem>
        </asp:RadioButtonList>
        <p></p><asp:TextBox ID="txtOther" runat="server"></asp:TextBox></p>
        <asp:Button ID="btnCalculate" runat="server" Text="Submit" OnClick="btnCalculate_Click" />
        <p>
            <asp:Label ID="lblTip" runat="server" Text="" CssClass="result"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" Text="" CssClass="result"></asp:Label>


        </p>


    </div>
    </form>
</body>
</html>
