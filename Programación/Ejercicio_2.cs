using System;

public class Vehiculo
{
    public string marca;
    public string modelo;
    private string patente;
}

class programa
{
    static void Main()
    {
        Vehiculo auto = new Vehiculo();
        auto.marca = "Toyota";
        auto.modelo= "2026";
         Console.WriteLine("Datos del Vehiculo");
         Console.WriteLine("Nombre:"+ auto.marca);
         Console.WriteLine("Apellido:"+ auto.modelo);
        
    }
}