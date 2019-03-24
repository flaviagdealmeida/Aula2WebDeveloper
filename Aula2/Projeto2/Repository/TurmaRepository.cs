using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto2.Entities;
using Newtonsoft.Json;

namespace Projeto2.Repository
{
   public class TurmaRepository
    {
        public void ExportarParaJson(Turma turma)
        {
            using (StreamWriter streamWriter = new StreamWriter("c:\\Temp\\c#\\turma.json"))
            {
                string dados = JsonConvert.SerializeObject(turma, Formatting.Indented);
                streamWriter.WriteLine(dados);
            }
        }

    }
}
