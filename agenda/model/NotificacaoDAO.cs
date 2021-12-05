using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace agenda
{
    class NotificacaoDAO
    {
        //DbProviderFactory permite a utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Oracle...)
        private DbProviderFactory factory;


        //Adicionar Notificacao ao banco de dados
        public void InserirNotificacao(string provider, string stringConexao, Notificacao notificacao, int idCompromisso)
        {
            factory = DbProviderFactories.GetFactory(provider);

            using (var conexao = factory.CreateConnection()) //Cria conexão
            {
                //Atribui a string de conexão
                conexao.ConnectionString = stringConexao;

                using (var comando = factory.CreateCommand()) //Cria comando
                {
                    //Atribui conexão
                    comando.Connection = conexao;

                    //Abre conexão
                    conexao.Open();

                    //Adiciona parâmetro (@campo e valor)
                    var tempo = comando.CreateParameter();
                    tempo.ParameterName = "@tempo";
                    tempo.Value = notificacao.Tempo;
                    comando.Parameters.Add(tempo);

                    var unidade = comando.CreateParameter();
                    unidade.ParameterName = "@unidade";
                    unidade.Value = notificacao.Unidade;
                    comando.Parameters.Add(unidade);

                    var tipo = comando.CreateParameter();
                    tipo.ParameterName = "@tipo";
                    tipo.Value = notificacao.Tipo;
                    comando.Parameters.Add(tipo);

                    var Compromisso_id = comando.CreateParameter();
                    Compromisso_id.ParameterName = "@Compromisso_id";
                    Compromisso_id.Value = idCompromisso;
                    comando.Parameters.Add(Compromisso_id);
                 


                    //monta o comando INSERT
                    comando.CommandText = @"" +
                    "INSERT INTO tb_notificacao (tempo, unidade, tipo, Compromisso_id) " +
                    "VALUES (@tempo,@unidade, @tipo, @Compromisso_id)";

                
                    //executa o comando no banco de dados 
                    var linhas = comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }


        public DataTable SelectNotificacoes(string provider, string stringConexao, int id_compromisso)
        {
            factory = DbProviderFactories.GetFactory(provider);

            using (var conexao = factory.CreateConnection()) //Cria conexão
            {
                //Atribui a string de conexão
                conexao.ConnectionString = stringConexao;

                using (var comando = factory.CreateCommand()) //Cria comando
                {
                    comando.Connection = conexao; //Atribui conexão

                    conexao.Open();

                    //verifica se tem filtro
                    var Compromisso_id = comando.CreateParameter();
                    Compromisso_id.ParameterName = "@idcompromisso";
                    Compromisso_id.Value = id_compromisso;
                    comando.Parameters.Add(Compromisso_id);


                    //comando sql
                    comando.CommandText = @"SELECT id_notificacao AS ID, tempo AS Tempo, unidade AS Unidade, tipo AS Tipo " +
                                           "FROM tb_notificacao " +
                                           "WHERE Compromisso_id = @idcompromisso";

                    //Executa o script na conexão e retorna as linhas afetadas.
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new();
                    linhas.Load(sdr);

                    return linhas;
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void EditarNotificacao(string provider, string stringConexao, Notificacao notificacao)
        {
            factory = DbProviderFactories.GetFactory(provider);

            using (var conexao = factory.CreateConnection()) //Cria conexão
            {
                //Atribui a string de conexão
                conexao.ConnectionString = stringConexao;

                using (var comando = factory.CreateCommand()) //Cria comando
                {
                    //Atribui conexão
                    comando.Connection = conexao;

                    //Abre conexão
                    conexao.Open();

                    //Adiciona parâmetro (@campo e valor)
                    var tempo = comando.CreateParameter();
                    tempo.ParameterName = "@tempo";
                    tempo.Value = notificacao.Tempo;
                    comando.Parameters.Add(tempo);

                    var unidade = comando.CreateParameter();
                    unidade.ParameterName = "@unidade";
                    unidade.Value = notificacao.Unidade;
                    comando.Parameters.Add(unidade);

                    var tipo = comando.CreateParameter();
                    tipo.ParameterName = "@tipo";
                    tipo.Value = notificacao.Tipo;
                    comando.Parameters.Add(tipo);

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = notificacao.Id;
                    comando.Parameters.Add(id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"" +
                    "UPDATE tb_notificacao SET tempo = @tempo, unidade = @unidade, tipo = @tipo " +
                    "WHERE id_notificacao = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void ExcluirNotificacao(string provider, string stringConexao, Notificacao notificacao)
        {
            factory = DbProviderFactories.GetFactory(provider);

            using (var conexao = factory.CreateConnection()) //Cria conexão
            {
                //Atribui a string de conexão
                conexao.ConnectionString = stringConexao;

                using (var comando = factory.CreateCommand()) //Cria comando
                {
                    //Atribui conexão
                    comando.Connection = conexao;

                    //Abre conexão
                    conexao.Open();

                    //Adiciona parâmetro (@campo e valor)
                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = notificacao.Id;
                    comando.Parameters.Add(id);

                    //monta os comandos UPDATE
                    comando.CommandText = @"DELETE FROM tb_notificacao WHERE id_notificacao = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

    }
}
