using Lista02.Entities;
using System;
using Lista02.Repositories;

namespace Lista02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** CADASTRO DE FUNCIONÁRIOS ***\n ");

            var funcionario = new Funcionario();
            funcionario.Departamento = new Departamento();



            Console.Write("Informe a Id do funcionário: ");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe o Salário do funcionário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data de Admissão do funcionário: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Id do Departamento do funcionário: ");
            funcionario.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome do Departamento: ");
            funcionario.Departamento.Nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve Descrição do Depepartamento: ");
            funcionario.Departamento.Descricao = Console.ReadLine();

            Console.WriteLine("\nDADOS DO FUNCIONÁRIO");
            Console.WriteLine("ID..................:" + funcionario.IdFuncionario);
            Console.WriteLine("Nome................:" + funcionario.Nome);
            Console.WriteLine("Salário.............:" + funcionario.Salario);
            Console.WriteLine("Data de Admissão....:" + funcionario.DataAdmissao);

            Console.WriteLine("\nDADOS DO DEPARTAMENTO");
            Console.WriteLine("Id Departamento...............:" + funcionario.Departamento.IdDepartamento);
            Console.WriteLine("Nome do Departamento..........:" + funcionario.Departamento.Nome);
            Console.WriteLine("Descrição do Departamento.....:" + funcionario.Departamento.Descricao);

            var funcionarioRepository = new FuncionarioRepository();


            try
            {
                funcionarioRepository.ExportarDados(funcionario);

                Console.WriteLine("\nDados gravados com sucesso!");

            }
            catch (Exception e)
            {

                Console.WriteLine("\nErro: " + e.Message);

            }  Console.ReadKey();
        }
    }
}
