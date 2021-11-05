using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 0;
            int valor2 = 0;
            int soma = 0;
            
            string resp = "S";
            
            while (resp == "S" || resp == "s")
            {
                Console.Clear();
                Console.Write("Valor 1..: ");
                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Valor 2..: ");
                valor2 = int.Parse(Console.ReadLine());

                soma = valor1 + valor2;

                Console.WriteLine("Soma..: " + soma);

                Console.Write("Deseja continuar? <S=Sim>..: ");
                resp = Console.ReadLine();

                
            }                
                        
            Console.WriteLine("Fim do Programa!");
        }

    }

}
