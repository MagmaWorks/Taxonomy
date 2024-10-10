namespace MagmaWorks.Taxonomy.Stages
{
    public class DetailedDesign : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new WhitbyWoodGoverned();

        private const string _name = "Detailed Design";
        private const string _description = "Detailed Design phase";
        private const string _id = "6";

        public DetailedDesign() { }
    }
}
