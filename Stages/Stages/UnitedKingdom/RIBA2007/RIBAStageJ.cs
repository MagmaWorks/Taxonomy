namespace MagmaWorks.Taxonomy.Stages.UK.RIBA2007
{
    public class RIBAStageJ : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage J";
        private const string _description = "Mobilisation";
        private const string _id = "J";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageJ() { }
    }
}
