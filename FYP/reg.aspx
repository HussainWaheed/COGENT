<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="FYP.reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <%--<head runat="server">--%>
    <%--<title></title>--%>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 334px;
        }
       
        .auto-style3 {
            text-align: right;
        }
        .auto-style5 {
            width: 334px;
            text-align: left;
        }
        .auto-style6 {
            text-align: justify;
        }
        body{
           background-color:#f5f5f5;
       }
        .auto-style8 {
            font-weight: normal;
            font-size: x-large;
            text-align: center;
        }
        .auto-style9 {
            font-size: small;
        }
        .auto-style10 {
            text-align: right;
            font-size: small;
        }
        .auto-style11 {
            color: #3366FF;
        }
        .auto-style13 {
            text-align: left;
        }
    </style>
<%--</head>
    
<body>--%>




 <%--   <form id="form1" runat="server">--%>
    <div class="auto-style3">
    
        <br />
        <br />
        
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <h1 class="auto-style8">Create your Account</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>&nbsp;<span class="auto-style9">*First Name:</span><br />
                    </strong>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxName" runat="server" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Please write your first name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong><span class="auto-style9">*Last Name:</span><br />
                    </strong>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxLast_N" runat="server" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxLast_N" ErrorMessage="Please Write your last name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style9">*E mail:</span><br />
                    </strong>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxEmail" runat="server" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Please write your Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="You must enter a valid E mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10"><strong><span class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Password:</span><br class="auto-style9" />
                    </strong>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Please write  your Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10"><strong>*Confirm Password:</strong></td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxconfirmpass" runat="server" TextMode="Password" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxconfirmpass" ErrorMessage="Please confirm your E mail" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxconfirmpass" ErrorMessage="Both passwords must match " ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"><strong><span class="auto-style9">*Application Name</span><br class="auto-style9" />
                    </strong>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxApp_Name" runat="server" BorderColor="#CCCCCC" BorderWidth="2px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxApp_Name" ErrorMessage="Specify your Applicaion name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style5">
                    <input id="Checkbox1" type="checkbox" /> I accept all<a href="http://Terms.aspx"> <span class="auto-style11">terms and conditions</span></a></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style5">
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Signup" BackColor="#0099FF" ForeColor="White" Width="97px" />
    
                </td>
                <td>
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        <br />
    
    </div>
  <%--  </form>
</body>
</html>--%>
</asp:Content>