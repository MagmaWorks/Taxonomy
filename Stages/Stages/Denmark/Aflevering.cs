namespace MagmaWorks.Taxonomy.Stages.AB89
{
    public class Aflevering : IHandover
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Aflevering";
        private const string _description = "Aflevering (Handover)";
        private const string _id = "8";
        private static readonly IGovernance _governance = new AB89();

        public Aflevering() { }
    }
}
