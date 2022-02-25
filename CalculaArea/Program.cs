using CalculaArea.models;
using System;
using System.Text.RegularExpressions;

namespace CalculaArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[0-9]";
            string captura;
            string error = "El dato Ingresado debe ser numero";
             
            Regex rg = new Regex(pattern);

            int opcionFigura = 0;
            Console.WriteLine("Bienvenido al programa Calcula tu Area \n"
                + "escriba el numero que correponde al area que desea calcular\n"
                + " * presione (1) => Circulo\n * presione (2) => Rectangulo");
            captura = Console.ReadLine();

            opcionFigura = rg.IsMatch(captura) && captura.GetType() == opcionFigura.GetType() ? int.Parse(captura) : 0;


            if (opcionFigura == 1)
            {
                double radio;

                Console.WriteLine("por favor ingrese el radio del Circulo");
                captura = Console.ReadLine();
                radio = rg.IsMatch(captura) ? double.Parse(captura) : 0;

                if(radio == 0){ messageError(error + "\n Enter para volver al inicio"); Main(args); }

                Circulo circulo = new Circulo(radio);

                Console.WriteLine("El area del circulo de radio {0} es: {1} \n", radio, circulo.Area());

            }
            else if (opcionFigura == 2)
            {
                double ancho, largo;
                Console.WriteLine("por favor ingrese la base del rectangulo");
                captura = Console.ReadLine();
                ancho = rg.IsMatch(captura) ? double.Parse(captura) : 0;
                if (ancho == 0) { messageError(error + "\n Enter para volver al inicio"); Main(args); }
                Console.WriteLine("por favor ingrese la altura del rectangulo");
                captura = Console.ReadLine();
                largo = rg.IsMatch(captura) ? double.Parse(captura) : 0;
                if (largo == 0) { messageError(error + "\n Enter para volver al inicio"); Main(args);  }
                Regtangulo rectangulo = new Regtangulo(ancho, largo);
                Console.WriteLine("El area del rectangulo de base {0} y altura {1} es: {2} \n", ancho, largo, rectangulo.Area());

            }
            else if (opcionFigura == 0) 
            {
                messageError(error + "\n Enter para Continuar");
            }
            else
            {
                Console.WriteLine("por favor toma una de las opciones validas \n Enter para Continuar");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }

            Main(args);
        }

        private static void messageError(string mensaje) {
            Console.WriteLine(mensaje);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
