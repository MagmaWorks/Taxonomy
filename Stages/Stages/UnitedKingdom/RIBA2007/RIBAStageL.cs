namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageL : IInUse
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage L";
        private const string _description = "Post Practical Completion";
        private const string _id = "L";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageL() { }
    }
}
