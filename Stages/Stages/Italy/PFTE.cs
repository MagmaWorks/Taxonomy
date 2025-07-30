namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class PFTE : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "PFTE";
        private const string _description = "Piano di Fattibilità Tecnico Economica";
        private const string _id = "1";
        private static readonly IGovernance _governance = new ConsiglioSuperioreDeiLavoriPubblici();

        public PFTE() { }
    }
}
