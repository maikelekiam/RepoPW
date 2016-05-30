<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="CyT.AltaPersona" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>Formulario ALTA PERSONA</h2>
            </div>
            <!--NOMBRE + APELLIDO-->
            <br />
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!--TIPO DOCUMENTO + CUIL-->
            <div class="form-group">
                <asp:Label ID="lblTipoDocumento" runat="server" Text="TIPO DE DOCUMENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server" Height="30">
                        <asp:ListItem Value="DNI">DNI</asp:ListItem>
                        <asp:ListItem Value="DU">LE</asp:ListItem>
                        <asp:ListItem Value="LE">DU</asp:ListItem>
                        <asp:ListItem Value="LE">CI</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:Label ID="lblCuil" runat="server" Text="CUIL/CUIT" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCuil" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

            </div>
            <!--DOCUMENTO + FECHA NACIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblDocumento" runat="server" Text="DOCUMENTO" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDocumento" runat="server" class="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <div class="input-group date"
                        data-provide="datepicker"
                        data-date-format="dd/mm/yyyy"
                        data-date-autoclose="true"
                        data-date-today-btn="true"
                        data-date-clear-btn="true"
                        data-date-today-highlight="true">
                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaNacimiento"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar"></span>
                        </div>
                    </div>
                </div>
            </div>
            <!--DIRECCION + LOCALIDAD-->
            <div class="form-group">
                <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblLocalidad" runat="server" Text="LOCALIDAD" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlLocalidad" runat="server"
                        Width="280"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="true"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="True"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione una Localidad&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!--LISTA DE TELEFONOS-->
            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalTelefono">Agregar Telefonos</button>
                </div>
                <!-- MODAL LISTA DE TELEFONOS -->
                <div class="modal fade" data-backdrop="static" id="modalTelefono" tabindex="-1" role="dialog" aria-labelledby="modalLabelTelefono" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content col-md-pull-12">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title" id="modalLabelTelefono">Lista de Telefonos</h4>
                            </div>
                            <div class="modal-body">
                                <asp:GridView ID="dgvTelefonoModal" runat="server" AutoGenerateColumns="false"
                                    CellPadding="3" GridLines="Horizontal" Width="500"
                                    >
                                    <HeaderStyle BackColor="black" ForeColor="White" HorizontalAlign="Center" Height="25" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Telefono">
                                            <ItemTemplate>
                                                <%#DataBinder.Eval(Container, "DataItem")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtProductName" Text='<%#DataBinder.Eval(Container, "DataItem")%>' />
                                            </EditItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtProductName" />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <br />
                                <asp:Label ID="lblListaTelefonosModal" runat="server" Text="Nuevo Telefono" CssClass="col-md-4 control-label"> </asp:Label>
                                <div class="col-md-4">
                                    <asp:TextBox ID="txtTelefonoModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                </div>
                                <br />
                            </div>
                            <div class="modal-footer">
                                <asp:Button runat="server" ID="btnModalTelefonoSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                <asp:Button runat="server" ID="btnModalTelefonoGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalTelefonoGuardar_Click" />
                            </div>
                        </div>
                    </div>
                </div>

                <%-- GRIDVIEW PARA VER LA LISTA DE TELEFONOS EN EL FORMULARIO          --%>
                <div class="col-md-6">
                    <asp:GridView ID="dgvTelefonoFormulario" runat="server" AutoGenerateColumns="true"
                        CssClass="table table-hover table-bordered table-striped table-condensed" BorderWidth="3px" Width="480" OnRowDataBound="dgvTelefonoFormulario_RowDataBound">
                    </asp:GridView>
                </div>
            </div>

            <!--CORREO ELECTRONICOS-->
            <div class="form-group">
                <asp:Label ID="lblCorreoElectronico" runat="server" Text="CORREO ELECTRONICOS" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalCorreoElectronico">Agregar Correo</button>
                </div>
                <!-- MODAL LISTA DE CORREO ELECTRONICOS  -->
                <div class="modal fade" id="modalCorreoElectronico" tabindex="-1" role="dialog" aria-labelledby="modalLabelCorreo" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content col-md-pull-12">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title" id="modalLabelCorreo">Lista de Correo Electronicos</h4>
                            </div>
                            <div class="modal-body">
                                <asp:GridView ID="dgvCorreoModal" runat="server" AutoGenerateColumns="true"
                                    CssClass="table table-hover table-bordered" BorderWidth="3px">
                                </asp:GridView>
                                <asp:Label ID="lblListaCorreoModal" runat="server" Text="Nuevo Correo Electronico" CssClass="col-md-6 control-label"> </asp:Label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txtCorreoModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                </div>
                                <br />
                            </div>
                            <div class="modal-footer">
                                <asp:Button runat="server" ID="btnModalCorreoSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                <asp:Button runat="server" ID="btnModalCorreoGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalCorreoGuardar_Click" />
                            </div>
                        </div>
                    </div>
                </div>

                <%-- GRIDVIEW PARA VER LA LISTA DE CORREOS EN EL FORMULARIO     --%>
                <div class="col-md-6">
                    <asp:GridView ID="dgvCorreoFormulario" runat="server" AutoGenerateColumns="true"
                        CssClass="table table-hover table-bordered table-striped table-condensed" BorderWidth="3px" Width="480" OnRowDataBound="dgvCorreoFormulario_RowDataBound">
                    </asp:GridView>
                </div>
            </div>

            <!-- INTERESADO + EMPRESA  -->
            <div class="form-group">
                <asp:Label ID="lblIsInteresado" runat="server" Text="INTERESADO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-1">
                    <asp:CheckBox ID="chkIsInteresado" runat="server" />
                </div>
                <asp:Label ID="lblEmpresa" runat="server" Text="EMPRESA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <!--ES INTERESADO Y ES BENEFICIARIO-->
            <div class="form-group">
                <asp:Label ID="lblIsBeneficiario" runat="server" Text="BENEFICIARIO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-1">
                    <asp:CheckBox ID="chkIsBeneficiario" runat="server" />
                </div>
            </div>




            <!--BOTON GUARDAR PERSONA      -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <br />
                    <asp:Button ID="btnGuardarPersona" runat="server" Text="Guardar Persona" CssClass="btn btn-success form-control" OnClick="btnGuardarPersona_Click" />
                </div>
            </div>

            <!--GRILLA PARA MOSTRAR LAS PERSONAS EN LA BASE DE DATOS-->
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvPersona" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered" BorderWidth="4px">
                        <Columns>
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Apellido" DataField="apellido" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Tipo" DataField="tipoDocumento" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderText="Documento" DataField="documento" ItemStyle-HorizontalAlign="Center" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>

    </div>

</asp:Content>
