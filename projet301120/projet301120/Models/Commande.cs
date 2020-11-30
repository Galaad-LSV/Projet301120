using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class Commande
    {
        #region Attributs
        public static List<Commande> collClasseCommande = new List<Commande>();
        private int _id;
        private string _date;
        private Dictionary<int, Pizza> _ligneCommande;
        private List<Pizza> _lesPizza;
        private Client _leClient;
        #endregion

        #region Constructeurs
        public Commande(int id, string date, Client leclient)
        {
            _id = id;
            _date = date;
            _leClient = leclient;
            Commande.collClasseCommande.Add(this);  
            _lesPizza = new List<Pizza>();
            _ligneCommande = new Dictionary<int, Pizza>();
        }


        #endregion

        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Date { get => _date; set => _date = value; }
        public Client LeClient { get => _leClient; set => _leClient = value; }
        public Dictionary<int, Pizza> LigneCommande { get => _ligneCommande; set => _ligneCommande = value; }
        public List<Pizza> LesPizza { get => _lesPizza; set => _lesPizza = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
