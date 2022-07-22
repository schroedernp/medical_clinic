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
    public partial class frmConsultaInserir : Form
    {
       
        public frmConsultaInserir()
        {
            InitializeComponent();
        }



        private void btnInserirConsulta_Click(object sender, EventArgs e)
        {
            ConsultaHandler ch = new ConsultaHandler(); //SelectedItem é um objeto deve ser transformado para o tipo de dado de interesse atraves de um casting
            DateTime data = DateTime.Parse(dtpDataConsulta.Text);
            var pac = (Paciente) cbNomePaciente.SelectedItem;
            var med = (Medico)cbNomeMedico.SelectedItem;
            var esp = (Especialidade)cbEspecialidade.SelectedItem;

            (int flag, Consulta consu) = ch.ValidarConsulta(med, pac, data, dudHora.Text);

            //Fazer switch case
                switch (flag) {
                    
                case 1:
                    MessageBox.Show("Preencha todos os campos de forma válida.\nÉ obrigatório preencher o paciente.", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;

                    
                case 2:
                    MessageBox.Show("Atenção você necessita de um médico para realizar consulta.", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                    
                case 3:
                    MessageBox.Show("Data inválida.\nNão é possível marcar uma consulta no passado.\n Escolha uma data possível. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                   
                case 4:
                    MessageBox.Show("Horário inválido.\nNão é possível marcar uma consulta sem definir o horário.\n Escolha uma horário disponível. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
                }



            ConsultasDAL dal = new ConsultasDAL();
            int flag2 = dal.InserirConsulta(consu); //Aqui insere na base de dados apos ter feito todas as validacoes acima.

            if (flag2 > 0)
            {
                MessageBox.Show("Registo guardado na base de dados com sucesso!", "Informativo OsteoSpa");
                LimparForm();
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.", "Informativo OsteoSpa");
            }

        }

        private void LimparForm()
        {
            cbNomePaciente.SelectedIndex = 0;
            cbEspecialidade.Text = "";
            cbNomeMedico.Text = "";
            dtpDataConsulta.Value = DateTime.Today;
            dudHora.Text = "00:00";
            cbNomePaciente.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparForm();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");

        }

        private void dtpDataConsulta_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tbNomePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaInserir_Load(object sender, EventArgs e)
        {
            PacienteDAL dal = new PacienteDAL();
            List<Paciente> utente = dal.ListarTodosPacientes(); //A lista ja esta instanciada, por ja ter a lista pronta.

            Paciente utente_temp = new Paciente();
            utente_temp.idPaciente = 0;
            utente_temp.nomePaciente = "Selecione..."; //é o primeiro argumento que tem o id = 0

            utente.Insert(0, utente_temp);

            cbNomePaciente.DisplayMember = "nomePaciente"; //Qdo eu passo uma lista, eu digo qual a propriedade quero que mostre...
            cbNomePaciente.ValueMember = "idPaciente";//ValueMember é o numero que vai associar a cada nome...
            cbNomePaciente.DataSource = utente; //nome e o id estao dentro do emp



            ConsultasDAL cdal = new ConsultasDAL();
            List<Especialidade> espec = cdal.ListarEspecialidades(); //A lista ja esta instanciada, por ja ter a lista pronta.

            Especialidade espec_temp = new Especialidade();
            espec_temp.id = 0;
            espec_temp.nome = "Selecione..."; 

            espec.Insert(0, espec_temp);

            cbEspecialidade.DisplayMember = "nome"; //Mostra o nome
            cbEspecialidade.ValueMember = "id"; // Pega id 
            cbEspecialidade.DataSource = espec; 

        }
        //faço as instrucoes onde irei selecionar
        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e) 
        {
            ConsultasDAL cmdal = new ConsultasDAL();
            var esp = (Especialidade)cbEspecialidade.SelectedItem; //cast de um tipo object para especialidade
            cbNomeMedico.Text = "";
            List<Medico> medico = cmdal.ListarMedico(esp.id);
            cbNomeMedico.DisplayMember = "nomeMedico"; //Qdo eu passo uma lista, eu digo qual a propriedade quero que mostre...
            cbNomeMedico.ValueMember = "idMedico";//ValueMember é o numero que vai associar a cada nome...
            cbNomeMedico.DataSource = medico;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Object é uma classe superior a Combobox
        {
             var paciente = (Paciente)cbNomePaciente.SelectedItem; //cast de um tipo object para paciente
            tbNIF.Text= paciente.nif;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         



        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");
        }
    }
}
