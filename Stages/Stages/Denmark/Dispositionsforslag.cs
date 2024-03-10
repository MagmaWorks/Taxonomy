namespace MagmaWorks.Taxonomy.Stages.AB89
{
    public class Dispositionsforslag : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Dispositionsforslag";
        private const string _description = "Dispositionsforslag (Outline proposal)";
        private const string _id = "2";
        private static readonly IGovernance _governance = new AB89();

        public Dispositionsforslag() { }
    }
}
