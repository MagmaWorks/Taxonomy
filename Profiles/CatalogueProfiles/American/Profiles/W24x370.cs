using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x370 : SingletonAmericanBase<W24x370>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X370";
        public Length Height => new Length(28.00, LengthUnit.Inch);
        public Length Width => new Length(13.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.72, LengthUnit.Inch);
        public Length WebThickness => new Length(1.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W24x370() { }
    }
}
