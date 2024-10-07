using System.Collections.Generic;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public class ConcreteSection : IConcreteSection
    {
        public IMaterial Material { get; set; }
        public IProfile Profile { get; set; }
        public IList<ILongitudinalReinforcement> Rebars { get; set; }
        public IRebar Link { get; set; }

        public ConcreteSection(IMaterial material, IProfile profile, IList<ILongitudinalReinforcement> rebars, IRebar link)
        {
            Material = material;
            Profile = profile;
            Rebars = rebars;
            Link = link;
        }

        public void AddRebar(ILongitudinalReinforcement rebar)
        {
            Rebars ??= new List<ILongitudinalReinforcement>();

            Rebars.Add(rebar);
        }

        public void AddRebars(IList<ILongitudinalReinforcement> rebars)
        {
            Rebars ??= new List<ILongitudinalReinforcement>();

            foreach (ILongitudinalReinforcement rebar in rebars)
            {
                Rebars.Add(rebar);
            }
        }
    }
}
