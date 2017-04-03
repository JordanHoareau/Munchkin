using Constantes;

namespace Cartes.Donjons.Monstres
{
    public abstract class Effet
    {
        public int ID { get; private set; }
    }

    namespace Effets
    {
        public class RaceBonus : Effet
        {
            public int BonusValue { get; private set; }
            public Race RaceConcernee { get; private set; }
        }

        public class ClasseBonus : Effet
        {
            public int BonusValue { get; private set; }
            public Classe ClasseConcernee { get; private set; }
        }
    }
}
