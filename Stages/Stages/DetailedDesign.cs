namespace MagmaWorks.Taxonomy.Stages
{
    public class Handover : IHandover
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "Handover";
        private const string _description = "Handover & Close-out";
        private const string _id = "8";

        public Handover() { }
    }
}
