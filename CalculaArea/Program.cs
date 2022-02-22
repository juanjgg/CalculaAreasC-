using CalculaArea.models;
using System;

namespace CalculaArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionFigura;
            Console.WriteLine("Bienvenido al programa Calcula tu Area");
            Console.WriteLine("escriba el numero que correponde al area que desea calcular");
            Console.WriteLine("1 = Circulo");
            Console.WriteLine("2 = Rectangulo");
            opcionFigura = int.Parse(Console.ReadLine());

            if (opcionFigura == 1)
            {
                double radio;
                Console.WriteLine("por favor ingrese el radio del Circulo");
                radio = double.Parse(Console.ReadLine());
                Circulo circulo = new Circulo(radio);
                Console.WriteLine("El area del circulo de radio {0} es: {1} \n", radio, circulo.Area());

            }
            else if (opcionFigura == 2)
            {
                double ancho, largo;
                Console.WriteLine("por favor ingrese el ancho del rectangulo");
                ancho = double.Parse(Console.ReadLine());
                Console.WriteLine("por favor ingrese el largo del rectangulo");
                largo = double.Parse(Console.ReadLine());
                Regtangulo rectangulo = new Regtangulo(ancho, largo);
                Console.WriteLine("El area del rectangulo de ancho {0} y largo {1} es: {2} \n", ancho, largo, rectangulo.Area());


            }
            else
            {
                Console.WriteLine("por favor toma una de las opciones validas \n Enter para Continuar");
                Console.ReadLine();
                Main(args);
            }

            Main(args);
        }
    }
}
