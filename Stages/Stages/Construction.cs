namespace MagmaWorks.Taxonomy.Stages
{
    public class Construction : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new WhitbyWoodGoverned();

        private const string _name = "Construction";
        private const string _description = "Construction phase";
        private const string _id = "7";

        public Construction() { }
    }
}
