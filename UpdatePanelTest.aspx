<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdatePanelTest.aspx.vb" Inherits="WebApplication1.UpdatePanelTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />

            <asp:Button ID="Button2" runat="server" Text="Button" />
            <br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
        <br />
        <br />
    
    </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />

            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
        </ContentTemplate>
        </asp:UpdatePanel>
        <div>
    
        <br />
        <br />

    </div>


    </form>
</body>
</html>
