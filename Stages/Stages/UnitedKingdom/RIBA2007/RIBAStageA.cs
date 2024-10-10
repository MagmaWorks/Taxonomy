namespace MagmaWorks.Taxonomy.Stages.RIBA.RIBA2007
{
    public class RIBAStageA : IIdea
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA 2007 Stage A";
        private const string _description = "Appraisal";
        private const string _id = "A";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStageA() { }
    }
}
