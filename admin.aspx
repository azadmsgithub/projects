<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication5.adamin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 

    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="231px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="465px">
            <Columns>
                <asp:ButtonField Text="details" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="back to home" />
        <br />
        <asp:GridView ID="GridView2" runat="server" Height="177px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="466px">
        </asp:GridView>
    <p>
        admin</p>
    azad
</form>
    </body>
</html>
