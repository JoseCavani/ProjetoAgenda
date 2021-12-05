using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

// o //codigo contem varias partes comentados fora para fins de lembrança sobre maneiras differentes de resolver os problemas

namespace agenda
{
    public enum EnumTipoLembrete
    {
        Dias = 'd',
        Dia = 'D',
        Semana = 'S',
        Mês = 'M',
        Ano = 'A',
    }
    public enum EnumPrioridade
    {
        Urgente = 'U',
        Alta = 'A',
        Normal = 'N',
        Baixa = 'B',
        Minima = 'M',
    }
    public enum EnumUnidade
    {
        Minutos = 'm',
        Horas = 'H',
        Dias = 'D',
        Semanas = 'S',  
        Meses = 'M',
        Anos = 'A'
    }
    public enum EnumTipo
    {
        [Description("E-mail")]
        Email = 'E',
        [Description("Notificação")]
        Notificação = 'N',
        [Description("Tremer")]
        Tremer = 'T'
    }

    public partial class FormAgenda : Form
    {
        List<compromisso> agenda;
        public FormAgenda(List<compromisso> agenda)
        {

            this.agenda = agenda;
            InitializeComponent();
            
            Update(new Evento());
            Update(new Tarefa());
            Update(new Lembrete());
            /*
            compromisso c2 = new compromisso();
            c2.Titulo = "C2";
            c2.Descricao = "compromisso C2";
            c2.Datahorainicio = new DateTime(2022, 9, 27, 19, 52, 00);
            c2.Datahorafim = new DateTime(2022, 10, 27, 22, 34, 54);
            c2.Notificacao.Add(new notificacao(20, "minutos", 'E'));
            agenda.Add(c2);

            compromisso c3 = new compromisso("C3", "compromisso C3", new DateTime(2026, 10, 15, 10, 30, 00), new DateTime(2026, 10, 17, 23, 10, 00));
            c3.Notificacao.Add(new notificacao(10, "minutos", 'E'));
            c3.Notificacao.Add(new notificacao(20, "minutos", 'E'));
            c3.Notificacao.Add(new notificacao(30, "minutos", 'E'));
            agenda.Add(c3);

            compromisso c4 = new compromisso("C4", new DateTime(2024, 10, 15, 10, 30, 00));
            c4.Descricao = "compromisso C4";
            c4.Datahorafim = new DateTime(2024, 10, 15, 10, 30, 00);
            agenda.Add(c4);

            compromisso c5 = new compromisso("C5", "compromisso C5", new DateTime(2025, 10, 15, 10, 30, 00), new DateTime(2025, 10, 15, 10, 30, 00));
            c5.Notificacao.Add(new notificacao(35, "minutos", 'T'));
            agenda.Add(c5);

            compromisso c7 = new compromisso();
            c7.Titulo = "C7";
            c7.Descricao = "compromisso C7";
            c7.Datahorainicio = new DateTime(2027, 9, 27, 19, 52, 00);
            c7.Datahorafim = new DateTime(2027, 10, 27, 22, 34, 54);
            c7.Notificacao.Add(new notificacao(70, "minutos", 'E'));
            c7.Notificacao.Add(new notificacao(75, "minutos", 'E'));
            agenda.Add(c7);

            compromisso c8 = new compromisso("C8", new DateTime(2024, 10, 15, 10, 30, 00));
            c8.Descricao = "compromisso C8";
            c8.Datahorafim = new DateTime(2028, 10, 15, 10, 30, 00);
            c8.Notificacao.Add(new notificacao(80, "minutos", 'E'));
            agenda.Add(c8);

            /* foreach (compromisso n in agenda)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Titulo}, {n.Descricao}, {n.Datahorainicio}, {n.Datahorafim}");
                 foreach (notificacao z in n.Notificacao)
                 {
                     textBoxcompromisso.AppendText($"{Environment.NewLine}{z.Tempo}-{z.Unidade}-{z.Tipo}");
                 }
             }
            */
            /* 
              textBoxcompromisso.AppendText($"{Environment.NewLine}{c1.Titulo}, {c1.Descricao}, {c1.Datahorainicio}, {c1.Datahorafim}");
             foreach (notificacao n in c1.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c2.Titulo}, {c2.Descricao}, {c2.Datahorainicio}, {c2.Datahorafim}");
             foreach (notificacao n in c2.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c3.Titulo}, {c3.Descricao}, {c3.Datahorainicio}, {c3.Datahorafim}");
             foreach (notificacao n in c3.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c4.Titulo}, {c4.Descricao}, {c4.Datahorainicio}, {c4.Datahorafim}");
             foreach (notificacao n in c4.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c5.Titulo}, {c5.Descricao}, {c5.Datahorainicio}, {c5.Datahorafim}");
             foreach (notificacao n in c5.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c6.Titulo}, {c6.Descricao}, {c6.Datahorainicio}, {c6.Datahorafim}");
             foreach (notificacao n in c6.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c7.Titulo}, {c7.Descricao}, {c7.Datahorainicio}, {c7.Datahorafim}");
             foreach (notificacao n in c7.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
             textBoxcompromisso.AppendText($"{Environment.NewLine}{c8.Titulo}, {c8.Descricao}, {c8.Datahorainicio}, {c8.Datahorafim}");
             foreach (notificacao n in c8.Notificacao)
             {
                 textBoxcompromisso.AppendText($"{Environment.NewLine}{n.Tempo}-{n.Unidade}-{n.Tipo}");
             }
            */
            StartPosition = FormStartPosition.Manual;
            Location = new(0, 0);


        }

