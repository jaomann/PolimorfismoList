using System;
using System.Collections.Generic;
namespace NewApp
{
    public class Program
    {

        static void Main()
        {
            Console.WriteLine("-----Bem vindo ao atendimento----");
            Console.WriteLine("Cadastre abaixo, os funcionários.\n");
            int qntd = 4;
            List<Funcionario> funcionarios = new List<Funcionario>();
            for (int i = 0; i < qntd; i++)
            {
                Console.WriteLine($"O funcionário {i+1} é PJ ou CLT?(digte 1 ou 2)");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    Console.WriteLine("Nome do funcionário: ");
                    string nome = Console.ReadLine() + " (PJ)";
                    Console.WriteLine("Salário mensal: ");
                    double salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Porcentagem do aumento, em relação ao funcionário normal: ");
                    double aumento = double.Parse(Console.ReadLine());
                    Console.WriteLine("Porcentagem de desconto da taxaPJ: ");
                    double taxa = double.Parse(Console.ReadLine());
                    Funcionario pessoa = new FuncionarioCLT(nome, salario, aumento, taxa);
                    funcionarios.Add(pessoa);
                    Console.WriteLine($"Tudo pronto para {nome}\n--");
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Nome do funcionário: ");
                    string nome = Console.ReadLine() + " (CLT)";
                    Console.WriteLine("Salário mensal: ");
                    double salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Porcentagem do aumento, em relação ao funcionário normal: ");
                    double aumento = double.Parse(Console.ReadLine());
                    Console.WriteLine("Porcentagem de desconto da taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    Funcionario pessoa = new FuncionarioCLT(nome, salario, aumento, taxa);
                    funcionarios.Add(pessoa);
                    Console.WriteLine($"Tudo pronto para {nome}\n--");
                }
            }
            bool run = true;
            do
            {
                Console.WriteLine("\nDeseja procurar por qual id?: ");
                Console.WriteLine("--4 para finalizar o atendimento.--");
                int id = int.Parse(Console.ReadLine());
                Funcionario busca = funcionarios.Find(x => x.ID == id);
                Console.WriteLine(busca.toString());
                if (id == 4)
                {
                    Console.WriteLine("Atendimento Finalizado.");
                    run = false;
                }

            } while (run == true);

        }

    }
}
