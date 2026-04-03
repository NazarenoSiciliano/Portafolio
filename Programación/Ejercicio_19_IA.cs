using System;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;






    public class Empleado
{
    public string _nombre { get; set; }
    public int _numeroLegajo { get; set; }

    public class EmpleadoMensual : Empleado
    {
        public decimal _sueldoFijo { get; set; }

    }

    public class EmpleadoPorHora : Empleado
    {
        public int _horasTrabajadas { get; set; }
        public decimal _valorHora { get; set; }
        public int CalcularSueldo()
        {
            return _horasTrabajadas * (int)_valorHora;
        }
    }
public class Lista
    {
        public List<Empleado> _lista { get; set; }
    
    public Lista()
    {
        _lista = new List<Empleado>();

    }

}

public decimal CalcularSueldo()
    {
        decimal total = 0;
        foreach (var _valorHora in EmpleadoPorHora)
        {
            total = _horasTrabajadas*_valorHora;
        } 
        return (decimal) total;
     }




}
class Program
{
    static void Main()
    {
 Lista miLista = new Lista();


        Empleado objEmpleado =new Empleado();
        objEmpleado._nombre= "Carlos";
        objEmpleado._numeroLegajo= 27285;

        Empleado objEmpleadp = new Empleado();
        objEmpleado._nombre= "Juana";
        objEmpleado._numeroLegajo= 34578;

Lista lista1 = new Lista();
lista1 _nombre= "Carlos";
lista1 _sueldoFijo= 35000;

Lista lista2 = new Lista();
lista2 _nombre= "Juana";
lista2 _horasTrabajadas= 45;
lista2 _valorHora= 500;

miLista._lista.Add(lista1);
miLista._lista.Add(lista2);


decimal total= lista1. CalcularSueldo();
Console.WriteLine($"El sueldo de Carlos es de: ${total}");
decimal total= lista2. CalcularSueldo();
Console.WriteLine($"El sueldo de Juana es de: ${total}");


    }
}