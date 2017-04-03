using Constantes;

namespace Cartes.Donjons
{
    public abstract class Action : Carte
    {
        public string Texte { get; private set; }
        public Action(int ID, string Nom, CarteType Type,string Texte) : base(ID, Nom)
        {
            this.Type = Type;
            this.Texte = Texte;
        }
    }
}
