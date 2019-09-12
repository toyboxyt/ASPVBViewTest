<%@ Page Title="ホーム ページ" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        &nbsp;</p>
    <p>
        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            <asp:ListItem Text="ax" Value="t"></asp:ListItem>
            <asp:ListItem Text="x2" Value="t2"></asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" />
    </p>
    <p>
        <br />

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="ax" Value="4">aaaa</asp:ListItem>
            <asp:ListItem Value="5">bb</asp:ListItem>
            <asp:ListItem Value="6">ccc</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"><%# Eval("btn1") %></asp:Label>
        </p>
        
        <p>
        <asp:Button ID="Button4" runat="server" Text="Button2" />
        </p>
    </p>
    <p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label">labelda1</asp:Label>
        </p>
        
        <p>
            <asp:Button ID="Button3" runat="server" Text="Button1" />
        </p>
    </p>
    <div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="F">
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource2" DataTextField="DataTextField" DataValueField="DataValueField" SelectedValue='<%# Eval("DropDownList") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getData" TypeName="DataClass"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="getDataField" TypeName="DataClass"></asp:ObjectDataSource>

        <br />
        <br />

    </div>
</asp:Content>
