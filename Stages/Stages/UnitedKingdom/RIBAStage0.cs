namespace MagmaWorks.Taxonomy.Stages.UK
{
    public class RIBAStage0 : IIdea
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 0";
        private const string _description = "Strategic Definition";
        private const string _id = "0";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage0() { }
    }
}
