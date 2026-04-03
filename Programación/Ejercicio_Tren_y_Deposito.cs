
namespace Trenes
{
using System;
    using System.Security.Cryptography.X509Certificates;

    namespace Trenes
{
    
    public class _Locomotora
    {
        public const int _LcPeso = 1000;
        public const int _LcVelMax = 80;
        public const int _LcPesoMax = 11000;
        public const int _Efilocomotora = _LcPeso * 5;
    } 
    
    public class _VagonPasaje : _Vagon
    {
        public double _AnchoVaPa { get; set; }
        public double _LargoVaPa { get; set; }

        public int Calcular_Pasajero()
        {
            if (_AnchoVaPa <= 2.5)
            {
                return (int)(_LargoVaPa * 8);
            }
            else
            {
                return (int)(_LargoVaPa * 10);
            }
        }
        public override int Calcular_PesoTotal() 
    {
        int Cantidad_Pasajero = Calcular_Pasajero();
        return Cantidad_Pasajero * 80;
    }

        public int Calcular_Peso()
        {
            int Cantidad_Pasajero = Calcular_Pasajero();
            return Cantidad_Pasajero * 80;
        }
    } 

    // 3. CLASE VAGON CARGA
    public class _VagonCarga : _Vagon
    {
        public int _PesoVaCa { get; set; }
        public override int Calcular_PesoTotal() 
    {
        return _PesoVaCa + 160;
    }
        public int _PesoMaximoVaCa
        {
            get
            {
                return _PesoVaCa + 160;
            }
        }
    }
    public abstract class _Vagon
        {
          public abstract int Calcular_PesoTotal();
        }
        public class _Formacion
{
    public List<_Vagon> Vagones { get; set; } = new List<_Vagon>();
    public List<_Locomotora> Locomotoras { get; set; } = new List<_Locomotora>();

    // Primero, un método de ayuda para calcular el peso total de TODO el tren
    public int Calcular_PesoTotal()
    {
        int pesoTotal = 0;

        // Sumamos el peso de todas las locomotoras (asumiendo que tienen un _LcPesoMax o similar)
        foreach (var loco in Locomotoras)
        {
            pesoTotal += _Locomotora._LcPeso; // Asegurate de usar la variable correcta de tu clase
        }

        // Sumamos el peso de todos los vagones
        foreach (var vagon in Vagones)
        {
            pesoTotal += vagon.Calcular_PesoTotal(); 
        }

        return pesoTotal;
    }

    // AHORA SÍ: Validamos si la formación es compleja (Más de 20 unidades O más de 10.000 kg)
    public bool EsCompleja()
    {
        int cantidadUnidades = Locomotoras.Count + Vagones.Count;
        int pesoTotal = Calcular_PesoTotal();

        // El símbolo || significa "O" en C#
        if (cantidadUnidades > 20 || pesoTotal > 10000)
        {
            return true; // Es compleja
        }
        else
        {
            return false; // No es compleja
        }
    }
}
public class _Deposito
{
    public List<_Formacion> Formaciones { get; set; } = new List<_Formacion>();

    public bool NecesitaConductorExperimentado()
    {
        // Revisamos tren por tren en el depósito
        foreach (var formacion in Formaciones)
        {
            // Le preguntamos a la formación si es compleja usando su propio método
            if (formacion.EsCompleja() == true)
            {
                // Con que UNA SOLA sea compleja, ya devolvemos true y se corta el ciclo.
                // ¡Avisamos que llamen al conductor experto!
                return true; 
            }
        }

        // Si terminó de revisar todas las formaciones y ninguna dio true...
        return false; 
    }
}
class App
{
    static void Main ()
    {
        
        _VagonPasaje VagonPasaje1= new _VagonPasaje();
        VagonPasaje1. _AnchoVaPa = 10;
        VagonPasaje1. _LargoVaPa = 20;
        
        int pesovagon= VagonPasaje1.Calcular_Peso ();
        int _efiLoco= _Locomotora._Efilocomotora;
        _VagonCarga vagonCarga1= new _VagonCarga();
        vagonCarga1. _PesoVaCa= 24000;
        int peso_Max= VagonPasaje1.Calcular_Peso() + _Locomotora._LcPeso + vagonCarga1._PesoMaximoVaCa;
        int arratre_util= _Locomotora._LcPesoMax*2;
        int kilosEmpuje= arratre_util- peso_Max ;
        int VelMaxTren= Math.Min(_Locomotora._LcVelMax + 100, _Locomotora._LcVelMax);
        _Deposito miDeposito = new _Deposito();
        _Formacion formacion1 = new _Formacion();
        formacion1.Locomotoras.Add(new _Locomotora());  
        formacion1.Vagones.Add(VagonPasaje1);
        formacion1.Vagones.Add(vagonCarga1);
        miDeposito.Formaciones.Add(formacion1);
        
        Console.WriteLine("1.El total de pasajeros que lleva es:"+ VagonPasaje1.Calcular_Pasajero());
        if(pesovagon<2500)
                {
                    Console.WriteLine("2.El vagon de pasajeros es Liviano:"+pesovagon);
                }
                else 
                {
                    Console.WriteLine("2.El vagon de pasajeros es Pesado:"+pesovagon);
                }
        if(vagonCarga1._PesoMaximoVaCa<2500)
                {
                    Console.WriteLine("2.El vagon de Carga es Liviano:"+vagonCarga1._PesoMaximoVaCa);
                }
                else 
                {
                    Console.WriteLine("2.El vagon de Carga es Pesado:"+vagonCarga1._PesoMaximoVaCa);
                }
         Console.WriteLine("3.La velocida de la formacion es: "+ VelMaxTren+"km/h");
                
        
        if(peso_Max>_efiLoco)
            {
                Console.WriteLine("4.La locomotora esta siendo eficiente");
            }
            else
            {
                Console.WriteLine("4.La locomotora no esta siendo eficiente");
            }
            if (peso_Max<arratre_util)
                {
                    Console.WriteLine("5.La formacion puede moverse");
                }
                else
                {
                    Console.WriteLine("5.La formacion no puede moverse");
                }
        
            Console.WriteLine("6.Los kilos de empuje de la formacion faltante son:"+ kilosEmpuje);
            if (miDeposito.NecesitaConductorExperimentado())
{
    Console.WriteLine("8.¡Alerta! Llamen a un conductor experimentado.");
}
else
{
    Console.WriteLine("8.Todo tranquilo, cualquier conductor puede manejar hoy.");
}    
    }

}
}
}