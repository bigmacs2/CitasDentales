/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import java.util.*;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;

public class Odontologo extends Usuario {
    private String id_odontologo;
    private String especialidad;
    private int hora_entrada;//Formato 24 horas
    private int hora_salida;//Formato 24 horas
    private int anios_de_experiencia;
    
    public Odontologo(String nombres, String apellidos, int dni, int telefono,
                   String email, Date fecha_registro, Date fecha_nacimiento,
                   Date ultimo_acceso, Boolean activo, String especialidad, 
                   int hora_entrada, int hora_salida, int anios_de_experiencia){
        super(nombres, apellidos, dni, telefono, email, fecha_registro, 
              fecha_nacimiento, ultimo_acceso, activo);
        this.id_odontologo=String.format("ODONTO%d", super.getId_usuario());
        this.especialidad=especialidad;
        this.hora_entrada=hora_entrada;
        this.hora_salida=hora_salida;
        this.anios_de_experiencia=anios_de_experiencia;
    }
}
