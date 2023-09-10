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
            cbxClient.ValueMember = "NUMCLI";
            cbxClient.DisplayMember = "nomComplet";
            bsCli.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
                x.Adrcli
            });
            cbxClient.DataSource = bsCli;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = false;
            bsData.DataSource = Modele.listeClients().Select(x => new
            {
                x.Nomcli,
                x.Prenomcli,
                x.Adrcli,
            });
            dgvData.DataSource = bsData;
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = false;
            bsData.DataSource = Modele.listeAuteurs().Select(x => new
            {
                x.Nomaut,
                x.Prenomaut
            });
            dgvData.DataSource = bsData;

        }

        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = true;
            bsData.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvData.DataSource = bsData;

        }

        private void partitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = false;
            bsData.DataSource = Modele.listePartitions(); // appel de la méthode listeClients
            dgvData.DataSource = bsData;

        }

        private void bsCli_CurrentChanged(object sender, EventArgs e)
        {
            int IdClient = Convert.ToInt32(cbxClient.SelectedValue);
            bsData.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvData.DataSource = bsData;

        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            int valueMontant = Convert.ToInt32(num.Value);
            bsData.DataSource = Modele.listeCommandesSuperieurA(valueMontant).Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvData.DataSource = bsData;
        }
    }
}