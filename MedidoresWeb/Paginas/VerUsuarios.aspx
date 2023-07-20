<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="MedidoresWeb.Paginas.VerUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Ver Usuarios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="mensaje">
                    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
                </div>
                <div class="card-header" >
                    <h3>Ver Usuarios</h3>
                </div>
                <div class="card-body col-md-12" >
                    <asp:GridView 
                        CssClass="table table-hover table-bordered" 
                        ShowHeaderWhenEmpty ="false"
                        runat="server" 
                        AutoGenerateColumns="false" 
                        EmptyDataText="No hay Registros" 
                        ID="grillaUsuarios">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="Rut" HeaderText="Rut Usuario" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre Usuario" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo Usuario" />
                            <asp:BoundField DataField="Contrasena" HeaderText="Password Usuario" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button runat="server" CssClass="btn btn-danger form-control-sm" Text="Eliminar"  OnClick="btnEliminar_click"/>
                                
                                    <asp:Button runat="server" CssClass="btn btn-success form-control-sm" Text="Ver Usuario" OnClick="btnEditar_click" />

                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div> 
    </div>
</asp:Content>
