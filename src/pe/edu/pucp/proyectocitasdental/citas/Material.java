/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;
import java.util.*;

public class Material {

    /**
     * @return the id_material
     */
    public String getId_material() {
        return id_material;
    }

    /**
     * @param id_material the id_material to set
     */
    public void setId_material(String id_material) {
        this.id_material = id_material;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the fecha_vencimiento
     */
    public Date getFecha_vencimiento() {
        return fecha_vencimiento;
    }

    /**
     * @param fecha_vencimiento the fecha_vencimiento to set
     */
    public void setFecha_vencimiento(Date fecha_vencimiento) {
        this.fecha_vencimiento = fecha_vencimiento;
    }
    private static int correlativo=0;
    private String id_material;
    private String nombre;
    private Date fecha_vencimiento;
    
    public Material(String nombre, Date fecha_vencimiento){
        correlativo++;
        this.id_material=String.format("MAT%d", correlativo);
        this.nombre=nombre;
        this.fecha_vencimiento=fecha_vencimiento;
    }
}
