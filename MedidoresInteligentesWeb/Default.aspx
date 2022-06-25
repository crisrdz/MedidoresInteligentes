<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresInteligentesWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group mb-3">
                        <label for="idTxt">ID</label>
                        <asp:TextBox ID="idTxt" CssClass="form-control" type="number" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="reqID" ControlToValidate="idTxt" ErrorMessage="Por favor, ingrese un ID" Display="Dynamic" CssClass="text-danger" />
                        <asp:CustomValidator runat="server" ID="customID" ControlToValidate="idTxt" ErrorMessage="Por favor, ingrese un número válido" Display="Dynamic" OnServerValidate="customID_ServerValidate" CssClass="text-danger"/>
                    </div>
                    <div class="form-group mb-3">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="reqNombre" ControlToValidate="nombreTxt" ErrorMessage="Por favor, ingrese un nombre" Display="Dynamic" CssClass="text-danger" />
                    </div>
                     <div class="form-group mb-3">
                        <label for="tipoRbl">Tipo</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Value="A" Text="A"></asp:ListItem>
                            <asp:ListItem Value="B" Text="B"></asp:ListItem>
                            <asp:ListItem Value="C" Text="C"></asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator runat="server" ID="reqTipo" ControlToValidate="tipoRbl" ErrorMessage="Por favor, seleccione un tipo de medidor" Display="Dynamic" CssClass="text-danger" />
                    </div>
                    <div class="form-group ">
                        <asp:Button runat="server" ID="ingresarBtn" OnClick="ingresarBtn_Click"
                            Text="Ingresar medidor" CssClass="btn btn-primary d-block mx-auto"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
