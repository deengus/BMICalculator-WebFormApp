<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="BmiWebApplication.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="txtName" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True" Width="243px"></asp:TextBox>
            <br />
            <br />
            Gender:
            <asp:TextBox ID="txtGender" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Age:
            <asp:TextBox ID="txtAge" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True" Width="401px"></asp:TextBox>
            <br />
            <br />
            BMI:
            <asp:TextBox ID="txtBMI" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            BMI Category:
            <asp:TextBox ID="txtBMICategory" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True" Width="636px"></asp:TextBox>
            <br />
            <br />
            Heart Rate:<asp:TextBox ID="txtHeartRate" runat="server" BorderStyle="None" Font-Bold="True" ReadOnly="True" Width="623px"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btnBMI" runat="server" OnClick="btnBMI_Click" Text="View BMI Chart" Width="157px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnHeartRate" runat="server" OnClick="btnHeartRate_Click" Text="View Target Heart Rates" Width="157px" />
        <br />
        <br />
        <asp:TextBox ID="txtCharts" runat="server" Height="269px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="388px"></asp:TextBox>
    </form>
</body>
</html>