        public void Update(compromisso aux)
        {

            if (aux is Evento)
            {


                try
                {
                    EventoDAO dao = new();

                    //chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = dao.SelectEventos(Program.providerName, Program.connectionStr);



                    // seta o datasouce do dataGridView com os dados retornados
                    DataGridEvento.Columns.Clear();
                    DataGridEvento.AutoGenerateColumns = true;
                    DataGridEvento.DataSource = linhas;
                    DataGridEvento.Columns[1].Visible = false;
                    DataGridEvento.Columns[0].Visible = false;
                    DataGridEvento.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (aux is Tarefa)
            {
                try
                {
                    TarefaDAO dao = new();

                    //chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = dao.SelectTarefa(Program.providerName, Program.connectionStr);



                    // seta o datasouce do dataGridView com os dados retornados
                    dataGridTarefa.Columns.Clear();
                    dataGridTarefa.AutoGenerateColumns = true;
                    dataGridTarefa.DataSource = linhas;
                    dataGridTarefa.Columns[1].Visible = false;
                    dataGridTarefa.Columns[0].Visible = false;
                    dataGridTarefa.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (aux is Lembrete)
            {
                try
                {
                    Lembrete aux2 = (Lembrete)aux;
                    LembreteDAO dao = new();

                    //chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = dao.SelectLembrete(Program.providerName, Program.connectionStr);



                    // seta o datasouce do dataGridView com os dados retornados
                    dataGridLembrete.Columns.Clear();
                    dataGridLembrete.AutoGenerateColumns = true;
                    dataGridLembrete.DataSource = linhas;
                    dataGridLembrete.Columns[1].Visible = false;
                    dataGridLembrete.Columns[0].Visible = false;
                    dataGridLembrete.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void UpdateNoti(compromisso aux)
        {
            try
            {
                NotificacaoDAO dao = new();
                if (aux is Evento)
                {
                    aux.Id = (int)DataGridEvento.CurrentRow.Cells[1].Value;
                }
                else if (aux is Tarefa)
                {
                    aux.Id = (int)dataGridTarefa.CurrentRow.Cells[1].Value;
                }
                else
                {
                    aux.Id = (int)dataGridLembrete.CurrentRow.Cells[1].Value;
                }
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectNotificacoes(Program.providerName, Program.connectionStr, aux.Id);

                // seta o datasouce do dataGridView com os dados retornados
                DataGridNoti.Columns.Clear();
                DataGridNoti.AutoGenerateColumns = true;
                DataGridNoti.DataSource = linhas;
                DataGridNoti.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonNovoEvento_Click(object sender, EventArgs e)
        {
            Opacity = .25;
            Evento aux = new();
            aux.Titulo = null;
            FormCompromisso FormComp = new FormCompromisso(aux);
            FormComp.TarefaVisible(false);
            FormComp.LembreteVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
            Update(aux);
            Opacity = 1.00;
        }
        private void ButtonNovoTarefa_Click(object sender, EventArgs e)
        {
            Tarefa aux = new();
            aux.Titulo = null;
            Opacity = .25;
            FormCompromisso FormComp = new FormCompromisso(aux);
            FormComp.EventoVisible(false);
            FormComp.LembreteVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
            Update(aux);
            Opacity = 1.00;
        }
        private void buttonNovoLembrete_Click(object sender, EventArgs e)
        {


            Lembrete aux = new();
            aux.Titulo = null;
            Opacity = .25;
            FormCompromisso FormComp = new FormCompromisso(aux);
            FormComp.EventoVisible(false);
            FormComp.TarefaVisible(false);
            FormComp.NotiVisible(false);
            FormComp.ShowDialog();
            Update(aux);
            Opacity = 1.00;
        }


        /*  private void DataGridComp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
           {


                   if (DataGridEvento.SelectedRows.Count != 0)
                   {
                   dynamic aux = new Evento(DataGridEvento.CurrentRow.Cells[1].Value.ToString(), DataGridEvento.CurrentRow.Cells[2].Value.ToString(), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[3].Value), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[4].Value), DataGridEvento.CurrentRow.Cells[5].Value.ToString(), null);
                   aux.Id = (int)DataGridEvento.CurrentRow.Cells[0].Value;

                   //       MessageBox.Show($"{aux.GetType()}");
                   FormCompromisso FormComp = new FormCompromisso(aux, agenda);
                   switch (aux)
                   {

                       case Evento:
                           FormComp.TarefaVisible(false);
                           FormComp.LembreteVisible(false);
                           break;
                       case Tarefa:
                           FormComp.EventoVisible(false);
                           FormComp.LembreteVisible(false);
                           break;
                       case Lembrete:
                           FormComp.EventoVisible(false);
                           FormComp.TarefaVisible(false);
                           break;
                   }
                   FormComp.ShowDialog();
                       DataGridNoti.DataSource = null;
                       DataGridNoti.Rows.Clear();                
                    SortAndShow(aux);
               }
           }
        */
        //unica maneira de fazer nao selecionar nada depois de invocar o sortandshowcomp metodo

        private void DataGridNoti_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridNoti.ClearSelection();
        }

        private void DataGridNoti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex != DataGridNoti.NewRowIndex)
            {
                if (e.Value != null)
                {
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = (EnumUnidade)char.Parse(e.Value.ToString());
                    }
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = (EnumTipo)char.Parse(e.Value.ToString());
                    }
                }
            }
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridEvento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridEvento.ClearSelection();
        }

        private void DataGridEvento_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = DataGridEvento.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                DataGridEvento.ClearSelection();
            DataGridNoti.DataSource = null;
        }

        private void dataGridTarefa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridTarefa.SelectedRows.Count != 0)
            {
                Opacity = 0;
                dynamic aux = new Tarefa(dataGridTarefa.CurrentRow.Cells[2].Value.ToString(), dataGridTarefa.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(dataGridTarefa.CurrentRow.Cells[4].Value), Convert.ToDateTime(dataGridTarefa.CurrentRow.Cells[5].Value), char.Parse(dataGridTarefa.CurrentRow.Cells[6].Value.ToString()), null);
                aux.Id = (int)dataGridTarefa.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridTarefa.CurrentRow.Cells[1].Value;

                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.EventoVisible(false);
                FormComp.LembreteVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;
            }
        }



        private void dataGridLembrete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridLembrete.SelectedRows.Count != 0)
            {

                ValueTuple<bool, bool, bool, bool, bool, bool, bool> diaLembrete = (false, false, false, false, false, false, false);
                Opacity = 0;
                Lembrete aux = new Lembrete(dataGridLembrete.CurrentRow.Cells[2].Value.ToString(), dataGridLembrete.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[4].Value), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[5].Value), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[6].Value), char.Parse(dataGridLembrete.CurrentRow.Cells[7].Value.ToString()));
                aux.Id = (int)dataGridLembrete.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridLembrete.CurrentRow.Cells[1].Value;
                diaLembrete.Item1 = (bool)dataGridLembrete.CurrentRow.Cells[8].Value;
                diaLembrete.Item2 = (bool)dataGridLembrete.CurrentRow.Cells[9].Value;
                diaLembrete.Item3 = (bool)dataGridLembrete.CurrentRow.Cells[10].Value;
                diaLembrete.Item4 = (bool)dataGridLembrete.CurrentRow.Cells[11].Value;
                diaLembrete.Item5 = (bool)dataGridLembrete.CurrentRow.Cells[12].Value;
                diaLembrete.Item6 = (bool)dataGridLembrete.CurrentRow.Cells[13].Value;
                diaLembrete.Item7 = (bool)dataGridLembrete.CurrentRow.Cells[14].Value;
                aux.DiaLembrete = diaLembrete;
                aux.TempoPara = (int)dataGridLembrete.CurrentRow.Cells[15].Value;
                aux.DatePara = Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[16].Value);


                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.EventoVisible(false);
                FormComp.TarefaVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;
            }
        }

        private void DataGridEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridEvento.SelectedRows.Count != 0)
            {
                Opacity = 0;
                dynamic aux = new Evento(DataGridEvento.CurrentRow.Cells[2].Value.ToString(), DataGridEvento.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[4].Value), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[5].Value), DataGridEvento.CurrentRow.Cells[6].Value.ToString(), null);
                aux.Id = (int)DataGridEvento.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)DataGridEvento.CurrentRow.Cells[1].Value;

                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.TarefaVisible(false);
                FormComp.LembreteVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;
            }
        }
        private void dataGridTarefa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != dataGridTarefa.NewRowIndex)
            {
                if (e.Value != null)
                {
                    if (e.ColumnIndex == 6)
                    {
                        e.Value = (EnumPrioridade)char.Parse(e.Value.ToString());
                    }
                }
            }
        }

        private void DataGridEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento aux = new();
            dataGridTarefa.ClearSelection();
            dataGridLembrete.ClearSelection();



            UpdateNoti(aux);
        }

        private void dataGridTarefa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridTarefa.ClearSelection();
        }

        private void dataGridTarefa_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridTarefa.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                dataGridTarefa.ClearSelection();
            DataGridNoti.DataSource = null;
        }

        private void dataGridTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tarefa aux = new();
            dataGridLembrete.ClearSelection();
            DataGridEvento.ClearSelection();
            UpdateNoti(aux);
        }


        private void dataGridLembrete_SelectionChanged(object sender, EventArgs e)
        {

            var x = dataGridLembrete.CurrentRow.Index;

            if ((int)dataGridLembrete.CurrentRow.Cells[15].Value != 0)
            {
                dataGridLembrete.Columns[15].Visible = true;
            }
            else if (dataGridLembrete.CurrentRow.Cells[16].Value != null)
            {
                dataGridLembrete.Columns[16].Visible = true;
                dataGridLembrete.Columns[15].Visible = false;
            }


            if (char.Parse(dataGridLembrete.CurrentRow.Cells[7].Value.ToString()) == 'd')
            {
                for (int i = 8; i < 15; i++)
                {
                    dataGridLembrete.Columns[i].Visible = true;
                }

            }
            else
            {

                for (int i = 8; i < 15; i++)
                {
                    dataGridLembrete.Columns[i].Visible = false;
                }
            }

            if (dataGridLembrete.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridLembrete.RowCount; i++)
                {
                    if (i != x)
                    {
                        dataGridLembrete.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridLembrete.RowCount; i++)
                {
                    dataGridLembrete.Rows[i].Visible = true;
                }
                for (int i = 8; i < 17; i++)
                {
                    dataGridLembrete.Columns[i].Visible = false;
                }
            }
            Lembrete aux = new();
            UpdateNoti(aux);
            dataGridTarefa.ClearSelection();
            DataGridEvento.ClearSelection();


        }
        
        private void dataGridLembrete_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridLembrete.ClearSelection();


            dataGridLembrete.Refresh();


        }

        private void dataGridLembrete_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridLembrete.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                dataGridLembrete.ClearSelection();
            DataGridNoti.DataSource = null;
        }

        private void dataGridLembrete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != dataGridLembrete.NewRowIndex)
            {
                if (e.Value != null)
                {
                    if (e.ColumnIndex == 7)
                    {
                        e.Value = (EnumTipoLembrete)char.Parse(e.Value.ToString());
                    }
                }
            }
        }

        private void buttonEditarEvento_Click(object sender, EventArgs e)
        {
            if (DataGridEvento.SelectedRows.Count != 0)
            {
                Opacity = 0;
                dynamic aux = new Evento(DataGridEvento.CurrentRow.Cells[2].Value.ToString(), DataGridEvento.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[4].Value), Convert.ToDateTime(DataGridEvento.CurrentRow.Cells[5].Value), DataGridEvento.CurrentRow.Cells[6].Value.ToString(), null);
                aux.Id = (int)DataGridEvento.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)DataGridEvento.CurrentRow.Cells[1].Value;

                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.TarefaVisible(false);
                FormComp.LembreteVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;
            }
        }

        private void buttonExcluirEvento_Click(object sender, EventArgs e)
        {
            if (dataGridTarefa.SelectedRows.Count != 0)
            {
                EventoDAO eventoDAO = new();
                dynamic aux = new Evento();
                aux.Id = (int)DataGridEvento.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)DataGridEvento.CurrentRow.Cells[1].Value;
                //aux.Convidados.Add(textBoxConvidado.Text);
                eventoDAO.ExcluirEvento(Program.providerName, Program.connectionStr, aux);
                MessageBox.Show($"Dados excluidos com sucesso!", $"ID: {aux.Id}");
                Update(aux);
            }
        }

        private void buttonEditarTarefa_Click(object sender, EventArgs e)
        {
            if (dataGridTarefa.SelectedRows.Count != 0)
            {
                Opacity = 0;
                dynamic aux = new Tarefa(dataGridTarefa.CurrentRow.Cells[2].Value.ToString(), dataGridTarefa.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(dataGridTarefa.CurrentRow.Cells[4].Value), Convert.ToDateTime(dataGridTarefa.CurrentRow.Cells[5].Value), char.Parse(dataGridTarefa.CurrentRow.Cells[6].Value.ToString()), null);
                aux.Id = (int)dataGridTarefa.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridTarefa.CurrentRow.Cells[1].Value;

                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.EventoVisible(false);
                FormComp.LembreteVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;
            }
        }

        private void buttonExcluirTarefa_Click(object sender, EventArgs e)
        {
            if (dataGridTarefa.SelectedRows.Count != 0)
            {
                // cria uma instancia da model
                TarefaDAO DAO = new();
                dynamic aux = new Tarefa();
                aux.Id = (int)dataGridTarefa.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridTarefa.CurrentRow.Cells[1].Value;
                // chama o método da camada model para excluir
                DAO.ExcluirTarefa(Program.providerName, Program.connectionStr, aux);

                MessageBox.Show($"Dados excluidos com sucesso!", $"ID: {aux.Id}");
                Update(aux);
            }
        }

        private void buttonEditarLembrete_Click(object sender, EventArgs e)
        {
            if (dataGridLembrete.SelectedRows.Count != 0)
            {

                ValueTuple<bool, bool, bool, bool, bool, bool, bool> diaLembrete = (false, false, false, false, false, false, false);
                Opacity = 0;
                Lembrete aux = new Lembrete(dataGridLembrete.CurrentRow.Cells[2].Value.ToString(), dataGridLembrete.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[4].Value), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[5].Value), Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[6].Value), char.Parse(dataGridLembrete.CurrentRow.Cells[7].Value.ToString()));
                aux.Id = (int)dataGridLembrete.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridLembrete.CurrentRow.Cells[1].Value;
                diaLembrete.Item1 = (bool)dataGridLembrete.CurrentRow.Cells[8].Value;
                diaLembrete.Item2 = (bool)dataGridLembrete.CurrentRow.Cells[9].Value;
                diaLembrete.Item3 = (bool)dataGridLembrete.CurrentRow.Cells[10].Value;
                diaLembrete.Item4 = (bool)dataGridLembrete.CurrentRow.Cells[11].Value;
                diaLembrete.Item5 = (bool)dataGridLembrete.CurrentRow.Cells[12].Value;
                diaLembrete.Item6 = (bool)dataGridLembrete.CurrentRow.Cells[13].Value;
                diaLembrete.Item7 = (bool)dataGridLembrete.CurrentRow.Cells[14].Value;
                aux.DiaLembrete = diaLembrete;
                aux.TempoPara = (int)dataGridLembrete.CurrentRow.Cells[15].Value;
                aux.DatePara = Convert.ToDateTime(dataGridLembrete.CurrentRow.Cells[16].Value);


                //       MessageBox.Show($"{aux.GetType()}");
                FormCompromisso FormComp = new FormCompromisso(aux);
                FormComp.StartPosition = FormStartPosition.CenterScreen;
                FormComp.EventoVisible(false);
                FormComp.TarefaVisible(false);
                FormComp.ShowDialog();
                Update(aux);
                Opacity = 100;

            }
        }

        private void buttonExcluirLembrete_Click(object sender, EventArgs e)
        {
            if (dataGridTarefa.SelectedRows.Count != 0)
            {
                LembreteDAO DAO = new();
                dynamic aux = new Lembrete();
                aux.Id = (int)dataGridLembrete.CurrentRow.Cells[0].Value;
                aux.Compromisso_id = (int)dataGridLembrete.CurrentRow.Cells[1].Value;
                // chama o método da camada model para excluir
                DAO.ExcluirLembrete(Program.providerName, Program.connectionStr, aux);

                MessageBox.Show($"Dados excluidos com sucesso!", $"ID: {aux.Id}");
                Update(aux);
            }
        }
    }

    }



