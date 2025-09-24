using System;

namespace butorgyar
{
    public class Butorlap
    {
        private int hossz;
        private int szelesseg;
        private string tipus;

        public const int AR_TARTOLAP = 5000;
        public const int AR_HATLAP = 500;

        public Butorlap(string tipus, int hossz, int szelesseg)
        {
            this.tipus = tipus;
            this.hossz = hossz;
            this.szelesseg = szelesseg;
        }

        public int ArSzamol()
        {
            double terulet = (hossz / 100.0) * (szelesseg / 100.0);
            if (tipus == "tartólap")
                return (int)(terulet * AR_TARTOLAP);
            else if (tipus == "hátlap")
                return (int)(terulet * AR_HATLAP);
            else
                return 0;
        }
    }

}
