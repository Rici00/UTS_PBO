using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCachier
{
    class XYZStore
    {
        //Constructor
        public XYZStore()
        {
            //Default Double
            nwstratG = 0.0;
            nwteleG = 0.0;
            nwlpG = 0.0;
            nwthinlineG = 0.0;
            nwsemihollowG = 0.0;
            nwhollowG = 0.0;
            nwpickA = 0.0;
            nwpicksetA = 0.0;
            nwgstringA = 0.0;
            nwhandleA = 0.0;
            nwstrapA = 0.0;
            nwgcaseA = 0.0;
        }
        //overload Contruc
        public XYZStore(double strat, double tele, double lp, double thinline, double semihollow, double hollow, 
            double pick, double pickset, double gstring, double handle, double strap, double gcase)
        {
            nwstratG = strat;
            nwteleG = tele;
            nwlpG = lp;
            nwthinlineG = thinline;
            nwsemihollowG = semihollow;
            nwhollowG = hollow;
            nwpickA = pick;
            nwpicksetA = pickset;
            nwgstringA = gstring;
            nwhandleA = handle;
            nwstrapA = strap;
            nwgcaseA = gcase;
        }

        //acesor func
        public double getStrat()
        {
            return nwstratG;
        }
        public double getTele()
        {
            return nwteleG;
        }
        public double getLp()
        {
            return nwlpG;
        }
        public double getThin()
        {
            return nwthinlineG;
        }
        public double getSemi()
        {
            return nwsemihollowG;
        }
        public double getHollow()
        {
            return nwhollowG;
        }
        public double getPick()
        {
            return nwpickA;
        }
        public double getPickset()
        {
            return nwpicksetA;
        }
        public double getGstring()
        {
            return nwgstringA;
        }
        public double getHandle()
        {
            return nwhandleA;
        }
        public double getStrap()
        {
            return nwstrapA;
        }
        public double getCase()
        {
            return nwgcaseA;
        }

        //enkapsulasi
        //Member Var. Guitar Type
        private double nwstratG;
        private double nwteleG;
        private double nwlpG;
        private double nwthinlineG;
        private double nwsemihollowG;
        private double nwhollowG;
        //Member Var. Accesories
        private double nwpickA;
        private double nwpicksetA;
        private double nwgstringA;
        private double nwhandleA;
        private double nwstrapA;
        private double nwgcaseA;
    }
}
