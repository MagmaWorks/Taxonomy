namespace MagmaWorks.Taxonomy.Stages.UK
{
    public class RIBAStage5 : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 5";
        private const string _description = "Construction";
        private const string _id = "5";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage5() { }
    }
}
