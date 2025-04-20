/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.usuarios;
import pe.edu.pucp.proyectocitasdental.usuarios.Usuario;
import java.util.*;

public class JefeAlmacen extends Usuario {

    /**
     * @return the id_jefe_almacen
     */
    public String getId_jefe_almacen() {
        return id_jefe_almacen;
    }

    /**
     * @param id_jefe_almacen the id_jefe_almacen to set
     */
    public void setId_jefe_almacen(String id_jefe_almacen) {
        this.id_jefe_almacen = id_jefe_almacen;
    }

    private String id_jefe_almacen;
    private Turno turno;
    
    public JefeAlmacen(String nombres, String apellidos, int dni, int telefono, 
                    String email, String direccion, Date fecha_nacimiento, 
                    char sexo, Turno turno) {
        super(nombres, apellidos, dni, telefono, email, direccion, 
              fecha_nacimiento, sexo);
        this.id_jefe_almacen=String.format("JEFEALM%d",super.getId_usuario());
        this.turno=turno;
    }
    
}
