using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cartes.Donjons.Monstres
{
    public abstract class IncidentFacheux
    {
        public int ID { get; private set; }

        public IncidentFacheux(int ID)
        {
            this.ID = ID;
        }
    }

    namespace IncidentsFacheux
    {
        public class PerteObjet : IncidentFacheux
        {
            public int NumberOfItemToDispose { get; private set; }

            public PerteObjet(int ID, int NumberOfItemToDispose) : base(ID)
            {
                this.NumberOfItemToDispose = NumberOfItemToDispose;
            }
        }

        public class Mort : IncidentFacheux
        {
            public Mort(int ID) : base(ID) { }
        }
    }
}
