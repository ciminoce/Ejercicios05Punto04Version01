using System;

namespace Ejercicios05Punto04Version01
{
    class Program
    {
        static void Main(string[] args)
        {
			var sumaAzar=0;
            var contadorNros = 0;
            int nroAzar;
            Random r=new Random();//Creación de una variable r de tipo Random (al azar)
            do
            {
                nroAzar=r.Next(1, 101);//Genera el nro al azar entre 1 y 100
                Console.WriteLine($"{nroAzar}");//Muestro el nro generado
                sumaAzar += nroAzar;//lo acumulo
                contadorNros++;//lo cuento
            } while (sumaAzar<=1000);//controlo para salir o seguir en el ciclo
            
            Console.WriteLine($"La suma de nros al azar es {sumaAzar}");
            Console.WriteLine($"Se generaron {contadorNros} números");
		}
    }
}
