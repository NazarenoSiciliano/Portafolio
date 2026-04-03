using System;
using System.Collections.Generic; // Necesario para usar List<>

namespace Trabajo
{
    public class Empleado
    {
        public string _nombre { get; set; }
        public int _numeroLegajo { get; set; }
        
        // Es una buena práctica agregar el método en la clase base como virtual 
        // para que las clases hijas lo puedan sobrescribir si es necesario.
        public abstract decimal CalcularSueldo() 
        {
            return 0;
        }
    }

    public class EmpleadoMensual : Empleado
    {
        public decimal _sueldoFijo { get; set; }

        public override decimal CalcularSueldo()
        {
            return _sueldoFijo;
        }
    }

    public class EmpleadoPorHora : Empleado
    {
        public int _horasTrabajadas { get; set; }
        public decimal _valorHora { get; set; }

        public override decimal CalcularSueldo()
        {
            // No necesitas un foreach acá, solo multiplicar las horas por el valor
            return _horasTrabajadas * _valorHora; 
        }
    } // ¡Acá faltaba cerrar la clase!

    public class Lista
    {
        public List<Empleado> _lista { get; set; }

        public Lista()
        {
            _lista = new List<Empleado>();
        }
    } // ¡Acá también faltaba cerrar la clase!

    class Program
    {
        static void Main()
        {
            Lista miLista = new Lista();

            // 1. Instanciamos a Carlos como EmpleadoMensual
            EmpleadoMensual empleado1 = new EmpleadoMensual();
            empleado1._nombre = "Carlos";
            empleado1._numeroLegajo = 27285;
            empleado1._sueldoFijo = 35000;

            // 2. Instanciamos a Juana como EmpleadoPorHora
            EmpleadoPorHora empleado2 = new EmpleadoPorHora();
            empleado2._nombre = "Juana";
            empleado2._numeroLegajo = 34578;
            empleado2._horasTrabajadas = 45;
            empleado2._valorHora = 500;

            // Agregamos ambos empleados a la lista general
            miLista._lista.Add(empleado1);
            miLista._lista.Add(empleado2);

            // Calculamos y mostramos los sueldos
            decimal totalCarlos = empleado1.CalcularSueldo();
            Console.WriteLine($"El sueldo de Carlos es de: ${totalCarlos}");

            decimal totalJuana = empleado2.CalcularSueldo();
            Console.WriteLine($"El sueldo de Juana es de: ${totalJuana}");
        }
    }
}