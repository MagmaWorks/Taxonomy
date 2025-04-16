namespace MagmaWorks.Taxonomy.Loads.Combinations.EN
{
    public struct TableA1_2Properties
    {
        public Ratio Gamma_Gsup;
        public Ratio Gamma_Ginf;
        public Ratio Gamma_Q1;
        public Ratio Gamma_Qi;
        public Ratio Xi;

        public TableA1_2Properties(double gamma_Gsup, double gamma_Ginf, double gamma_Q1, double gamma_Qi, double xi)
        {
            RatioUnit unit = RatioUnit.DecimalFraction;
            Gamma_Gsup = new Ratio(gamma_Gsup, unit);
            Gamma_Ginf = new Ratio(gamma_Ginf, unit);
            Gamma_Q1 = new Ratio(gamma_Q1, unit);
            Gamma_Qi = new Ratio(gamma_Qi, unit);
            Xi = new Ratio(xi, unit);
        }

        public TableA1_2Properties(double gamma_Gsup, double gamma_Ginf, double gamma_Q1, double gamma_Qi)
        {
            RatioUnit unit = RatioUnit.DecimalFraction;
            Gamma_Gsup = new Ratio(gamma_Gsup, unit);
            Gamma_Ginf = new Ratio(gamma_Ginf, unit);
            Gamma_Q1 = new Ratio(gamma_Q1, unit);
            Gamma_Qi = new Ratio(gamma_Qi, unit);
            Xi = Ratio.Zero;
        }
    }
}
