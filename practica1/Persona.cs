using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }


        public void despliegaNombre()
        {
            Console.WriteLine("El nombre es: {0}", Nombre);
        }

        public void despliegaEdad()
        {
            Console.WriteLine("La edad del Alumno es: {0} ", Edad);
            
        }

       
    }
}
