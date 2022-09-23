using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        #region Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public string GetDni()
        {
            return this.dni;
        }
        #endregion

        #region Setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        #endregion

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            TimeSpan edad;
            DateTime fechaActual = DateTime.Now;

            edad = fechaActual - fechaDeNacimiento;

            return edad.Days / 365;
        }

        public string esMayorDeEdad(int edad)
        {
            string esMayor = "Es mayor de edad";

            if (edad < 18)
            {
                esMayor = "es menor";
            }

            return esMayor;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendFormat("{0} {1} {2} {3} {4}", this.GetNombre(), this.GetFechaNacimiento().ToString("dd/MM/yyyy"), this.GetDni(), this.CalcularEdad(this.GetFechaNacimiento()), this.esMayorDeEdad(this.CalcularEdad(this.GetFechaNacimiento())));

            return mensaje.ToString();
        }
    }
}
