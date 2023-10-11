using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_SLAM5.Entities;

namespace TP1_SLAM5
{
    public partial class FormGestionCommandes : Form
    {

        Commande c = new Commande();

        public FormGestionCommandes()
        {
            InitializeComponent();
            cbxAddCommande.ValueMember = "NUMCLI";
            cbxAddCommande.DisplayMember = "nomComplet";
            bsCli.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
                x.Adrcli
            });
            cbxAddCommande.DataSource = bsCli;
            btnAddCommande.Visible = true;
            btnEditCmd.Visible = false;
        }

        public FormGestionCommandes(int idCom)
        {
            InitializeComponent();
            cbxAddCommande.ValueMember = "NUMCLI";
            cbxAddCommande.DisplayMember = "nomComplet";
            bsCli.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
                x.Adrcli
            });
            cbxAddCommande.DataSource = bsCli;

            this.c = Modele.recupererCommande(idCom);

            numMontant.Value = (int)c.Montantcde;
            dateAddCommande.Value = c.Datecde.Value.ToDateTime(TimeOnly.Parse("00:00 PM"));
            btnAddCommande.Visible = false;
            btnEditCmd.Visible = true;
        }


        // Ajouter une commande
        private void btnAddCommande_Click(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(cbxAddCommande.SelectedValue);
            if (Modele.AjoutCommande(Decimal.ToInt32(numMontant.Value), DateOnly.FromDateTime(dateAddCommande.Value), idCli)) MessageBox.Show("ajout réussi");
            else MessageBox.Show("Erreur ! commande non ajouté");
        }

        // Editer une commande
        private void btnEditCmd_Click(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(cbxAddCommande.SelectedValue);
            if(Modele.ModifierCommande(c.Numcde, (int)numMontant.Value, DateOnly.FromDateTime(dateAddCommande.Value), idCli)) MessageBox.Show("Commande modifié");
            else MessageBox.Show("Erreur ! commande non édité");

            this.Close();
        }
    }
}
