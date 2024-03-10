namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP3 : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 3";
        private const string _description = "Entwurfsplanung (Design planning including cost calculation)";
        private const string _id = "3";
        private static readonly IGovernance _governance = new HOAI();

        public LP3() { }
    }
}
