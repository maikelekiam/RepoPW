<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarBeneficiarios.aspx.cs" Inherits="CyT.ListarBeneficiarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <div class="panel-heading">
                <h3>Listado de Beneficiarios</h3>
            </div>
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvPersona" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both"
                        OnRowCommand="dgvPersona_RowCommand"
                        >
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
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" Text="Mostrar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>

<%--                <div class="modal fade" id="modalBeneficiario" tabindex="-1" role="dialog" aria-labelledby="modalLabelBeneficiario" aria-hidden="true">
                    <div class="modal-dialog modal-md">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title" id="modalLabelBeneficiario">Datos del Beneficiario:</h4>
                            </div>
                            <div class="modal-body">
                                <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="col-md-4 control-label"> </asp:Label>
                                <asp:Label ID="lblNombreIngresado" runat="server" CssClass="col-md-4 control-label"> </asp:Label>
                                <br />

                            </div>
                            <div class="modal-footer">
                                <br />
                                <asp:Button runat="server" ID="btnModalBeneficiarioSalir" Text="Salir" class="btn btn-danger" data-dismiss="modal" />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