/* private void SalvarNoti_Click(object sender, EventArgs e)
 {
     compromisso aux = (compromisso)DataGridComp.CurrentRow.DataBoundItem;

     aux.Notificacao.Add(new Notificacao((byte)TempoNotificacao.Value, (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade),
    comboBoxTempo.Text), (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text)));
     sortandshownoti();
 }


 private void buttonListar_Click(object sender, EventArgs e)
 {
     sortandshowcomp();

     /* try
      {
          foreach (compromisso n in agenda)
          {
              textboxcompromissos.AppendText($"{Environment.NewLine}{n.Titulo}, {n.Descricao}, {n.Datahorainicio}, {n.Datahorafim}");
              foreach (notificacao z in n.Notificacao)
              {
                  textboxcompromissos.AppendText($"{Environment.NewLine}{z.Tempo}, {z.Unidade}, {z.Tipo}");
              }
          }
      }
      catch (NullReferenceException)
      {
          MessageBox.Show("NullReferenceException");
      }
  */




/*

 private void ButtonExcluirComp_Click(object sender, EventArgs e)
 {
     compromisso aux = (compromisso)DataGridComp.CurrentRow.DataBoundItem;

     agenda.Remove(aux);
     sortandshowcomp();

     //a segunte parte foi commentado fora pois e utilizado para varios items selecionados e o codigo acima funciona com apenas um melhorando o desempenho essa logica segue nos outros botoes tambem
     /* for (int x = listboxcompromissos.SelectedIndices.Count - 1; x >= 0; x--)
      {
          int idx = listboxcompromissos.SelectedIndices[x];
          agenda.RemoveAt(idx);
      }
     */

