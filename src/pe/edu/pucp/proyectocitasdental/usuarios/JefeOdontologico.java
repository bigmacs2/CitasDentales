/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;

import java.util.*;

public class JefeOdontologico extends Usuario {

    /**
     * @return the id_jefe_odontologico
     */
    public String getId_jefe_odontologico() {
        return id_jefe_odontologico;
    }

    /**
     * @param id_jefe_odontologico the id_jefe_odontologico to set
     */
    public void setId_jefe_odontologico(String id_jefe_odontologico) {
        this.id_jefe_odontologico = id_jefe_odontologico;
    }

    private String id_jefe_odontologico;
    private Turno turno;

    
    public JefeOdontologico(String nombres, String apellidos, int dni, int telefono, 
                    String email, String direccion, Date fecha_nacimiento, 
                    char sexo, Turno turno) {
        super(nombres, apellidos, dni, telefono, email, direccion, 
              fecha_nacimiento, sexo);
        this.id_jefe_odontologico=String.format("JEFEODN%d", super.getId_usuario());
        this.turno=turno;
    }
    
    
    
<<<<<<< HEAD
}
=======
}
>>>>>>> origin/main
