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
    public partial class frmEditarPaciente : Form
    {
        public frmEditarPaciente()
        {
            InitializeComponent();
        }

        private void frmEditarPaciente_Load(object sender, EventArgs e)
        {
           
        }

        public void setValoresPaciente(Paciente utente)
        {
            tbIdPaciente.Text = utente.idPaciente.ToString();
            tbNomePaciente.Text=utente.nomePaciente;
            tbContatoPaciente.Text = utente.contato;
            tbNIF.Text = utente.nif;
            tbCodigoPostal.Text = utente.cod_postal;
            tbMoradaPaciente.Text= utente.morada;
            tbLocalidade.Text = utente.localidade;
            dtpData.Value = utente.data_nasc;


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PacienteHandler ph = new PacienteHandler();
            DateTime data_nasc = DateTime.Parse(dtpData.Text);

            

            (int conection_flag, Paciente utente) = ph.ValidarPaciente(tbNomePaciente.Text, tbNIF.Text, tbCodigoPostal.Text, tbLocalidade.Text,
                                            tbContatoPaciente.Text, tbMoradaPaciente.Text, data_nasc);

            switch (conection_flag)
            {
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
            else if (data_nasc > DateTime.Today)
            {
                MessageBox.Show("Por favor, adicione a data de nascimento correta.", "Solicitação OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            PacienteDAL pa = new PacienteDAL();
            utente.idPaciente = int.Parse(tbIdPaciente.Text);
            int bdworks = pa.Atualizar(utente);
            if (bdworks > 0)
            {
                MessageBox.Show("Registo atualizado na base de dados com sucesso!");
                
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.");
            }

        }

        private void LimparForm()
        {
            tbIdPaciente.Text = "";
            tbNomePaciente.Text = "";
            tbMoradaPaciente.Text = "";
            tbContatoPaciente.Text = "";
            tbNIF.Text = "";
            tbCodigoPostal.Text = "";
            tbLocalidade.Text = "";
            dtpData.Value = DateTime.Today;
            tbNomePaciente.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
           
        }
    }
}
