using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class SurPlace: Pizza
    {
        #region Attributs
        private string _cadeau;
        #endregion
        #region Constructeurs
        public SurPlace(string cadeau, int id, string leNom, double lePrix) : base(id, leNom, lePrix)
        {
            _cadeau = cadeau;
        }
        #endregion
        #region Getters-Setteurs
        public string Cadeau { get => _cadeau; set => _cadeau = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
