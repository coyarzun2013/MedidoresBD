<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresWeb.Paginas.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Ver Medidores
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-header" >
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body col-md-12" >
                    <asp:GridView 
                        CssClass="table table-hover table-bordered" 
                        ShowHeaderWhenEmpty ="false"
                        runat="server" 
                        AutoGenerateColumns="false" 
                        EmptyDataText="No hay Registros" 
                        ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="IdMedidor" HeaderText="Id" />
                            <asp:BoundField DataField="Numero" HeaderText="Numero Medidor" />
                            <asp:TemplateField HeaderText="Tipo de Medidor">
                                <ItemTemplate>
                                    <asp:Label ID="lblStatus" runat="server" Text='<%# (Convert.ToDecimal(Eval("IdTipo")) == 1) ? "Digital" : "Mecánico"   %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" />
                            <asp:TemplateField HeaderText="Acción">
                                <ItemTemplate>
                                    <asp:Button runat="server" CssClass="btn btn-primary form-control-sm" Text="Ver Lecturas" OnClick="btnVer_click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div> 
    </div>
</asp:Content>
