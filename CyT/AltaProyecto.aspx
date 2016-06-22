<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaProyecto.aspx.cs" Inherits="CyT.AltaProyecto" %>

<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>--%>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>--%>
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
                        AutoPostBack="False"
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
                        DataTextField="nombreUvt"
                        AutoPostBack="False"
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
                        AutoPostBack="False"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Estado&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <%--AGREGAR ACA EL MODAL PARA EL NUEVO ESTADO--%>
                <div class="form-group">
                    <div class="col-md-4">
                        <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalEstado">Nuevo Estado</button>
                    </div>
                    <!-- MODAL ESTADO  -->
                    <div class="modal fade" id="modalEstado" tabindex="-1" role="dialog" aria-labelledby="modalLabelEstado" aria-hidden="true">
                        <div class="modal-dialog modal-md">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <h4 class="modal-title" id="modalLabelEstado">Nuevo Estado</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtEstadoModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>
                                    <br />
                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" ID="btnModalEstadoSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                    <asp:Button runat="server" ID="btnModalEstadoGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalEstadoGuardar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>








            <!--AREA PRODUCTIVA + MODAL AREA PRODUCTIVA-->
            <div class="form-group">
                <asp:Label ID="lblAreaProductiva" runat="server" Text="AREA PRODUCTIVA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlAreaProductiva" runat="server"
                        BackColor="WhiteSmoke"
                        ForeColor="#000066"
                        CssClass="form-control"
                        DataTextField="nombre"
                        AutoPostBack="False"
                        AppendDataBoundItems="true">
                        <asp:ListItem Value="-1">&lt;Seleccione Area Productiva&gt;</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <%--AGREGAR ACA EL MODAL PARA LA NUEVA AREA PRODUCTIVA--%>
                <div class="form-group">
                    <div class="col-md-4">
                        <button type="button" class="btn btn-info btn-md" data-toggle="modal" data-target="#modalAreaProductiva">Nueva Area Prod</button>
                    </div>
                    <!-- MODAL AREA PRODUCTIVA  -->
                    <div class="modal fade" id="modalAreaProductiva" tabindex="-1" role="dialog" aria-labelledby="modalLabelAreaProductiva" aria-hidden="true">
                        <div class="modal-dialog modal-md">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                    <h4 class="modal-title" id="modalLabelAreaProductiva">Nueva Area Productiva</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtAreaProductivaModal" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    </div>
                                    <br />
                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" ID="btnModalAreaProductivaSalir" Text="SALIR" class="btn btn-danger" data-dismiss="modal" />
                                    <asp:Button runat="server" ID="btnModalAreaProductivaGuardar" Text="GUARDAR" CssClass="btn btn-success" OnClick="btnModalAreaProductivaGuardar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
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

            <!--BOTON ACTUALIZAR PROYECTO  -->
            <div class="form-group">
                <div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnActualizarProyecto" runat="server" Text="Actualizar Proyecto" CssClass="btn btn-danger form-control" OnClick="btnActualizarProyecto_Click" />
                </div>
            </div>

            <!--GRILLA CON LOS PROYECTOS-->
            <h4>TABLA DE PROYECTOS</h4>
            <div class="form-group">
                <div class="col-md-9 col-md-offset-1">
                    <asp:GridView ID="dgvProyecto" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both"
                        AutoGenerateSelectButton="true"
                        OnSelectedIndexChanging="dgvProyecto_SelectedIndexChanging">
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
                        <SelectedRowStyle BackColor="Yellow" />
                    </asp:GridView>
                </div>
            </div>

            <div>
                Your Name :
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <input id="btnGetTime" type="button" value="Show Current Time"
                    onclick="ShowCurrentTime()" />
            </div>
        </asp:Panel>
    </div>
    <script type="text/javascript">
        function ShowCurrentTime() {
            $.ajax({
                type: "POST",
                url: "AltaProyecto.aspx/GetCurrentTime",
                data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                failure: function (response) {
                    alert(response.d);
                }
            });
        }
        function OnSuccess(response) {
            alert(response.d);
        }
    </script>
</asp:Content>
