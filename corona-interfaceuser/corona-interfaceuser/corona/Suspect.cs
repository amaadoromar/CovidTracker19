using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corona
{
    public class Suspect : Citoyen
    {
        public Suspect()
        { }
        public Suspect(String Cin) : base(Cin)
        {
            this.Cin = Cin;
            this.CodeCouleur = "Orange";
        }
        public Suspect(String Cin,bool encontact,bool  frequente) : base(Cin)
        {
            this.Cin = Cin;
            this.Encontact = encontact;
            this.Frequente = frequente;
            this.CodeCouleur = "Orange";
        }

        public Suspect(String Cin,bool testcorona)
        {
            this.Cin = Cin;
            this.testcorona = testcorona;
        }



    }
}
