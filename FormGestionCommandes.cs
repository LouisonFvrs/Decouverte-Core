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
        }

        // Ajouter une commande
        private void btnAddCommande_Click(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(cbxAddCommande.SelectedValue);
            if (Modele.AjoutCommande(Decimal.ToInt32(numMontant.Value), DateOnly.FromDateTime(dateAddCommande.Value), idCli)) MessageBox.Show("ajout réussi");
            else MessageBox.Show("Erreur ! commande non ajouté");
        }
    }
}
