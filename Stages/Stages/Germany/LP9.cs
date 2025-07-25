namespace MagmaWorks.Taxonomy.Stages.Germany
{
    public class LP9 : IHandover
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 9";
        private const string _description = "Objektbetreuung (Project control and documentation)";
        private const string _id = "9";
        private static readonly IGovernance _governance = new HOAI();

        public LP9() { }
    }
}
