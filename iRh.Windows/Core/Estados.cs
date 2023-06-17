using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados { Sigla = "RO" ,Nome = "Rondônia"});
            listaDeEstados.Add(new Estados { Sigla = "AC" ,Nome = "Acre"});
            listaDeEstados.Add(new Estados { Sigla = "SP" ,Nome = "São Paulo"});
            listaDeEstados.Add(new Estados { Sigla = "RJ" ,Nome = "Rio de Janeiro"});
            listaDeEstados.Add(new Estados { Sigla = "ES" ,Nome = "Espírito Santo"});
            listaDeEstados.Add(new Estados { Sigla = "SC" ,Nome = "Santa Catarina"});
            listaDeEstados.Add(new Estados { Sigla = "MG", Nome = "Minas Gerais"});
            listaDeEstados.Add(new Estados { Sigla = "RS", Nome = "Rio Grande do Sul"});
            listaDeEstados.Add(new Estados { Sigla = "PR", Nome = "Paraná"});
            listaDeEstados.Add(new Estados { Sigla = "AM", Nome = "Amazonas"});
            listaDeEstados.Add(new Estados { Sigla = "RR", Nome = "Roraima"});
            listaDeEstados.Add(new Estados { Sigla = "GO", Nome = "Goias"});
            listaDeEstados.Add(new Estados { Sigla = "BA", Nome = "Bahia"});
            listaDeEstados.Add(new Estados { Sigla = "MT", Nome = "Mato Grosso"});
            listaDeEstados.Add(new Estados { Sigla = "MS", Nome = "Mato Grosso do Sul"});
            listaDeEstados.Add(new Estados { Sigla = "PA", Nome = "Pará"});
            listaDeEstados.Add(new Estados { Sigla = "AP", Nome = "Amapá"});
            listaDeEstados.Add(new Estados { Sigla = "MA", Nome = "Maranhão"});
            listaDeEstados.Add(new Estados { Sigla = "PI", Nome = "Piauí"});
            listaDeEstados.Add(new Estados { Sigla = "CE", Nome = "Ceará"});
            listaDeEstados.Add(new Estados { Sigla = "RN", Nome = "Rio Grande do Norte"});
            listaDeEstados.Add(new Estados { Sigla = "PR", Nome = "Paraná"});
            listaDeEstados.Add(new Estados { Sigla = "PB", Nome = "Paraíba"});
            listaDeEstados.Add(new Estados { Sigla = "PE", Nome = "Pernambuco"});
            listaDeEstados.Add(new Estados { Sigla = "AL", Nome = "Alagoas"});
            listaDeEstados.Add(new Estados { Sigla = "SE", Nome = "Sergipe"});
            listaDeEstados.Add(new Estados { Sigla = "TO", Nome = "Tocantins"});
            listaDeEstados.Add(new Estados { Sigla = "DF", Nome = "Distrito Federal"});

            return listaDeEstados;
        }
    }
}
