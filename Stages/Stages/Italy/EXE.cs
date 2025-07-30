namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class EXE : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "EXE";
        private const string _description = "Progetto Esecutivo";
        private const string _id = "3";
        private static readonly IGovernance _governance = new ConsiglioSuperioreDeiLavoriPubblici();

        public EXE() { }
    }
}
