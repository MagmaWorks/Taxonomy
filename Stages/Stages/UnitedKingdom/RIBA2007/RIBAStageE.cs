namespace MagmaWorks.Taxonomy.Stages.UK.RIBA2007
{
    public class RIBAStageE : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage E";
        private const string _description = "Technical Design";
        private const string _id = "E";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageE() { }
    }
}
