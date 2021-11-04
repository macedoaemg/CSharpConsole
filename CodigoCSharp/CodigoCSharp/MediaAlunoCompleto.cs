using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1    = 0;
            double b2    = 0;
            double soma  = 0;
            double media = 0;
            string situacao = "";

            double exame = 0;
            double novaMedia = 0;

            Console.WriteLine("** Cálculo da Média de Um Aluno **");

            Console.Write("Nota do 1º Bimestre.: ");
            b1 = double.Parse(Console.ReadLine());

            Console.Write("Nota do 2º Bimestre.: ");
            b2 = double.Parse(Console.ReadLine());

            soma = b1 + b2;
            media = soma / 2;

            if (media >= 70)
            {
                situacao = "APROVADO";
                Console.WriteLine("Média...: " + media + " Situação: " + situacao);
            }
            else
            {
                if (media >= 40)
                {
                    situacao = "EXAME";
                    Console.WriteLine(" ** Situação ** " + situacao + " Média..: " + media);
                    Console.Write("Entre com a nota do Exame..: ");
                    exame = double.Parse(Console.ReadLine());
                    novaMedia = (media + exame) / 2;
                    
                    if(novaMedia >= 50)
                       Console.WriteLine(novaMedia + " - APROVADO em Exame!!!");
                    else
                       Console.WriteLine(novaMedia + " - REPROVADO em Exame!!!");

                }

                else
                {
                    situacao = "REPROVADO";
                    Console.WriteLine("Média...: " + media + " Situação: " + situacao);
                }
            }
            

            Console.WriteLine("Fim do Programa!");
        }

    }

}
