using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
Articulo objArticulo = new Articulo();
objArticulo.Nombre = "Mesa";
objArticulo.Costo = 500;
Articulo objArticulo1 = new Articulo();
objArticulo1.Nombre = "Repisa";
objArticulo1.Costo = 600;


ListaDePrecio objListaDePrecio = new ListaDePrecio();
objListaDePrecio.Precio = 250;
objListaDePrecio.EsMayorista =  true;
objListaDePrecio.EsMayorista = !objListaDePrecio.EsMayorista;



        Console.WriteLine($"--- Datos del Producto ---");
        Console.WriteLine($"Nombre: {objArticulo.Nombre}");
        Console.WriteLine($"Costo: {objArticulo.Costo}");
        Console.WriteLine($"Nombre: {objArticulo1.Nombre}");
        Console.WriteLine($"Costo: {objArticulo1.Costo}");
        Console.WriteLine("\n--- LISTA DE PRECIOS ---");
        Console.WriteLine($"Nombre: {objArticulo.Nombre}");
        Console.WriteLine($"Mayorista:{objListaDePrecio.EsMayorista}");
        Console.WriteLine($"Precio:{objListaDePrecio.Precio}");

    }
}
public class Articulo
{
    private string _nombre;
    private float _costo;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public float Costo
    {
        get { return _costo; }
        set { _costo = value; }
    }

}
public class ListaDePrecio
{
    private bool _mayorista;
    private bool _minorista;
    private float _precio;

    public bool EsMayorista
    {
        get { return _mayorista; }
        set { _mayorista = value; }
    }
    public bool EsMinorista
    {
        get { return _minorista; }
        set { _minorista = value; }
    }
    public float Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

}