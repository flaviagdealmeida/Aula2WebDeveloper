using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;
using Projeto1.Repositories;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(".:: CADASTRO DE FUNCIONARIOS ::.");
            Funcionario funcionario = new Funcionario();
            funcionario.Setor  = new Setor();
            funcionario.Funcao = new Funcao();

            try
            {
                
                Console.Write("Informe de o Id do funcionario  ................: \t");
                funcionario.Id = int.Parse(Console.ReadLine());

                Console.Write("Informe de o Nome do funcionario ...............: \t");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Informe de o Salario do funcionario ............: \t");
                funcionario.Salario = decimal.Parse(Console.ReadLine());

                Console.Write("Informe de a data de admissao do funcionario ...: \t");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe de o Id da função ......................: \t");

                funcionario.Funcao.Id = int.Parse(Console.ReadLine());
                Console.Write("Informe a descrição da função ..................: \t");
                funcionario.Funcao.Descricao = Console.ReadLine();
                                
                Console.Write("Informe de o Id do setor .......................: \t");
                funcionario.Setor.Id = int.Parse(Console.ReadLine());

                Console.Write("Informe a Sigla do Setor .......................: \t");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("Informe o Nome do Setor ........................: \t");
                funcionario.Setor.Nome = Console.ReadLine();

                FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.ExportarParaXml(funcionario);

                Console.WriteLine("Dados gravados com sucesso!");

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro" + e.Message);
            }

            Console.ReadKey();

        }
    }
}
