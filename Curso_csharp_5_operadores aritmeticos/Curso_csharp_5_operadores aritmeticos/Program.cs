using System;

namespace Curso_csharp_5_operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * /

            var val1 = 10;
            var val2 = 20;

            int result = val1 + val2;
            Console.WriteLine(result);
            result = val1 - val2;
            Console.WriteLine(result);
            result = val1 * val2;
            Console.WriteLine(result);
            result = val1 / val2;
            Console.WriteLine(result);
            result = val1 % val2;
            Console.WriteLine(result);

            var val3 = 10.0;
            var val4 = 3.0;

            Console.WriteLine(val3 / val4);


            //operador residuo 

            Console.WriteLine(8764 % 31);

            //numeros infinitos o Nan

            double infinito = 100.0 / 0.0;
            Console.WriteLine(infinito);

            double nan = 0.0 / 0.0;
            Console.WriteLine(nan);

            //precedencia

            Console.WriteLine(5 + 10 * 2);
            //25
            Console.WriteLine((5 + 10) * 2);
            //30

            //asociatividad

            Console.WriteLine(5.0 / 10.0 * 2.0);

            //incremento de variables
            var variable = 0;
            variable++;
            ++variable;

            Console.WriteLine(variable);

            //incremento de variables
            var variable2 = 0;
            variable2--;
            --variable2;

            Console.WriteLine(variable2);

            Console.ReadLine();
        }
    }
}
