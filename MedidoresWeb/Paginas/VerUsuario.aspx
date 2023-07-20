<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerUsuario.aspx.cs" Inherits="MedidoresWeb.Paginas.VerUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
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
                    <h3>Ver Usuario</h3>
                </div>
                <div class="card-body col-md-12" >
                    <div class="form-group">
                        <label >Rut</label>
                        <asp:TextBox ID="ruttxt" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="reqNumero" controltovalidate="ruttxt" errormessage="(*) Campo Requerido" />
                    </div>
                    <div class="form-group">
                        <label >Nombre Usuario</label>
                        <asp:TextBox ID="nombretxt" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator2" controltovalidate="nombretxt" errormessage="(*) Campo Requerido" />
                    </div>
                    <div class="form-group">
                        <label >Email Usuario</label>
                        <asp:TextBox ID="emailtxt" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator1" controltovalidate="emailtxt" errormessage="(*) Campo Requerido" />
                    </div>
                    <div class="form-group">
                        <label >Contraseña Usuario</label>
                        <asp:TextBox ID="passtxt" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator3" controltovalidate="passtxt" errormessage="(*) Campo Requerido" />
                    </div>

                </div>
            </div>
        </div>
     </div>

    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-header" >
                    <h3>Ver Medidores del Usuario</h3>
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
