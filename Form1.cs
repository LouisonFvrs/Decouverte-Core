using System.Windows.Forms;
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


            cbxComande.ValueMember = "NUMCDE";
            cbxComande.DisplayMember = "DATECDE";
            bsCmd.DataSource = (Modele.listeCommandes()).Select(x => new
            {
                x.Numcde,
                DATECDE = x.Datecde
            });
            cbxComande.DataSource = bsCmd;

            cbx_style.ValueMember = "numStyle";
            cbx_style.DisplayMember = "libStyle";
            bsStyle.DataSource = (Modele.listeStyle()).Select(x => new
            {
                x.NumStyle,
                libStyle = x.LibStyle
            });
            cbx_style.DataSource = bsStyle;

            num.Visible = false;
            cbxClient.Visible = true;
            cbxComande.Visible = false;
            btnDelCmd.Visible = false;
            btnEdit.Visible = false;
            cbx_style.Visible = false;
            addButton.Visible = false;
            bsData.DataSource = Modele.listeClients().Select(x => new
            {
                x.Nomcli,
                x.Prenomcli,
                x.Adrcli,
                x.Tel
            });
            dgvData.DataSource = bsData;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = false;
            cbxClient.Visible = true;
            btnDelCmd.Visible = false;
            cbxComande.Visible = false;
            btnEdit.Visible = false;
            cbx_style.Visible = false;
            addButton.Visible = false;
            bsData.DataSource = Modele.listeClients().Select(x => new
            {
                x.Nomcli,
                x.Prenomcli,
                x.Adrcli,
                x.Tel

            });
            dgvData.DataSource = bsData;
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num.Visible = false;
            btnEdit.Visible = false;
            btnDelCmd.Visible = false;
            cbxClient.Visible = false;
            cbxComande.Visible = false;
            cbx_style.Visible = false;
            addButton.Visible = false;
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
            btnEdit.Visible = true;
            btnDelCmd.Visible = true;
            cbxClient.Visible = false;
            cbxComande.Visible = false;
            cbx_style.Visible = false;
            addButton.Visible = true;

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
            cbxClient.Visible = false;
            btnEdit.Visible = false;
            btnDelCmd.Visible = false;
            addButton.Visible = false;
            //cbxComande.Visible = true;
            cbx_style.Visible = true;
            bsData.DataSource = Modele.listePartitions().Select(x => new
            {
                x.Numpart,
                x.Prixpart,
                x.Libpart
            }); // appel de la méthode listeClients
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

        private void bsCmd_CurrentChanged(object sender, EventArgs e)
        {
            int IdCmd = Convert.ToInt32(cbxComande.SelectedValue);
            bsData.DataSource = Modele.listePartitionParCommande(IdCmd).Select(x => new
            {
                x.Numpart,
                x.Prixpart,
                x.Libpart
            });
            dgvData.DataSource = bsData;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            int numStyle = Convert.ToInt32(cbx_style.SelectedValue);
            bsData.DataSource = Modele.listePartitionStyle(numStyle).Select(x => new
            {
                x.Numpart,
                x.Prixpart,
                x.Libpart
            });
            dgvData.DataSource = bsData;
        }

        // Ajouter une commande
        private void addButton_Click(object sender, EventArgs e)
        {
            FormGestionCommandes form = new FormGestionCommandes();
            form.Show();
        }

        // Modifier une commande
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                if (selectedRow != null)
                {
                    object cellValue = selectedRow.Cells["Numcde"].Value;
                    int idCom = Convert.ToInt32(cellValue);

                    FormGestionCommandes form = new FormGestionCommandes(idCom);
                    form.Show();
                }

            }
        }

        // Supprimer une commande
        private void btnDelCmd_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                if (selectedRow != null)
                {
                    object cellValue = selectedRow.Cells["Numcde"].Value;
                    int idCom = Convert.ToInt32(cellValue);
                    if (Modele.SuppCommande(idCom)) MessageBox.Show("commande supprimer");
                    else MessageBox.Show("Erreur");
                }

            }
        }


    }
}