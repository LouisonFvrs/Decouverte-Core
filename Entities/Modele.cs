using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TP1_SLAM5.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP1_SLAM5.Entities
{
    internal static class Modele
    {

        private static BdPartitionContext monModel;
        public static void init()
        {
            monModel = new BdPartitionContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }

        public static List<Auteur> listeAuteurs()
        {
            return monModel.Auteurs.ToList();
        }

        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }

        public static List<Partition> listePartitions()
        {
            List<Partition> list = new List<Partition>();
            return monModel.Partitions.ToList();
        }

        // bien la comprendre pour savoir la réutiliser
        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Commande> listeCommandesSuperieurA(int value)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Montantcde >= value).ToList();
            return lesCommandes;
        }

        public static List<Partition> listePartitionParCommande(int idCde)
        {
            List<Partition> lesPartitions = monModel.Partitions.Where(p => p.Numpart == idCde).Include(p => p.Numcdes).ToList();
            return lesPartitions;
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static List<Partition> listePartitionStyle(int idStyle)
        {
            List<Partition> partitionSortByStyle = monModel.Partitions.Where(p => p.NumStyle == idStyle).Include(p => p.Numcdes).ToList();
         //   List<Partition> partitionSortByStyle = monModel.Partitions.Where(s => s.NumStyle == 1).ToList();
          
            return partitionSortByStyle;
          
        }

        public static bool AjoutCommande(int montant, DateOnly dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = dateC;
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        // Récupérer une commande
        public static Commande recupererCommande(int idCommande)
        {
            Commande commande = new Commande();
            try
            {
                commande = monModel.Commandes.First(x => x.Numcde == idCommande);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
             }

            return commande;
        }

        // Modifier une commande
        public static bool ModifierCommande(int idCde, int montant, DateOnly dateC, int idClient)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = recupererCommande(idCde);
                maCommande.Montantcde = montant;
                maCommande.Datecde = dateC;
                maCommande.Numcli = idClient;
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                vretour=false;
            }

            return vretour;
        }

        // Supprimer une commande
        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = recupererCommande(idCommande);
                monModel.Commandes.Remove(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                vretour = false;
            }

            return vretour;
        }

    }
}
