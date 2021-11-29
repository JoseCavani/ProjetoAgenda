using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Evento : compromisso, IAjuda
    {
        private string local;
        private List<string> convidados;

        internal string Local { get => local; set => local = value; }
        internal List<string> Convidados { get => convidados; set => convidados = value; }
        public Evento(
             string tipo = default,
           string titulo = default,
           string descricao = default,
           DateTime datahorainicio = default,
           DateTime datahorafim = default,
           string local = default,
           Notificacao notificacao = default,
           string convidados = default) : base(tipo,titulo, descricao, datahorainicio, datahorafim, notificacao)
        {


            this.local = local;
            this.convidados = new List<string>();
            if (convidados != null)
            {
                this.convidados.Add(convidados);
            }

        }
        public string AjudaNovo() { return "Implementar o texto de Ajuda Novo da evento"; }
        public string AjudaEdita() { return "Implementar o texto de Ajuda Edita da evento"; }
        public string AjudaDeleta() { return "Implementar o texto de Ajuda Exclui da evento"; }
    }
}
//base calls the constructor of the super class (compromisso in this case)