/*
    private void DataGridNoti_SelectionChanged(object sender, EventArgs e)
    {
        if (DataGridNoti.SelectedRows.Count != 0)
        {
            try
            {
                Notificacao auxn = (Notificacao)DataGridNoti.CurrentRow.DataBoundItem;
                TempoNotificacao.Value = auxn.Tempo;
                comboBoxTempo.SelectedItem = (EnumUnidade)auxn.Unidade;
                comboBoxTipo.SelectedItem = (EnumTipo)auxn.Tipo;
                ButtonSalvarNoti.Enabled = false;
                ButtonEditarNoti.Enabled = true;
                ButtonExcluirNoti.Enabled = true;
            }
            catch (IndexOutOfRangeException) { }
        }
        else
        {
            TempoNotificacao.Value = 0;
            comboBoxTempo.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;

            ButtonSalvarNoti.Enabled = true;
            ButtonEditarNoti.Enabled = false;
            ButtonExcluirNoti.Enabled = false;

        }
        /*notificacao auxnoti = (notificacao)listBoxnotificacao.SelectedItem;

        if (auxnoti != null)
        {
            temponotificacao.Value = auxnoti.Tempo;
            comboBoxtipo.Text = auxnoti.Unidade;
            maskedTextBoxnotitipo.Text = auxnoti.Tipo.ToString();
        }
            */


