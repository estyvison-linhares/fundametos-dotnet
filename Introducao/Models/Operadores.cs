using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundametos_dotnet.Models
{
    public class Operadores
    {
        public void OperadoresExemplo() {
            
            //Convert e Parse
            int a = Convert.ToInt32("5"); //Recebe uma string e converte para um inteiro
            int b = int.Parse("6"); //Parse não aceita valor null
            Console.WriteLine(a);
            Console.WriteLine(b);

            //ToString
            int inteiro = 3;
            string c = inteiro.ToString();
            Console.WriteLine(c);

            //Casting implícito
            int d = 5;
            double e = d;
            //Casting explícito
            long f = 5;
            int g = Convert.ToInt32(f);
            Console.WriteLine(g);

            
            
            Console.WriteLine(c);
        }
    }
}