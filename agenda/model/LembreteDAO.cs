using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class LembreteDAO
    {
        private DbProviderFactory factory;
        public int InserirLembrete(string provider, string stringConexao, Lembrete lembrete)
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
                    var titulo = comando.CreateParameter(); titulo.ParameterName = "@titulo"; titulo.Value = lembrete.Titulo; comando.Parameters.Add(titulo);
                    var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = lembrete.Descricao; comando.Parameters.Add(descricao);
                    var dataHoraInicio = comando.CreateParameter(); dataHoraInicio.ParameterName = "@dataHoraInicio"; dataHoraInicio.Value = lembrete.Datahorainicio; comando.Parameters.Add(dataHoraInicio);
                    var dataHoraFim = comando.CreateParameter(); dataHoraFim.ParameterName = "@dataHoraFim"; dataHoraFim.Value = lembrete.Datahorafim; comando.Parameters.Add(dataHoraFim);
                    var tempoLembrete = comando.CreateParameter(); tempoLembrete.ParameterName = "@tempoLemebrete"; tempoLembrete.Value = lembrete.TempoLemebrete; comando.Parameters.Add(tempoLembrete);
                    var tipoLembrete = comando.CreateParameter(); tipoLembrete.ParameterName = "@tipoLembrete"; tipoLembrete.Value = lembrete.TipoLembrete; comando.Parameters.Add(tipoLembrete);
                    var diaLembreteDoming= comando.CreateParameter(); diaLembreteDoming.ParameterName = "@diaLembreteDoming"; diaLembreteDoming.Value = lembrete.DiaLembrete.Item1; comando.Parameters.Add(diaLembreteDoming);
                    var diaLembreteSegunda = comando.CreateParameter(); diaLembreteSegunda.ParameterName = "@diaLembreteSegunda"; diaLembreteSegunda.Value = lembrete.DiaLembrete.Item2; comando.Parameters.Add(diaLembreteSegunda);
                    var diaLembreteTerca = comando.CreateParameter(); diaLembreteTerca.ParameterName = "@diaLembreteTerca"; diaLembreteTerca.Value = lembrete.DiaLembrete.Item3; comando.Parameters.Add(diaLembreteTerca);
                    var diaLembreteQuarta = comando.CreateParameter(); diaLembreteQuarta.ParameterName = "@diaLembreteQuarta"; diaLembreteQuarta.Value = lembrete.DiaLembrete.Item4; comando.Parameters.Add(diaLembreteQuarta);
                    var diaLembreteQuinta = comando.CreateParameter(); diaLembreteQuinta.ParameterName = "@diaLembreteQuinta"; diaLembreteQuinta.Value = lembrete.DiaLembrete.Item5; comando.Parameters.Add(diaLembreteQuinta);
                    var diaLembreteSexta = comando.CreateParameter(); diaLembreteSexta.ParameterName = "@diaLembreteSexta"; diaLembreteSexta.Value = lembrete.DiaLembrete.Item6; comando.Parameters.Add(diaLembreteSexta);
                    var diaLembreteSabado = comando.CreateParameter(); diaLembreteSabado.ParameterName = "@diaLembreteSabado"; diaLembreteSabado.Value = lembrete.DiaLembrete.Item7; comando.Parameters.Add(diaLembreteSabado);
                    var tempopara = comando.CreateParameter(); tempopara.ParameterName = "@tempopara"; tempopara.Value = lembrete.TempoPara; comando.Parameters.Add(tempopara);
                    var datepara = comando.CreateParameter(); datepara.ParameterName = "@datepara"; datepara.Value = lembrete.DatePara; comando.Parameters.Add(datepara);






                    //ajusta o comando SQL para capturar o ID gerado pelo insert, tanto do SQL Server com do MySql
                    string auxSQL_ID = provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

                    //monta os comandos INSERT e captura do ID gerado pelo banco de dados
                    comando.CommandText = @"INSERT INTO compromisso (titulo, descricao, dataHoraInicio, dataHoraFim) VALUES (@titulo,@descricao,@dataHoraInicio,@dataHoraFim); " + auxSQL_ID;
                    var id = System.Convert.ToInt32(comando.ExecuteScalar());
                    var compromisso_id = comando.CreateParameter(); compromisso_id.ParameterName = "@compromisso_id"; compromisso_id.Value = id; comando.Parameters.Add(compromisso_id);
                    comando.CommandText = @"INSERT INTO tb_lembrete (Compromisso_id, tempoLembrete, tipoLembrete, diaLembrete_domingo, diaLembrete_segunda, diaLembrete_terca, diaLembrete_quarta, diaLembrete_quinta, diaLembrete_sexta, diaLembrete_sabado, tempopara, datepara) VALUES (@compromisso_id, @tempoLemebrete, @tipoLembrete, @diaLembreteDoming, @diaLembreteSegunda, @diaLembreteTerca, @diaLembreteQuarta, @diaLembreteQuinta,@diaLembreteSexta, @diaLembreteSabado, @tempopara, @datepara ); " + auxSQL_ID;

                   

                    //executa o comando no banco de dados e retorna o ID gerado 
                    comando.ExecuteNonQuery();
                    return (id);

                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }


        public DataTable SelectLembrete(string provider, string stringConexao)
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

                    comando.CommandText = @"SELECT B.id_lembrete AS Lembrete,
