<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="SoftGestWA.Recuperar" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Recuperar Contraseña - DentaCare</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap + FontAwesome -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    <link href="/styles/RecuperarStyles.css" rel="stylesheet" />
    
</head>
<body>

<div class="card-container">
    <div class="recovery-card">
        <!-- Logo -->
        <img src="/img/logo.png" alt="Logo DentaCare" />

        <!-- Título -->
        <h5>Recuperar Contraseña</h5>

        <!-- Texto descriptivo -->
        <p>Envíe su solicitud para que el asistente mostrador pueda restaurar su contraseña.</p>

        <!-- Campo de correo -->
        <div class="mb-3 text-start">
            <label for="txtCorreo" class="form-label">Correo electrónico</label>
            <input type="email" id="txtCorreo" name="txtCorreo" class="form-control" placeholder="ejemplo@correo.com" required />
        </div>

        <!-- Botón de envío -->
        <button class="btn btn-primary w-100 mb-2">Enviar solicitud</button>

        <!-- Link para volver -->
        <a href="Login.aspx" class="link-back">Volver al inicio de sesión</a>

        <!-- Pie de página -->
        <div class="footer-note">
            DentaCare es el aplicativo web de la clínica dental <strong>SisaDent</strong>
        </div>
    </div>
</div>

</body>
</html>
