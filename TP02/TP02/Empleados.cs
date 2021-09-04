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
        private string datosProfecionales;
        private int edad;
        private int antiguedad;
        private double salario;


        public string ApellidoYnombre { get => apellidoYnombre; set => apellidoYnombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public string DatosProfecionales { get => datosProfecionales; set => datosProfecionales = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public double Salario { get => salario; set => salario = value; }
        public int Dni { get => dni; set => dni = value; }
        

        public void crearEmpleado(string _apellidoYnombre, DateTime _fechaNac, int _dni, string _direccion, DateTime _ingreso, string _datosProfecionales)
        {
            this.ApellidoYnombre = _apellidoYnombre;
            this.fechaNac = _fechaNac;
            this.dni = _dni;
            this.direccion = _direccion;
            this.Ingreso = _ingreso;
            this.datosProfecionales = _datosProfecionales;

            //---Edad Y Antiguedad----//
            this.edad = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1;
            this.antiguedad = DateTime.Today.AddTicks(-ingreso.Ticks).Year - 1;

            //-----Salario-----//
            double sueldoBasico = 28000;
            double adicional;
            double descuento = (sueldoBasico * 15) / 100;

            if (antiguedad >= 1 && antiguedad < 20)
            {
                adicional = (sueldoBasico * antiguedad) / 100;
                salario = sueldoBasico + adicional - descuento;
            }
            if (antiguedad >= 20)
            {
                adicional = (sueldoBasico * 25) / 100;
                salario = sueldoBasico + adicional - descuento;
            }
            else
            {
                salario = sueldoBasico - descuento;
            }
        }
    }
}
