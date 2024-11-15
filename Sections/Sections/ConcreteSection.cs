using System.Collections.Generic;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public class ConcreteSection : Section, IConcreteSection
    {
        public IList<ILongitudinalReinforcement> Rebars { get; set; } = new List<ILongitudinalReinforcement>();
        public IRebar Link { get; set; }
        public Length Cover { get; set; } = Length.Zero;

        public ConcreteSection(IProfile profile, IMaterial material) : base (profile, material) { }

        public ConcreteSection(IProfile profile, IMaterial material, IList<ILongitudinalReinforcement> rebars, IRebar link, Length cover)
            : base(profile, material)
        {
            Rebars = rebars;
            Link = link;
            Cover = cover;
        }
    }
}
