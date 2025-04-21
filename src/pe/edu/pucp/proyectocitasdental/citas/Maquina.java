/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;
import java.util.*;

public class Maquina {
    private static int correlativo=0;
    private String id_maquina;
    private String nombre;
    private Date ultima_revision;
    private EstadoMaquina estado_maquina;
    private TipoMaquina tipo_maquina;
    
    public Maquina(String nombre,Date ultima_revision, 
            EstadoMaquina estado_maquina, TipoMaquina tipo_maquina){

        correlativo++;
        this.id_maquina=String.format("MAQ%d", correlativo);
        this.nombre=nombre;
        this.ultima_revision=ultima_revision;
        this.estado_maquina=estado_maquina;
        this.tipo_maquina=tipo_maquina;
        
    }
}
