using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02
{
    public class Empleados
    {
        private string apellidoYnombre;
        private DateTime fechaNac;
        private int dni;
        private string direccion;
        private DateTime ingreso;
        private int edad;
        private int antiguedad;
        private double salario;

        public string ApellidoYnombre { get => apellidoYnombre; set => apellidoYnombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public double Salario { get => salario; set => salario = value; }

        public void crearEmpleado(string _apellidoYnombre, DateTime _fechaNac, int _dni, string _direccion, DateTime _ingreso)
        {
            this.ApellidoYnombre = _apellidoYnombre;
            this.FechaNac = _fechaNac;
            this.Dni = _dni;
            this.Direccion = _direccion;
            this.Ingreso = _ingreso;


            //---Edad Y Antiguedad----//
            this.Edad = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1;
            this.Antiguedad = DateTime.Today.AddTicks(-Ingreso.Ticks).Year - 1;

            //-----Salario-----//
            double sueldoBasico = 28000;
            double adicional;
            double descuento = (sueldoBasico * 15) / 100;

            if (Antiguedad >= 1 && Antiguedad < 20)
            {
                adicional = (sueldoBasico * Antiguedad) / 100;
                Salario = sueldoBasico + adicional - descuento;
            }
            if (Antiguedad >= 20)
            {
                adicional = (sueldoBasico * 25) / 100;
                Salario = sueldoBasico + adicional - descuento;
            }
            else
            {
                Salario = sueldoBasico - descuento;
            }
        }
    }
}
