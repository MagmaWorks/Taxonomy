namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageD : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage D";
        private const string _description = "Design Development";
        private const string _id = "D";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageD() { }
    }
}
