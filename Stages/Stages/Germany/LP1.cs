namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP1 : IPredesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 1";
        private const string _description = "Grundlagenermittlung (Basic Evaluation)";
        private const string _id = "1";
        private static readonly IGovernance _governance = new HOAI();

        public LP1() { }
    }
}
