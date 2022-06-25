<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresInteligentesWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group mb-3">
                        <label for="tipoMedidorDdl">Tipo de medidor</label>
                        <asp:DropDownList AutoPostBack="true" ID="tipoMedidorDdl" CssClass="form-control" runat="server" OnSelectedIndexChanged="tipoMedidorDdl_SelectedIndexChanged">
              
                        </asp:DropDownList>
                    </div>
                    <asp:GridView CssClass="table table-hover table-bordered mb-3" 
                        AutoGenerateColumns="false"
                        runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre medidor" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo de medidor" />
                        </Columns>
                    </asp:GridView>

                    <div class="form-group mx-auto d-flex justify-content-center">
                        <a id="ingresarBtn" href="Default.aspx" class="btn btn-success">
                            Ingresar medidor
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
