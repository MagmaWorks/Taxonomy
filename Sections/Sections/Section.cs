using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public class Section : ISection
    {
        public IMaterial Material { get; set; }
        public IProfile Profile { get; set; }

        public Section(IProfile profile, IMaterial material)
        {
            Material = material;
            Profile = profile;
        }
    }
}
