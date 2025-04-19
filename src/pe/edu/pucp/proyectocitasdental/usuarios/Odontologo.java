/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import java.util.*;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;

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
