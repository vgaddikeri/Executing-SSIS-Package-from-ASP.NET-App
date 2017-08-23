<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="APP_To_Run_SSISPackage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div class="row">        
        <div class="form-group col-md-4 col-md-offset-4">
            <h2 class="text-center">
                <asp:Label ID="lbSelect" runat="server" Text="Executing SSIS Package:"></asp:Label>
            </h2>           
            <p class="text-center">
                

                <asp:Button ID="btn_GenerateExcelFile" runat="server" Text="Go »" CssClass="btn btn-default" />
                

            </p>
           
            <p class="text-center">
                <asp:Label ID="lbResultSSISExecute" runat="server" ForeColor="#0730CA" Visible="False"></asp:Label>                
            </p>       
           
        </div>        
    </div>  


</asp:Content>
