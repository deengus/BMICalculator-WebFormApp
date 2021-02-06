<%@ Page Language="C#" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BmiWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BMI CALCULATOR/TARGET HEART RATE<br />
            <br />
            First Name:
            <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFname" runat="server" ControlToValidate="txtFname" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Last Name:
            <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLname" runat="server" ControlToValidate="txtLname" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Gender (M or F):
            <asp:TextBox ID="txtGender" runat="server" MaxLength="1" Width="20px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="txtGender" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Date of Birth:<br />
            Month:
            <asp:TextBox ID="txtMonth" runat="server" MaxLength="2" Width="30px">MM</asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvMonth" runat="server" ControlToValidate="txtMonth" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red" InitialValue="MM"></asp:RequiredFieldValidator>
&nbsp;Day:
            <asp:TextBox ID="txtDay" runat="server" MaxLength="2" Width="30px">DD</asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvDay" runat="server" ControlToValidate="txtDay" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red" InitialValue="DD"></asp:RequiredFieldValidator>
&nbsp;Year:
            <asp:TextBox ID="txtYear" runat="server" MaxLength="4" Width="50px">YYYY</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvYear" runat="server" ControlToValidate="txtYear" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red" InitialValue="YYYY"></asp:RequiredFieldValidator>
            <br />
            <br />
            Height (inches): <asp:TextBox ID="txtHeight" runat="server" MaxLength="2" TextMode="Number" Width="40px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvHeight" runat="server" ControlToValidate="txtHeight" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Weight (pounds): <asp:TextBox ID="txtWeight" runat="server" MaxLength="3" TextMode="Number" Width="40px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvWeight" runat="server" ControlToValidate="txtWeight" Display="Dynamic" ErrorMessage="*This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Calculate" />
        </div>
    </form>
</body>
</html>
