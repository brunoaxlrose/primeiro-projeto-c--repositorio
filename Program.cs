using System;

namespace CalcAritmetico1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            double opcao, soma, menos, divide, vezes;
            double n1, n2;

            Console.WriteLine("---Codigo fonte de funcoes aritmeticas--- ");
            Console.WriteLine("[1] Somar dois numeros ");
            Console.WriteLine("[2] Subtrair dois numeros ");
            Console.WriteLine("[3] Multiplicar dois numeros ");
            Console.WriteLine("[4] Dividir dois numeros ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {

                case 1:
                    Console.WriteLine("Digite um numero ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro numero ");
                    n2 = int.Parse(Console.ReadLine());
                    soma = n1 + n2;
                    Console.WriteLine("A soma dois numeros sera de: {0} ", soma);
                    break;
                case 2:
                    Console.WriteLine("Digite um numero ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro numero ");
                    n2 = int.Parse(Console.ReadLine());
                    menos = n1 - n2;
                    Console.WriteLine("A subtracao dois numeros sera de: {0} ", menos);
                    break;
                case 3:
                    Console.WriteLine("Digite um numero ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro numero ");
                    n2 = int.Parse(Console.ReadLine());
                    vezes = n1 * n2;
                    Console.WriteLine("A multiplicacao dos dois numeros sera de: {0}", vezes);
                    break;
                case 4:
                    Console.WriteLine("Digite um numero ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro numero ");
                    n2 = int.Parse(Console.ReadLine());
                    divide = n1 / n2;
                    Console.WriteLine("A divisao dos dois numeros sera de: {0} ", divide);
                    break;
            }
        }
    }
}
