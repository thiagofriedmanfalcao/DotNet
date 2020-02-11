using System;

namespace csharp
{
    class Lista1_Exe1
    {

        public void CalculaMedia()
        {
            string texto;

            Console.WriteLine("Informe a 1ª nota: ");
            texto = Console.ReadLine();
            float nota1 = float.Parse(texto);


            Console.WriteLine("Informe a 2ª nota: ");
            texto = Console.ReadLine();
            float nota2 = float.Parse(texto);            


            Console.WriteLine("Informe a 3ª nota: ");
            texto = Console.ReadLine();
            float nota3 = float.Parse(texto);                        

            float media = (nota1 + nota2 + nota3) / 3;
            
            Console.WriteLine("A média é: " + Math.Round(media, 2));    
        }
    }
}