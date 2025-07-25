namespace MagmaWorks.Taxonomy.Stages.UK.RIBA2007
{
    public class RIBAStageG : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage G";
        private const string _description = "Tender Documentation";
        private const string _id = "G";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageG() { }
    }
}
