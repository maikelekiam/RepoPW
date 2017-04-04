<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="CyT.AltaPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <div class="panel-heading">
                <h3>Formulario de ALTA Persona</h3>
            </div>
            <!--NOMBRE + APELLIDO-->
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
                        onkeypress="return validarSoloLetras(event);"></asp:TextBox>
                </div>
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"
                        onkeypress="return validarSoloLetras(event);"></asp:TextBox>
                </div>
            </div>

            <!--TIPO DOCUMENTO + DNI-->
            <div class="form-group">
                <asp:Label ID="lblTipoDocumento" runat="server" Text="TIPO DOCUMENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        data-width="fit">
                        <asp:ListItem Value="DNI">DNI</asp:ListItem>
                        <asp:ListItem Value="DU">DU</asp:ListItem>
                        <asp:ListItem Value="LE">LE</asp:ListItem>
                        <asp:ListItem Value="CI">CI</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:Label ID="lblDocumento" runat="server" Text="DOCUMENTO" class="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDocumento" runat="server" class="form-control"
                        onkeypress="return validarSoloNumeros(event);" MaxLength="8"></asp:TextBox>
                </div>
            </div>
            <!--CUIL + FECHA NACIMIENTO-->
            <div class="form-group">
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <div class="input-group date"
                        data-provide="datepicker"
                        data-date-format="dd/mm/yyyy"
                        data-date-autoclose="true"
                        data-date-today-btn="true"
                        data-date-clear-btn="true"
                        data-date-today-highlight="true">
                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaNacimiento"
                            onkeypress="return validarSoloNumerosYGuion(event);"></asp:TextBox>
                        <div class="input-group-addon">
                            <span class="glyphicon glyphicon-th"></span>
                        </div>
                    </div>
                </div>
                <asp:Label ID="lblCuil" runat="server" Text="CUIL/CUIT" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCuil" runat="server" CssClass="form-control" MaxLength="13"
                        onkeypress="return validarSoloNumerosYGuion(event);"></asp:TextBox>
                </div>
            </div>
            <!--DIRECCION + LOCALIDAD-->
            <div class="form-group">
                <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"
                        onkeypress="return validarSoloLetrasYNumeros(event);"></asp:TextBox>
                </div>
                <asp:Label ID="lblLocalidad" runat="server" Text="LOCALIDAD" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="ddlLocalidad" runat="server"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        Font-Bold="true"
                        CssClass="selectpicker form-control show-tick"
                        data-live-search="true"
                        DataTextField="nombre"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione una Localidad&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <!--LISTA DE TELEFONOS-->
            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="TELEFONOS" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalTelefono">Agregar Telefonos</button>
                </div>

                <!-- MODAL LISTA DE TELEFONOS -->
                <div class="modal fade" id="modalTelefono" tabindex="-1" role="dialog" aria-labelledby="modalLabelTelefono" aria-hidden="true">
                    <div class="modal-dialog modal-md">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title" id="modalLabelTelefono">Telefonos existentes</h4>
                            </div>
                            <div class="modal-body">
                                <asp:GridView ID="dgvTelefonoModal" runat="server" AutoGenerateColumns="false"
                                    Width="500" GridLines="None" EmptyDataText="No existen telefonos cargados" ShowHeaderWhenEmpty="true">
                                    <HeaderStyle BackColor="#0099cc" ForeColor="White" HorizontalAlign="Center" Height="35" Font-Names="Cambria" Font-Size="Large" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemStyle Height="30" CssClass="alert-info form-control " />
                                            <ItemTemplate>
                                                <%#DataBinder.Eval(Container, "DataItem")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtProductName" Text='<%#DataBinder.Eval(Container, "DataItem")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <br />
                                <asp:Label ID="lblListaTelefonosModal" runat="server" Text="Nuevo Telefono" CssClass="col-md-4 control-label"> </asp:Label>
                                <div class="col-md-6">
                                    <asp:TextBox ID="txtTelefonoModal" runat="server" CssClass="form-control"
                                        onkeypress="return validarTelefonos(event);"></asp:TextBox><br />
                                    <input id="btnAgregarTelefono" type="button" value="Click para agregar a la lista temporal" class="alert-info" />
                                </div>
                                <br />
                            </div>

                            <!-- TABLA PARA AGREGAR NUEVOS TELEFONOS SIN SALIR DEL MODAL-->
                            <div id="content">
                                <label>Lista de telefonos temporal</label>
                                <table id="tabla" class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <td>N°</td>
                                            <td>Telefono</td>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                            <div class="modal-footer">
                                <br />
                                <asp:Button runat="server" ID="btnModalTelefonoSalir" Text="Salir" class="btn btn-danger" data-dismiss="modal" />
                                <asp:Button runat="server" ID="btnModalTelefonoGuardar" Text="Guardar Lista" CssClass="btn btn-success" OnClick="btnModalTelefonoGuardar_Click" />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>


                <%-- GRIDVIEW PARA VER LA LISTA DE TELEFONOS EN EL FORMULARIO          --%>
                <div class="col-md-6 col-md-offset-0">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h2 class="panel-title">Lista de Telefonos</h2>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="dgvTelefonoFormulario" runat="server" AutoGenerateColumns="false"
                                Width="300"
                                ShowHeader="false"
                                GridLines="None"
                                AutoGenerateDeleteButton="false"
                                OnRowDeleting="dgvTelefonoFormulario_RowDeleting">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemStyle Height="25" Width="300" Font-Size="Small" />
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container, "DataItem")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowDeleteButton="True" ButtonType="Image" DeleteImageUrl="~/imagenes/deletered.png" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>


            <!--LISTA DE CORREO ELECTRONICOS-->
            <div class="form-group">
                <asp:Label ID="lblCorreoElectronico" runat="server" Text="CORREO ELECTRONICOS" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalCorreoElectronico">Agregar Correo</button>
                </div>
                <!-- MODAL LISTA DE CORREO ELECTRONICOS  -->
                <div class="modal fade" id="modalCorreoElectronico" tabindex="-1" role="dialog" aria-labelledby="modalLabelCorreo" aria-hidden="true">
                    <div class="modal-dialog modal-md" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                                <h4 class="modal-title" id="modalLabelCorreo">Lista de Correo Electronicos</h4>
                            </div>
                            <div class="modal-body">
                                <asp:GridView ID="dgvCorreoModal" runat="server" AutoGenerateColumns="false"
                                    Width="500" GridLines="None">
                                    <HeaderStyle BackColor="#0099cc" ForeColor="White" HorizontalAlign="Center" Height="35" Font-Names="Cambria" Font-Size="Large" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemStyle Height="30" CssClass="alert-info form-control " />
                                            <ItemTemplate>
                                                <%#DataBinder.Eval(Container, "DataItem")%>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtProductName" Text='<%#DataBinder.Eval(Container, "DataItem")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <br />
                                <asp:Label ID="lblListaCorreoModal" runat="server" Text="Nuevo Correo" CssClass="col-md-4 control-label"> </asp:Label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txtCorreoModal" runat="server" CssClass="form-control"
                                        onkeypress="return validarEmail(event);"></asp:TextBox><br />
                                    <input id="btnAgregarCorreoElectronico" type="button" value="Click para agregar a la lista temporal" class="alert-info" />
                                </div>
                                <br />
                            </div>

                            <!-- TABLA PARA AGREGAR NUEVOS CORREO ELECTRONICOS SIN SALIR DEL MODAL-->
                            <div id="contentce">
                                <label>Lista de Correo Electronicos temporal</label>
                                <table id="tablace" class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <td>N°</td>
                                            <td>Correo Electronico</td>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                            <div class="modal-footer">
                                <br />
                                <asp:Button runat="server" ID="btnModalCorreoSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                <asp:Button runat="server" ID="btnModalCorreoGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalCorreoGuardar_Click" />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>



                <%-- GRIDVIEW PARA VER LA LISTA DE CORREOS EN EL FORMULARIO     --%>
                <div class="col-md-6 col-md-offset-0">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h2 class="panel-title">Lista de Correo Electronicos</h2>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="dgvCorreoFormulario" runat="server" AutoGenerateColumns="false"
                                Width="300"
                                ShowHeader="false"
                                GridLines="none"
                                AutoGenerateDeleteButton="false">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemStyle Height="25" Width="300" Font-Size="Small" />
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container, "DataItem")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnEliminarCorreoModal" runat="server" Text="<i class='glyphicon glyphicon-trash'></i>"
                                                CssClass="btn btn-danger btn-xs" CommandName="Add" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' OnCommand="btnEliminarCorreoModal_Command"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
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

            <!--BOTON GUARDAR PERSONA Y ACTUALIZAR PERSONA      -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <br />
                    <asp:Button ID="btnGuardarPersona" runat="server" Text="Guardar Persona" CssClass="btn btn-success form-control" OnClick="btnGuardarPersona_Click" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnActualizarPersona" runat="server" Text="Actualizar Persona" CssClass="btn btn-success form-control" OnClick="btnActualizarPersona_Click" />
                </div>
            </div>

            <!--GRILLA PARA MOSTRAR LAS PERSONAS EN LA BASE DE DATOS-->
            <h4>GRILLA DE PERSONAS</h4>
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvPersona" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both" EmptyDataText="No existen personas registradas" ShowHeaderWhenEmpty="true"
                        OnSelectedIndexChanging="dgvPersona_SelectedIndexChanging"
                        OnRowDeleting="dgvPersona_RowDeleting">
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="idPersona" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Apellido" DataField="apellido" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Tipo" DataField="tipoDocumento" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Documento" DataField="documento" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Localidad" DataField="idLocalidad" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Interesado" DataField="isInteresado" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Beneficiario" DataField="isBeneficiario" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Fecha Nac" DataField="fechaNacimiento" DataFormatString="{0:d}" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Empresa" DataField="empresa" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Direccion" DataField="direccion" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Cuil" DataField="cuil" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:BoundField HeaderText="Activo" DataField="activo" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#cccccc" />
                            <asp:ButtonField Text="Editar" CommandName="select" HeaderStyle-BackColor="#cccccc" />
                            <asp:ButtonField Text="Borrar" CommandName="delete" HeaderStyle-BackColor="#cccccc" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnAgregarTelefono").click(function () {
                var tel = $('<%= txtTelefonoModal.ClientID %>').val();
                $.ajax({
                    type: "POST",
                    url: "AltaPersona.aspx/AgregarTelefono",
                    data: '{tel: "' + $("#<%=txtTelefonoModal.ClientID%>")[0].value + '"}',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: OnSuccessTelefono,
                    error: function (data) {
                        alert(data.d);
                        //$("#lblRespuesta").text(data.d);
                    }
                });
            });
        });
        var cont = 0;
        function OnSuccessTelefono(data) {
            var a = $('data').d;
            cont++;
            var fila = '<tr class="selected" id="fila' + cont + '"><td>' + cont + '</td><td>' + data.d + '</td></tr>';
            $('#tabla').append(fila);
        };
    </script>


    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnAgregarCorreoElectronico").click(function () {
                var corr = $('<%= txtCorreoModal.ClientID %>').val();
                $.ajax({
                    type: "POST",
                    url: "AltaPersona.aspx/AgregarCorreoElectronico",
                    data: '{corr: "' + $("#<%=txtCorreoModal.ClientID%>")[0].value + '"}',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: OnSuccessCorreo,
                    error: function (data) {
                        alert(data.d);
                        //$("#lblRespuesta").text(data.d);
                    }
                });
            });
        });
        var cont = 0;
        function OnSuccessCorreo(data) {
            var a = $('data').d;
            cont++;
            var fila = '<tr class="selected" id="fila' + cont + '"><td>' + cont + '</td><td>' + data.d + '</td></tr>';
            $('#tablace').append(fila);
        };
    </script>

</asp:Content>
