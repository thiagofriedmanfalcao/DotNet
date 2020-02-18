using System;
using System.IO;
using System.Collections; 

namespace csharp
{
    class Lista3_Exe1
    {
        public void Tabuada()
        {
            string texto;

            Console.WriteLine("Informe o número para tabuada: ");
            texto = Console.ReadLine();
            int numero = int.Parse(texto);                        
            GravarTabuada(numero);
        }

        public void GravarTabuada(int numero)
        {
            int cont = 1;
            ArrayList listaNumeros = new ArrayList(); 
            do
            {
                int resultado = numero * cont;
                string linResult = numero.ToString() + " * " + cont.ToString() + " = " + resultado.ToString();
                listaNumeros.Add(linResult);

                cont++;
            } while(cont<=10);

            GravarArquivo(listaNumeros);
            LerEImprimirArquivo(numero);
        }

        public void GravarArquivo(ArrayList listaNumeros)
        {
            using (StreamWriter sw = new StreamWriter("tabuada.txt")) {
                foreach (string s in listaNumeros) {
                sw.WriteLine(s);
                }
            }
        }

        public void LerEImprimirArquivo(int numero)
        {
            Console.WriteLine("\nSegue abaixo a tabuada do número: " + numero.ToString() + "\n");
            string line = "";
            using (StreamReader sr = new StreamReader("tabuada.txt")) {
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
            //Console.ReadKey();            
        }
    }
}