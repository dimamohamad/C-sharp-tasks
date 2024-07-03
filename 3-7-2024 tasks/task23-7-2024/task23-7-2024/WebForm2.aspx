<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task23_7_2024.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Number 1  "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" BackColor="#0033CC" Height="50px" OnClick="Button1_Click" Text="+" Width="150px" />
        <asp:Button ID="Button2" runat="server" BackColor="#CC99FF" Height="50px" OnClick="Button2_Click" Text="-" Width="150px" />
        <asp:Button ID="Button3" runat="server" Text="*" Height="50px" OnClick="Button3_Click"  Width="150px" BackColor="Fuchsia" />
        <asp:Button ID="Button4" runat="server" BackColor="#FF33CC" BorderColor="#66CCFF" Height="50px" OnClick="Button4_Click" Text="/" Width="150px" />
        <p>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
