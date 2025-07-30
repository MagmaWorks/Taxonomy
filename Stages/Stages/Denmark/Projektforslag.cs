namespace MagmaWorks.Taxonomy.Stages.Denmark
{
    public class Projektforslag : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Projektforslag";
        private const string _description = "Projektforslag (Project proposal)";
        private const string _id = "3";
        private static readonly IGovernance _governance = new AB89();

        public Projektforslag() { }
    }
}
