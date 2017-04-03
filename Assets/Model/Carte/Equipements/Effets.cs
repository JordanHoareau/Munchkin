using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cartes.Donjons.Equipements
{
    public abstract class Effet
    {
        public int ID { get; private set; }
        public string Texte { get; private set; }

        public Effet(int ID, string Texte)
        {
            this.ID = ID;
            this.Texte = Texte;
        }
    }
}
