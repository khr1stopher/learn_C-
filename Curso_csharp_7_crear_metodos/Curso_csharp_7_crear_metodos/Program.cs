using System;

namespace Curso_csharp_7_crear_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BorrarConsola();

            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            Saludar(nombre);
            Console.WriteLine(Sumar(213, 57) / 2);
            Console.WriteLine(mis_datos());
            int cociente = 0;
            int residuo = 0;

            (cociente, residuo) = Dividir(243, 68);
            Console.WriteLine(cociente);
            Console.WriteLine(residuo);


            (int cociente, int residuo) data = Dividir(243, 68);
            Console.WriteLine(data.cociente);
            Console.WriteLine(data.residuo);

            Console.ReadLine();
        }

        static (int, int) Dividir(int n1,int n2)
        {
            return (n1 / n2, n1 % n2);
        }
        static (string, string, int) mis_datos()
        {
            return ("khristopher", "pineda", 18);
        }

        static int Sumar(int n1, int n2) => /*return*/ n1 + n2;
        static void Saludar(string nombre = "khristopher") {
            Console.WriteLine($"hola {nombre}");
        }

        static void BorrarConsola()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();

            Console.WriteLine(100 + 1000);
        }
    }
}
