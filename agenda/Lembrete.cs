using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Lembrete : compromisso, IAjuda
    {
        private DateTime tempoLemebrete;
        private char tipoLembrete;
        private ValueTuple<bool, bool, bool, bool, bool, bool,bool> diaLembrete = (false,false,false,false,false,false,false);
        private int tempopara;
        private DateTime datepara;
        private int compromisso_id;


        public int Id { get; set; }
        internal DateTime TempoLemebrete { get => tempoLemebrete; set => tempoLemebrete = value; }
        internal char TipoLembrete { get => tipoLembrete; set => tipoLembrete = value; }
        internal ValueTuple<bool, bool, bool, bool, bool, bool, bool> DiaLembrete { get => diaLembrete; set => diaLembrete = value; }
        internal int TempoPara { get => tempopara; set => tempopara = value; }
        internal DateTime DatePara { get => datepara; set => datepara = value; }
        internal int Compromisso_id { get => compromisso_id; set => compromisso_id = value; }


        public Lembrete(     
            string titulo = default,
           string descricao = default,
           DateTime datahorainicio = default,
           DateTime datahorafim = default,
           DateTime tempoLemebrete = default,
           char tipoLembrete = default,
           ValueTuple<bool, bool, bool, bool, bool, bool, bool> diaLembrete = default,
           DateTime datepara = default,
           int tempopara = default,
           Notificacao notificacao = default) : base(titulo, descricao, datahorainicio, datahorafim, notificacao)
        {
            this.tempopara = tempopara;
            this.datepara = datepara;
            this.diaLembrete = diaLembrete;
            this.tipoLembrete = tipoLembrete;
            this.tempoLemebrete = tempoLemebrete;


        }
        public string AjudaNovo() { return "Implementar o texto de Ajuda Novo da lembrete"; }
        public string AjudaEdita() { return "Implementar o texto de Ajuda Edita da lembrete"; }
        public string AjudaDeleta() { return "Implementar o texto de Ajuda Exclui da lembrete"; }
    }
}
//base calls the constructor of the super class (compromisso in this case)
