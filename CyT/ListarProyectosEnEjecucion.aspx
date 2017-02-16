<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarProyectosEnEjecucion.aspx.cs" Inherits="CyT.ListarProyectosEnEjecucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <div class="panel-heading">
                <h3>Proyectos en ejecucion</h3>
            </div>
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvProyecto" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both" EmptyDataText="No existen proyectos registrados" ShowHeaderWhenEmpty="true"
                        >
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="idProyecto" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Expediente" DataField="numeroExp" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Convocatoria" DataField="idConvocatoria" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="UVT" DataField="idUvt" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Area Productiva" DataField="idAreaProductiva" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Estado" DataField="idEstado" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Monto Solicitado" DataField="montoSolicitado" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Contraparte" DataField="montoContraparte" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Activo" DataField="activo" ItemStyle-HorizontalAlign="Center" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
