using Cartes.Donjons.Monstres;
using Constantes;
using System.Collections.Generic;

namespace Cartes.Donjons
{
    public class Monstre : Carte
    {
        public int Dommage { get; private set; }
        public int NombreDeNiveaux { get; private set; }
        public int NombreDeTresors { get; private set; }
        public List<Effet> Effets { get; private set; }
        public List<IncidentFacheux> IncidentsFacheux;

        public Monstre(int ID, CarteType Type, string Nom, int Dommage, int NombreDeNiveaux, int NombreDeTresors, List<Effet> Effets, List<IncidentFacheux> IncidentsFacheux) : base(ID,Nom)
        {
            this.Type = Type;
            this.Dommage = Dommage;
            this.NombreDeNiveaux = NombreDeNiveaux;
            this.NombreDeTresors = NombreDeTresors;
            this.Effets = Effets;
            this.IncidentsFacheux = IncidentsFacheux;
        }
    }
}
