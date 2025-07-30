namespace MagmaWorks.Taxonomy.Stages.UK
{
    public class RIBAStage6 : IHandover
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 6";
        private const string _description = "Handover";
        private const string _id = "6";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage6() { }
    }
}
