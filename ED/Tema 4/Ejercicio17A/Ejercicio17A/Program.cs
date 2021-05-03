using System;

namespace Ejercicio17A
{
    class Program
    {
        static void Main(string[] args)
        {
            String lado1, lado2, lado3;
            Console.WriteLine("Introduce un lado del triangulo");
            int intlado1 = Int32.Parse (lado1 = Console.ReadLine());
            Console.WriteLine("Introduce el segundo lado del triangulo");
            int intlado2 = Int32.Parse(lado2 = Console.ReadLine());
            Console.WriteLine("Introduce el tercer lado del triangulo");
            int intlado3 = Int32.Parse(lado3 = Console.ReadLine());

            if (intlado1 == intlado2 && intlado3 == intlado1)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else {
                Console.WriteLine("No es un triangulo equilatero");

            }
        }
    }
}
