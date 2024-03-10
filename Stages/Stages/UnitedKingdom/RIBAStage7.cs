namespace MagmaWorks.Taxonomy.Stages.RIBA
{
    public class RIBAStage7 : IInUse
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 7";
        private const string _description = "In Use";
        private const string _id = "7";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage7() { }
    }
}
