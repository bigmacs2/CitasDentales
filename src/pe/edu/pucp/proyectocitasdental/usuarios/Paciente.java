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
     * @return the direccion
     */
    public String getDireccion() {
        return direccion;
    }

    /**
     * @param direccion the direccion to set
     */
    public void setDireccion(String direccion) {
        this.direccion = direccion;
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

    /**
     * @return the seguro_dental
     */
    public Boolean getSeguro_dental() {
        return seguro_dental;
    }

    /**
     * @param seguro_dental the seguro_dental to set
     */
    public void setSeguro_dental(Boolean seguro_dental) {
        this.seguro_dental = seguro_dental;
    }
    
    private String id_paciente;
    private String direccion;
    private ArrayList<String> alergias;
    private Boolean seguro_dental;

    public Paciente(String nombres, String apellidos, int dni, int telefono, 
                    String email, Date fecha_registro, Date fecha_nacimiento, 
                    Date ultimo_acceso, Boolean activo, String direccion, 
                    ArrayList<String> alergias, Boolean seguro_dental) {
        super(nombres, apellidos, dni, telefono, email, fecha_registro, 
              fecha_nacimiento, ultimo_acceso, activo);
        this.id_paciente=String.format("PAC%d", super.getId_usuario());
        this.direccion=direccion;
        this.alergias=alergias;
        this.seguro_dental=seguro_dental;
    }
}
