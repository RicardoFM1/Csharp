// ATIVIDADE 1:

//using System;

//namespace aula5
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

//using System;

//namespace aula5
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite um número inteiro:");
//            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
//            {

//                int somaPares = 0;
//                long ProdutoImpares = 1;
//                bool temImpar = false;
//                int i = 1;

//                Console.WriteLine("Contando de 1 até " + numero + ":");
//                while (i <= numero)
//                {
//                    Console.WriteLine(i);

//                    if (i % 2 == 0)
//                    {
//                        somaPares += i;
//                    }
//                    else
//                    {
//                        ProdutoImpares *= i;
//                        temImpar = true;
//                    }
//                    i++;

//                }
//                Console.WriteLine("\nA soma dos pares no intervalo do seu número é: " + somaPares);
//                Console.WriteLine("Produto dos números ímpares no intervalo: " + (temImpar ? ProdutoImpares : 0));

//            }
//            else
//            {
//                Console.WriteLine("Insira um valor inteiro positivo válido.");
//            }
//        }

//    }
//}

// ATIVIDADE 3:

//using System;

//namespace aula5
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite quantos alunos têm na academia:");
            
            
//                int numerosAlunos = int.Parse(Console.ReadLine());
          
            
            
//                int i = 1;
//                int peso = 0;
//            int Media = 0;
//            int aux = numerosAlunos;
                    
//                    while (i <= numerosAlunos)
//                    {
//                        Console.WriteLine("digite o peso do aluno");
//                        peso += int.Parse(Console.ReadLine());
                        
                        
//                    numerosAlunos--;

//                    }
//                        Console.WriteLine("a soma do peso dos alunos é: " + peso);
//            Media = peso / aux;
//            Console.WriteLine("A média do peso dos alunos é: " + Media);
            

                

            

            
     
//            }
//        }
//}

// ATIVIDADE 4: 

using System;
using System.ComponentModel;

namespace aula5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for(int i = 1; i <= numero; i++) {
            fatorial *= i;

            }
            for (int i = 1; i <= 10; i++)
            {
                int resultado = fatorial * i;
                Console.WriteLine($"{i} x fatorial de {numero} = {resultado}");
            }
            Console.WriteLine("Calculo concluído");
        }
    }
}
