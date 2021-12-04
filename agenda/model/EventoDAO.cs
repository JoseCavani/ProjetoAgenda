using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace agenda
{
   internal class EventoDAO
    {
        private DbProviderFactory factory;



        public void InserirConvidado(string provider, string stringConexao, int idEvento, String Email)
        {
            factory = DbProviderFactories.GetFactory(provider);

            using (var conexao = factory.CreateConnection()) //Cria conexão
            {
                //Atribui a string de conexão
                conexao.ConnectionString = stringConexao;

               
                    using (var comando_convidado = factory.CreateCommand()) //Cria comando
                    {

                    //Atribui conexão
                    comando_convidado.Connection = conexao;

                        //Abre conexão
                        conexao.Open();
                        var id_evento = comando_convidado.CreateParameter();
                        id_evento.ParameterName = "@id_evento";
                        id_evento.Value = idEvento;
                        comando_convidado.Parameters.Add(id_evento);

                        var email = comando_convidado.CreateParameter();
                        email.ParameterName = "@email";
                        email.Value = Email;
                        comando_convidado.Parameters.Add(email);

                        comando_convidado.CommandText = @"INSERT INTO tb_convidado (id_evento, e_mail) VALUES (@id_evento,@email); ";

                        var linhas = comando_convidado.ExecuteNonQuery();
                    
                }
            }
        }
        public void EditarConvidado(string provider, string stringConexao, int idConvidado, string eMail)
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
                    var email = comando.CreateParameter();
                    email.ParameterName = "@email";
                    email.Value = eMail;
                    comando.Parameters.Add(email);

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = idConvidado;
                    comando.Parameters.Add(id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"" +
                    "UPDATE tb_convidado SET e_mail = @email " +
                    "WHERE id_convidado = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void ExcluirConvidado(string provider, string stringConexao, int idConvidado)
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
                    id.Value = idConvidado;
                    comando.Parameters.Add(id);

                    //monta os comandos UPDATE
                    comando.CommandText = @"DELETE FROM tb_convidado WHERE id_convidado = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }


        public DataTable SelectConvidados(string provider, string stringConexao, int id_compromisso)
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

                    comando.CommandText = @"SELECT id_convidado AS ID, e_mail AS 'E-Mail' FROM tb_convidado WHERE id_evento = " + id_compromisso + ";";

                    //Executa o script na conexão e retorna as linhas afetadas.
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new();
                    linhas.Load(sdr);

                    return linhas;
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }


        public int InserirEvento(string provider, string stringConexao, Evento evento)
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
                    var titulo = comando.CreateParameter(); titulo.ParameterName = "@titulo"; titulo.Value = evento.Titulo; comando.Parameters.Add(titulo);
                    var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = evento.Descricao; comando.Parameters.Add(descricao);
                    var dataHoraInicio = comando.CreateParameter(); dataHoraInicio.ParameterName = "@dataHoraInicio"; dataHoraInicio.Value = evento.Datahorainicio; comando.Parameters.Add(dataHoraInicio);
                    var dataHoraFim = comando.CreateParameter(); dataHoraFim.ParameterName = "@dataHoraFim"; dataHoraFim.Value = evento.Datahorafim; comando.Parameters.Add(dataHoraFim);
                    var local = comando.CreateParameter(); local.ParameterName = "@local"; local.Value = evento.Local; comando.Parameters.Add(local);

                    //ajusta o comando SQL para capturar o ID gerado pelo insert, tanto do SQL Server com do MySql
                    string auxSQL_ID = provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

                    //monta os comandos INSERT e captura do ID gerado pelo banco de dados
                    comando.CommandText = @"INSERT INTO tb_evento (titulo, descricao, dataHoraInicio, dataHoraFim, local) VALUES (@titulo,@descricao,@dataHoraInicio,@dataHoraFim, @local); " + auxSQL_ID;

                    //executa o comando no banco de dados e retorna o ID gerado 
                    return System.Convert.ToInt32(comando.ExecuteScalar());

                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }
        public DataTable SelectEventos(string provider, string stringConexao)
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

                    comando.CommandText = @"SELECT id_evento AS ID, titulo AS Titulo, descricao AS Descrição, dataHoraInicio AS Inicio, dataHoraFim AS Fim, local AS Local " +
                                            "FROM tb_evento;";

                    //Executa o script na conexão e retorna as linhas afetadas.
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new();
                    linhas.Load(sdr);

                    return linhas;
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void EditarEvento(string provider, string stringConexao, Evento evento)
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
                    titulo.Value = evento.Titulo;
                    comando.Parameters.Add(titulo);

                    var descricao = comando.CreateParameter();
                    descricao.ParameterName = "@descricao";
                    descricao.Value = evento.Descricao;
                    comando.Parameters.Add(descricao);

                    var dataHoraInicio = comando.CreateParameter();
                    dataHoraInicio.ParameterName = "@dataHoraInicio";
                    dataHoraInicio.Value = evento.Datahorainicio;
                    comando.Parameters.Add(dataHoraInicio);

                    var dataHoraFim = comando.CreateParameter();
                    dataHoraFim.ParameterName = "@dataHoraFim";
                    dataHoraFim.Value = evento.Datahorafim;
                    comando.Parameters.Add(dataHoraFim);

                    var local = comando.CreateParameter();
                    local.ParameterName = "@local";
                    local.Value = evento.Local;
                    comando.Parameters.Add(local);

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = evento.Id;
                    comando.Parameters.Add(id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"" +
                    "UPDATE tb_evento SET titulo = @titulo, descricao = @descricao, dataHoraInicio = @dataHoraInicio, dataHoraFim = @dataHoraFim, local = @local " +
                    "WHERE id_evento = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }
        public void ExcluirEvento(string provider, string stringConexao, Evento evento)
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
                    comando.CommandText = @"DELETE FROM tb_convidado WHERE id_evento = @id; " +
                                           "DELETE FROM tb_notificacao WHERE id_compromisso = @id AND tipo_compromisso = 'E';" +
                                           "DELETE FROM tb_evento WHERE id_evento = @id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }
    }
}