using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
   public class Notificacao
    {
        private int id;
        //private byte tempo;
        private char unidade;
        private char tipo;

        public int Id { get; set; }
        public byte Tempo { get; set; }
        public char Unidade { get=> unidade; set=> unidade = value; }
         public char Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
            }
        }
        /* public Notificacao()
         {
             Unidade = default;
             Tipo = default;
             Tempo = default;
         }*/
        public Notificacao()
        {
        }
            public Notificacao(byte tempo, char unidade, char tipo)
        {
            id = 0;
            this.Tempo = tempo;
            this.unidade = unidade;
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return $"{Tempo}, {(EnumUnidade)unidade},{(EnumTipo)tipo}";
        }
    }
}
