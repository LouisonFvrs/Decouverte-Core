using TP1_SLAM5.Entities;

namespace TP1_SLAM5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bsData.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvData.DataSource = bsData;
            dgvData.Columns[0].Visible = false;
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsData.DataSource = Modele.listeAuteurs(); // appel de la méthode listeClients
            dgvData.DataSource = bsData;
            dgvData.Columns[0].Visible = false;

        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsData.DataSource = Modele.listeCommandes(); // appel de la méthode listeClients
            dgvData.DataSource = bsData;
            dgvData.Columns[0].Visible = false;

        }

        private void partitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsData.DataSource = Modele.listePartitions(); // appel de la méthode listeClients
            dgvData.DataSource = bsData;
            dgvData.Columns[0].Visible = false;

        }
    }
}