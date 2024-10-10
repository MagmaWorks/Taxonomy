namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageH : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage H";
        private const string _description = "Tender Action";
        private const string _id = "H";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageH() { }
    }
}
