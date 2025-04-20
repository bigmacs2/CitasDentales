/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;
import pe.edu.pucp.proyectocitasdental.citas.*;
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


    private String id_asistente_mostrador;
    private Turno turno;

    
    public AsistenteMostrador(String nombres, String apellidos, int dni, int telefono, 
                    String email, String direccion, Date fecha_nacimiento,char sexo,Turno turno) {
        super(nombres, apellidos, dni, telefono, email, direccion, 
              fecha_nacimiento, sexo);
        this.id_asistente_mostrador=String.format("ASTMST%d", super.getId_usuario());
        this.turno=turno;
    }
    
    
}
