/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;
import java.util.*;
/**
 *
 * @author egm14
 */
public class Lote {

    /**
     * @return the correlativo
     */
    public static int getCorrelativo() {
        return correlativo;
    }

    /**
     * @param aCorrelativo the correlativo to set
     */
    public static void setCorrelativo(int aCorrelativo) {
        correlativo = aCorrelativo;
    }

    /**
     * @return the id_lote
     */
    public String getId_lote() {
        return id_lote;
    }

    /**
     * @param id_lote the id_lote to set
     */
    public void setId_lote(String id_lote) {
        this.id_lote = id_lote;
    }

    /**
     * @return the stock_dispo
     */
    public int getStock_dispo() {
        return stock_dispo;
    }

    /**
     * @param stock_dispo the stock_dispo to set
     */
    public void setStock_dispo(int stock_dispo) {
        this.stock_dispo = stock_dispo;
    }

    /**
     * @return the stock_min
     */
    public int getStock_min() {
        return stock_min;
    }

    /**
     * @param stock_min the stock_min to set
     */
    public void setStock_min(int stock_min) {
        this.stock_min = stock_min;
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

    /**
     * @return the material
     */
    public Material getMaterial() {
        return material;
    }

    /**
     * @param material the material to set
     */
    public void setMaterial(Material material) {
        this.material = material;
    }
    private static int correlativo=0;
    private String id_lote;
    private int stock_dispo;
    private int stock_min;
    private Date fecha_vencimiento;
    private Material material;
    
    public Lote(int stock_dispo, int stock_min, Date fecha_vencimiento, 
                Material material){
        correlativo++;
        this.id_lote=String.format("LOTE%d", correlativo);
        this.stock_dispo=stock_dispo;
        this.stock_min=stock_min;
        this.fecha_vencimiento=fecha_vencimiento;
        this.material=material;
    }
}
