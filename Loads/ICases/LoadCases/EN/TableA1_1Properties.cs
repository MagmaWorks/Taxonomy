using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads.Cases.EN
{
    public struct TableA1_1Properties
    {
        public Ratio Phi_0;
        public Ratio Phi_1;
        public Ratio Phi_2;

        public TableA1_1Properties(double phi_0, double phi_1, double phi_2)
        {
            RatioUnit unit = RatioUnit.DecimalFraction;
            Phi_0 = new Ratio(phi_0, unit);
            Phi_1 = new Ratio(phi_1, unit);
            Phi_2 = new Ratio(phi_2, unit);
        }
    }
}
