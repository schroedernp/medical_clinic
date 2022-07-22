namespace ProjetoFinal
{
    partial class frmConsultaConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbNomePaciente = new System.Windows.Forms.ComboBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvConsultarConsultas = new System.Windows.Forms.DataGridView();
            this.nomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNomeMedico = new System.Windows.Forms.ComboBox();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnEliminas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomePaciente
            // 
            this.cbNomePaciente.FormattingEnabled = true;
            this.cbNomePaciente.Location = new System.Drawing.Point(212, 251);
            this.cbNomePaciente.Name = "cbNomePaciente";
            this.cbNomePaciente.Size = new System.Drawing.Size(1108, 33);
            this.cbNomePaciente.TabIndex = 24;
            this.cbNomePaciente.SelectedIndexChanged += new System.EventHandler(this.cbNomePaciente_SelectedIndexChanged);
            // 
            // tbNIF
            // 
            this.tbNIF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNIF.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbNIF.Location = new System.Drawing.Point(1464, 247);
            this.tbNIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.ReadOnly = true;
            this.tbNIF.Size = new System.Drawing.Size(431, 37);
            this.tbNIF.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1352, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "NIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome do Paciente";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.HotPink;
            this.btnConsultar.Location = new System.Drawing.Point(1097, 848);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(172, 60);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1943, 222);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvConsultarConsultas
            // 
            this.dgvConsultarConsultas.AllowUserToOrderColumns = true;
            this.dgvConsultarConsultas.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dgvConsultarConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePaciente,
            this.nif,
            this.data_nasc,
            this.morada,
            this.localidade,
            this.cod_postal,
            this.nomeMedico,
            this.cedula,
            this.especialidade,
            this.data,
            this.hora});
            this.dgvConsultarConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultarConsultas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvConsultarConsultas.Location = new System.Drawing.Point(31, 360);
            this.dgvConsultarConsultas.MultiSelect = false;
            this.dgvConsultarConsultas.Name = "dgvConsultarConsultas";
            this.dgvConsultarConsultas.ReadOnly = true;
            this.dgvConsultarConsultas.RowHeadersWidth = 62;
            this.dgvConsultarConsultas.RowTemplate.Height = 33;
            this.dgvConsultarConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarConsultas.Size = new System.Drawing.Size(1912, 442);
            this.dgvConsultarConsultas.TabIndex = 31;
            this.dgvConsultarConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarConsultas_CellContentClick);
            this.dgvConsultarConsultas.ColumnStateChanged += new System.Windows.Forms.DataGridViewColumnStateChangedEventHandler(this.dgvConsultarConsultas_ColumnStateChanged);
            this.dgvConsultarConsultas.Sorted += new System.EventHandler(this.dgvConsultarConsultas_Sorted);
            // 
            // nomePaciente
            // 
            this.nomePaciente.DataPropertyName = "nomePaciente";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.nomePaciente.DefaultCellStyle = dataGridViewCellStyle1;
            this.nomePaciente.HeaderText = "Paciente";
            this.nomePaciente.MinimumWidth = 8;
            this.nomePaciente.Name = "nomePaciente";
            this.nomePaciente.ReadOnly = true;
            this.nomePaciente.Width = 150;
            // 
            // nif
            // 
            this.nif.DataPropertyName = "nif";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.nif.DefaultCellStyle = dataGridViewCellStyle2;
            this.nif.HeaderText = "NIF";
            this.nif.MinimumWidth = 8;
            this.nif.Name = "nif";
            this.nif.ReadOnly = true;
            this.nif.Width = 150;
            // 
            // data_nasc
            // 
            this.data_nasc.DataPropertyName = "data_nasc";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.data_nasc.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_nasc.HeaderText = "Data Nascimento";
            this.data_nasc.MinimumWidth = 8;
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.ReadOnly = true;
            this.data_nasc.Width = 150;
            // 
            // morada
            // 
            this.morada.DataPropertyName = "morada";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.morada.DefaultCellStyle = dataGridViewCellStyle4;
            this.morada.HeaderText = "Morada";
            this.morada.MinimumWidth = 8;
            this.morada.Name = "morada";
            this.morada.ReadOnly = true;
            this.morada.Width = 150;
            // 
            // localidade
            // 
            this.localidade.DataPropertyName = "localidade";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.localidade.DefaultCellStyle = dataGridViewCellStyle5;
            this.localidade.HeaderText = "Localidade";
            this.localidade.MinimumWidth = 8;
            this.localidade.Name = "localidade";
            this.localidade.ReadOnly = true;
            this.localidade.Width = 150;
            // 
            // cod_postal
            // 
            this.cod_postal.DataPropertyName = "cod_postal";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.cod_postal.DefaultCellStyle = dataGridViewCellStyle6;
            this.cod_postal.HeaderText = "Código Postal";
            this.cod_postal.MinimumWidth = 8;
            this.cod_postal.Name = "cod_postal";
            this.cod_postal.ReadOnly = true;
            this.cod_postal.Width = 150;
            // 
            // nomeMedico
            // 
            this.nomeMedico.DataPropertyName = "nomeMedico";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.nomeMedico.DefaultCellStyle = dataGridViewCellStyle7;
            this.nomeMedico.HeaderText = "Medico";
            this.nomeMedico.MinimumWidth = 8;
            this.nomeMedico.Name = "nomeMedico";
            this.nomeMedico.ReadOnly = true;
            this.nomeMedico.Width = 150;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.cedula.DefaultCellStyle = dataGridViewCellStyle8;
            this.cedula.HeaderText = "Cédula";
            this.cedula.MinimumWidth = 8;
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 150;
            // 
            // especialidade
            // 
            this.especialidade.DataPropertyName = "especialidade";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.especialidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.especialidade.HeaderText = "Especialidade";
            this.especialidade.MinimumWidth = 8;
            this.especialidade.Name = "especialidade";
            this.especialidade.ReadOnly = true;
            this.especialidade.Width = 150;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.data.DefaultCellStyle = dataGridViewCellStyle10;
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 8;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DeepPink;
            this.hora.DefaultCellStyle = dataGridViewCellStyle11;
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 8;
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 150;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.HotPink;
            this.btnLimpar.Location = new System.Drawing.Point(1319, 848);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 60);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.HotPink;
            this.btnSair.Location = new System.Drawing.Point(1732, 848);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(172, 60);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Especialidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1016, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Médico";
            // 
            // cbNomeMedico
            // 
            this.cbNomeMedico.FormattingEnabled = true;
            this.cbNomeMedico.Location = new System.Drawing.Point(1133, 301);
            this.cbNomeMedico.Name = "cbNomeMedico";
            this.cbNomeMedico.Size = new System.Drawing.Size(762, 33);
            this.cbNomeMedico.TabIndex = 29;
            this.cbNomeMedico.SelectedIndexChanged += new System.EventHandler(this.cbNomeMedico_SelectedIndexChanged);
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(212, 301);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(762, 33);
            this.cbEspecialidade.TabIndex = 26;
            this.cbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidade_SelectedIndexChanged);
            // 
            // btnEliminas
            // 
            this.btnEliminas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminas.ForeColor = System.Drawing.Color.HotPink;
            this.btnEliminas.Location = new System.Drawing.Point(1527, 848);
            this.btnEliminas.Name = "btnEliminas";
            this.btnEliminas.Size = new System.Drawing.Size(172, 60);
            this.btnEliminas.TabIndex = 38;
            this.btnEliminas.Text = "Eliminar";
            this.btnEliminas.UseVisualStyleBackColor = true;
            this.btnEliminas.Click += new System.EventHandler(this.btnEliminas_Click);
            // 
            // frmConsultaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(2042, 1076);
            this.Controls.Add(this.btnEliminas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvConsultarConsultas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbNomeMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbNomePaciente);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Consulta ";
            this.Load += new System.EventHandler(this.frmConsultaConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbNomePaciente;
        private TextBox tbNIF;
        private Label label6;
        private Label label1;
        private Button btnConsultar;
        private Panel panel1;
        private DataGridView dgvConsultarConsultas;
        private Button btnLimpar;
        private Button btnSair;
        private Label label2;
        private Label label3;
        private ComboBox cbNomeMedico;
        private ComboBox cbEspecialidade;
        private Button btnEliminas;
        private DataGridViewTextBoxColumn nomePaciente;
        private DataGridViewTextBoxColumn nif;
        private DataGridViewTextBoxColumn data_nasc;
        private DataGridViewTextBoxColumn morada;
        private DataGridViewTextBoxColumn localidade;
        private DataGridViewTextBoxColumn cod_postal;
        private DataGridViewTextBoxColumn nomeMedico;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn especialidade;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn hora;
    }
}