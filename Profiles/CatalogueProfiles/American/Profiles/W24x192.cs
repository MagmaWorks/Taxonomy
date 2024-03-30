using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x192 : SingletonAmericanBase<W24x192>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X192";
        public Length Height => new Length(25.50, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.81, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.29, LengthUnit.Inch);

        public W24x192() { }
    }
}
