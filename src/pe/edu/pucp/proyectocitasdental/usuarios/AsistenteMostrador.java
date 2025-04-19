/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;
import java.util.*;

public class AsistenteMostrador extends Usuario {
    private String id_asistente_mostrador;
    private int hora_entrada;
    private int hora_salida;
    
    public AsistenteMostrador(String nombres, String apellidos, int dni, 
                              int telefono, String email, Date fecha_registro, 
                              Date fecha_nacimiento, Date ultimo_acceso, 
                              Boolean activo, int hora_entrada, int hora_salida) {
        super(nombres, apellidos, dni, telefono, email, fecha_registro, 
              fecha_nacimiento, ultimo_acceso, activo);
        this.id_asistente_mostrador=String.format("ASTMST%d", super.getId_usuario());
        this.hora_entrada=hora_entrada;
        this.hora_salida=hora_salida;
    }
}
