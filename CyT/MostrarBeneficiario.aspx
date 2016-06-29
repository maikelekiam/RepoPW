<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarBeneficiario.aspx.cs" Inherits="CyT.MostrarBeneficiario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>DATOS DEL BENEFICIARIO</h2>
            </div>

            <br />
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblApellido" runat="server" Text="APELLIDO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblTipoDocumento" runat="server" Text="Tipo de Documento" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTipoDocumento" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDocumento" runat="server" Text="Documento" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCuil" runat="server" Text="CUIL/CUIT" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCuil" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="FECHA DE NACIMIENTO" CssClass="col-md-2 control-label"> </asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLocalidad" runat="server" Text="LOCALIDAD" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtLocalidad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmpresa" runat="server" Text="EMPRESA" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>


            <div class="form-group">
                <div class="col-md-5 col-md-offset-1">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h2 class="panel-title">Lista de Telefonos</h2>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="dgvTelefonoModal" runat="server" AutoGenerateColumns="false"
                                Width="400" GridLines="None" EmptyDataText="No existen telefonos cargados" ShowHeaderWhenEmpty="true">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemStyle Height="30" CssClass="form-control" HorizontalAlign="Right" />
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container, "DataItem")%>
                                        </ItemTemplate>
                                        <%--<EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtProductName" Text='<%#DataBinder.Eval(Container, "DataItem")%>' />
                                            </EditItemTemplate>--%>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-5 col-md-offset-1">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h2 class="panel-title">Lista de Correo Electronicos</h2>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="dgvCorreoModal" runat="server" AutoGenerateColumns="false"
                                Width="400" GridLines="None" EmptyDataText="No existen correos cargados" ShowHeaderWhenEmpty="true">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemStyle Height="30" CssClass="form-control" HorizontalAlign="Right" />
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container, "DataItem")%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>




        </asp:Panel>
    </div>



</asp:Content>
