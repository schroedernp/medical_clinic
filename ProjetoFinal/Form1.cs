namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaInserir fci = new frmConsultaInserir();
            fci.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair do sistema?", "OsteoSpa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                MessageBox.Show("Obrigado, volte sempre!\n A clínica OsteoSpa aguarda seu retorno. ", "Informativo OsteoSpa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            
            

        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPacienteInserir fpi = new frmPacienteInserir();
            fpi.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPacienteConsultar fpc =  new frmPacienteConsultar();
            fpc.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaConsultar fcc = new frmConsultaConsultar();
            fcc.ShowDialog();
        }
    }
}