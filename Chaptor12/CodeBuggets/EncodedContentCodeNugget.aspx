<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EncodedContentCodeNugget.aspx.cs" Inherits="Chaptor12_CodeBuggets_StandardCodeNugget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        I live in:<%:GetCity() %>
    </div>
    </form>
</body>
</html>
