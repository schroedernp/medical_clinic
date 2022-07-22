using ProjetoFinal.DAL;
using ProjetoFinal.Handlers;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class frmPacienteInserir : Form
    {
        public frmPacienteInserir()
        {
            InitializeComponent();
        }

        private void frmPacienteInserir_Load(object sender, EventArgs e)
        {

        }

        private void LimparForm()
        {
            tbNomePaciente.Text = "";
            tbMoradaPaciente.Text = "";
            tbContatoPaciente.Text = "";
            tbNIF.Text = "";
            tbCodigoPostal.Text = "";
            tbLocalidade.Text = "";
            dtpData.Value = DateTime.Today;
            tbNomePaciente.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnRegistarPaciente_Click(object sender, EventArgs e)
        {
            PacienteHandler ph = new PacienteHandler();
            DateTime data_nasc = DateTime.Parse(dtpData.Text);
           

            (int flag, Paciente utente) = ph.ValidarPaciente(tbNomePaciente.Text, tbNIF.Text, tbCodigoPostal.Text, tbLocalidade.Text,
                                            tbContatoPaciente.Text, tbMoradaPaciente.Text, data_nasc);

            switch (flag) {
                case 1:
                    MessageBox.Show("Preencha todos os campos de forma válida.", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                case 2:
                    MessageBox.Show("Preencha todos os campos de forma válida.\n O NIF deve ter 9 números. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                case 3:
                    MessageBox.Show("Preencha todos os campos de forma válida.\n O contato telefônico deve ter 9 números. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                case 4:
                    MessageBox.Show("Preencha todos os campos de forma válida.\n O codigo postal deve ter 7 números e um separador. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
            }

            if (data_nasc == DateTime.Today)
            {
                DialogResult confirmar;
                confirmar = MessageBox.Show("Atenção a data de nascimento do paciente é hoje. Confirme este dado.", "Confimarmação OsteoSpa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar.Equals(DialogResult.Yes))
                {

                }
                else
                {
                    confirmar = MessageBox.Show("Por favor, adicione a data de nascimento correta.", "Solicitação OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (data_nasc > DateTime.Now)
            {
                MessageBox.Show("Por favor, adicione a data de nascimento correta.", "Solicitação OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            PacienteDAL pa = new PacienteDAL();
            int flag2 = pa.InserirPaciente(utente);
            if (flag2 > 0)
            {
                MessageBox.Show("Registo guardado na base de dados com sucesso!");
                LimparForm();
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");
        }
    }
}
