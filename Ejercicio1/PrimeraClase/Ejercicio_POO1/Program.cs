using System;
using Ejercicio_POO1.Modelos;
namespace Ejercicio_POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Diana";
            persona.Apellido = "Tacos";
            persona.Edad = 25;
            Persona persona2 = new Persona();
            persona2.Nombre = "Juan";
            persona2.Apellido = "Kastro";
            persona2.Edad = 32;
            NombreCompleto(persona,persona2);
        }

        private static void NombreCompleto(Persona persona, Persona persona2)
        {
            Console.WriteLine(persona.Nombre + " " + persona.Apellido);
            Console.WriteLine(persona.Edad);
            Console.WriteLine(persona2.Nombre + " " + persona2.Apellido);
            Console.WriteLine(persona2.Edad);
            Console.ReadLine();
        }
    }
}
