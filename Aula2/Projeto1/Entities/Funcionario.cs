using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;


namespace Projeto1.Entities
{
    public class Funcionario:Pessoa
    {

        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }

        public Setor Setor { get; set; }
        public Funcao Funcao { get; set; }

    }
}
