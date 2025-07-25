namespace MagmaWorks.Taxonomy.Stages.UK.RIBA2007
{
    public class RIBAStageC : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage C";
        private const string _description = "Concept";
        private const string _id = "C";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageC() { }
    }
}
