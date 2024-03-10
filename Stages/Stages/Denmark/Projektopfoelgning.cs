namespace MagmaWorks.Taxonomy.Stages.AB89
{
    public class Projektopfoelgning : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Projektopfølgning";
        private const string _description = "Projektopfølgning (Site supervision)";
        private const string _id = "6";
        private static readonly IGovernance _governance = new AB89();

        public Projektopfoelgning() { }
    }
}
