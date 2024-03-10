namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP5 : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 5";
        private const string _description = "Ausführungsplanung (Detailed design)";
        private const string _id = "5";
        private static readonly IGovernance _governance = new HOAI();

        public LP5() { }
    }
}
