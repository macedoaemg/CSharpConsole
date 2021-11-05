using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double v1   = 0;
            double v2   = 0;
            int    op   = 0;
            string resp = "S";

            while(resp == "s" || resp == "S")
            {
                Console.Clear();
                Console.WriteLine(" ** Menu de Opções ** ");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.Write("Opção..: ");
                op = int.Parse(Console.ReadLine());                

                if (op == 1)
                {
                    Console.Write("Valor 1..: ");
                    v1 = double.Parse(Console.ReadLine());

                    Console.Write("Valor 2..: ");
                    v2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A adição foi de..: " + (v1 + v2));
                }
                else if (op == 2)
                {
                    Console.Write("Valor 1..: ");
                    v1 = double.Parse(Console.ReadLine());

                    Console.Write("Valor 2..: ");
                    v2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A subtração foi de..: " + (v1 - v2));
                }
                else if (op == 3)
                {
                    Console.Write("Valor 1..: ");
                    v1 = double.Parse(Console.ReadLine());

                    Console.Write("Valor 2..: ");
                    v2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A multiplicação foi de..: " + (v1 * v2));
                }
                else if (op == 4)
                {
                    Console.Write("Valor 1..: ");
                    v1 = double.Parse(Console.ReadLine());

                    Console.Write("Valor 2..: ");
                    v2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A divisão foi de..: " + (v1 / v2));
                }
                else
                    Console.WriteLine("Opção Inválida!!!");

                Console.Write("Deseja executar outra operação <S=SIM>..: ");
                resp = Console.ReadLine();
            }                       
                        
            Console.WriteLine("Fim do Programa!");
        }

    }

}
