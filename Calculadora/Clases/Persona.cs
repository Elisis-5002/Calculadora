using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Persona
    {
        
        private string nombre ="";
        private string apellido="";
        private DateTime fechaNac;
        private int edad;
        
    public string Nombre{ get => nombre; set =>nombre = value; }
        public string Apelllido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        public int Edad{ 
            get => edad = DateTime.Now.Year - FechaNac.Year; 
            set => edad = value; }



    }
}
