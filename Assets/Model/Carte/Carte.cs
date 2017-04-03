using Constantes;

namespace Cartes
{
    public abstract class Carte
    {
        public int ID { get; protected set; }
        public CarteType Type { get; protected set;}
        public string Nom { get; private set; }
        
        public Carte(int ID, string Nom)
        {
            this.ID = ID;
            this.Nom = Nom;
        }
    }
}
