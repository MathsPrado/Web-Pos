using System;
using System.Collections.Generic;

namespace Student.Web.Model
{
    public class SolicitacaoProjeto
    {
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool SemDataInicio { get; set; }
        public bool SemDataFim { get; set; }
        public string Orçamento { get; set; }
        public string Local { get; set; }
        public List<String> ListaConhecimentos { get; set; }
        public string Descricao { get; set; }


    }
}
