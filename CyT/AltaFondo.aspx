<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaFondo.aspx.cs" Inherits="CyT.AltaFondo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h2>Fondos</h2>
            </div>
            <br />
            <div class="form-group">
                <button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">
                    Nuevo Fondo
                </button>
            </div>
            <!-- Modal -->
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
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
                                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-6 ">
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox><br />
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-6 ">
                                    <asp:TextBox ID="txtDecripcion" runat="server" class="form-control"></asp:TextBox><br />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblOrigen" runat="server" Text="Origen" CssClass="col-md-2 control-label"> </asp:Label>
                                <div class="col-md-4 ">
                                    <asp:DropDownList ID="ddlOrigen" runat="server"
                                        Width="280"
                                        BackColor="WhiteSmoke"
                                        ForeColor="#000066"
                                        Font-Bold="false"
                                        CssClass="form-control"
                                        DataTextField="nombre">


                                        <asp:ListItem Value="-1">&lt;Seleccione Origen&gt;</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnGuardar" Text="Guardar" runat="server" class="btn btn-default" OnClick="btnGuardar_Click"></asp:Button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--Lista de fondos cargados-->

            <div class="form-group">
                <div class="col-md-12">
                    <asp:GridView ID="dgvFondo" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvFondo_SelectedIndexChanged"
                        CssClass="table table-hover table-bordered" BorderWidth="4px" EmptyDataText="No existen fondos registrados" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Nombre Fondo" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Descripcion" DataField="descripcion" ItemStyle-HorizontalAlign="Center" />
                            <asp:TemplateField HeaderText="SomeColumn">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Origen.Nombre") %>' ></asp:Label>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Origen">
                                <ItemTemplate>
                                    <p><%#DataBinder.Eval(Container.DataItem, "origen.Nombre")%></p>                      
                                    
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>


        </asp:Panel>
    </div>
</asp:Content>
