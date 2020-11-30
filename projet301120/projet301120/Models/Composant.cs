using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class Composant
    {
        #region Attributs
        public static List<Composant> CollClasseComposant = new List<Composant>();
        private int _id;
        private string _nomIngredients;
        private int _quantite;
        private double _prix;
        #endregion
        #region Constructeurs
        public Composant(int id, string nomIngredients, int quantite, double prix)
        {
            _id = id;
            _nomIngredients = nomIngredients;
            _quantite = quantite;
            _prix = prix;
            CollClasseComposant.Add(this);
        }
        #endregion
        #region Getters-Setteurs
        public int Id { get => _id; set => _id = value; }
        public string NomIngredients { get => _nomIngredients; set => _nomIngredients = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        public double Prix { get => _prix; set => _prix = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
