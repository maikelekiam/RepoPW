<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaConvocatoria.aspx.cs" Inherits="CyT.AltaConvocatoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>Formulario ALTA CONVOCATORIA</h2>
            </div>
            <br />
            <div class="form-group">
                <button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">
                    Nueva Convocatoria
                </button>
            </div>
            <!-- Modal -->
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel"
                aria-hidden="true">
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="myModalLabel">Nuevo Fondo</h4>
                        </div>
                        <div class="modal-body">
                            <div class="form-group">
                                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-4">
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:Label ID="lblDescripcion" runat="server" Text="DESCRIPCION" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblObjetivo" runat="server" Text="OBJETIVO" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txtObjetivo" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblAnio" runat="server" Text="AÑO" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-3">
                                    <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:Label ID="lblFondo" runat="server" Text="FONDO" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-3 ">
                                    <asp:DropDownList ID="ddlFondo" runat="server"
                                        Width="280"
                                        BackColor="WhiteSmoke"
                                        ForeColor="#000066"
                                        Font-Bold="false"
                                        CssClass="form-control"
                                        DataTextField="nombre">
                                        <asp:ListItem Value="-1">&lt;Seleccione Fondo&gt;</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group">                                
                                <asp:Label ID="lblTipoFinanciamiento" runat="server" Text="TIPO DE FINANCIAMIENTO" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-4 ">
                                    <asp:DropDownList ID="ddlTipoFinanciamiento" runat="server"
                                        Width="280"
                                        BackColor="WhiteSmoke"
                                        ForeColor="#000066"
                                        Font-Bold="false"
                                        CssClass="form-control"
                                        DataTextField="nombre">
                                        <asp:ListItem Value="-1">&lt;Seleccione Tipo Financiamiento&gt;</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:Label ID="lblModalidad" runat="server" Text="MODALIDAD" CssClass="col-md-1 control-label"></asp:Label>
                                <div class="col-md-4 ">
                                    <asp:DropDownList ID="ddlModalidad" runat="server"
                                        Width="280"
                                        BackColor="WhiteSmoke"
                                        ForeColor="#000066"
                                        Font-Bold="false"
                                        CssClass="form-control"
                                        DataTextField="nombre">
                                        <asp:ListItem Value="-1">&lt;Seleccione Modalidad&gt;</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>                            
                            <div class="form-group">
                                <asp:Label ID="lblMontoTotal" runat="server" Text="MONTO TOTAL" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-3">
                                    <asp:TextBox ID="txtMontoTotal" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:Label ID="lblMontoProyecto" runat="server" Text="MONTO PROYECTO" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-3">
                                    <asp:TextBox ID="txtMontoProyecto" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblFechaInicio" runat="server" Text="FECHA DE INICIO" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-3">
                                    <div class="input-group date"
                                        data-provide="datepicker"
                                        data-date-format="dd/mm/yyyy"
                                        data-date-autoclose="true"
                                        data-date-today-btn="true"
                                        data-date-clear-btn="true"
                                        data-date-today-highlight="true">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaInicio"></asp:TextBox>
                                        <div class="input-group-addon">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </div>
                                    </div>
                                </div>
                                <asp:Label ID="lblFechaCierre" runat="server" Text="FECHA DE CIERRE" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-3">
                                    <div class="input-group date"
                                        data-provide="datepicker"
                                        data-date-format="dd/mm/yyyy"
                                        data-date-autoclose="true"
                                        data-date-today-btn="true"
                                        data-date-clear-btn="true"
                                        data-date-today-highlight="true">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtFechaCierre"></asp:TextBox>
                                        <div class="input-group-addon">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblIsAbierta" runat="server" Text="ABIERTA" CssClass="col-md-2 control-label"></asp:Label>
                                <div class="col-md-1">
                                    <asp:CheckBox ID="chkIsAbierta" runat="server" />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-2 col-md-offset-2">
                                    <br />

                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnGuardarConvocatoria" runat="server" Text="Guardar Convocatoria" CssClass="btn btn-default" OnClick="btnGuardarConvocatoria_Click" />
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>


            <!--Lista de convocatorias cargadas-->

            <div class="form-group">
                <div class="col-md-12">
                    <asp:GridView ID="dgvConvocatoria" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvConvocatoria_SelectedIndexChanged"
                        CssClass="table table-hover table-bordered" BorderWidth="4px" EmptyDataText="No existen convocatorias registradas" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Nombre Convocatoria" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Fondo">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Fondo.Nombre") %>' ></asp:Label>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Año" DataField="anio" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Estado" DataField="isAbierta" ItemStyle-HorizontalAlign="Center" />


                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>
    </div>
    
</asp:Content>

