<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaProyecto.aspx.cs" Inherits="CyT.AltaProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>Formulario ALTA PROYECTO</h2>
            </div>
            <!--NOMBRE + EXPEDIENTE-->
            <br />
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control "></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblNumeroExp" runat="server" Text="EXPEDIENTE" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumeroExp" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--CONVOCATORIA-->
            <div class="form-group">
                <asp:Label ID="lblConvocatoria" runat="server" Text="CONVOCATORIA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10 ">
                    <asp:DropDownList ID="ddlConvocatoria" runat="server"
                        Width="800"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione una Convocatoria&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!--UVT-->
            <div class="form-group">
                <asp:Label ID="lblUvt" runat="server" Text="UVT" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10 ">
                    <asp:DropDownList ID="ddlUvt" runat="server"
                        Width="800"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione una Uvt&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!--ESTADO + MODAL ESTADO-->
            <div class="form-group">
                <asp:Label ID="lblEstado" runat="server" Text="ESTADO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlEstado" runat="server"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Estado&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblAreaProductiva" runat="server" Text="AREA PRODUCTIVA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlAreaProductiva" runat="server"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Area Productiva&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!--MONTO SOLICITADO + MONTO CONTRAPARTE -->
            <br />
            <div class="form-group">
                <asp:Label ID="lblMontoSolicitado" runat="server" Text="MONTO SOLICITADO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtMontoSolicitado" runat="server" CssClass="form-control "></asp:TextBox>
                </div>
                <asp:Label ID="lblMontoContraparte" runat="server" Text="MONTO CONTRAPARTE" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtMontoContraparte" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>



            <!--BOTON GUARDAR PROYECTO  -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <br />
                    <asp:Button ID="btnGuardarProyecto" runat="server" Text="Guardar Proyecto" CssClass="btn btn-success form-control" OnClick="btnGuardarProyecto_Click" />
                </div>
            </div>


        </asp:Panel>
    </div>
</asp:Content>
