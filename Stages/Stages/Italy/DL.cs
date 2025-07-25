namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class DL : IConstruction
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "DL";
        private const string _description = "Direzione Lavori";
        private const string _id = "4";
        private static readonly IGovernance _governance = new ConsiglioSuperioreDeiLavoriPubblici();

        public DL() { }
    }
}
