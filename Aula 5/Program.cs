// ATIVIDADE 1:

//using System;

//namespace atividades
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            int multiplosde5 = 100;
//            while (multiplosde5 >= 0)
//            {
//                Console.WriteLine(multiplosde5);
//                multiplosde5 = multiplosde5 - 5;
//            }
//        }
//    }
//}


// ATIVIDADE 2:

using System;

namespace atividades
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {

                int somaPares = 0;
                long ProdutoImpares = 1;
                bool temImpar = false;
                int i = 1;

                Console.WriteLine("Contando de 1 até " + numero + ":");
                while (i <= numero)
                {
                    Console.WriteLine(i);

                    if (i % 2 == 0)
                    {
                        somaPares += i;
                    }
                    else
                    {
                        ProdutoImpares *= i;
                        temImpar = true;
                    }
                    i++;

                }
                Console.WriteLine("\nA soma dos pares no intervalo do seu número é: " + somaPares);
                Console.WriteLine("Produto dos números ímpares no intervalo: " + (temImpar ? ProdutoImpares : 0));

            }
            else
            {
                Console.WriteLine("Insira um valor inteiro positivo válido.");
            }
        }

    }
}
//using System;

//namespace atividades
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            int numero = 0;
//            while (numero <= 10)
//            {
//                Console.WriteLine(numero);
//                numero++;
                
               
//            }
//        }
//    }
//}

