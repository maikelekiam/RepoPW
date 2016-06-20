<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaActuacion.aspx.cs" Inherits="CyT.AltaActuacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>Formulario ALTA ACTUACION</h2>
            </div>
            <!--PERSONA QUE REALIZA LA ACTUACION-->
            <div class="form-group">
                <asp:Label ID="lblPersonaSeleccionada" runat="server" Text="PERSONA SELECCIONADA" CssClass="col-md-2 control-label"> </asp:Label>
                <asp:Label ID="lblPersonaSeleccionadaDeLaGrilla" runat="server" Text="Seleccione una persona de la grilla" CssClass="col-md-4 control-label table-bordered" BackColor="Azure" Font-Bold="false"> </asp:Label>
            </div>
            <!--FECHA DE LA ACTUACION-->
            <div class="form-group">
                <asp:Label ID="lblFechaActuacion" runat="server" Text="FECHA DE ACTUACION" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <div class="input-group date"
                        data-provide="datepicker"
                        data-date-format="dd/mm/yyyy"
                        data-date-autoclose="true"
                        data-date-today-btn="true"
                        data-date-clear-btn="true"
                        data-date-today-highlight="true">
                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaActuacion"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-th"></span>
                        </div>
                    </div>
                </div>
            </div>
            <!--VIA DE COMUNICACION + OPCION PARA AGREGAR NUEVA VIA DE COMUNICACION-->
            <div class="form-group">
                <asp:Label ID="lblViaComunicacion" runat="server" Text="VIA DE COMUNICACION" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlViaComunicacion" runat="server"
                        Width="280"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="false"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="false"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Via Comunicacion&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>


                <%--AGREGAR ACA EL MODAL PARA LA NUEVA VIA DE COMUNICACION--%>
                <div class="form-group">
                    <div class="col-md-4">
                        <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalViaComunicacion">Nueva Via de Comunicacion</button>
                    </div>
                    <!-- MODAL VIA DE COMUNICACION  -->
                    <div class="modal fade" id="modalViaComunicacion" tabindex="-1" role="dialog" aria-labelledby="modalLabelViaComunicacion" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <h4 class="modal-title" id="modalLabelViaComunicacion">Nueva Via de Comunicacion</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="col-md-4">
                                        <asp:TextBox ID="txtViaComunicacionModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>
                                    <br />
                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" ID="btnModalViaComunicacionSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                    <asp:Button runat="server" ID="btnModalViaComunicacionGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalViaComunicacionGuardar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!--TEMATICA + OPCION PARA AGREGAR NUEVA TEMATICA-->
            <div class="form-group">
                <asp:Label ID="lblTematica" runat="server" Text="TEMATICA" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlTematica" runat="server"
                        Width="280"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="false"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="false"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Tematica&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <%--AGREGAR ACA EL MODAL PARA LA NUEVA TEMATICA --%>
                <div class="form-group">
                    <div class="col-md-4">
                        <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalTematica">Nueva Tematica</button>
                    </div>
                    <!-- MODAL VIA DE COMUNICACION  -->
                    <div class="modal fade" id="modalTematica" tabindex="-1" role="dialog" aria-labelledby="modalLabelTematica" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <h4 class="modal-title" id="modalLabelTematica">Nueva Tematica</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="col-md-4">
                                        <asp:TextBox ID="txtTematicaModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>
                                    <br />
                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" ID="btnModalTematicaSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                    <asp:Button runat="server" ID="btnModalTematicaGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalTematicaGuardar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!--DETALLE DE LA ACTUACION-->
            <div class="form-group">
                <asp:Label ID="lblDetalle" runat="server" Text="DETALLE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="txtDetalle" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4"></asp:TextBox>
                </div>
            </div>
            <!--BOTONES GUARDAR + ACTUALIZAR ACTUACION -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <br />
                    <asp:Button ID="btnGuardarActuacion" runat="server" Text="Guardar Actuacion" CssClass="btn btn-primary form-control" OnClick="btnGuardarActuacion_Click" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnActualizarActuacion" runat="server" Text="Actualizar Actuacion" CssClass="btn btn-danger form-control" OnClick="btnActualizarActuacion_Click" />
                </div>
            </div>


            <!--GRILLA CON LAS ACTUACIONES DE LA PERSONA ELEGIDA-->
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvActuacion" runat="server" AutoGenerateColumns="false"
                        OnSelectedIndexChanging="dgvActuacion_SelectedIndexChanging"
                        OnRowDeleting="dgvActuacion_RowDeleting"
                        CssClass="table table-hover table-bordered" BorderWidth="3px">
                        <Columns>
                            <asp:BoundField HeaderText="IdActuacion" DataField="IdActuacion" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Fecha de la Actuacion" DataField="fecha"
                                DataFormatString="{0:d}" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50" HeaderStyle-Width="200" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Detalle" DataField="detalle"
                                ItemStyle-HorizontalAlign="Justify" ItemStyle-Width="400" HeaderStyle-Width="200" />
                            <asp:BoundField HeaderText="Via de Comunicacion" DataField="idViaComunicacion" />
                            <asp:BoundField HeaderText="Tematica" DataField="idTematica" />
                            <asp:BoundField HeaderText="Persona" DataField="idPersona" />
                            <asp:BoundField HeaderText="Activo" DataField="activo" />
                            <asp:ButtonField Text="Editar" CommandName="select" />
                            <asp:ButtonField Text="Borrar" CommandName="delete" />
                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>

            <!--GRILLA CON LAS PERSONAS DE LA BASE DE DATOS-->
            <h4>TABLA DE PERSONAS</h4>
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
