/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;
import java.util.*;

public class AsistenteMostrador extends Usuario {

    /**
     * @return the id_asistente_mostrador
     */
    public String getId_asistente_mostrador() {
        return id_asistente_mostrador;
    }

    /**
     * @param id_asistente_mostrador the id_asistente_mostrador to set
     */
    public void setId_asistente_mostrador(String id_asistente_mostrador) {
        this.id_asistente_mostrador = id_asistente_mostrador;
    }

    /**
     * @return the hora_entrada
     */
    public int getHora_entrada() {
        return hora_entrada;
    }

    /**
     * @param hora_entrada the hora_entrada to set
     */
    public void setHora_entrada(int hora_entrada) {
        this.hora_entrada = hora_entrada;
    }

    /**
     * @return the hora_salida
     */
    public int getHora_salida() {
        return hora_salida;
    }

    /**
     * @param hora_salida the hora_salida to set
     */
    public void setHora_salida(int hora_salida) {
        this.hora_salida = hora_salida;
    }
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
