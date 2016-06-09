<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmFondo.aspx.cs" Inherits="CyT.frmFondo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h1>Fondos</h1>            
            <button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">
                Nuevo
            </button>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <!-- Modal -->
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
                    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
                        aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content col-md-pull-12">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                                </div>
                                <div class="modal-body">
                                    <asp:TextBox ID="TextBox1" runat="server" placeholder="First Name" class="form-control"></asp:TextBox><br />
                                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Middle Name" class="form-control"></asp:TextBox><br />
                                    <asp:TextBox ID="TextBox3" runat="server" placeholder="Last Name" class="form-control"></asp:TextBox><br />
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">
                                        Close</button>
                                    <%--<button type="button"  class="btn btn-primary">
                                        Save changes</button>--%>
                                    <asp:Button Text="Save" runat="server"></asp:Button>
                                </div>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

</asp:Content>
