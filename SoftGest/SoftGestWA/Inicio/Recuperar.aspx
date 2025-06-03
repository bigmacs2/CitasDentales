<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recuperar.aspx.cs" Inherits="SoftGestWA.Recuperar" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Mis Citas - DentaCare</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        body {
            background-color: #f9f9f9;
        }
        .header {
            background-color: #ffffff;
            border-bottom: 1px solid #ddd;
            padding: 1rem;
        }
        .header h1 {
            font-size: 1.5rem;
            color: #0d6efd;
        }
        .citas-box {
            background-color: white;
            border: 1px solid #ddd;
            border-radius: 10px;
            padding: 20px;
            margin-top: 20px;
        }
        .cita-item {
            border-left: 5px solid #0d6efd;
            padding: 10px 15px;
            margin-bottom: 15px;
            background-color: #f0f4ff;
            border-radius: 5px;
        }
        .footer {
            font-size: 0.8rem;
            text-align: center;
            margin-top: 40px;
            color: #888;
        }
    </style>
</head>
<body>

    <div class="container">
        <!-- Encabezado -->
        <div class="d-flex justify-content-between align-items-center header">
            <div>
                <img src="logo.png" alt="Logo DentaCare" style="height: 30px;">
                <span class="ms-2 fw-bold">DentaCare</span>
            </div>
            <div>
                <a href="#" class="me-3">Mis Citas</a>
                <a href="#" class="me-3">Historial</a>
                <a href="#" class="me-3"><i class="bi bi-person"></i> Perfil</a>
                <a href="#">Salir</a>
            </div>
        </div>

        <!-- Contenido principal -->
        <div class="text-center mt-4">
            <h1 class="text-primary">¡Bienvenido!</h1>
            <p class="text-muted">Paciente [Nombre]</p>
            <p class="text-secondary">Mis citas programadas para la semana</p>
            <p><strong>08 - 14 de mayo de 2025</strong></p>
        </div>

        <!-- Listado de Citas -->
        <div class="citas-box">
            <div class="cita-item">
                <strong>Examen dental</strong> — Lunes 08 de mayo, 08:00 AM
            </div>
            <div class="cita-item">
                <strong>Limpieza dental</strong> — Lunes 08 de mayo, 09:00 AM
            </div>
            <div class="cita-item">
                <strong>Consulta</strong> — Miércoles 10 de mayo, 10:00 AM
            </div>
            <div class="cita-item">
                <strong>Evaluación</strong> — Jueves 11 de mayo, 09:00 AM
            </div>
            <div class="cita-item">
                <strong>Revisión</strong> — Jueves 11 de mayo, 11:00 AM
            </div>
        </div>

        <!-- Pie de página -->
        <div class="footer mt-5">
            DentaCare es el aplicativo web de la clínica dental SisaDent
        </div>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

