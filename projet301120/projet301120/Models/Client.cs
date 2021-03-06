﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class Client
    {
        #region Attributs
        public static List<Client> collClasseClient = new List<Client>();
        private int _id;
        private string _nom;
        private List<Commande> _lesCommandes;
        #endregion

        #region Constructeurs
        public Client(int id, string nom)
        {
            _id = id;
            _nom = nom;
            collClasseClient.Add(this);
            _lesCommandes = new List<Commande>();
        }
        #endregion

        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public List<Commande> LesCommandes { get => _lesCommandes; set => _lesCommandes = value; }
        #endregion

        #region Methodes
        /// <summary>
        /// Prend le nom
        /// </summary>
        /// <returns>le nom</returns>
        public string GetNom() 
        { 
            return _nom; 
        }

        /// <summary>
        /// Savoir l'id du client
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        public static Client ClientAvecId(int id)
        {
            foreach(Client unClient in Client.collClasseClient)
            {
                if(unClient.Id == id)
                {
                    return unClient;
                }
            }
            return null;
        }
        /// <summary>
        /// Permet de supprimer le Client
        /// </summary>
        /// <param name="leId"></param>
        public static void SupprimerClient(int leId)
        {
            collClasseClient.Remove(ClientAvecId(leId));
        }
        #endregion


    }
}
