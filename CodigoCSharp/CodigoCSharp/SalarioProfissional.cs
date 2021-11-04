using System;

namespace CodigoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double vh = 0; double qh = 0; double inss = 0; double sb = 0; double td = 0; double sl = 0;

            Console.Write("Quantidade de horas..: ");
            qh = double.Parse(Console.ReadLine());

            Console.Write("Valor da hora........: ");
            vh = double.Parse(Console.ReadLine());

            //Console.Write("Desconto INSS........: ");
            //inss = double.Parse(Console.ReadLine());

            sb = vh * qh;
            //td =  sb * (inss / 100);
            sl = sb * 1.09;
            //sl = sb - td;

            Console.WriteLine("Salário Líquido..: " + sl);
            if(sl > 1100)            
                Console.WriteLine("Salário acima do mínimo");
            
            Console.WriteLine("Fim do Programa!");
        }

    }

}
