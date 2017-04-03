using Constantes;
using Cartes.Donjons.Equipements;
using System.Collections.Generic;

namespace Cartes.Donjons
{
    public class Equipement : Carte
    {
        public int Bonus { get; private set; }
        public int PrixDeVente { get; private set; }
        public bool Gros { get; private set; }
        public EquipementSlot Slot { get; private set; } 
        public Race RaceInterdite { get; private set; }
        public Race RaceObligatoire { get; private set; }
        public Classe ClasseInterdite { get; private set; }
        public Classe ClasseObligatoire { get; private set; }
        public List<Effet> Effets { get; private set; }

        public Equipement(int ID, string Nom, int Bonus, int PrixDeVente, bool Gros, EquipementSlot Slot, Race RaceInterdite, Race RaceObligatoire, Classe ClasseInterdite, Classe ClasseObligatoire, List<Effet> Effets) : base(ID,Nom)
        {
            this.Bonus = Bonus;
            this.PrixDeVente = PrixDeVente;
            this.Gros = Gros;
            this.Slot = Slot;
            this.RaceInterdite = RaceInterdite;
            this.RaceObligatoire = RaceObligatoire;
            this.ClasseInterdite = ClasseInterdite;
            this.ClasseObligatoire = ClasseObligatoire;
            this.Effets = Effets;
        }

    }
}
