using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class DocumentosIdentificacao
    {
        public int Id { get; set; }
        public string Documentos { get; set; }
        public List<DocumentosIdentificacao> ObterTodosDocumentos()
        {
            var listaDeDocumentos = new List<DocumentosIdentificacao>();

            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 1, Documentos = "Carteira de Identidade (RG)" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 2, Documentos = "Carteira Nacional de Habilitação (CNH)" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 3, Documentos = "Passaporte" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 4, Documentos = "Carteira de Trabalho" });
            listaDeDocumentos.Add(new DocumentosIdentificacao { Id = 5, Documentos = "Certificado de Dispensa de Incorporação" });

            return listaDeDocumentos;
        }
    }
}
