
namespace agenda
{
    partial class FormAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridComp = new System.Windows.Forms.DataGridView();
            this.DataGridNoti = new System.Windows.Forms.DataGridView();
            this.monthCalendarDataInicio = new System.Windows.Forms.MonthCalendar();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.monthCalendarDataFim = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNoti)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridComp
            // 
            this.DataGridComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridComp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridComp.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridComp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridComp.Location = new System.Drawing.Point(0, 2);
            this.DataGridComp.Name = "DataGridComp";
            this.DataGridComp.ReadOnly = true;
            this.DataGridComp.RowTemplate.Height = 25;
            this.DataGridComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridComp.Size = new System.Drawing.Size(640, 312);
            this.DataGridComp.TabIndex = 31;
            this.DataGridComp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridComp_CellClick);
            this.DataGridComp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridComp_CellDoubleClick);
            this.DataGridComp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridComp_DataBindingComplete);
            this.DataGridComp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridComp_MouseDown);
            // 
            // DataGridNoti
            // 
            this.DataGridNoti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridNoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNoti.Location = new System.Drawing.Point(0, 330);
            this.DataGridNoti.Name = "DataGridNoti";
            this.DataGridNoti.ReadOnly = true;
            this.DataGridNoti.RowTemplate.Height = 25;
            this.DataGridNoti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridNoti.Size = new System.Drawing.Size(494, 131);
            this.DataGridNoti.TabIndex = 32;
            this.DataGridNoti.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridNoti_CellFormatting);
            this.DataGridNoti.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridNoti_DataBindingComplete);
            // 
            // monthCalendarDataInicio
            // 
            this.monthCalendarDataInicio.Location = new System.Drawing.Point(652, 12);
            this.monthCalendarDataInicio.MaxSelectionCount = 1;
            this.monthCalendarDataInicio.Name = "monthCalendarDataInicio";
            this.monthCalendarDataInicio.ShowTodayCircle = false;
            this.monthCalendarDataInicio.TabIndex = 33;
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.Location = new System.Drawing.Point(517, 320);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(123, 25);
            this.ButtonNovo.TabIndex = 35;
            this.ButtonNovo.Text = "Novo Evento";
            this.ButtonNovo.UseVisualStyleBackColor = true;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovoEvento_Click);
            // 
            // monthCalendarDataFim
            // 
            this.monthCalendarDataFim.Location = new System.Drawing.Point(652, 183);
            this.monthCalendarDataFim.Name = "monthCalendarDataFim";
            this.monthCalendarDataFim.ShowTodayCircle = false;
            this.monthCalendarDataFim.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 37;
            this.button1.Text = "Nova Tarefa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonNovoTarefa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Novo Lembrete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNovoLembrete_Click);
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonFechar.Location = new System.Drawing.Point(788, 416);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(91, 45);
            this.ButtonFechar.TabIndex = 59;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(905, 474);
            this.Controls.Add(this.ButtonFechar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendarDataFim);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.monthCalendarDataInicio);
            this.Controls.Add(this.DataGridNoti);
            this.Controls.Add(this.DataGridComp);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "agenda do abc bolinhas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNoti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridComp;
        private System.Windows.Forms.DataGridView DataGridNoti;
        private System.Windows.Forms.MonthCalendar monthCalendarDataInicio;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.MonthCalendar monthCalendarDataFim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonFechar;
    }
}

