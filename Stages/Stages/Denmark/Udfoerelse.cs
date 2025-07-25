namespace MagmaWorks.Taxonomy.Stages.Denmark
{
    public class Udfoerelse : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Udførelse";
        private const string _description = "Udførelse (Construction)";
        private const string _id = "7";
        private static readonly IGovernance _governance = new AB89();

        public Udfoerelse() { }
    }
}