/*
  private void ButtonExcluirNoti_Click(object sender, EventArgs e)
{
    compromisso aux = (compromisso)DataGridComp.CurrentRow.DataBoundItem;
    Notificacao auxn = (Notificacao)DataGridNoti.CurrentRow.DataBoundItem;

    aux.Notificacao.Remove(auxn);
    sortandshownoti();
    /*
    for (int x = listboxcompromissos.SelectedIndices.Count - 1; x >= 0; x--)
    {
        int idx = listboxcompromissos.SelectedIndices[x];
        for (int x2 = listBoxnotificacao.SelectedIndices.Count - 1; x >= 0; x--)
        {
            int idx2 = listBoxnotificacao.SelectedIndices[x2];
            agenda[idx].Notificacao.RemoveAt(idx2);               
        }
    }
    */

/*
 * private void ButtonEditarComp_Click(object sender, EventArgs e)
{
    compromisso aux = (compromisso)DataGridComp.CurrentRow.DataBoundItem;

    aux.Titulo = textBoxTitulo.Text;
    aux.Descricao = textBox1descricao.Text;
    aux.Datahorainicio = datainicio.Value;

    try
    {
        aux.Datahorafim = DateTime.ParseExact(datafim.Text, "MM/dd/yyyy H:mm", null);
    }
    catch (FormatException)
    {
        MessageBox.Show("data incorreta");
    }
    sortandshowcomp();
    /*
    for (int x = listboxcompromissos.SelectedIndices.Count - 1; x >= 0; x--)
    {
        int idx = listboxcompromissos.SelectedIndices[x];
        agenda.RemoveAt(idx);
    }*/


