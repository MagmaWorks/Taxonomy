namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP2 : IBrief
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 2";
        private const string _description = "Vorplanung (Preliminary planning and estimate)";
        private const string _id = "2";
        private static readonly IGovernance _governance = new HOAI();

        public LP2() { }
    }
}
