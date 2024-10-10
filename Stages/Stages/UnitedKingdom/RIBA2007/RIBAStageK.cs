namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageK : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage K";
        private const string _description = "Construction to Practical Completion";
        private const string _id = "K";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageK() { }
    }
}
