/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.proyectocitasdental.citas;
import java.util.*;
import pe.edu.pucp.proyectocitasdental.usuarios.*; 

public class Cita {

    /**
     * @return the id_cita
     */
    public String getId_cita() {
        return id_cita;
    }

    /**
     * @return the fecha_y_hora
     */
    public Date getFecha_y_hora() {
        return fecha_y_hora;
    }

    /**
     * @param fecha_y_hora the fecha_y_hora to set
     */
    public void setFecha_y_hora(Date fecha_y_hora) {
        this.fecha_y_hora = fecha_y_hora;
    }

    /**
     * @return the observaciones
     */
    public String getObservaciones() {
        return observaciones;
    }

    /**
     * @param observaciones the observaciones to set
     */
    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }

    /**
     * @return the estado
     */
    public EstadoCita getEstado() {
        return estado;
    }

    /**
     * @param estado the estado to set
     */
    public void setEstado(EstadoCita estado) {
        this.estado = estado;
    }

    /**
     * @return the pago_realizado
     */
    public Boolean getPago_realizado() {
        return pago_realizado;
    }

    /**
     * @param pago_realizado the pago_realizado to set
     */
    public void setPago_realizado(Boolean pago_realizado) {
        this.pago_realizado = pago_realizado;
    }

    /**
     * @return the monto
     */
    public double getMonto() {
        return monto;
    }

    /**
     * @param monto the monto to set
     */
    public void setMonto(double monto) {
        this.monto = monto;
    }
    private static int num_correlativo = 0;
<<<<<<< HEAD
    private String id_cita;
=======
    private int id_cita;
>>>>>>> origin/main
    private Paciente paciente;
    private Odontologo odontologo;
    private Date fecha_y_hora;//investigar datetime
    private String observaciones;
    private EstadoCita estado;
    private Boolean pago_realizado;
    private Tratamiento tratamiento;
    private double monto;
    private int duracion;//en minutos
    //enum metodo de pago
    
    public Cita(Paciente paciente, Odontologo odontologo, Date fecha_y_hora, 
            Tratamiento tratamiento, int duracion, String observaciones){
        
        num_correlativo++;
<<<<<<< HEAD
        this.id_cita=String.format("CIT%d", num_correlativo);
=======
        this.id_cita=num_correlativo;
>>>>>>> origin/main
        this.paciente=paciente;
        this.odontologo=odontologo;
        this.fecha_y_hora=fecha_y_hora;
        this.tratamiento=tratamiento;
        this.duracion=duracion;
        this.observaciones=observaciones;
        this.estado=EstadoCita.PENDIENTE;
        this.pago_realizado=false;
        this.monto=tratamiento.getCosto_base();
    }
    
}
