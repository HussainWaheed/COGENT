<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="FYP.log" %>

<%--<!DOCTYPE html>--%>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>
<%--<head runat="server">--%>
    
  
    <%--<title></title>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<link rel="stylesheet" type="text/css" href="css/style.css"/>--%>
      <link href="Content/Logpage.css" rel="stylesheet" type="text/css" />
   
<%--            <br />
            <table class="auto-style18" " style="width:250px;margin-left:auto;margin-right:auto">
                <tr>
                    <td class="auto-style1">

                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">

            <div class="auto-style7">

                <h3 class="auto-style3" style="text-align: center"><strong><br /></strong>
            <br />
                    </h3>
            </div>
            <table class="auto-style5">
                <tr>
                    <td class="auto-style2"><strong>EMAIL ADDRESS:<br />
                        </strong> </td>
                    <td class="auto-style2">
               
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                    <asp:TextBox ID="TextBoxlogEmail" runat="server" ForeColor="Black" Width="250px" BorderColor="#CCCCCC" Height="30px"></asp:TextBox>
               
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22"><strong>PASSWORD:</strong><br />
                    </td>
                    <td class="auto-style12"> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"> <asp:TextBox ID="TextBoxLogPass" runat="server" ForeColor="Black" Width="250px" BorderColor="#CCCCCC" Height="30px"></asp:TextBox>
                    </td>
                    <td class="auto-style7"> &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">
    
                        &nbsp;</td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
    
                        &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
    
                        <span class="auto-style20"><strong>FORGOT YOUR PASSWORD</strong></span><span class="newStyle2">?<br />
                        <br />
                        </span><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Height="26px" Width="250px" ForeColor="White" CssClass="YourButtonStyle" BackColor="#00CC00" />
    
                    </td>
                    <td class="auto-style16"></td>
                </tr>
            </table>

                    </td>
                </tr>
            </table>
           
        <br />--%>
    <br/>
    <br/><br/>

    <div class="container">
  <div class="jumbotron">
          
    
      <table class="nav-justified">
          <tr>
              <td rowspan="4">
                  <p class="text-center">
                      <span style="font-size: medium">Experiment and surprise yourself
                      With Cogent Analytics</span></p>
                  <p class="text-center">
                      &nbsp;&nbsp;</p>
                  <p class="text-center">
                      <img alt="" src="Images/hero.png" style="height: 130px" /></p>
                  <p class="text-center" style="font-size: medium">
                      Please LOGIN To avail our serices</p>
              </td>
              <td id="log1">LOGIN:</td>
          </tr>
          <tr>
              <td> <asp:TextBox ID="TextBoxlogEmail" runat="server" ForeColor="Black" Width="251px" BorderColor="#CCCCCC" Height="40px" placeholder="Email"></asp:TextBox>&nbsp;</td>
          </tr>
          <tr>
              <td> <asp:TextBox ID="TextBoxLogPass" runat="server" ForeColor="Black" Width="251px" BorderColor="#CCCCCC" Height="40px" placeholder="Password"></asp:TextBox>&nbsp;</td>
          </tr>
          <tr>
              <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Height="40px" Width="251px" ForeColor="White" CssClass="YourButtonStyle" BackColor="#3366cc" />&nbsp;</td>
          </tr>
      </table>
          
    
  </div>
</div>













        </asp:content>