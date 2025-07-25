namespace MagmaWorks.Taxonomy.Stages
{
    public class Competition : ICompetition
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "Competition";
        private const string _description = "Architectural Competition phase";
        private const string _id = "2";

        public Competition() { }
    }
}
