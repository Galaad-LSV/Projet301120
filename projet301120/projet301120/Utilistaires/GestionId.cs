using projet301120.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet301120.Utilistaires
{
    class GestionId
    {
        public static int GetNouvelIndexBox()
        {
            return Client.collClasseClient.Count + 1;
        }
    }
}
