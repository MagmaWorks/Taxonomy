using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x250 : SingletonAmericanBase<W24x250>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X250";
        public Length Height => new Length(26.30, LengthUnit.Inch);
        public Length Width => new Length(13.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.04, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.26, LengthUnit.Inch);

        public W24x250() { }
    }
}
