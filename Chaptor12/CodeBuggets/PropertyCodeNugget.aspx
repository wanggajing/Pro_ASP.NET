<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PropertyCodeNugget.aspx.cs" Inherits="Chaptor12_CodeBuggets_PropertyCodeNugget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal Text = " < %$ AppSettings: cityMessage % > " runat = "server" />
    </div>
    </form>
</body>
</html>
