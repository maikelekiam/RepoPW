<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarBeneficiarios.aspx.cs" Inherits="CyT.ListarBeneficiarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h1>LISTA DE BENEFICIARIOS</h1>
            </div>
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvPersona" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both"
                        AutoGenerateSelectButton="true"
                        OnSelectedIndexChanged="dgvPersona_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="idPersona" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Apellido" DataField="apellido" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Tipo" DataField="tipoDocumento" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Documento" DataField="documento" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Localidad" DataField="idLocalidad" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Interesado" DataField="isInteresado" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Beneficiario" DataField="isBeneficiario" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Fecha Nac" DataField="fechaNacimiento" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Empresa" DataField="empresa" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Direccion" DataField="direccion" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Cuil" DataField="cuil" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Activo" DataField="activo" ItemStyle-HorizontalAlign="Center" />
                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
