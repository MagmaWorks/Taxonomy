using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x183 : SingletonAmericanBase<W40x183>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X183";
        public Length Height => new Length(39.00, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.3, LengthUnit.Inch);

        public W40x183() { }
    }
}
