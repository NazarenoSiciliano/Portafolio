using System;
using System.Diagnostics.Contracts;
using System.Reflection;

public class Persona
{
    public string nombre;
    public string apellido;

}

class program
{
    static void Main ()
    {
         Persona alguien= new Persona();
         alguien.nombre = "Nazareno";
         alguien.apellido = "Siciliano";
         Console.WriteLine("Datos de las personas");
         Console.WriteLine("Nombre:"+ alguien.nombre);
         Console.WriteLine("Apellido:"+ alguien.apellido);
         Console.ReadLine();
        
    }
   

}