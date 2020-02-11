using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            do
            {
                   
                Console.WriteLine("Digite de 1 à 2, o exercício desejado: (0 - PARA SAIR)");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Lista1_Exe1 exe1 = new Lista1_Exe1();
                        exe1.CalculaMedia();
                        break;

                    case "2":
                        Lista1_Exe2 exe2 = new Lista1_Exe2();
                        exe2.CalculeArea();
                        break;                    

                    default:
                        if (opcao!="0")
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        else
                        {
                            Console.WriteLine("Deus o abençoe, até logo!");
                        }

                        break;
                }

            }while (opcao!="0");

        }
    }
}