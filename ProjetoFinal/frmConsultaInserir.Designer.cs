namespace ProjetoFinal
{
    partial class frmConsultaInserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaInserir));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnInserirConsulta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dudHora = new System.Windows.Forms.DomainUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.cbNomePaciente = new System.Windows.Forms.ComboBox();
            this.cbNomeMedico = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(826, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Médico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(803, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horário da Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(60, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Especialidade";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEspecialidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbEspecialidade.Items.AddRange(new object[] {
            "Clínica Geral",
            "Otorrino",
            "Pediatra",
            "Cardiologista",
            "Ginecologista",
            "Urologista",
            "Oncologista",
            "Pneumologista",
            "Dermatologista",
            "Hematologista",
            "Reumatologista",
            "Ortopedista",
            "Traumatologista",
            "Endócrino"});
            this.cbEspecialidade.Location = new System.Drawing.Point(224, 287);
            this.cbEspecialidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(578, 37);
            this.cbEspecialidade.TabIndex = 5;
            this.cbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidade_SelectedIndexChanged);
            // 
            // btnInserirConsulta
            // 
            this.btnInserirConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirConsulta.FlatAppearance.BorderSize = 2;
            this.btnInserirConsulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirConsulta.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnInserirConsulta.Location = new System.Drawing.Point(210, 575);
            this.btnInserirConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserirConsulta.Name = "btnInserirConsulta";
            this.btnInserirConsulta.Size = new System.Drawing.Size(161, 89);
            this.btnInserirConsulta.TabIndex = 10;
            this.btnInserirConsulta.Text = "Inserir Consulta";
            this.btnInserirConsulta.UseVisualStyleBackColor = true;
            this.btnInserirConsulta.Click += new System.EventHandler(this.btnInserirConsulta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(924, 575);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 89);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Location = new System.Drawing.Point(568, 575);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 89);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.CustomFormat = "yyyy-MM-dd";
            this.dtpDataConsulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConsulta.Location = new System.Drawing.Point(224, 387);
            this.dtpDataConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(571, 37);
            this.dtpDataConsulta.TabIndex = 13;
            this.dtpDataConsulta.Value = new System.DateTime(2022, 5, 3, 0, 0, 0, 0);
            this.dtpDataConsulta.ValueChanged += new System.EventHandler(this.dtpDataConsulta_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data da Consulta";
            // 
            // dudHora
            // 
            this.dudHora.CausesValidation = false;
            this.dudHora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dudHora.Items.Add("19:30");
            this.dudHora.Items.Add("19:00");
            this.dudHora.Items.Add("18:30");
            this.dudHora.Items.Add("18:00");
            this.dudHora.Items.Add("17:30");
            this.dudHora.Items.Add("17:00");
            this.dudHora.Items.Add("16:30");
            this.dudHora.Items.Add("16:00");
            this.dudHora.Items.Add("15:30");
            this.dudHora.Items.Add("15:00");
            this.dudHora.Items.Add("14:30");
            this.dudHora.Items.Add("14:00");
            this.dudHora.Items.Add("13:30");
            this.dudHora.Items.Add("13:00");
            this.dudHora.Items.Add("12:30");
            this.dudHora.Items.Add("12:00");
            this.dudHora.Items.Add("11:30");
            this.dudHora.Items.Add("11:00");
            this.dudHora.Items.Add("10:30");
            this.dudHora.Items.Add("10:00");
            this.dudHora.Items.Add("09:30");
            this.dudHora.Items.Add("09:00");
            this.dudHora.Items.Add("08:30");
            this.dudHora.Items.Add("08:00");
            this.dudHora.Location = new System.Drawing.Point(1026, 387);
            this.dudHora.Name = "dudHora";
            this.dudHora.Size = new System.Drawing.Size(180, 37);
            this.dudHora.TabIndex = 16;
            this.dudHora.Text = "00:00";
            this.dudHora.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1915, 200);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1339, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "NIF";
            // 
            // tbNIF
            // 
            this.tbNIF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNIF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbNIF.Location = new System.Drawing.Point(1392, 210);
            this.tbNIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.ReadOnly = true;
            this.tbNIF.Size = new System.Drawing.Size(428, 37);
            this.tbNIF.TabIndex = 19;
            // 
            // cbNomePaciente
            // 
            this.cbNomePaciente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbNomePaciente.FormattingEnabled = true;
            this.cbNomePaciente.Location = new System.Drawing.Point(224, 213);
            this.cbNomePaciente.Name = "cbNomePaciente";
            this.cbNomePaciente.Size = new System.Drawing.Size(1108, 37);
            this.cbNomePaciente.TabIndex = 20;
            this.cbNomePaciente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbNomeMedico
            // 
            this.cbNomeMedico.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbNomeMedico.FormattingEnabled = true;
            this.cbNomeMedico.Location = new System.Drawing.Point(1012, 287);
            this.cbNomeMedico.Name = "cbNomeMedico";
            this.cbNomeMedico.Size = new System.Drawing.Size(808, 37);
            this.cbNomeMedico.TabIndex = 21;
            this.cbNomeMedico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1374, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 555);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1915, 823);
            this.Controls.Add(this.cbNomeMedico);
            this.Controls.Add(this.cbNomePaciente);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dudHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpDataConsulta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserirConsulta);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultaInserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Consultas";
            this.Load += new System.EventHandler(this.frmConsultaInserir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox cbEspecialidade;
        private Button btnInserirConsulta;
        private Button btnSair;
        private Button btnLimpar;
        private DateTimePicker dtpDataConsulta;
        private EventHandler label4_Click;
        private EventHandler label5_Click;
        private EventHandler label3_Click;
        private EventHandler dtpDataConsulta_ValueChanged;
        private Label label3;
        private DomainUpDown dudHora;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox tbNIF;
        private ComboBox cbNomePaciente;
        private ComboBox cbNomeMedico;
        private PictureBox pictureBox1;
    }
}