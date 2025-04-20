/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;

import java.util.*;

public class Tratamiento {

    /**
     * @return the id_tratamiento
     */
    public int getId_tratamiento() {
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
    private int id_tratamiento;
    private String nombre;
    private String descripcion;
    private double costo_base;
    //enum tipo
    
    public Tratamiento(String nombre, String descripcion, double costo_base){
        correlativo++;
        this.id_tratamiento=correlativo;
        this.nombre=nombre;
        this.descripcion=descripcion;
        this.costo_base=costo_base;
    }
    
    
}
