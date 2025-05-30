<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DentaCare.Login" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Login - DentaCare</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- Bootstrap y Font Awesome -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet" />
    <link href="/styles/styleslogin.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid full-height">
        <div class="row full-height">

            <!-- PANEL IZQUIERDO -->
            <div class="col-md-6 left-panel">
                <div class="w-100" style="max-width: 400px;">
                    <!-- Logo en el login -->
                    <div class="text-center mb-3">
                    <img src="/img/Logo.png" alt="Logo DentaCare"
                         class="d-block mx-auto"
                         style="max-height: 60px; height: auto; margin-bottom: 16px; padding: 0;" />



                    </div>

                    <h3 class="form-title text-center">Iniciar sesión</h3>
                    <form method="post" action="/Login/Validar">
                        <div class="mb-3 position-relative">
                            <i class="fa fa-user form-icon"></i>
                            <input type="text" class="form-control" name="usuario" placeholder="Usuario" required />
                        </div>

                        <div class="mb-3 position-relative">
                            <i class="fa fa-lock form-icon"></i>
                            <input type="password" class="form-control" name="contrasena" placeholder="Contraseña" required />
                        </div>

                        <div class="mb-3 text-end">
                            <a href="Recuperar.aspx" class="text-decoration-none text-primary">¿Olvidó su contraseña?</a>
                        </div>

                        <div class="d-grid">
                            <button type="submit" class="btn btn-primary btn-lg login-button">Ingresar</button>
                        </div>
                    </form>
                </div>
            </div>

            <!-- PANEL DERECHO -->
            <div class="col-md-6 right-panel">
                <img src="/img/dentista.jpg" alt="Doctor" class="bg-image" />
                        <div class="welcome-overlay text-white text-justify px-4">
                                                <div class="text-center mb-3">
                         <img src="/img/LogoBlanco.png" alt="Logo DentaCare"
                         class="d-block mx-auto"
                         style="max-height: 60px; height: auto; margin-bottom: 16px; padding: 0;" />


                    </div>

                            <div style="background-color: rgba(255, 255, 255, 0.05); padding: 20px; border-left: 4px solid white; border-radius: 4px; text-align: justify;">

                                <h5 class="mb-2">Bienvenido a <strong>DentaCare</strong></h5>
                                <p class="mb-0" style="font-size: 15px;">
                                    Sistema web de gestión dental de la clínica <strong>SisaDent</strong><br />
                                    Gestione sus citas, revise su historial clínico y manténgase en contacto con su profesional de confianza.
                                </p>
                            </div>
                       </div>


            </div>

        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/js/all.min.js"></script>
</body>
</html>
