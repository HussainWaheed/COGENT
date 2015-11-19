<%@ Page Language="C#" MasterPageFile="~/Afterlog.Master" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="FYP.success" %>

<%--<!DOCTYPE html>--%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <table class="auto-style6">
        <tr>
            <td class="auto-style7">
                <asp:Button ID="Appbutton" runat="server" Text="My Applications" Width="222px"
                    class="btn btn-primary active" CssClass="auto-style8" OnClick="Appbutton_Click" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="newapplications" runat="server" Text="New Applications" Width="157px" OnClick="newapplications_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" EnableViewState="False" Text="Label"></asp:Label>

            </td>
            <%if (Games != null)
                {

                    foreach (var item in Games)
                    {
                        Response.Write("<td>" + item.Name + "</td>");
                    }
                }%>
            <td class="auto-style5">
                <asp:TextBox ID="TxtNewGme" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>





</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }

        .auto-style7 {
            text-align: left;
        }

        .auto-style8 {
            margin-left: 0px;
        }
    </style>
</asp:Content>

