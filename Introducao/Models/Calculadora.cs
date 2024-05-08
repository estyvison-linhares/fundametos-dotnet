using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundametos_dotnet.Models
{
    public class Calculadora
    {
        public void Somar(int operador1, int operador2) {
            Console.WriteLine($"A soma dos valores é {operador1 + operador2}");
        }

        public void Subtrair(int operador1, int operador2) {
            Console.WriteLine($"A subtração dos valores é {operador1 - operador2}");
        }

        public void Multiplicar(int operador1, int y) {
            Console.WriteLine($"A multiplicação dos valores é {operador1 * y}");
        }

        public void Dividir(int dividendo, int divisor) {
            Console.WriteLine($"A divisão dos valores é {dividendo / divisor}");
        }
        
        public void Potencia(int numero, int expoente) {
            double potencia = Math.Pow(numero, expoente);
            Console.WriteLine($"A Potência dos valores é {potencia}");
        }

        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double numero) {
            double raizQuadrada = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raizQuadrada}");
        }
    }
}