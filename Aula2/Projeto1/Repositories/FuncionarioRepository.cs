using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Projeto1.Entities;
namespace Projeto1.Repositories
{
    class FuncionarioRepository
    {
        public void ExportarParaXml(Funcionario funcionario)
        {

            string dataHora = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string nomeArquivo = $"funcionario_{dataHora}.xml";

            using (XmlWriter xml = XmlWriter.Create($"c:\\Temp\\c#\\{nomeArquivo}"))
            {
                xml.WriteStartDocument();

                xml.WriteStartElement("funcionario");

                xml.WriteElementString("id", funcionario.DataAdmissao.ToString("D4"));
                xml.WriteElementString("nome", funcionario.Nome);
                xml.WriteElementString("salario", funcionario.Salario.ToString("c"));
                xml.WriteElementString("dataAdmissao", funcionario.DataAdmissao.ToString("dd/MM/yyyy"));


                xml.WriteStartElement("setor");

                xml.WriteElementString("id", funcionario.Setor.Id.ToString("D4"));
                xml.WriteElementString("sigla", funcionario.Setor.Sigla.ToUpper());
                xml.WriteElementString("nome", funcionario.Setor.Nome);

                xml.WriteEndElement();

                xml.WriteStartElement("funcao");

                xml.WriteElementString("id", funcionario.Funcao.Id.ToString("D4"));
                xml.WriteElementString("descricao", funcionario.Funcao.Descricao);

                xml.WriteEndElement();



                xml.WriteEndElement();

            }


        }



    }
}
