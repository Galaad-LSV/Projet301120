using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Models
{
    public class Emporter : Pizza
    {
        #region Attributs
        private int _reduction;
        #endregion
        #region Constructeurs
        public Emporter(int id, string leNom, double lePrix, int reduction): base(id, leNom, lePrix)
        {

        }
        #endregion
        #region Getters-Setteurs
        #endregion
        #region Methodes
        #endregion
    }
}
