namespace MagmaWorks.Taxonomy.Stages
{
    public class InUse : IInUse
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new WhitbyWoodGoverned();

        private const string _name = "In Use";
        private const string _description = "In Use";
        private const string _id = "8";

        public InUse() { }
    }
}
