using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{[Serializable]
    public class Produse
    {
        private string denumire;
        private string categorie;
        private double pret;

        public string Denumire { get => denumire; set => denumire = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public double Pret { get => pret; set => pret = value; }

        public Produse(string denumire, string categorie, double pret)
        {
            Denumire = denumire;
            Categorie = categorie;
            Pret = pret;
        }
    }
}
