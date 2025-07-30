namespace MagmaWorks.Taxonomy.Stages
{
    public class EndOfLife : IEndOfLife
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "End of Life";
        private const string _description = "End of Life - Dissasemble and Demolition phase";
        private const string _id = "10";

        public EndOfLife() { }
    }
}
