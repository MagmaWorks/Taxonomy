namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageB : IBrief
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage B";
        private const string _description = "Design Brief";
        private const string _id = "B";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageB() { }
    }
}
