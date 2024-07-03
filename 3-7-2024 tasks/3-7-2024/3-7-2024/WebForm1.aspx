<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_3_7_2024.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            </br>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div></br>
            <div>
                <asp:Label ID="Label3" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div> </br>
            <div>
            <asp:Label ID="Label4" runat="server" Text="Gender:"></asp:Label>
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>female</asp:ListItem>
                    <asp:ListItem>male</asp:ListItem>
                </asp:RadioButtonList>
                </div> </br>
            <div>
            <asp:Label ID="Label7" runat="server" Text="Skills"></asp:Label>
                <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="C" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="C++" />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="C#" />
                </div>
            <div>
            <asp:Label ID="Label8" runat="server" Text="description:"></asp:Label>
                <textarea id="TextArea1" cols="20" rows="2" runat="server"></textarea>
                </div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    <div>
   
    <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
        </div>
    <div>
   
<asp:Label ID="Label10" runat="server" Text=""></asp:Label>
        </div>
        <div>
   
<asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        </div>
            <div>
   
<asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label13" runat="server"></asp:Label>
                <asp:Label ID="Label14" runat="server"></asp:Label>
        </div>

        <asp:Label ID="Label15" runat="server"></asp:Label>
        <p>
            <asp:Label ID="Label16" runat="server"></asp:Label>
        </p>
    </form>
    
</body>
</html>
