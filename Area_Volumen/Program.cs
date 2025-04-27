using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculosGeometricos;
using FigurasGeometricas;
using static FigurasGeometricas.Geometria;


namespace Area_Volumen
{
    class Program
    {
        static void Main(string[] args)
        {
            int seleccionFigura = 0;
            float valor1 = 0f;
            float valor2 = 0f;
            float valor3 = 0f;

            do
            {
                Console.WriteLine("Seleccione una opcion\n1. Esfera\n2. Cilindro\n3. Paralelepipedo\n0. Salir\n");
                seleccionFigura = int.Parse(Console.ReadLine());

                switch (seleccionFigura)
                {
                    case 1: //Esfera
                        Console.WriteLine("Ingrese el radio: ");
                        valor1 = int.Parse(Console.ReadLine());

                        Geometria.Esfera esfera = new Geometria.Esfera(valor1);
                        esfera.HallarArea();
                        esfera.HallarVolumen();
                        MostrarResultado(esfera);
                        break;
                    case 2: //Cilindro
                        Console.WriteLine("Ingrese el radio: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura: ");
                        valor2 = int.Parse(Console.ReadLine());

                        Geometria.Cilindro cilindro = new Geometria.Cilindro(valor1, valor2);
                        cilindro.HallarArea();
                        cilindro.HallarVolumen();
                        MostrarResultado(cilindro);
                        break;
                    case 3: //Paralelepipedo
                        Console.WriteLine("Ingrese el lado A: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado B: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado C: ");
                        valor3 = int.Parse(Console.ReadLine());

                        Geometria.Paralelepipedo paralelepipedo = new Geometria.Paralelepipedo(valor1, valor2, valor3);
                        paralelepipedo.HallarArea();
                        paralelepipedo.HallarVolumen();
                        MostrarResultado(paralelepipedo);
                        break;
                }
            }
            while (seleccionFigura != 0);


        }

        public static void MostrarResultado(FiguraGeometrica objeto)
        {
            Console.WriteLine($"Area:  {objeto.Area}");
            Console.WriteLine($"Volumen: {objeto.Volumen}\n");
        }
    }
}
