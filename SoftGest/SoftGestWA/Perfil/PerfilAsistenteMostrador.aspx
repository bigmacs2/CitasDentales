<%@ Page Language="C#" MasterPageFile="~/Views/AsistenteMostrador/AsistenteMostrador.Master" AutoEventWireup="true" CodeBehind="PerfilAsistenteMostrador.aspx.cs" Inherits="SoftGestWA.Perfil.PerfilAsistenteMostrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="padding-top: 0; overflow-x: hidden;">
        <h2 style="margin-top: -10px; margin-bottom: 1rem; margin-left: 0; text-align: left;">Perfil de Asistente Mostrador</h2>
        <div class="row justify-content-center">
            <div class="col-md-8">
                <div class="card" style="width: 90%; max-width: 800px; padding: 1rem; margin: 0 auto;">
                    <div class="card-body">
                        <h3 style="margin-bottom: 1rem;">Consulta y actualiza tu información personal</h3>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtNombre">Nombre completo</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtCorreo">Correo electrónico</label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtTelefono">Teléfono</label>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtDireccion">Dirección</label>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtCallePrincipal">Calle Principal</label>
                            <asp:TextBox ID="txtCallePrincipal" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <h3 style="margin-top: 1rem; margin-bottom: 1rem;">Cambiar Contraseña</h3>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtContraseñaActual">Contraseña actual</label>
                            <asp:TextBox ID="txtContraseñaActual" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtNuevaContraseña">Nueva contraseña</label>
                            <asp:TextBox ID="txtNuevaContraseña" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group" style="margin-bottom: 0.5rem;">
                            <label for="txtConfirmarContraseña">Confirmar nueva contraseña</label>
                            <asp:TextBox ID="txtConfirmarContraseña" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="text-center" style="margin-top: 0.5rem;">
            <asp:Button ID="btnCambiarContraseña" runat="server" Text="Cambiar Contraseña" CssClass="btn btn-primary" style="width: 25%; min-width: 150px; margin-right: 1rem;" OnClick="btnCambiarContraseña_Click" />
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-secondary" style="width: 25%; min-width: 150px;" OnClick="btnRegresar_Click" />
        </div>
    </div>
</asp:Content>