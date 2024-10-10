using MagmaWorks.Taxonomy.Countries;

namespace MagmaWorks.Taxonomy.Stages
{
    public class WhitbyWoodGoverned : IGovernance
    {
        public string Name => _name;
        public string FullBodyName => _fullBodyName;
        public ICountry Country => _country;

        private const string _name = "Whitby Wood";
        private const string _fullBodyName = "Whitby Wood's definition of international stages";
        private static readonly ICountry _country = new UnitedKingdom();

        public WhitbyWoodGoverned() { }
    }
}
