namespace MagmaWorks.Taxonomy.Stages.RIBA
{
    public class RIBAStage2 : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 2";
        private const string _description = "Concept Design";
        private const string _id = "2";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage2() { }
    }
}
