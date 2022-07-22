using ProjetoFinal.DAL;
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
    public partial class frmPacienteConsultar : Form
    {
        public frmPacienteConsultar()
        {
            InitializeComponent();
            
      

        }

        private void frmPacienteConsultar_Load(object sender, EventArgs e)
        {
            ListarPacientes();

        }
        private void ListarPacientes()
        {
            PacienteDAL dal = new PacienteDAL();
            List<Paciente> pacientes = dal.ListarTodosPacientes();
           
            dgvPacientes.DataSource = pacientes;
          


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Obrigado, volte sempre! ", "Informativo OsteoSpa");
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Tem a certeza que quer eliminar este registro?", "Confirmação OsteoSpa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                var selectedRow = dgvPacientes.SelectedRows[0].DataBoundItem as Paciente;

                PacienteDAL dal = new PacienteDAL();

                int res = dal.EliminarPaciente(selectedRow);

                if (res > 0)
                {
                    MessageBox.Show("Eliminação feita com sucesso!", "Confirmação OsteoSpa");
                    ListarPacientes();
                }
                else
                {
                    MessageBox.Show("A eliminação falhou...", "Erro OsteoSpa");
                }
                
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try {
                var selectedRow = dgvPacientes.SelectedRows[0].DataBoundItem as Paciente;
                frmEditarPaciente fep = new frmEditarPaciente();
                fep.setValoresPaciente(selectedRow); //setValoresPaciente está em frmEditarPaciente

                fep.ShowDialog();

                ListarPacientes(); //Atualiza a lista de contatos
            }catch (Exception ex)
            {

            }
        }

      
    }
}
