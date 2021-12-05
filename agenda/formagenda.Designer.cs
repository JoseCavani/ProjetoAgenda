
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
            this.DataGridEvento = new System.Windows.Forms.DataGridView();
            this.DataGridNoti = new System.Windows.Forms.DataGridView();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridTarefa = new System.Windows.Forms.DataGridView();
            this.dataGridLembrete = new System.Windows.Forms.DataGridView();
            this.buttonEditarEvento = new System.Windows.Forms.Button();
            this.buttonExcluirEvento = new System.Windows.Forms.Button();
            this.buttonEditarTarefa = new System.Windows.Forms.Button();
            this.buttonExcluirTarefa = new System.Windows.Forms.Button();
            this.buttonEditarLembrete = new System.Windows.Forms.Button();
            this.buttonExcluirLembrete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLembrete)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEvento
            // 
            this.DataGridEvento.AllowUserToAddRows = false;
            this.DataGridEvento.AllowUserToDeleteRows = false;
            this.DataGridEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEvento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEvento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridEvento.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridEvento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridEvento.Location = new System.Drawing.Point(0, 2);
            this.DataGridEvento.MultiSelect = false;
            this.DataGridEvento.Name = "DataGridEvento";
            this.DataGridEvento.ReadOnly = true;
            this.DataGridEvento.RowTemplate.Height = 25;
            this.DataGridEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEvento.Size = new System.Drawing.Size(997, 176);
            this.DataGridEvento.TabIndex = 31;
            this.DataGridEvento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEvento_CellClick);
            this.DataGridEvento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEvento_CellDoubleClick);
            this.DataGridEvento.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridEvento_DataBindingComplete);
            this.DataGridEvento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridEvento_MouseDown);
            // 
            // DataGridNoti
            // 
            this.DataGridNoti.AllowUserToAddRows = false;
            this.DataGridNoti.AllowUserToDeleteRows = false;
            this.DataGridNoti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridNoti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridNoti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridNoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNoti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridNoti.Location = new System.Drawing.Point(0, 632);
            this.DataGridNoti.Name = "DataGridNoti";
            this.DataGridNoti.ReadOnly = true;
            this.DataGridNoti.RowTemplate.Height = 25;
            this.DataGridNoti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridNoti.Size = new System.Drawing.Size(997, 105);
            this.DataGridNoti.TabIndex = 32;
            this.DataGridNoti.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridNoti_CellFormatting);
            this.DataGridNoti.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridNoti_DataBindingComplete);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.Location = new System.Drawing.Point(196, 184);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(123, 25);
            this.ButtonNovo.TabIndex = 35;
            this.ButtonNovo.Text = "Novo Evento";
            this.ButtonNovo.UseVisualStyleBackColor = true;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovoEvento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 37;
            this.button1.Text = "Nova Tarefa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonNovoTarefa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Novo Lembrete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNovoLembrete_Click);
            // 
            // dataGridTarefa
            // 
            this.dataGridTarefa.AllowUserToAddRows = false;
            this.dataGridTarefa.AllowUserToDeleteRows = false;
            this.dataGridTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTarefa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefa.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridTarefa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridTarefa.Location = new System.Drawing.Point(0, 215);
            this.dataGridTarefa.Name = "dataGridTarefa";
            this.dataGridTarefa.ReadOnly = true;
            this.dataGridTarefa.RowTemplate.Height = 25;
            this.dataGridTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTarefa.Size = new System.Drawing.Size(997, 154);
            this.dataGridTarefa.TabIndex = 60;
            this.dataGridTarefa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTarefa_CellClick);
            this.dataGridTarefa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTarefa_CellDoubleClick);
            this.dataGridTarefa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridTarefa_CellFormatting);
            this.dataGridTarefa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridTarefa_DataBindingComplete);
            this.dataGridTarefa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridTarefa_MouseDown);
            // 
            // dataGridLembrete
            // 
            this.dataGridLembrete.AllowUserToAddRows = false;
            this.dataGridLembrete.AllowUserToDeleteRows = false;
            this.dataGridLembrete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLembrete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridLembrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLembrete.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridLembrete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridLembrete.Location = new System.Drawing.Point(0, 405);
            this.dataGridLembrete.Name = "dataGridLembrete";
            this.dataGridLembrete.ReadOnly = true;
            this.dataGridLembrete.RowTemplate.Height = 25;
            this.dataGridLembrete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLembrete.Size = new System.Drawing.Size(997, 187);
            this.dataGridLembrete.TabIndex = 61;
            this.dataGridLembrete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLembrete_CellDoubleClick);
            this.dataGridLembrete.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridLembrete_CellFormatting);
            this.dataGridLembrete.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridLembrete_DataBindingComplete);
            this.dataGridLembrete.SelectionChanged += new System.EventHandler(this.dataGridLembrete_SelectionChanged);
            this.dataGridLembrete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridLembrete_MouseDown);
            // 
            // buttonEditarEvento
            // 
            this.buttonEditarEvento.Location = new System.Drawing.Point(455, 184);
            this.buttonEditarEvento.Name = "buttonEditarEvento";
            this.buttonEditarEvento.Size = new System.Drawing.Size(123, 25);
            this.buttonEditarEvento.TabIndex = 62;
            this.buttonEditarEvento.Text = "Editar Evento";
            this.buttonEditarEvento.UseVisualStyleBackColor = true;
            this.buttonEditarEvento.Click += new System.EventHandler(this.buttonEditarEvento_Click);
            // 
            // buttonExcluirEvento
            // 
            this.buttonExcluirEvento.Location = new System.Drawing.Point(728, 184);
            this.buttonExcluirEvento.Name = "buttonExcluirEvento";
            this.buttonExcluirEvento.Size = new System.Drawing.Size(123, 25);
            this.buttonExcluirEvento.TabIndex = 63;
            this.buttonExcluirEvento.Text = "Excluir Evento";
            this.buttonExcluirEvento.UseVisualStyleBackColor = true;
            this.buttonExcluirEvento.Click += new System.EventHandler(this.buttonExcluirEvento_Click);
            // 
            // buttonEditarTarefa
            // 
            this.buttonEditarTarefa.Location = new System.Drawing.Point(455, 375);
            this.buttonEditarTarefa.Name = "buttonEditarTarefa";
            this.buttonEditarTarefa.Size = new System.Drawing.Size(123, 24);
            this.buttonEditarTarefa.TabIndex = 64;
            this.buttonEditarTarefa.Text = "Editar Tarefa";
            this.buttonEditarTarefa.UseVisualStyleBackColor = true;
            this.buttonEditarTarefa.Click += new System.EventHandler(this.buttonEditarTarefa_Click);
            // 
            // buttonExcluirTarefa
            // 
            this.buttonExcluirTarefa.Location = new System.Drawing.Point(728, 375);
            this.buttonExcluirTarefa.Name = "buttonExcluirTarefa";
            this.buttonExcluirTarefa.Size = new System.Drawing.Size(123, 24);
            this.buttonExcluirTarefa.TabIndex = 65;
            this.buttonExcluirTarefa.Text = "Excluir Tarefa";
            this.buttonExcluirTarefa.UseVisualStyleBackColor = true;
            this.buttonExcluirTarefa.Click += new System.EventHandler(this.buttonExcluirTarefa_Click);
            // 
            // buttonEditarLembrete
            // 
            this.buttonEditarLembrete.Location = new System.Drawing.Point(455, 602);
            this.buttonEditarLembrete.Name = "buttonEditarLembrete";
            this.buttonEditarLembrete.Size = new System.Drawing.Size(123, 24);
            this.buttonEditarLembrete.TabIndex = 66;
            this.buttonEditarLembrete.Text = "Editar Lembrete";
            this.buttonEditarLembrete.UseVisualStyleBackColor = true;
            this.buttonEditarLembrete.Click += new System.EventHandler(this.buttonEditarLembrete_Click);
            // 
            // buttonExcluirLembrete
            // 
            this.buttonExcluirLembrete.Location = new System.Drawing.Point(728, 602);
            this.buttonExcluirLembrete.Name = "buttonExcluirLembrete";
            this.buttonExcluirLembrete.Size = new System.Drawing.Size(123, 24);
            this.buttonExcluirLembrete.TabIndex = 67;
            this.buttonExcluirLembrete.Text = "Excluir Lembrete";
            this.buttonExcluirLembrete.UseVisualStyleBackColor = true;
            this.buttonExcluirLembrete.Click += new System.EventHandler(this.buttonExcluirLembrete_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1009, 749);
            this.Controls.Add(this.buttonExcluirLembrete);
            this.Controls.Add(this.buttonEditarLembrete);
            this.Controls.Add(this.buttonExcluirTarefa);
            this.Controls.Add(this.buttonEditarTarefa);
            this.Controls.Add(this.buttonExcluirEvento);
            this.Controls.Add(this.buttonEditarEvento);
            this.Controls.Add(this.dataGridLembrete);
            this.Controls.Add(this.dataGridTarefa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.DataGridNoti);
            this.Controls.Add(this.DataGridEvento);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "agenda do abc bolinhas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLembrete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridEvento;
        private System.Windows.Forms.DataGridView DataGridNoti;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridTarefa;
        private System.Windows.Forms.DataGridView dataGridLembrete;
        private System.Windows.Forms.Button buttonEditarEvento;
        private System.Windows.Forms.Button buttonExcluirEvento;
        private System.Windows.Forms.Button buttonEditarTarefa;
        private System.Windows.Forms.Button buttonExcluirTarefa;
        private System.Windows.Forms.Button buttonEditarLembrete;
        private System.Windows.Forms.Button buttonExcluirLembrete;
    }
}

