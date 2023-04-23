using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corona
{
    public class Patient : Suspect
    {
        public Patient()
        { }
        public Patient(String Cin)
        {
            this.Cin = Cin;
            this.CodeCouleur = "Red";
        }
        public Patient(String Cin,bool testcorona) 
        {
            this.Cin = Cin;
            this.CodeCouleur = "Red";
            this.testcorona = testcorona;
        }

        public bool IsVulnerable()
        {
            return (Medicationhopital && Reanimation);
        }


        public bool IsRecovered()
        {
            return recovered;
        }

        public bool Medicationhopital;
        public bool Reanimation;
        public bool recovered;
    }
}
