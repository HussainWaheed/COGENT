<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FYP.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="Content/contact.css">
    <%: Title %>

    <div class="contactform">
        <table class="nav-justified" style="width:700px; margin-left:auto; margin-right:auto">
            <tr>
                <td class="text-center" colspan="2" style="height: 22px; background-color: #666666;">
                    <h3 style="color: #FFFFFF">CONTACT</h3>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #666666">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #C0C0C0">FULLNAME&nbsp;</span></td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxCont_Name" runat="server" BackColor="#CCCCCC" Height="30px" Width="230px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">EMAIL:<br />
                    Support_COGENT@gmail.com</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #CCCCCC">&nbsp;EMAIL&nbsp;</span></td>
                <td style="width: 204px; background-color: #FFFFFF">LOCATION:</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBoxContEmail" runat="server" BackColor="#CCCCCC" Height="30px" Width="230px"></asp:TextBox>
                </td>
                <td style="width: 204px; background-color: #FFFFFF">Comsats University, Park Road<br />
                    Islamabad.</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #CCCCCC">Message</span>&nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;&nbsp;Get Directions:</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxmessage" runat="server" BackColor="#CCCCCC" Height="97px" Width="231px"></asp:TextBox>
                </td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;" class="text-right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send Response" />
                </td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 314px; background-color: #FFFFFF;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td style="width: 204px; background-color: #FFFFFF">&nbsp;</td>
            </tr>
        </table>
   <div/>
    </div>
    </div>
</asp:Content>
