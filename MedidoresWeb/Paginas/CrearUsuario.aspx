<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="MedidoresWeb.Paginas.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Crear Usuario
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="mensaje">
                    <asp:Label runat="server" ID="mensajesLbl" CssClass="text-danger"></asp:Label>
                </div>
                <div class="card-header" >
                    <h3>Crear Usuario</h3>
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
                    <div class="form-group mt-4">
                        <asp:Button runat="server" ID="agregarBtn" CssClass="btn btn-success" Text="Agregar Usuario" OnClick="agregarBtn_Click" />
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
