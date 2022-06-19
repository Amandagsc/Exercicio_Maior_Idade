using System;

namespace Exercicio_Maior_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("Determinando a Maior Idade");

            //coletando Dados
            Console.WriteLine("Digite o nome da 1ª pessoa: ");
            Console.ReadLine();
            Console.WriteLine("Digite a idade da 1ª pessoa: ");
            p1 .idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome da 2ª pessoa: ");
            Console.ReadLine();
            Console.WriteLine("Digite a idade da 2ª pessoa: ");
            p2.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome da 3ª pessoa: ");
            Console.ReadLine();
            Console.WriteLine("Digite a idade da 3ª pessoa: ");
            p3.idade = Convert.ToInt32(Console.ReadLine());

            //Lógica
            if ((p1.idade > p2.idade) && (p1.idade > p3.idade))
            {
                Console.WriteLine("A pessoa com maior idade é: ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.idade >p1.idade) && (p2.idade> p3.idade))
                {
                    Console.WriteLine("A pessoa com maior idade é: ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.idade > p1.idade) && (p3.idade > p2.idade))
                    {
                        Console.WriteLine("A pessoa com maior idade é: " );
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas Possuem a mesma idade! ");
                    }
                }
            }
        }
    }
}
