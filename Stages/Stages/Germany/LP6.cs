namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP6 : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 6";
        private const string _description = "Vorbereitung der Vergabe (Preparation for tender)";
        private const string _id = "6";
        private static readonly IGovernance _governance = new HOAI();

        public LP6() { }
    }
}
