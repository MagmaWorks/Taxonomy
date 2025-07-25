namespace MagmaWorks.Taxonomy.Stages.Germany
{
    public class LP8 : IPredesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 8";
        private const string _description = "Objektüberwachung (Site supervision)";
        private const string _id = "8";
        private static readonly IGovernance _governance = new HOAI();

        public LP8() { }
    }
}
