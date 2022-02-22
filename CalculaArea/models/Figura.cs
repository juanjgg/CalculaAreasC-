using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaArea.models
{
    public abstract class Figura
    {

        public abstract double Area();
    }

    public class Circulo : Figura
    {
        public Circulo(double radio) {
            this.radio = radio;
        }

        const double PI = 3.1416;
        private double radio;
        public override double Area()
        {
            return radio * radio * PI;
        }
    }

    public class Regtangulo : Figura
    {
        public Regtangulo(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        private double ancho;

        private double largo;

        public override double Area()
        {
            return ancho * largo;
        }
    }
}
