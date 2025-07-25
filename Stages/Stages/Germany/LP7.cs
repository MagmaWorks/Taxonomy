namespace MagmaWorks.Taxonomy.Stages.Germany
{
    public class LP7 : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 7";
        private const string _description = "Mitwirkung bei der Vergabe (Tender evalutation)";
        private const string _id = "7";
        private static readonly IGovernance _governance = new HOAI();

        public LP7() { }
    }
}
