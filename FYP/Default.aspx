<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FYP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
    </asp:ScriptManagerProxy>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

                <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick1">
                </asp:Timer>

                <style>
		
		img.bg {
			/* Set rules to fill background */
			min-height: 100%;
			min-width: 1024px;
			
			/* Set up proportionate scaling */
			width: 100%;
			height: auto;
			
			/* Set up positioning */
			position: fixed;
			top: 0;
			left: 0;
		}
		
		@media screen and (max-width: 1024px){
			img.bg {
				left: 50%;
				margin-left: -512px; 
			}
            
               }
         /*    @media screen and (max-height: 1024px) {
                 img.bg {
                margin-top: 50px;
                 margin-bottom: -512px;
                 bottom:50%;
                 }
             }
		*/
	</style>


<asp:Image ID="Image1" runat="server" class="bg"/>
            <h1>ASP.NET </h1>

        </ContentTemplate>


    </asp:UpdatePanel>





    



</asp:Content>
