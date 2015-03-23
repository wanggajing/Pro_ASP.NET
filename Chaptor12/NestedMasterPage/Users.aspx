<%@ Page Title="" Language="C#" MasterPageFile="~/Chaptor12/NestedMasterPage/Admin.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Chaptor12_NestedMasterPage_Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="pageHead" Runat="Server">
    <style type = "text/css">
        span {
            display: block;
            border: thin double black;
            padding: 10px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageContent" Runat="Server">
    <span > This is the Users.aspx page content</span>
</asp:Content>

