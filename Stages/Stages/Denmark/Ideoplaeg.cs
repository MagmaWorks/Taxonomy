namespace MagmaWorks.Taxonomy.Stages.Denmark
{
    public class Ideoplaeg : IPredesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Idéoplæg";
        private const string _description = "Idéoplæg (Idea)";
        private const string _id = "0";
        private static readonly IGovernance _governance = new AB89();

        public Ideoplaeg() { }
    }
}
