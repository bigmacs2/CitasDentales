/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;

import java.util.*;

public class Tratamiento {

    /**
     * @return the tipo_tratamiento
     */
    public TipoTratamiento getTipo_tratamiento() {
        return tipo_tratamiento;
    }

    /**
     * @param tipo_tratamiento the tipo_tratamiento to set
     */
    public void setTipo_tratamiento(TipoTratamiento tipo_tratamiento) {
        this.tipo_tratamiento = tipo_tratamiento;
    }

    /**
     * @return the id_tratamiento
     */
    public String getId_tratamiento() {
        return id_tratamiento;
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
     * @return the descripcion
     */
    public String getDescripcion() {
        return descripcion;
    }

    /**
     * @param descripcion the descripcion to set
     */
    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    /**
     * @return the costo_base
     */
    public double getCosto_base() {
        return costo_base;
    }

    /**
     * @param costo_base the costo_base to set
     */
    public void setCosto_base(double costo_base) {
        this.costo_base = costo_base;
    }
    
    private static int correlativo=0;
    private String id_tratamiento;
    private String nombre;
    private String descripcion;
    private double costo_base;
    private TipoTratamiento tipo_tratamiento;
    
    public Tratamiento(String nombre, String descripcion, double costo_base,
                       TipoTratamiento tipo_tratamiento){
        correlativo++;
        this.id_tratamiento=String.format("TRAT%d", correlativo);
        this.nombre=nombre;
        this.descripcion=descripcion;
        this.costo_base=costo_base;
        this.tipo_tratamiento=tipo_tratamiento;
    }
    
    public void tratamiento_mas_demandado(){
        
    }
}
