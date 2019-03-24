using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }





    }
}
