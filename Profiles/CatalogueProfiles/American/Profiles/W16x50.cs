using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W16x50 : SingletonAmericanBase<W16x50>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W16X50";
        public Length Height => new Length(16.30, LengthUnit.Inch);
        public Length Width => new Length(7.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.38, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.62, LengthUnit.Inch);

        public W16x50() { }
    }
}
