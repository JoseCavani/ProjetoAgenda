using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{

    class TarefaDAO
    {
        private DbProviderFactory factory;
        public int InserirTarefa(string provider, string stringConexao, Tarefa tarefa)
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
                    var titulo = comando.CreateParameter(); titulo.ParameterName = "@titulo"; titulo.Value = tarefa.Titulo; comando.Parameters.Add(titulo);
                    var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = tarefa.Descricao; comando.Parameters.Add(descricao);
                    var dataHoraInicio = comando.CreateParameter(); dataHoraInicio.ParameterName = "@dataHoraInicio"; dataHoraInicio.Value = tarefa.Datahorainicio; comando.Parameters.Add(dataHoraInicio);
                    var dataHoraFim = comando.CreateParameter(); dataHoraFim.ParameterName = "@dataHoraFim"; dataHoraFim.Value = tarefa.Datahorafim; comando.Parameters.Add(dataHoraFim);
                    var prioridade = comando.CreateParameter(); prioridade.ParameterName = "@prioridade"; prioridade.Value = tarefa.Propriedade; comando.Parameters.Add(prioridade);

                    //ajusta o comando SQL para capturar o ID gerado pelo insert, tanto do SQL Server com do MySql
                    string auxSQL_ID = provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

                    //monta os comandos INSERT e captura do ID gerado pelo banco de dados
                    comando.CommandText = @"INSERT INTO tb_tarefa (titulo, descricao, dataHoraInicio, dataHoraFim, prioridade) VALUES (@titulo,@descricao,@dataHoraInicio,@dataHoraFim, @prioridade); " + auxSQL_ID;

                    //executa o comando no banco de dados e retorna o ID gerado 
                    return System.Convert.ToInt32(comando.ExecuteScalar());

                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }


        public DataTable SelectTarefa(string provider, string stringConexao)
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

                    comando.CommandText = @"SELECT id_tarefa AS ID, titulo AS Titulo, descricao AS Descrição, dataHoraInicio AS Inicio, dataHoraFim AS Fim, prioridade AS prioridade " +
                                            "FROM tb_tarefa;";

                    //Executa o script na conexão e retorna as linhas afetadas.
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new();
                    linhas.Load(sdr);

                    return linhas;
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void ExcluirTarefa(string provider, string stringConexao, Tarefa evento)
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
                    id.Value = evento.Id;
                    comando.Parameters.Add(id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"DELETE FROM tb_tarefa WHERE id_tarefa = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void EditarTarefa(string provider, string stringConexao, Tarefa tarefa)
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
                    var titulo = comando.CreateParameter();
                    titulo.ParameterName = "@titulo";
                    titulo.Value = tarefa.Titulo;
                    comando.Parameters.Add(titulo);

                    var descricao = comando.CreateParameter();
                    descricao.ParameterName = "@descricao";
                    descricao.Value = tarefa.Descricao;
                    comando.Parameters.Add(descricao);

                    var dataHoraInicio = comando.CreateParameter();
                    dataHoraInicio.ParameterName = "@dataHoraInicio";
                    dataHoraInicio.Value = tarefa.Datahorainicio;
                    comando.Parameters.Add(dataHoraInicio);

                    var dataHoraFim = comando.CreateParameter();
                    dataHoraFim.ParameterName = "@dataHoraFim";
                    dataHoraFim.Value = tarefa.Datahorafim;
                    comando.Parameters.Add(dataHoraFim);

                    var local = comando.CreateParameter();
                    local.ParameterName = "@prioridade";
                    local.Value = tarefa.Propriedade;
                    comando.Parameters.Add(local);

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = tarefa.Id;
                    comando.Parameters.Add(id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"" +
                    "UPDATE tb_tarefa SET titulo = @titulo, descricao = @descricao, dataHoraInicio = @dataHoraInicio, dataHoraFim = @dataHoraFim, prioridade = @prioridade " +
                    "WHERE id_tarefa = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }



    }


}
    


