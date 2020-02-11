using System;

namespace csharp
{
    class Lista1_Exe2
    {
        public void CalculeArea()
        {
            string texto;

            Console.WriteLine("Informe o valor do lado 1: ");
            texto = Console.ReadLine();
            float lado1 = float.Parse(texto);

            Console.WriteLine("Informe o valor do lado 2: ");
            texto = Console.ReadLine();
            float lado2 = float.Parse(texto);

            float area = lado1 * lado2;
            Console.WriteLine("O valor da área é: " + area);
        }
    }
}