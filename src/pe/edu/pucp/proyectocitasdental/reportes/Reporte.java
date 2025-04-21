/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.reportes;
import pe.edu.pucp.proyectocitasdental.reportes.Ireporte;
import java.util.*;

public abstract class Reporte implements Ireporte {

    /**
     * @return the id_reporte
     */
    public int getId_reporte() {
        return id_reporte;
    }

    /**
     * @param id_reporte the id_reporte to set
     */
    public void setId_reporte(int id_reporte) {
        this.id_reporte = id_reporte;
    }

    /**
     * @return the tipo
     */
    public TipoReporte getTipo() {
        return tipo_reporte;
    }

    /**
     * @param tipo the tipo to set
     */
    public void setTipo(TipoReporte tipo) {
        this.tipo_reporte = tipo;
    }

    /**
     * @return the fecha_generacion
     */
    public Date getFecha_generacion() {
        return fecha_generacion;
    }

    /**
     * @param fecha_generacion the fecha_generacion to set
     */
    public void setFecha_generacion(Date fecha_generacion) {
        this.fecha_generacion = fecha_generacion;
    }

    /**
     * @return the periodo
     */
    public String getPeriodo() {
        return periodo;
    }

    /**
     * @param periodo the periodo to set
     */
    public void setPeriodo(String periodo) {
        this.periodo = periodo;
    }
    private static int correlativo = 0;
    private int id_reporte;
<<<<<<< HEAD
    private TipoReporte tipo_reporte;//ENUM
=======
    private String tipo;//ENUM
>>>>>>> origin/main
    private Date fecha_generacion;
    private String periodo;
    
    public Reporte(TipoReporte tipo_reporte, Date fecha_generacion, String periodo){
        correlativo++;
        this.id_reporte=correlativo;
        this.tipo_reporte=tipo_reporte;
        this.fecha_generacion=fecha_generacion;
    }
    
    
    public abstract String devolverReporte();
    
}
