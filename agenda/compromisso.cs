using System;

using System.Collections.Generic;

namespace agenda
{
    public interface IAjuda
    {
        public string AjudaNovo();
        public string AjudaEdita();
        public string AjudaDeleta();
    }

    public abstract class compromisso
    {
        protected int id;
        protected string titulo, descricao;
        protected DateTime datahorainicio, datahorafim;
        protected List<Notificacao> notificacao;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Datahorainicio { get => datahorainicio; set => datahorainicio = value; }
        public DateTime Datahorafim { get => datahorafim; set => datahorafim = value; }
        public List<Notificacao> Notificacao { get => notificacao; set => notificacao = value; }




        // this allows the structure compromisso c1 = new();  c1.titulo = "C1";  DateTime auxinicio = new DateTime(2021, 9, 27, 19, 52, 00); c1.datahorainicio = auxinicio c1.datahorafim = new DateTime(2021, 9, 27, 22, 34, 54);

        /* public compromisso()
         {
             titulo = default;
             descricao = default;
             datahorainicio = default;
             datahorafim = default;
             notificacao = new List<Notificacao>();
         }
         // this allows the structure  compromisso c2 = new compromisso("C2", "compromisso C2", new DateTime(2021, 10, 15, 10, 30, 00), new DateTime(2021,10, 17, 23, 10, 00));
         public compromisso(string titulo, string descricao, DateTime datahorainicio, DateTime datahorafim)
         {
             this.titulo = titulo;
             this.descricao = descricao;
             this.datahorainicio = datahorainicio;
             this.datahorafim = datahorafim;
             notificacao = new List<Notificacao>();
         }
         public compromisso(string titulo, DateTime datahorainicio)
         {
             this.titulo = titulo;
             this.datahorainicio = datahorainicio;
             notificacao = new List<Notificacao>();
         }*/
        public compromisso(string titulo, string descricao, DateTime datahorainicio, DateTime datahorafim, Notificacao Notificacao)
        {
            this.id = default;
            this.titulo = titulo;
            this.descricao = descricao;
            this.datahorainicio = datahorainicio;
            this.datahorafim = datahorafim;
           
                notificacao = new List<Notificacao>();
            if (Notificacao != null)
            {
            
                notificacao.Add(Notificacao);
            }
        }
        public override string ToString()
        {
            return $" {titulo},{descricao}, {datahorainicio} ate {datahorafim}";
        }

    }
}
