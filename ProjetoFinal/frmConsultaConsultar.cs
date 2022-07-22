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
    public partial class frmConsultaConsultar : Form
    {
        public frmConsultaConsultar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            

            Paciente utente_selecionado = (Paciente)cbNomePaciente.SelectedItem;
            int nome_id = utente_selecionado.idPaciente;
           

            Medico medico_selecionado = (Medico)cbNomeMedico.SelectedItem;
            int med_id = medico_selecionado.idMedico;

            Especialidade especialidade_selecionada = (Especialidade)cbEspecialidade.SelectedItem;
            int especialidade_id = especialidade_selecionada.id;

            ConsultaHandler handler = new ConsultaHandler();
            string query = handler.CriarQuery_ConsultarConsulta_Paciente_Medico(nome_id, med_id, especialidade_id);

            ConsultasDAL dal = new ConsultasDAL();  
            List<Consulta> consultasPacientes = dal.FiltrarConsultaPaciente(nome_id, med_id, especialidade_id, query);
            dgvConsultarConsultas.DataSource = consultasPacientes;
            OrdenarColunas();

        }

        public void ListarConsultas()
        {
            ConsultasDAL dal = new ConsultasDAL();
            List<Consulta> consultas = dal.ListarTodasConsultas();
  
            dgvConsultarConsultas.DataSource = consultas;
            dgvConsultarConsultas.Columns["id"].Visible = false;
            dgvConsultarConsultas.Columns["idMedico"].Visible = false;
            dgvConsultarConsultas.Columns["idPaciente"].Visible=false;
            OrdenarColunas();
        }

        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Preencho os dados do médico na respectiva Combobox
            ConsultasDAL cmdal = new ConsultasDAL();
            var esp = (Especialidade)cbEspecialidade.SelectedItem; //cast de um tipo object para especialidade
            cbNomeMedico.Text = " ";
            List<Medico> medico = cmdal.ListarMedico(esp.id);

 
            Medico med_temp = new Medico();
            med_temp.idMedico = 0;
            med_temp.nomeMedico = "Selecione...";
            medico.Insert(0, med_temp);

            cbNomeMedico.DisplayMember = "nomeMedico"; //Qdo eu passo uma lista, eu digo qual a propriedade quero que mostre...
            cbNomeMedico.ValueMember = "idMedico";//ValueMember é o numero que vai associar a cada nome...
            cbNomeMedico.DataSource = medico;
        }

        private void frmConsultaConsultar_Load(object sender, EventArgs e)
        {
            //Prenche os dados da minha dgvConsultarConsultas:
       

            //Preencho dados pacientes na  respectiva combobox
            PacienteDAL dal = new PacienteDAL();
            List<Paciente> utente = dal.ListarTodosPacientes(); //A lista ja esta instanciada, por ja ter a lista pronta.

            Paciente utente_temp = new Paciente();
            utente_temp.idPaciente = 0;
            utente_temp.nomePaciente = "Selecione..."; //é o primeiro argumento que tem o id = 0

            utente.Insert(0, utente_temp);

            cbNomePaciente.DisplayMember = "nomePaciente"; //Qdo eu passo uma lista, eu digo qual a propriedade quero que mostre...
            cbNomePaciente.ValueMember = "idPaciente";//ValueMember é o numero que vai associar a cada nome...
            cbNomePaciente.DataSource = utente; //nome e o id estao dentro do emp
 

            //Preencho dados das especialidades na  respectiva combobox
            ConsultasDAL cdal = new ConsultasDAL();
            List<Especialidade> espec = cdal.ListarEspecialidades(); //A lista ja esta instanciada, por ja ter a lista pronta.

            Especialidade espec_temp = new Especialidade();
            espec_temp.id = 0;
            espec_temp.nome = "Selecione...";

            espec.Insert(0, espec_temp);

            cbEspecialidade.DisplayMember = "nome"; //Mostra o nome
            cbEspecialidade.ValueMember = "id"; // Pega id 
            cbEspecialidade.DataSource = espec;

            ListarConsultas();





        }

        private void cbNomePaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Preencho o nif do paciente.
            var paciente = (Paciente)cbNomePaciente.SelectedItem; //cast de um tipo object para paciente
            tbNIF.Text = paciente.nif;
        }

        private void LimparForm()
        {
            cbNomePaciente.SelectedIndex = 0;
            cbEspecialidade.Text = "";
            cbNomeMedico.Text = "";
            cbNomePaciente.SelectedIndex = 0;
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvConsultarConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void OrdenarColunas()
        {
            dgvConsultarConsultas.Columns["nomePaciente"].DisplayIndex = 0;
            dgvConsultarConsultas.Columns["nif"].DisplayIndex = 1;
            dgvConsultarConsultas.Columns["data_nasc"].DisplayIndex = 2;
            dgvConsultarConsultas.Columns["morada"].DisplayIndex = 3;
            dgvConsultarConsultas.Columns["localidade"].DisplayIndex = 4;
            dgvConsultarConsultas.Columns["cod_postal"].DisplayIndex = 5;
            dgvConsultarConsultas.Columns["nomeMedico"].DisplayIndex = 6;
            dgvConsultarConsultas.Columns["cedula"].DisplayIndex = 7;
            dgvConsultarConsultas.Columns["especialidade"].DisplayIndex = 8;
            dgvConsultarConsultas.Columns["data"].DisplayIndex = 9;
            dgvConsultarConsultas.Columns["hora"].DisplayIndex = 10;
            

        }

        private void btnEliminas_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Tem a certeza que quer eliminar este registro?", "Confirmação OsteoSpa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var selectedRow = dgvConsultarConsultas.SelectedRows[0].DataBoundItem as Consulta;


               ConsultasDAL dal = new ConsultasDAL();

                int res = dal.EliminarConsulta(selectedRow);


                if (res > 0)
                {
                    MessageBox.Show("Eliminação feita com sucesso!", "Confirmação OsteoSpa");
                    ListarConsultas();
                }
                else
                {
                    MessageBox.Show("A eliminação falhou...", "Erro OsteoSpa");
                }
            }
        }

        private void cbNomeMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
            ListarConsultas();
        }

        private void dgvConsultarConsultas_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {

        }

        private void dgvConsultarConsultas_Sorted(object sender, EventArgs e)
        {
            
        }
    }
}
