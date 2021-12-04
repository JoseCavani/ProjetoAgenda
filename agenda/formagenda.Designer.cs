
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
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.dataGridTarefa = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.DataGridEvento.Size = new System.Drawing.Size(326, 222);
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
            this.DataGridNoti.Location = new System.Drawing.Point(24, 282);
            this.DataGridNoti.Name = "DataGridNoti";
            this.DataGridNoti.ReadOnly = true;
            this.DataGridNoti.RowTemplate.Height = 25;
            this.DataGridNoti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridNoti.Size = new System.Drawing.Size(634, 131);
            this.DataGridNoti.TabIndex = 32;
            this.DataGridNoti.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridNoti_CellFormatting);
            this.DataGridNoti.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridNoti_DataBindingComplete);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.Location = new System.Drawing.Point(30, 230);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(123, 25);
            this.ButtonNovo.TabIndex = 35;
            this.ButtonNovo.Text = "Novo Evento";
            this.ButtonNovo.UseVisualStyleBackColor = true;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovoEvento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 37;
            this.button1.Text = "Nova Tarefa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonNovoTarefa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 226);
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
            this.ButtonFechar.Location = new System.Drawing.Point(0, 429);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(997, 45);
            this.ButtonFechar.TabIndex = 59;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
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
            this.dataGridTarefa.Location = new System.Drawing.Point(332, 2);
            this.dataGridTarefa.Name = "dataGridTarefa";
            this.dataGridTarefa.ReadOnly = true;
            this.dataGridTarefa.RowTemplate.Height = 25;
            this.dataGridTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTarefa.Size = new System.Drawing.Size(326, 222);
            this.dataGridTarefa.TabIndex = 60;
            this.dataGridTarefa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTarefa_CellDoubleClick);
            this.dataGridTarefa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridTarefa_CellFormatting);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(664, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(326, 222);
            this.dataGridView1.TabIndex = 61;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1009, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridTarefa);
            this.Controls.Add(this.ButtonFechar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridEvento;
        private System.Windows.Forms.DataGridView DataGridNoti;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonFechar;
        private System.Windows.Forms.DataGridView dataGridTarefa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

