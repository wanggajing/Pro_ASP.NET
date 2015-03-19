<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Example2.aspx.cs" Inherits="Chaptor12_ProgrammableHTML_Example2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        I live in: <span id = "mySpan" runat = "server" > </span>
    </div>
    <div > Today is: <%: GetDayOfWeek() %> </div>
    </form>
</body>
</html>
