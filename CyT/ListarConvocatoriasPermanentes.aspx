<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarConvocatoriasPermanentes.aspx.cs" Inherits="CyT.ListarConvocatoriasPermanentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <div class="panel-heading">
                <h1>LISTA DE CONVOCATORIAS PERMANENTES</h1>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:GridView ID="dgvConvocatoria" runat="server" AutoGenerateColumns="false"
                        CssClass="table table-hover table-bordered table-striped" BorderWidth="2px"
                        GridLines="Both"
                        AutoGenerateSelectButton="false"
                        OnRowDataBound="dgvConvocatoria_RowDataBound">
                        <Columns>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Nombre Convocatoria" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Descripcion" DataField="descripcion" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Objetivo" DataField="objetivo" ItemStyle-HorizontalAlign="Center" />
                            <asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Fondo">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Fondo.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Año" DataField="anio" ItemStyle-HorizontalAlign="Center" />
                            <asp:TemplateField HeaderStyle-BackColor="#cccccc" HeaderText="Tipo Financiamiento">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TipoFinanciamiento.Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            
                            <asp:BoundField HeaderStyle-BackColor="#cccccc" HeaderText="Estado" DataField="isAbierta" ItemStyle-HorizontalAlign="Center" />

                        </Columns>
                        <SelectedRowStyle BackColor="Azure" />
                    </asp:GridView>
                </div>
            </div>

        </asp:Panel>
    </div>
</asp:Content>
