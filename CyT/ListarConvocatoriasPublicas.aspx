<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarConvocatoriasPublicas.aspx.cs" Inherits="CyT.ListarConvocatoriasPublicas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h1>LISTA DE CONVOCATORIAS PUBLICAS</h1>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:GridView ID="dgvConvocatoria" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both"
                        AutoGenerateSelectButton="false"
                        OnRowDataBound="dgvConvocatoria_RowDataBound">
                        <Columns>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Justify" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Descripcion" DataField="descripcion" ItemStyle-HorizontalAlign="Justify" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Objetivo" DataField="objetivo" ItemStyle-HorizontalAlign="Justify" />
                            <asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Fondo">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Fondo.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Año" DataField="anio" ItemStyle-HorizontalAlign="Left" />
                            <asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Tipo">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TipoFinanciamiento.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Estado" DataField="isAbierta" ItemStyle-HorizontalAlign="Left" />

                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>

        </asp:Panel>
    </div>
</asp:Content>
