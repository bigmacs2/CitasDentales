/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import java.util.*;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;

public class Paciente extends Usuario {

    /**
     * @return the id_paciente
     */
    public String getId_paciente() {
        return id_paciente;
    }

    /**
     * @param id_paciente the id_paciente to set
     */
    public void setId_paciente(String id_paciente) {
        this.id_paciente = id_paciente;
    }

    /**
     * @return the alergias
     */
    public ArrayList<String> getAlergias() {
        return alergias;
    }

    /**
     * @param alergias the alergias to set
     */
    public void setAlergias(ArrayList<String> alergias) {
        this.alergias = alergias;
    }

   
    private String id_paciente;
    private ArrayList<String> alergias;
    private ArrayList<String> condiciones_previas;
   

    public Paciente(String nombres, String apellidos, int dni, int telefono, 
                    String email, String direccion, Date fecha_nacimiento, 
                    char sexo, ArrayList<String> alergias,ArrayList<String>condiciones_previas) {
        super(nombres, apellidos, dni, telefono, email, direccion, 
              fecha_nacimiento, sexo);
        this.id_paciente=String.format("PAC%2d", super.getId_usuario());//PAC01
        this.alergias=alergias;
        this.condiciones_previas=condiciones_previas;
        
    }
}
