using System;

namespace Ejercicios05Punto04Version01
{
    class Program
    {
        static void Main(string[] args)
        {
			var sumaAzar=0;//variable de tipo entero para acumular los nros generados
            var contadorNros = 0;//variable de tipo entero para cotnar los nros generados
            //Random es un objeto que genera nros al azar
            //Para poderlo utilizar lo debo instanciar primero
            //Debo crear un objeto de tipo random y asignarlo a una variable
            Random r=new Random();//Creación de una variable r de tipo Random (al azar)
            do
            {
                /*El método Next del objeto Random
                 genera números al azar entre el menor y uno menos que el mayor
                la sintaxis es siempre r.Next(nMenor, nMayor)*/
                var nroAzar=r.Next(1, 101);//Genera el nro al azar entre 1 y 100
                Console.WriteLine($"{nroAzar}");//Muestro el nro generado
                sumaAzar += nroAzar;//lo acumulo
                contadorNros++;//lo cuento
            } while (sumaAzar<=1000);//controlo para salir o seguir en el ciclo
            
            Console.WriteLine($"La suma de nros al azar es {sumaAzar}");
            Console.WriteLine($"Se generaron {contadorNros} números");
		}
    }
}
