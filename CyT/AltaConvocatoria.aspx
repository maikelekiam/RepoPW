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
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblDescripcion" runat="server" Text="DESCRIPCION" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblObjetivo" runat="server" Text="OBJETIVO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtObjetivo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblFondo" runat="server" Text="FONDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4 ">
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
                <asp:Label ID="lblAnio" runat="server" Text="AÑO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblTipoFinanciamiento" runat="server" Text="TIPO DE FINANCIAMIENTO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblModalidad" runat="server" Text="MODALIDAD" CssClass="col-md-2 control-label"></asp:Label>
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
                <div class="col-md-4">
                    <asp:TextBox ID="txtMontoTotal" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="lblMontoProyecto" runat="server" Text="MONTO PROYECTO" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
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
                    <asp:Button ID="btnGuardarConvocatoria" runat="server" Text="Guardar Convocatoria" CssClass="btn btn-success form-control" OnClick="btnGuardarConvocatoria_Click" />
                </div>
            </div>


            <!--Lista de convocatorias cargadas-->

            <div class="form-group">
                <div class="col-md-12">
                    <asp:GridView ID="dgvConvocatoria" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvConvocatoria_SelectedIndexChanged"
                        CssClass="table table-hover table-bordered" BorderWidth="4px" EmptyDataText="No existen convocatorias registradas" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Nombre Convocatoria" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Descripcion" DataField="descripcion" ItemStyle-HorizontalAlign="Center" />
                            
                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
