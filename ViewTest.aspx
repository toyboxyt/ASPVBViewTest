<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ViewTest.aspx.vb" Inherits="WebApplication1.ViewTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="1">
        <asp:View ID="View1" runat="server">
        view1<asp:Button ID="Button2" runat="server" Text="Button" />
        </asp:View>
        <asp:View ID="View2" runat="server">
        view2<asp:Button ID="Button1" runat="server" Text="Button" />
        </asp:View>
        </asp:MultiView>

    </div>
    </form>
</body>
</html>
