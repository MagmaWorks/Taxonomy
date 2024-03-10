namespace MagmaWorks.Taxonomy.Stages.AB89
{
    public class Byggeprogram : IPredesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Byggeprogram";
        private const string _description = "Byggeprogram (Building program)";
        private const string _id = "1";
        private static readonly IGovernance _governance = new AB89();

        public Byggeprogram() { }
    }
}
