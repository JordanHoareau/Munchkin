using Constantes;

namespace Cartes.Donjons
{
    public abstract class Utilisable : Carte
    {
        public Utilisable(int ID, string Nom) : base(ID,Nom)
        {
            this.Type = CarteType.Tresor;
        }
    }
}
