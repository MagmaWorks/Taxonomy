using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public class Rebar : IRebar
    {
        public Length Diameter { get; set; }
        public IMaterial Material { get; set; }

        public Rebar(IMaterial material, Length diameter)
        {
            Material = material;
            Diameter = diameter;
        }
    }
}
