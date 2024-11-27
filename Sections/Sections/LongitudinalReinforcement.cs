using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public class LongitudinalReinforcement : ILongitudinalReinforcement
    {
        public ILocalPoint2d Position { get; set; }
        public IRebar Rebar { get; set; }
        public int CountPerBundle { get; set; } = 1;

        private LongitudinalReinforcement() { }

        public LongitudinalReinforcement(IRebar rebar, ILocalPoint2d position)
        {
            Rebar = rebar;
            Position = position;
        }

        public LongitudinalReinforcement(IMaterial material, Length diameter, ILocalPoint2d position)
        {
            Rebar = new Rebar(material, diameter);
            Position = position;
        }
    }
}
