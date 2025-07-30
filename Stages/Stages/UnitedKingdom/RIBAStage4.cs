namespace MagmaWorks.Taxonomy.Stages.UK
{
    public class RIBAStage4 : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 4";
        private const string _description = "Technical Design";
        private const string _id = "4";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage4() { }
    }
}
