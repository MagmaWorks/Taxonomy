using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x391 : SingletonAmericanBase<W30x391>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X391";
        public Length Height => new Length(33.20, LengthUnit.Inch);
        public Length Width => new Length(15.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.44, LengthUnit.Inch);
        public Length WebThickness => new Length(1.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.2, LengthUnit.Inch);

        public W30x391() { }
    }
}
