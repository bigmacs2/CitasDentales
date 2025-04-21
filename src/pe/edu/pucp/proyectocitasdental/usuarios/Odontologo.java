/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import java.util.*;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;
import pe.edu.pucp.proyectocitasdental.usuarios.Turno;

public class Odontologo extends Usuario {

    /**
     * @return the id_odontologo
     */
    public String getId_odontologo() {
        return id_odontologo;
    }

    /**
     * @param id_odontologo the id_odontologo to set
     */
    public void setId_odontologo(String id_odontologo) {
        this.id_odontologo = id_odontologo;
    }

    /**
     * @return the especialidad
     */
    public String getEspecialidad() {
        return especialidad;
    }

    /**
     * @param especialidad the especialidad to set
     */
    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }



    /**
     * @return the anios_de_experiencia
     */
    public int getAnios_de_experiencia() {
        return anios_de_experiencia;
    }

    /**
     * @param anios_de_experiencia the anios_de_experiencia to set
     */
    public void setAnios_de_experiencia(int anios_de_experiencia) {
        this.anios_de_experiencia = anios_de_experiencia;
    }
    private String id_odontologo;
    private String especialidad;
    private int anios_de_experiencia;
    private Turno turno;
    
    public Odontologo(String nombres, String apellidos, int dni, int telefono, 
                    String email, String direccion, Date fecha_nacimiento, 
                    char sexo, String especialidad,int anios_de_experiencia,Turno turno){
        super(nombres, apellidos, dni, telefono, email, direccion, 
              fecha_nacimiento, sexo);
        this.id_odontologo=String.format("ODONTO%d", super.getId_usuario());
        this.especialidad=especialidad;
        this.turno=turno;
        this.anios_de_experiencia=anios_de_experiencia;
    }
}
