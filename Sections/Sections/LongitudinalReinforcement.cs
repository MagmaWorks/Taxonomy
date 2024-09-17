using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public class LongitudinalReinforcement : ILongitudinalReinforcement
    {
        public Length Diameter { get; set; }
        public IMaterial Material { get; set; }
        public ILocalPoint2d Position { get; set; }

        public LongitudinalReinforcement(IMaterial material, Length diameter, ILocalPoint2d position)
        {
            Material = material;
            Diameter = diameter;
            Position = position;
        }
    }
}
