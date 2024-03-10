namespace MagmaWorks.Taxonomy.Stages.RIBA
{
    public class RIBAStage1 : IPredesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 1";
        private const string _description = "Preparation and Brief";
        private const string _id = "1";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage1() { }
    }
}