/*private void ButtonEditarNoti_Click(object sender, EventArgs e)
{
    Notificacao auxn = (Notificacao)DataGridNoti.CurrentRow.DataBoundItem;



    auxn.Tempo = (byte)TempoNotificacao.Value;
    auxn.Unidade = (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade), comboBoxTempo.Text);
    auxn.Tipo = (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text);
    sortandshownoti();

    /*
     for (int x = listboxcompromissos.SelectedIndices.Count - 1; x >= 0; x--)
     {
         int idx = listboxcompromissos.SelectedIndices[x];
         for (int x2 = listBoxnotificacao.SelectedIndices.Count - 1; x >= 0; x--)
         {
             int idx2 = listBoxnotificacao.SelectedIndices[x2];
             agenda[idx].Notificacao.RemoveAt(idx2);
             agenda[idx].Notificacao.Add(new notificacao(auxn.Tempo, auxn.Unidade, auxn.Tipo));
         }
     }
     */

// public static compromisso DataGridViewSelectedRowCollection;







//comentarios que me ajudaram na hora de criar o codigo (essa parte e um lembrete para mim)

// SelectedIndices = for multiple
//SelectedIndex = for singular

//.parse ---> string para outra coisa
//converção numerica faz casting (byte)

//scale vertically on designs
//screen is a stack not a line

//object = collection of variables
//variables = box that holds values
//properties are variables that are attached to the object
//class = blueprint, it creates object 
//function = machine it gets an input and returns sometinh (like a calculator input number and + and get the anwser
//function calculateage(birthdate)
//corey schefer = item porgraming tutorial and net ninja https://www.youtube.com/playlist?list=PL4cUxeGkcC9haFPT7J25Q9GRB_ZkFrQAc

//methoad = function attachted to an object