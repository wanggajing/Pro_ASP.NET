<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Params.aspx.cs" Inherits="Chaptor13_Params" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="hidden" name="accessLevel" value="normal" />
        <button type="submit">Submit</button>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
