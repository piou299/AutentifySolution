using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutentifyAPI.Models
{
    public class DisplayEnum
    {
        public static string GetSexe(Sexe sexe)
        {
            switch (sexe)
            {
                case Sexe.Femme: 
                    return "Feminin";
                case Sexe.Homme: 
                    return "Masculin";
                default: return "Aucun sexe";

            }
        }
    }
}
