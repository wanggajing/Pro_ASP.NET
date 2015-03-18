<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataBingCodeNugget.aspx.cs" Inherits="Chaptor12_CodeBuggets_DataBingCodeNugget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" SelectMethod="GetCities" ItemType="System.String">
            <ItemTemplate>
                <li><%#Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
