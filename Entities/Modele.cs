using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_SLAM5.Entities;

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

    }
}
