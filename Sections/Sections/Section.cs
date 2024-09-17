using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public class Section : ISection
    {
        public IMaterial Material { get; set; }
        public IProfile Profile { get; set; }

        public Section(IMaterial material, IProfile profile)
        {
            Material = material;
            Profile = profile;
        }
    }
}
