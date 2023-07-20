<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearLectura.aspx.cs" Inherits="MedidoresWeb.Paginas.CrearLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Crear Lectura
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
                    <h3>Crear Lectura</h3>
                </div>
                <div class="card-body col-md-12" >
                    <div class="form-group">
                        <label >Medidor</label>
                        <asp:DropDownList runat="server" ID="medidoresDbl" CssClass="form-select form-select-sm" AppendDataBoundItems="true">
                        </asp:DropDownList>
                   </div>
                    <div class="form-group">
                        <label >Fecha</label>
                        <asp:Calendar ID="fechatxt" CssClass="form-control form-control-sm" runat="server"></asp:Calendar>
                   </div>
                    <div class="form-group">
                        <label >Hora</label>
                        <asp:TextBox ID="horatxt" CssClass="form-control form-control-sm" runat="server" MaxLength="2"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator2" controltovalidate="horatxt" errormessage="(*) Campo Requerido" />
                        <asp:RangeValidator runat="server" Display="Dynamic" ID="range1" ValidationGroup="grdsave"
            SetFocusOnError="true" ControlToValidate="horatxt" Type ="Integer" MinimumValue="0" MaximumValue="24"
            ErrorMessage="La hora debe ser entre 00 y 23"></asp:RangeValidator>
                   </div>
                    <div class="form-group">
                        <label >Minutos</label>
                        <asp:TextBox ID="minutostxt" CssClass="form-control form-control-sm" runat="server" MaxLength="2"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator3" controltovalidate="minutostxt" errormessage="(*) Campo Requerido" />
                        <asp:RangeValidator runat="server" Display="Dynamic" ID="RangeValidator1" ValidationGroup="grdsave"
            SetFocusOnError="true" ControlToValidate="minutostxt" Type ="Integer" MinimumValue="0" MaximumValue="59"
            ErrorMessage="La hora debe ser entre 00 y 59"></asp:RangeValidator>
                    </div>
                    <div class="form-group">
                        <label >Consumo</label>
                        <asp:TextBox ID="consumotxt" CssClass="form-control form-control-sm" runat="server" MaxLength="3"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" CssClass="text-danger" id="RequiredFieldValidator4" controltovalidate="consumotxt" errormessage="(*) Campo Requerido" />
                       </div>
                    <div class="form-group mt-4">
                        <asp:Button runat="server" ID="agregarBtn" CssClass="btn btn-success" Text="Agregar Lectura" OnClick="agregarBtn_Click" />
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
