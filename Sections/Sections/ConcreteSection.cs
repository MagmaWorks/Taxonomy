using System.Collections.Generic;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public class ConcreteSection : IConcreteSection
    {
        public IMaterial Material { get; set; }
        public IProfile Profile { get; set; }
        public IList<ILongitudinalReinforcement> Rebars { get; set; } = new List<ILongitudinalReinforcement>();
        public IRebar Link { get; set; }

        public ConcreteSection(IMaterial material, IProfile profile, IList<ILongitudinalReinforcement> rebars, IRebar link)
        {
            Material = material;
            Profile = profile;
            Rebars = rebars;
            Link = link;
        }
    }
}
