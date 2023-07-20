<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearMedidor.aspx.cs" Inherits="MedidoresWeb.Paginas.CrearMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Crear Medidor
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
                    <h3>Crear Medidor</h3>
                </div>
                <div class="card-body col-md-12" >
                    <div class="form-group">
                        <label >Numero Medidor</label>
                        <asp:TextBox ID="numerotxt" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="reqNumero" controltovalidate="numerotxt" errormessage="(*) Campo Requerido" />
                    </div>
                    <div class="form-group">
                        <label >Usuario</label>
                        <asp:DropDownList 
                            runat="server" 
                            ID="usuariosDbl" 
                            CssClass="form-select form-select-sm" 
                            AppendDataBoundItems="true">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label >Tipo</label>
                        <asp:DropDownList runat="server" ID="tiposDbl" CssClass="form-select form-select-sm" AppendDataBoundItems="true">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group mt-4">
                        <asp:Button runat="server" ID="agregarBtn" CssClass="btn btn-success" Text="Agregar Medidor" OnClick="agregarBtn_Click" />
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
