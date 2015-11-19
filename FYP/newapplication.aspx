<%@ Page Title="" Language="C#" MasterPageFile="~/Afterlog.Master" AutoEventWireup="true" CodeBehind="newapplication.aspx.cs" Inherits="FYP.newapplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">







    <p>
        We are glad to see you again
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Please Enter your Email:</td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Please Enter your password:</td>
                <td>
                    <asp:TextBox ID="TextBoxNewPass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Please Enter your New App Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxAppName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </p>







</asp:Content>
