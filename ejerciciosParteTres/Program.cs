using System;

namespace ejerciciosParteTres
{
    class Program
    {

        class Triangulo
        {
            public double ladoUno;
            public double ladoDos;
            public double ladoTres;
            public int numeroTriangulo;

            public Triangulo(double ladoUno, double ladoDos, double ladoTres, int numeroTriangulo)
            {
                this.ladoUno = ladoUno;
                this.ladoDos = ladoDos;
                this.ladoTres = ladoTres;
                this.numeroTriangulo = numeroTriangulo;
            }

            public string tipoTriangulo()
            {
                double ladoUno = this.ladoUno;
                double ladoDos = this.ladoDos;
                double ladoTres = this.ladoTres;
                double numero = this.numeroTriangulo;

                string resultado = "";

                if (ladoUno == ladoDos && ladoDos == ladoTres && ladoTres == ladoUno)
                {
                    resultado = "El Triángulo N° " + numero + " que tiene una longitud de " + ladoUno + " x " + ladoDos + " x " + ladoTres + " es equilátero";
                } else if(ladoUno != ladoDos && ladoDos != ladoTres && ladoTres != ladoUno)
                {
                    resultado = "El Triángulo N° " + numero + " que tiene una longitud de " + ladoUno + " x " + ladoDos + " x " + ladoTres + " es escaleno";
                } else
                {
                    resultado = "El Triángulo N° " + numero + " que tiene una longitud de " + ladoUno + " x " + ladoDos + " x " + ladoTres + " es isósceles";
                }

                return resultado;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de triangulos a ingresar: ");
            int cantidadTriangulos = Convert.ToInt32(Console.ReadLine());

            Triangulo[] triangulos = new Triangulo[cantidadTriangulos];

            for (int i = 0; i < cantidadTriangulos; i++)
            {
                Console.WriteLine("TRIANGULO N° {0}", i + 1);
                Console.Write("Ingrese cuanto mide el lado n° 1: ");
                double ladoUno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese cuanto mide el lado n° 2: ");
                double ladoDos = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese cuanto mide el lado n° 3: ");
                double ladoTres = Convert.ToDouble(Console.ReadLine());

                Triangulo triangulo = new Triangulo(ladoUno, ladoDos, ladoTres, (i + 1));

                triangulos[i] = triangulo;
            }

            foreach (Triangulo triangulo in triangulos)
            {
                string resultado = triangulo.tipoTriangulo();
                Console.WriteLine(resultado);
            }
        }
    }
}
