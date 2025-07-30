namespace MagmaWorks.Taxonomy.Stages.Denmark
{
    public class Myndighedsprojekt : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Myndighedsprojekt";
        private const string _description = "Myndighedsprojekt (Building permission application)";
        private const string _id = "4";
        private static readonly IGovernance _governance = new AB89();

        public Myndighedsprojekt() { }
    }
}
