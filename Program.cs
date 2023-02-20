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
                Console.WriteLine("Nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário mensal: ");
                double salario = double.Parse(Console.ReadLine());
                Funcionario pessoa = new Funcionario(nome, salario);
                funcionarios.Add(pessoa);
            }
            for (int i = 0; i < qntd;i++)
            {
                Console.WriteLine($"\n---Funcionário: {funcionarios[i].nome}\n"
                                         + $"---Id: {funcionarios[i].ID}\n"
                                         + $"---Salário: {funcionarios[i].salario}.");
            }
            Console.WriteLine("\nDeseja procurar por qual id?: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < qntd; i++)
            {
               if(funcionarios[i].ID == id)
                {
                    Console.WriteLine($"Nome: {funcionarios[i].nome}\n" +
                                      $"Salario: {funcionarios[i].salario}.");
                }
            }


        }

    }
}
