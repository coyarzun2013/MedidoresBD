<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidoresWeb.Paginas.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Ver Lecturas de Medidor
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="row mt-4">
        <div class="col-md-8 mx-auto">
            <div class="card">
                <div class="card-header" >
                    <h3><asp:Label runat="server" ID="mensajesLbl" CssClass="text-danger"></asp:Label></h3>
                </div>
                <div class="card-body col-md-12" >
                    <asp:GridView 
                        CssClass="table table-hover table-bordered" 
                        ShowHeaderWhenEmpty ="false"
                        runat="server" 
                        AutoGenerateColumns="false" 
                        EmptyDataText="No hay Registros" 
                        ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="IdLectura" HeaderText="Id" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Lectura" />
                            <asp:BoundField DataField="Hora" HeaderText="Hora Lectura" />
                            <asp:BoundField DataField="Consumo" HeaderText="Consumo" />
                            <asp:BoundField DataField="IdMedidor" HeaderText="Id Medidor" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div> 
    </div>
</asp:Content>
