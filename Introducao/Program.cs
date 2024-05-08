using FundamentosDotnet.Models;
using fundametos_dotnet.Models;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "Tito";
pessoa.Idade = 10;

pessoa.Apresentar();

Operadores operadores = new Operadores();
operadores.OperadoresExemplo();

Calculadora calculadora = new Calculadora();
calculadora.Somar(3, 2);
calculadora.Subtrair(9, 4);
calculadora.Multiplicar(4, 4);
calculadora.Dividir(15, 3);
calculadora.Potencia(3, 3);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(9);