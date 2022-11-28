using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1gyumolcs
{
    internal class Gyumolcsok
    {
        int id;
        string nev;
        double Egyseg;
        double Meret;

     

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double Egyseg1 { get => Egyseg; set => Egyseg = value; }
        public double Meret1 { get => Meret; set => Meret = value; }

        public Gyumolcsok(int id, string nev, double egyseg1, double meret1)
        {
            Id = id;
            Nev = nev;
            Egyseg1 = egyseg1;
            Meret1 = meret1;
        }
        public override string ToString()
        {
            return "Név:"+ nev + " Egységár:" + Egyseg+" Mennyiség:"+ Meret;
        }
    }
}