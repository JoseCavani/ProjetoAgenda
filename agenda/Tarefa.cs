using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Tarefa : compromisso, IAjuda
    {
        private char propriedade;
        internal char Propriedade { get => propriedade; set => propriedade = value; }

        public Tarefa(
            string tipo = default,
            string titulo = default,
           string descricao = default,
           DateTime datahorainicio = default,
           DateTime datahorafim = default,
           char propriedade = default,
           Notificacao notificacao = default) : base(tipo,titulo, descricao, datahorainicio, datahorafim, notificacao)
        {
          this.propriedade = propriedade;
        }
        public string AjudaNovo() { return "Implementar o texto de Ajuda Novo da Tarefa"; }
        public string AjudaEdita() { return "Implementar o texto de Ajuda Edita da Tarefa"; }
        public string AjudaDeleta() { return "Implementar o texto de Ajuda Exclui da Tarefa"; }

    }
}
