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
        List<compromisso> agenda;
        dynamic aux;
        public void NotiVisible(bool flag)
        {
            this.labelNotificação.Visible = flag;
            this.labelNotificaçãoInstrução.Visible = flag;
            this.listBoxNoti.Visible = flag;
            this.labelNotificaçãoInstrução2.Visible = flag;
            this.labelNotificaçãoTempo.Visible = flag;
            this.TempoNotificacao.Visible = flag;
            this.label6.Visible = flag;
            this.comboBoxTempo.Visible = flag;
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
            this.listBoxConvidados.Visible = flag;
            this.textBoxConvidado.Visible = flag;
            this.buttonEditarConvidados.Visible = flag;
            this.buttonExcluirConvidados.Visible = flag;
            this.buttonSalvarConvidados.Visible = flag;
            this.textBoxLocal.Visible = flag;
            this.labelEmailDoConvidado.Visible = flag;
            this.labelLocal.Visible = flag;


        }
        public void LembreteVisible(bool flag)
        {
            this.labelLembretRepitir.Visible = flag;
            this.comboBoxTipoLembrete.Visible = flag;
            this.numericUpDownTempoLembrete.Visible = flag;
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
        }
        public FormCompromisso(dynamic aux, List<compromisso> agenda, DataGridView DataGridComp, MonthCalendar monthCalendarDataInicio, MonthCalendar monthCalendarDataFim)
        {
            this.aux = aux;
            this.DataGridComp = DataGridComp;
            this.agenda = agenda;
            InitializeComponent();
            numericUpDownOcorrenciasLembrete.Visible = false;
            dateTimePickerLembrete.Visible = false;
            StartPosition = FormStartPosition.Manual;
            Location = new(425, 110);
            Boxdatainicio.Value = monthCalendarDataInicio.SelectionStart;
            BoxDataFim.Text = monthCalendarDataFim.SelectionEnd.ToString();
            ButtonEditarComp.Enabled = false;
            ButtonExcluirComp.Enabled = false;
            buttonEditarConvidados.Enabled = false;
            buttonExcluirConvidados.Enabled = false;
            buttonSalvarConvidados.Enabled = false;
            if (aux is Tarefa)
            {
                comboBoxPrioridade.DataSource = Enum.GetValues(typeof(EnumPrioridade));
                comboBoxTempo.SelectedIndex = -1;
            }
            else if (aux is Lembrete)
            {
                checkBoxNunca.Checked = true;
                var aux2 = (Lembrete)aux;
                numericUpDownOcorrenciasLembrete.Visible = aux2.TempoPara == default ? false : true;
                dateTimePickerLembrete.Visible = aux2.DatePara == default ? false : true;
                CheckBoxData.Checked = aux2.TempoPara == default ? false : true;
                checkBoxOcorrencias.Checked = aux2.DatePara == default ? false : true;
                comboBoxTipoLembrete.DataSource = Enum.GetValues(typeof(EnumTipoLembrete));
                comboBoxTipoLembrete.SelectedItem = -1;
            }

        }
        private DataGridView DataGridComp;
        private DataGridView DataGridNoti;
        public FormCompromisso(dynamic aux, List<compromisso> agenda, DataGridView DataGridComp, DataGridView DataGridNoti)
        {
            this.DataGridNoti = DataGridNoti;
            this.DataGridComp = DataGridComp;
            this.agenda = agenda;
            InitializeComponent();

            numericUpDownOcorrenciasLembrete.Visible = false;
            dateTimePickerLembrete.Visible = false;
            StartPosition = FormStartPosition.Manual;
            Location = new(425, 110);
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipo));
            comboBoxTipo.SelectedIndex = -1;

            comboBoxTempo.DataSource = Enum.GetValues(typeof(EnumUnidade));
            comboBoxTempo.SelectedIndex = -1;

            comboBoxPrioridade.DataSource = Enum.GetValues(typeof(EnumPrioridade));
            comboBoxTempo.SelectedIndex = -1;




            textBoxTitulo.Text = aux.Titulo;
            TextBoxDescricao.Text = aux.Descricao;
            Boxdatainicio.Value = aux.Datahorainicio;
            BoxDataFim.Text = aux.Datahorafim.ToString();
            if (aux is Evento)
            {
                ButtonEditarComp.Enabled = false;
                ButtonExcluirComp.Enabled = false;
                listBoxConvidados.DataSource = aux.Convidados;
                listBoxConvidados.SelectedIndex = -1;
                textBoxLocal.Text = aux.Local;
            }
            else if (aux is Tarefa)
            {
                comboBoxPrioridade.SelectedItem = (EnumPrioridade)aux.Propriedade;
            }
            else if (aux is Lembrete)
            {
                checkBoxNunca.Checked = true;
                comboBoxTipoLembrete.DataSource = Enum.GetValues(typeof(EnumTipoLembrete));
                comboBoxTipoLembrete.SelectedItem = -1;
                comboBoxTipoLembrete.SelectedItem = (EnumTipoLembrete)aux.TipoLembrete;
                numericUpDownTempoLembrete.Value = aux.TempoLemebrete;
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
            ButtonSalvarComp.Enabled = false;
            ButtonEditarComp.Enabled = true;
            ButtonExcluirComp.Enabled = true;
            listBoxNoti.DataSource = aux.Notificacao;
            listBoxNoti.SelectedIndex = -1;
            this.aux = aux;
        }



        private void ButtonExcluirComp_Click(object sender, EventArgs e)
        {
            agenda.Remove(aux);
            DataGridComp.DataSource = null;
            DataGridComp.Rows.Clear();
            DataGridComp.DataSource = agenda;
            MessageBox.Show(aux.GetType().Name + " excluido");
            Close();
        }

        public void UpdateConvidados()
        {

            //var aux2 = (Evento)aux.CreateInstance();
            var aux2 = (Evento)aux;


            aux2.Convidados.Sort((x, y) => (x).CompareTo(y));
            listBoxConvidados.DataSource = null;
            listBoxConvidados.Items.Clear();
            listBoxConvidados.DataSource = aux.Convidados;
        }
        public void UpdateNotificaçã()
        {

            var aux2 = (compromisso)aux;
            switch (aux)
            {
                case Evento:
                    aux2 = (Evento)aux;
                    break;
                case Tarefa:
                    aux2 = (Tarefa)aux;
                    break;
                case Lembrete:
                    aux2 = (Lembrete)aux;
                    break;
            }

            aux2.Notificacao.Sort((x, y) => (x.Unidade).CompareTo(y.Unidade));
            aux2.Notificacao.Sort((a, z) => (a.Tempo).CompareTo(z.Tempo));
            listBoxNoti.DataSource = null;
            listBoxNoti.Items.Clear();
            listBoxNoti.DataSource = aux.Notificacao;
            DataGridNoti.DataSource = null;
            DataGridNoti.Rows.Clear();
            DataGridNoti.DataSource = aux.Notificacao;
        }

        public void SortAndShowComp()
        {
            agenda.Sort((x, y) => x.Datahorainicio.CompareTo(y.Datahorainicio));
            DataGridComp.DataSource = null;
            DataGridComp.Rows.Clear();
            DataGridComp.DataSource = agenda;
        }


        private void ButtonSalvarNoti_Click(object sender, EventArgs e)
        {
            aux.Notificacao.Add(new Notificacao((byte)TempoNotificacao.Value, (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade),
           comboBoxTempo.Text), (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text)));
            UpdateNotificaçã();
            MessageBox.Show("notificação salva");
        }

        private void listBoxNoti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNoti.SelectedItem != null)
            {
                Notificacao auxn = (Notificacao)listBoxNoti.SelectedItem;
                TempoNotificacao.Value = auxn.Tempo;
                comboBoxTempo.SelectedItem = (EnumUnidade)auxn.Unidade;
                comboBoxTipo.SelectedItem = (EnumTipo)auxn.Tipo;
                ButtonSalvarNoti.Enabled = false;
                ButtonEditarNoti.Enabled = true;
                ButtonExcluirNoti.Enabled = true;
            }
            else
            {
                ButtonSalvarNoti.Enabled = true;
                ButtonExcluirNoti.Enabled = false;
                ButtonEditarNoti.Enabled = false;
            }
        }

        private void ButtonEditarNoti_Click(object sender, EventArgs e)
        {
            Notificacao auxn = (Notificacao)listBoxNoti.SelectedItem;
            auxn.Tempo = (byte)TempoNotificacao.Value;
            auxn.Unidade = (char)(EnumUnidade)Enum.Parse(typeof(EnumUnidade), comboBoxTempo.Text);
            auxn.Tipo = (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text);
            UpdateNotificaçã();
            MessageBox.Show("notificação atualizada");
        }

        private void ButtonExcluirNoti_Click(object sender, EventArgs e)
        {
            Notificacao auxn = (Notificacao)listBoxNoti.SelectedItem;
            aux.Notificacao.Remove(auxn);
            SortAndShowComp(); //error if removed
            UpdateNotificaçã();
            MessageBox.Show("notificação excluida");
        }

        private void listBoxNoti_DoubleClick(object sender, EventArgs e)
        {
            listBoxNoti.SelectedItem = null;
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxConvidados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxConvidados.SelectedItem != null)
            {
                textBoxConvidado.Text = listBoxConvidados.SelectedItem.ToString();
                buttonSalvarConvidados.Enabled = false;
                buttonEditarConvidados.Enabled = true;
                buttonExcluirConvidados.Enabled = true;
            }
            else
            {
                buttonSalvarConvidados.Enabled = true;
                buttonEditarConvidados.Enabled = false;
                buttonExcluirConvidados.Enabled = false;
            }
        }

        private void buttonSalvarConvidados_Click(object sender, EventArgs e)
        {
            aux.Convidados.Add(textBoxConvidado.Text);
            UpdateConvidados();
            MessageBox.Show("convidado salvo");
        }

        private void buttonEditarConvidados_Click(object sender, EventArgs e)
        {

            aux.Convidados[listBoxConvidados.SelectedIndex] = textBoxConvidado.Text;
            UpdateConvidados();
            MessageBox.Show("convidado editado");
        }

        private void buttonExcluirConvidados_Click(object sender, EventArgs e)
        {
            aux.Convidados.RemoveAt(listBoxConvidados.SelectedIndex);
            textBoxConvidado.Text = "";
            MessageBox.Show("convidado excluida");
            UpdateConvidados();
        }

        private void listBoxConvidados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxConvidados.SelectedItem = null;
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
                    agenda.Add(new Evento("Evento", textBoxTitulo.Text, TextBoxDescricao.Text,
                        Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), textBoxLocal.Text));
                }

                else if (aux is Tarefa)
                {
                    agenda.Add(new Tarefa("Tarefa", textBoxTitulo.Text, TextBoxDescricao.Text,
                    Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture),
                    (char)(EnumPrioridade)Enum.Parse(typeof(EnumPrioridade), comboBoxPrioridade.Text)));
                }
                else if (aux is Lembrete)
                {
                    var aux2 = (Lembrete)aux;
                    if (CheckBoxData.Checked == true)
                    {
                        aux2.DatePara = dateTimePickerLembrete.Value;
                        agenda.Add(new Lembrete("Lembrete", textBoxTitulo.Text, TextBoxDescricao.Text,
                           Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), (byte)numericUpDownTempoLembrete.Value,
                           (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text), auxDiasLembrete, aux2.DatePara));
                    }
                    else
                    {
                        aux2.TempoPara = (int)numericUpDownOcorrenciasLembrete.Value;
                        agenda.Add(new Lembrete("Lembrete", textBoxTitulo.Text, TextBoxDescricao.Text,
                              Boxdatainicio.Value, DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture), (byte)numericUpDownTempoLembrete.Value,
                              (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text), auxDiasLembrete, default, aux2.TempoPara));
                    }
                }
                MessageBox.Show(aux.GetType().Name + " salvo");
                agenda.Sort((x, y) => x.Datahorainicio.CompareTo(y.Datahorainicio));
                DataGridComp.DataSource = null;
                DataGridComp.Rows.Clear();
                DataGridComp.DataSource = agenda;

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
            numericUpDownTempoLembrete.Value = 0;
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
            aux.Titulo = textBoxTitulo.Text;
            aux.Descricao = TextBoxDescricao.Text;
            aux.Datahorainicio = Boxdatainicio.Value;
            if (aux is Evento)
            {
                aux.Local = textBoxLocal.Text;
            }
            else if (aux is Tarefa)
            {
                aux.Propriedade = (char)(EnumPrioridade)Enum.Parse(typeof(EnumPrioridade), comboBoxPrioridade.SelectedItem.ToString());
                comboBoxPrioridade.SelectedItem = (EnumPrioridade)aux.Propriedade;
            }
            else if (aux is Lembrete)
            {
                aux.TempoLemebrete = (byte)numericUpDownTempoLembrete.Value;
                aux.TipoLembrete = (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipoLembrete.Text);
                aux.DiaLembrete = auxDiasLembrete;
                aux.DatePara = CheckBoxData.Checked == true ? dateTimePickerLembrete.Value : default;
                aux.TempoPara = checkBoxOcorrencias.Checked == true ? (int)numericUpDownOcorrenciasLembrete.Value : default;


            }

            try
            {
                aux.Datahorafim = DateTime.ParseExact(BoxDataFim.Text, "dd/MM/yyyy H:mm", null);
                MessageBox.Show(aux.GetType().Name + " atualizado");
            }
            catch (FormatException)
            {
                MessageBox.Show("data incorreta ou campos vazio");
            }

            SortAndShowComp();
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
    }
}
