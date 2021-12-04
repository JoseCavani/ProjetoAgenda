using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace agenda
{

    public partial class FormCompromisso : Form
    { 
        dynamic aux;
        public void NotiVisible(bool flag)
        {
            this.labelNotificação.Visible = flag;
            this.labelNotiId.Visible = flag;
            this.textBoxIdNoti.Visible = flag;
            this.dataGridViewNotificacoes.Visible = flag;
            this.labelNotificaçãoTempo.Visible = flag;
            this.TempoNotificacao.Visible = flag;
            this.label6.Visible = flag;
            this.comboBoxUnidade.Visible = flag;
            this.label7.Visible = flag;
            this.comboBoxTipo.Visible = flag;
            this.ButtonSalvarNoti.Visible = flag;
            this.ButtonEditarNoti.Visible = flag;
            this.ButtonExcluirNoti.Visible = flag;
            this.textBox1.Visible = flag;
        }

        public void TarefaVisible(bool flag)
        {
            this.comboBoxPrioridade.Visible = flag;
            this.labelPrioridade.Visible = flag;
        }
        public void EventoVisible(bool flag)
        {
            this.dataGridConvidado.Visible = flag;
            this.textBoxConvidado.Visible = flag;
            this.buttonEditarConvidados.Visible = flag;
            this.buttonExcluirConvidados.Visible = flag;
            this.buttonSalvarConvidados.Visible = flag;
            this.textBoxLocal.Visible = flag;
            this.labelEmailDoConvidado.Visible = flag;
            this.labelLocal.Visible = flag;


        }
        public void diasVisible(bool flag)
        {
            checkBoxDomingo.Visible = flag;
            checkBoxSegunda.Visible = flag;
            checkBoxTerca.Visible = flag;
            checkBoxQuarta.Visible = flag;
            checkBoxQuinta.Visible = flag;
            checkBoxSexta.Visible = flag;
            checkBoxSabado.Visible = flag;
            labelRepitir.Visible = flag;
        }
        public void LembreteVisible(bool flag)
        {
            this.labelLembretRepitir.Visible = flag;
            this.comboBoxTipoLembrete.Visible = flag;
            this.labelRepitir.Visible = flag;
            this.checkBoxDomingo.Visible = flag;
            this.checkBoxQuarta.Visible = flag;
            this.checkBoxQuinta.Visible = flag;
            this.checkBoxSabado.Visible = flag;
            this.checkBoxSegunda.Visible = flag;
            this.checkBoxSexta.Visible = flag;
            this.checkBoxTerca.Visible = flag;
            this.labelTerminarEm.Visible = flag;
            this.checkBoxOcorrencias.Visible = flag;
            this.checkBoxNunca.Visible = flag;
            this.CheckBoxData.Visible = flag;
            dateTimePickerLemb.Visible = flag;
            labelTimeLembrete.Visible = flag;
            numericUpDownOcorrenciasLembrete.Visible = flag;
            dateTimePickerLembrete.Visible = flag;
        }
        public void UpdateNotificaçã()
        {
            try
            {
                NotificacaoDAO dao = new();
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectNotificacoes(Program.providerName, Program.connectionStr, aux.Id);

                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewNotificacoes.Columns.Clear();
                dataGridViewNotificacoes.AutoGenerateColumns = true;
                dataGridViewNotificacoes.DataSource = linhas;
                dataGridViewNotificacoes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public FormCompromisso(dynamic aux)
        {
            InitializeComponent();
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipo));
            comboBoxTipo.SelectedIndex = -1;

            comboBoxUnidade.DataSource = Enum.GetValues(typeof(EnumUnidade));
            comboBoxUnidade.SelectedIndex = -1;


            diasVisible(false);
            //edit aux
            if (aux.Titulo != null)
            {
                textBoxTitulo.Text = aux.Titulo;
                TextBoxDescricao.Text = aux.Descricao;
                Boxdatainicio.Value = aux.Datahorainicio;
                BoxDataFim.Text = aux.Datahorafim.ToString();
                ButtonSalvarComp.Enabled = false;
                ButtonEditarComp.Enabled = true;
                ButtonExcluirComp.Enabled = true;
            }
            //new aux
            else
            {
                ButtonSalvarComp.Enabled = true;
                ButtonEditarComp.Enabled = false;
                ButtonExcluirComp.Enabled = false;
            }
                if (aux is Evento)
                {
                    
     
                    textBoxLocal.Text = aux.Local;
                }
            

            //both
             if (aux is Tarefa)
            {
                comboBoxPrioridade.DataSource = Enum.GetValues(typeof(EnumPrioridade));
                comboBoxUnidade.SelectedIndex = -1;
                comboBoxPrioridade.SelectedItem = (EnumPrioridade)aux.Propriedade;
            }
            else if (aux is Lembrete)
            {
                checkBoxNunca.Checked = true;
                comboBoxTipoLembrete.DataSource = Enum.GetValues(typeof(EnumTipoLembrete));
                comboBoxTipoLembrete.SelectedItem = -1;
                comboBoxTipoLembrete.SelectedItem = (EnumTipoLembrete)aux.TipoLembrete;
                var aux2 = (Lembrete)aux;
                numericUpDownOcorrenciasLembrete.Visible = aux2.TempoPara == default ? false : true;
                dateTimePickerLembrete.Visible = aux2.DatePara == default ? false : true;
                CheckBoxData.Checked = aux2.DatePara == default ? false : true;
                checkBoxOcorrencias.Checked = aux2.TempoPara == default ? false : true;
                if (checkBoxOcorrencias.Checked == true)
                {
                    numericUpDownOcorrenciasLembrete.Value = aux2.TempoPara;
                }
                else if (CheckBoxData.Checked == true)
                {
                    dateTimePickerLembrete.Value = aux2.DatePara;
                }
                checkBoxDomingo.Checked = aux.DiaLembrete.Item1 == true ? true : false;
                checkBoxSegunda.Checked = aux.DiaLembrete.Item2 == true ? true : false;
                checkBoxTerca.Checked = aux.DiaLembrete.Item3 == true ? true : false;
                checkBoxQuarta.Checked = aux.DiaLembrete.Item4 == true ? true : false;
                checkBoxQuinta.Checked = aux.DiaLembrete.Item5 == true ? true : false;
                checkBoxSexta.Checked = aux.DiaLembrete.Item6 == true ? true : false;
                checkBoxSabado.Checked = aux.DiaLembrete.Item7 == true ? true : false;

            }

            this.aux = aux;

            try
            {
                EventoDAO dao2 = new();
                UpdateConvidado(dao2);

                UpdateNotificaçã();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void ButtonExcluirComp_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux is Evento)
                {
                    // cria uma instancia da model
                    EventoDAO eventoDAO = new();

                    // chama o método da camada model para excluir
                    eventoDAO.ExcluirEvento(Program.providerName, Program.connectionStr, aux);

                    MessageBox.Show($"Dados excluidos com sucesso!", $"ID: {aux.Id}");
                }
                if (aux is Tarefa){
                // cria uma instancia da model
                TarefaDAO DAO = new();

                // chama o método da camada model para excluir
                DAO.ExcluirTarefa(Program.providerName, Program.connectionStr, aux);

                MessageBox.Show($"Dados excluidos com sucesso!", $"ID: {aux.Id}");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            Close();
        }
        
       
        private void UpdateConvidado(EventoDAO dao)
        {
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectConvidados(Program.providerName, Program.connectionStr, aux.Id);

                // seta o datasouce do dataGridView com os dados retornados
                dataGridConvidado.Columns.Clear();
                dataGridConvidado.AutoGenerateColumns = true;
                dataGridConvidado.DataSource = linhas;
                dataGridConvidado.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



            private void ButtonSalvarNoti_Click(object sender, EventArgs e)
        {
            Notificacao auxNotificacao = new Notificacao((byte)TempoNotificacao.Value, (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade),
           comboBoxUnidade.Text), (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text));
            NotificacaoDAO dao = new();
            dao.InserirNotificacao(Program.providerName, Program.connectionStr, auxNotificacao, aux.Id);
            MessageBox.Show("Notificação cadastrada com sucesso!\nSe estiver tudo OK, feche a tela!");
            UpdateNotificaçã();

        }

        private void ButtonEditarNoti_Click(object sender, EventArgs e)
        {
            try
            {
                Notificacao auxNotificacao = new((byte)TempoNotificacao.Value, (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade), comboBoxUnidade.Text), (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text));
                auxNotificacao.Id = Convert.ToInt32(textBoxIdNoti.Text);

                // cria uma instancia da model
                NotificacaoDAO dao = new();

                // chama o método da camada model para inserir
                dao.EditarNotificacao(Program.providerName, Program.connectionStr, auxNotificacao);

                MessageBox.Show("Notificação editada com sucesso!\nSe estiver tudo OK, feche a tela!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateNotificaçã();
        }

        private void ButtonExcluirNoti_Click(object sender, EventArgs e)
        {
            try
            {
                Notificacao auxNotificacao = new();
                auxNotificacao.Id = Convert.ToInt32(textBoxIdNoti.Text);

                // cria uma instancia da model
                NotificacaoDAO dao = new();

                // chama o método da camada model para inserir
                dao.ExcluirNotificacao(Program.providerName, Program.connectionStr, auxNotificacao);

                MessageBox.Show("Notificação excluida com sucesso!\nSe estiver tudo OK, feche a tela!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateNotificaçã();
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvarConvidados_Click(object sender, EventArgs e)
        {
            EventoDAO eventoDAO = new();
            //aux.Convidados.Add(textBoxConvidado.Text);
            eventoDAO.InserirConvidado(Program.providerName, Program.connectionStr, aux.Id, textBoxConvidado.Text);
            UpdateConvidado(eventoDAO);
            MessageBox.Show("convidado salvo");


        }

        


        private void buttonEditarConvidados_Click(object sender, EventArgs e)
        {
            ValueTuple<String, int> auxConvidado = (textBoxConvidado.Text, Convert.ToInt32(dataGridConvidado.CurrentRow.Cells[0].Value));
            EventoDAO eventoDAO = new();
            //aux.Convidados.Add(textBoxConvidado.Text);
            eventoDAO.EditarConvidado(Program.providerName, Program.connectionStr, auxConvidado.Item2, auxConvidado.Item1);
            UpdateConvidado(eventoDAO);
            MessageBox.Show("convidado editado");
        }


       

        private void buttonExcluirConvidados_Click(object sender, EventArgs e)
        {

            EventoDAO eventoDAO = new();
            //aux.Convidados.Add(textBoxConvidado.Text);
            eventoDAO.ExcluirConvidado(Program.providerName, Program.connectionStr, Convert.ToInt32(dataGridConvidado.CurrentRow.Cells[0].Value));
            UpdateConvidado(eventoDAO);
            MessageBox.Show("convidado excluida");
        }

        ValueTuple<bool, bool, bool, bool, bool, bool, bool> auxDiasLembrete = (false, false, false, false, false, false, false);
        private void checkBoxDomingo_CheckedChanged(object sender, EventArgs e)
        {
            auxDiasLembrete.Item1 = checkBoxDomingo.Checked == true ? true : false;
        }

        private void checkBoxSegunda_CheckedChanged(object sender, EventArgs e)
        {
            auxDiasLembrete.Item2 = checkBoxSegunda.Checked == true ? true : false;
        }

        private void checkBoxTerca_CheckedChanged(object sender, EventArgs e)
        {

            auxDiasLembrete.Item3 = checkBoxTerca.Checked == true ? true : false;
        }

        private void checkBoxQuarta_CheckedChanged(object sender, EventArgs e)
        {

            auxDiasLembrete.Item4 = checkBoxQuarta.Checked == true ? true : false;
        }

        private void checkBoxQuinta_CheckedChanged(object sender, EventArgs e)
        {

            auxDiasLembrete.Item5 = checkBoxQuinta.Checked == true ? true : false;
        }

        private void checkBoxSexta_CheckedChanged(object sender, EventArgs e)
        {

            auxDiasLembrete.Item6 = checkBoxSexta.Checked == true ? true : false;
        }

        private void checkBoxSabado_CheckedChanged(object sender, EventArgs e)
        {

            auxDiasLembrete.Item7 = checkBoxSabado.Checked == true ? true : false;
        }
        private void ButtonSalvarComp_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux is Evento)
                {
                    aux = new Evento(textBoxTitulo.Text, TextBoxDescricao.Text,
                        Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), textBoxLocal.Text);
                    EventoDAO eventoDAO = new();

                    // chama o método da camada model para inserir, e já captura o ID que foi gerado durante o insert
                    int idGerado = eventoDAO.InserirEvento(Program.providerName, Program.connectionStr, aux);

                    // alimenta no objeto o id gerado no banco de dados
                    aux.Id = idGerado;

                    MessageBox.Show($"Dados cadastrado com sucesso!", $"Evento ID: {idGerado}");
                    buttonSalvarConvidados.Enabled = true;
                }

                else if (aux is Tarefa)
                {
                    aux = new Tarefa(textBoxTitulo.Text, TextBoxDescricao.Text,
                    Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture),
                    (char)(EnumPrioridade)Enum.Parse(typeof(EnumPrioridade), comboBoxPrioridade.Text));

                    TarefaDAO tarefaDAO = new();

                    // chama o método da camada model para inserir, e já captura o ID que foi gerado durante o insert
                    int idGerado = tarefaDAO.InserirTarefa(Program.providerName, Program.connectionStr, aux);

                    // alimenta no objeto o id gerado no banco de dados
                    aux.Id = idGerado;

                    MessageBox.Show($"Dados cadastrado com sucesso!", $"Evento ID: {idGerado}");


                   /* agenda.Add(new Tarefa(textBoxTitulo.Text, TextBoxDescricao.Text,
                    Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture),
                    (char)(EnumPrioridade)Enum.Parse(typeof(EnumPrioridade), comboBoxPrioridade.Text)));*/
                }
            /*    else if (aux is Lembrete)
                {
                    var aux2 = (Lembrete)aux;
                    if (CheckBoxData.Checked == true)
                    {
                        aux2.DatePara = dateTimePickerLembrete.Value;
                        agenda.Add(new Lembrete( textBoxTitulo.Text, TextBoxDescricao.Text,
                           Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), (byte)numericUpDownTempoLembrete.Value,
                           (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text), auxDiasLembrete, aux2.DatePara));
                    }
                    else
                    {
                        aux2.TempoPara = (int)numericUpDownOcorrenciasLembrete.Value;
                        agenda.Add(new Lembrete( textBoxTitulo.Text, TextBoxDescricao.Text,
                              Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), (byte)numericUpDownTempoLembrete.Value,
                              (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text), auxDiasLembrete, default, aux2.TempoPara));
                    }
                }*/
                MessageBox.Show(aux.GetType().Name + " salvo");
                NotiVisible(true);

            }

            catch (FormatException)
            {
                MessageBox.Show("data incorreta ou campos vazios");
            }
            textBoxTitulo.Text = "";
            TextBoxDescricao.Text = "";
            Boxdatainicio.Value = DateTime.Now;
            BoxDataFim.Text = "";
            textBoxConvidado.Text = "";
            comboBoxTipoLembrete.Text = "Ano";
            dateTimePickerLemb.Value = default;
            comboBoxPrioridade.Text = "Alta";
            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
            checkBoxNunca.Checked = true;
        }
        private void ButtonEditarComp_Click(object sender, EventArgs e)
        {
            try
            {
                aux.Titulo = textBoxTitulo.Text;
            aux.Descricao = TextBoxDescricao.Text;
            aux.Datahorainicio = Boxdatainicio.Value;
            aux.Datahorafim = DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", null);
                if (aux is Evento)
            {
                aux.Local = textBoxLocal.Text;

                    // cria uma instancia da model
                    EventoDAO eventoDAO = new();

                    // chama o método da camada model para inserir, e já captura o ID que foi gerado durante o insert
                    eventoDAO.EditarEvento(Program.providerName, Program.connectionStr, aux);

                }
            else if (aux is Tarefa)
            {
                aux.Propriedade = (char)(EnumPrioridade)Enum.Parse(typeof(EnumPrioridade), comboBoxPrioridade.SelectedItem.ToString());
                    // cria uma instancia da model
                    TarefaDAO dao = new();

                    // chama o método da camada model para inserir, e já captura o ID que foi gerado durante o insert
                    dao.EditarTarefa(Program.providerName, Program.connectionStr, aux);
                }
                else if (aux is Lembrete)
            {
                    //to fix
                aux.TempoLemebrete = dateTimePickerLemb.Value;
                aux.TipoLembrete = (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text);
                aux.DiaLembrete = auxDiasLembrete;
                aux.DatePara = CheckBoxData.Checked == true ? dateTimePickerLembrete.Value : default;
                aux.TempoPara = checkBoxOcorrencias.Checked == true ? (int)numericUpDownOcorrenciasLembrete.Value : default;


            }
                MessageBox.Show(aux.GetType().Name + " atualizado");

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckBoxData_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxData.Checked == true)
            {
                checkBoxNunca.Checked = false;
                dateTimePickerLembrete.Visible = true;
                checkBoxOcorrencias.Checked = false;
                numericUpDownOcorrenciasLembrete.Visible = false;
            }
            else { dateTimePickerLembrete.Visible = false; }


        }

        private void checkBoxOcorrencias_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOcorrencias.Checked == true)
            {
                checkBoxNunca.Checked = false;
                dateTimePickerLembrete.Visible = false;
                numericUpDownOcorrenciasLembrete.Visible = true;
                CheckBoxData.Checked = false;
            }
            else { numericUpDownOcorrenciasLembrete.Visible = false; }
        }

        private void checkBoxNunca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNunca.Checked == true)
            {
                dateTimePickerLembrete.Visible = false;
                numericUpDownOcorrenciasLembrete.Visible = false;
                CheckBoxData.Checked = false;
                checkBoxOcorrencias.Checked = false;
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aux.AjudaNovo());
             
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aux.AjudaEdita());
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aux.AjudaDeleta());
        }


        private void dataGridViewNotificacoes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNotificacoes.SelectedRows.Count > 0)
            {
              
                    textBoxIdNoti.Text = dataGridViewNotificacoes.CurrentRow.Cells[0].Value.ToString();
                TempoNotificacao.Value = Convert.ToDecimal(dataGridViewNotificacoes.CurrentRow.Cells[1].Value);
                comboBoxUnidade.SelectedItem = (EnumUnidade)Convert.ToChar(dataGridViewNotificacoes.CurrentRow.Cells[2].Value);
                comboBoxTipo.SelectedItem = (EnumTipo)Convert.ToChar(dataGridViewNotificacoes.CurrentRow.Cells[3].Value);

                ButtonSalvarNoti.Enabled = false;
                ButtonEditarNoti.Enabled = true;
                ButtonExcluirNoti.Enabled = true;
            
                }
                else
                {
                    textBoxIdNoti.Clear();
                    TempoNotificacao.Value = 0;
                    comboBoxUnidade.SelectedIndex = -1;
                    comboBoxTipo.SelectedIndex = -1;

                    ButtonSalvarNoti.Enabled = true;
                    ButtonExcluirNoti.Enabled = false;
                    ButtonEditarNoti.Enabled = false;
                
            }
        }

        private void dataGridConvidado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridConvidado.SelectedRows.Count > 0)
            {
              
                    textBoxConvidado.Text = dataGridConvidado.CurrentRow.Cells[1].Value.ToString();
                 
                    buttonSalvarConvidados.Enabled = false;
                    buttonEditarConvidados.Enabled = true;
                    buttonExcluirConvidados.Enabled = true;
                
            }
            else
            {
                textBoxConvidado.Text = "";

                buttonSalvarConvidados.Enabled = true;
                buttonEditarConvidados.Enabled = false;
                buttonExcluirConvidados.Enabled = false;

            }
        }

        private void dataGridConvidado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridConvidado.ClearSelection();
        }

        private void dataGridConvidado_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridConvidado.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                dataGridConvidado.ClearSelection();
            dataGridConvidado.DataSource = null;
        }

        private void dataGridViewNotificacoes_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridViewNotificacoes.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell)
                dataGridViewNotificacoes.ClearSelection();
            dataGridViewNotificacoes.DataSource = null;
            UpdateNotificaçã();
        }

        private void dataGridViewNotificacoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewNotificacoes.ClearSelection();
        }

        private void dataGridConvidado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridConvidado.ClearSelection();
        }

        private void comboBoxTipoLembrete_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoLembrete.Text == "Dias")
            {
                diasVisible(true);
            }
        }

        private void dataGridViewNotificacoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != dataGridViewNotificacoes.NewRowIndex)
            {
                if (e.Value != null)
                {
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = (EnumTipo)char.Parse(e.Value.ToString());
                    }
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = (EnumUnidade)char.Parse(e.Value.ToString());
                    }
                }
            }
        }
    }
    }
    
    