B.compromisso_id AS Compromisso, 
titulo AS Titulo, descricao AS Descrição,
dataHoraInicio AS Inicio, dataHoraFim AS Fim,
B.tempoLembrete AS Horario_Inicio, B.tipoLembrete AS tipo,
B.diaLembrete_domingo AS domingo, B.diaLembrete_segunda AS segunda, B.diaLembrete_terca AS terça,
B.diaLembrete_quarta AS quarta, B.diaLembrete_quinta AS quinta, B.diaLembrete_sexta AS sexta,
B.diaLembrete_sabado AS sabado, B.tempopara AS Tempo_para, B.datepara AS data_para FROM compromisso A
                                            Inner join tb_lembrete B on B.compromisso_id=A.id;";

                    //Executa o script na conexão e retorna as linhas afetadas.
                    var sdr = comando.ExecuteReader();
                    DataTable linhas = new();
                    linhas.Load(sdr);

                    return linhas;
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void ExcluirLembrete(string provider, string stringConexao, Lembrete lembrete)
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
                    id.Value = lembrete.Id;
                    comando.Parameters.Add(id);

                    var Compromisso_id = comando.CreateParameter();
                    Compromisso_id.ParameterName = "@Compromisso_id";
                    Compromisso_id.Value = lembrete.Compromisso_id;
                    comando.Parameters.Add(Compromisso_id);


                    //monta os comandos UPDATE
                    comando.CommandText = @"DELETE FROM tb_lembrete WHERE id_lembrete = @id;" +
                         "DELETE FROM tb_notificacao WHERE Compromisso_id = @Compromisso_id ;" +
                                            "DELETE FROM compromisso WHERE id = @Compromisso_id;";

                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }

        public void EditarLembrete(string provider, string stringConexao, Lembrete lembrete)
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
                    var titulo = comando.CreateParameter(); titulo.ParameterName = "@titulo"; titulo.Value = lembrete.Titulo; comando.Parameters.Add(titulo);
                    var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = lembrete.Descricao; comando.Parameters.Add(descricao);
                    var dataHoraInicio = comando.CreateParameter(); dataHoraInicio.ParameterName = "@dataHoraInicio"; dataHoraInicio.Value = lembrete.Datahorainicio; comando.Parameters.Add(dataHoraInicio);
                    var dataHoraFim = comando.CreateParameter(); dataHoraFim.ParameterName = "@dataHoraFim"; dataHoraFim.Value = lembrete.Datahorafim; comando.Parameters.Add(dataHoraFim);
                    var tempoLembrete = comando.CreateParameter(); tempoLembrete.ParameterName = "@tempoLemebrete"; tempoLembrete.Value = lembrete.TempoLemebrete; comando.Parameters.Add(tempoLembrete);
                    var tipoLembrete = comando.CreateParameter(); tipoLembrete.ParameterName = "@tipoLembrete"; tipoLembrete.Value = lembrete.TipoLembrete; comando.Parameters.Add(tipoLembrete);
                    var diaLembreteDoming = comando.CreateParameter(); diaLembreteDoming.ParameterName = "@diaLembreteDoming"; diaLembreteDoming.Value = lembrete.DiaLembrete.Item1; comando.Parameters.Add(diaLembreteDoming);
                    var diaLembreteSegunda = comando.CreateParameter(); diaLembreteSegunda.ParameterName = "@diaLembreteSegunda"; diaLembreteSegunda.Value = lembrete.DiaLembrete.Item2; comando.Parameters.Add(diaLembreteSegunda);
                    var diaLembreteTerca = comando.CreateParameter(); diaLembreteTerca.ParameterName = "@diaLembreteTerca"; diaLembreteTerca.Value = lembrete.DiaLembrete.Item3; comando.Parameters.Add(diaLembreteTerca);
                    var diaLembreteQuarta = comando.CreateParameter(); diaLembreteQuarta.ParameterName = "@diaLembreteQuarta"; diaLembreteQuarta.Value = lembrete.DiaLembrete.Item4; comando.Parameters.Add(diaLembreteQuarta);
                    var diaLembreteQuinta = comando.CreateParameter(); diaLembreteQuinta.ParameterName = "@diaLembreteQuinta"; diaLembreteQuinta.Value = lembrete.DiaLembrete.Item5; comando.Parameters.Add(diaLembreteQuinta);
                    var diaLembreteSexta = comando.CreateParameter(); diaLembreteSexta.ParameterName = "@diaLembreteSexta"; diaLembreteSexta.Value = lembrete.DiaLembrete.Item6; comando.Parameters.Add(diaLembreteSexta);
                    var diaLembreteSabado = comando.CreateParameter(); diaLembreteSabado.ParameterName = "@diaLembreteSabado"; diaLembreteSabado.Value = lembrete.DiaLembrete.Item7; comando.Parameters.Add(diaLembreteSabado);
                    var tempopara = comando.CreateParameter(); tempopara.ParameterName = "@tempopara"; tempopara.Value = lembrete.TempoPara; comando.Parameters.Add(tempopara);
                    var datepara = comando.CreateParameter(); datepara.ParameterName = "@datepara"; datepara.Value = lembrete.DatePara; comando.Parameters.Add(datepara);
                    var Compromisso_id = comando.CreateParameter();
                    Compromisso_id.ParameterName = "@Compromisso_id";
                    Compromisso_id.Value = lembrete.Compromisso_id;
                    comando.Parameters.Add(Compromisso_id);

                    var id = comando.CreateParameter();
                    id.ParameterName = "@id";
                    id.Value = lembrete.Id;
                    comando.Parameters.Add(id);

                    //monta os comandos UPDATE
                    comando.CommandText = @"" +
                    "UPDATE compromisso SET titulo = @titulo, descricao = @descricao, dataHoraInicio = @dataHoraInicio, dataHoraFim = @dataHoraFim " +
                    "WHERE id = @Compromisso_id;" +
                    "UPDATE tb_lembrete SET tempoLembrete = @tempoLemebrete, tipoLembrete =  @tipoLembrete, diaLembrete_domingo = @diaLembreteDoming, diaLembrete_segunda = @diaLembreteSegunda, diaLembrete_terca = @diaLembreteTerca, diaLembrete_quarta = @diaLembreteQuarta, diaLembrete_quinta =  @diaLembreteQuinta, diaLembrete_sexta = @diaLembreteSexta, diaLembrete_sabado = @diaLembreteSabado, tempopara = @tempopara, datepara = @datepara  " +
                    "WHERE id_lembrete = @id;";

                             
                              
                    //executa o comando no banco de dados
                    comando.ExecuteNonQuery();
                }
            } //using faz o conexao.Close() automático quando fecha o seu escopo
        }



    }


}
    