<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alquileres.aspx.cs" Inherits="CyT.Alquileres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <asp:GridView ID="dgvAlquiler" runat="server" AutoGenerateColumns="true"
            CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
            GridLines="Both" EmptyDataText="No existen personas registradas" ShowHeaderWhenEmpty="true"
            >
        </asp:GridView>
    </div>



</asp:Content>
