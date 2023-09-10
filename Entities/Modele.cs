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
            return monModel.Partitions.ToList();
        }

    }
}
