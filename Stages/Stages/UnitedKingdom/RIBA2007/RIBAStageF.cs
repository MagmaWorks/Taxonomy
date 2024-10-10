namespace MagmaWorks.Taxonomy.Stages.RIBA
{
    public class RIBAStageF : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage F";
        private const string _description = "Product Information";
        private const string _id = "F";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageF() { }
    }
}
