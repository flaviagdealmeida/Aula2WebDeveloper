using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto2.Entities;
using Projeto2.Repository;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {


            Turma turma = new Turma();
            turma.Curso = new Curso();
            turma.Professor = new Professor();
            turma.Alunos = new List<Aluno>();

            Console.WriteLine(".:: Gestao de Turmas..:");

            turma.Id = 1;
            turma.DataInicio = new DateTime(2019, 03, 23);
            turma.DataFim = new DateTime(2019, 06, 23);
            turma.Curso.Id = 2;
            turma.Curso.Nome = "Web Developer c#";
            turma.Curso.CargaHoraria = 96;
            turma.Professor.Id = 3;
            turma.Professor.Cpf = "537.888.987-03";
            turma.Professor.Nome = "Flavia Almeida";

            Console.WriteLine("Total de alunos da turma para serem cadastrados?");
            int totalAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalAlunos; i++)
            {
                Aluno aluno = new Aluno();

                Console.Write("\nId do Aluno .........\t");
                aluno.Id = int.Parse(Console.ReadLine());

                Console.Write("Matricula do Aluno ..\t");
                aluno.Matricula = Console.ReadLine();

                Console.Write("Nome do Aluno .......\t");
                aluno.Nome = Console.ReadLine();

                turma.Alunos.Add(aluno);
            }

            Console.Write("\nTurma ......... \t" + turma.Id);
            Console.Write("\nInicio ........ \t" + turma.DataInicio.ToString("dd/MM/yyyy"));
            Console.Write("\nTermino ....... \t" + turma.DataFim.ToString("dd/MM/yyyy"));
            Console.Write("\nCurso ......... \t" + turma.Curso.Nome);
            Console.Write("\nCarga Horaria . \t" + turma.Curso.CargaHoraria+" H");
            Console.Write("\nProfessor ..... \t" + turma.Professor.Nome+"\n");
            
            foreach (var alunos in turma.Alunos)
            {
                Console.Write("\nId do Aluno ......... \t" + alunos.Id + "\n");
                Console.Write("Matricula do Aluno .. \t" +alunos.Matricula + "\n");
                Console.Write("Nome do Aluno ....... \t" +alunos.Nome + "\n");
                Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> \n");
            }

            try
            {
                TurmaRepository turmaRepository = new TurmaRepository();
                turmaRepository.ExportarParaJson(turma);
                Console.WriteLine("\nDados gravados com sucesso");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
