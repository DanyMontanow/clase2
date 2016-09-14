using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciar objetos
            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();


            //Alimentar las propiedades de las clases
            _alumno.Edad = 17;
            _alumno.Nombre = "Gabriel";
            _alumno.NumeroControl = 10211117;
            _alumno.Grupo = "5IM";

            _profesor.Edad = 23;
            _profesor.Nombre = "Erick";
            _profesor.Sueldo = 5;
            _profesor.Materia = "Programación Orientada a objetos";


            //Metodos de la clase Persona
            _profesor.despliegaNombre();
            _alumno.despliegaNombre();


            //Despliegue de la información.
            Console.WriteLine("\n\n\nProfesor \n\n El nombre  es: {0} \n La edad es: {1} \n EL sueldo es: {2} \n La materia es: {3} ", _profesor.Nombre, _profesor.Edad,_profesor.Sueldo,_profesor.Materia);
            Console.WriteLine("\n\n\nAlumno \n\n El nombre  es: {0} \n La edad es: {1} \n EL numero de Control es: {2} \n El grupo es es: {3} ", _alumno.Nombre, _alumno.Edad, _alumno.NumeroControl, _alumno.Grupo);
             


            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
