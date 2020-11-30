using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class Pizza
    {
        #region Attributs
        public static List<Pizza> CollClassePizza = new List<Pizza>();
        private int _id;
        private string _nom;
        private double _prix;
        private List<Composant> _lesIngredients;
        #endregion
        #region Constructeurs
        public Pizza(int id, string nom, double prix)
        {
            _id = id;
            _nom = nom;
            _prix = prix;
            _lesIngredients = new List<Composant>();
            CollClassePizza.Add(this);
        }
        #endregion
        #region Getters-Setteurs
        public List<Composant> LesIngredients { get => _lesIngredients; set => _lesIngredients = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Id { get => _id; set => _id = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
