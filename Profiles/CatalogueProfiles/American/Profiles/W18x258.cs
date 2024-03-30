using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x258 : SingletonAmericanBase<W18x258>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X258";
        public Length Height => new Length(21.50, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.30, LengthUnit.Inch);
        public Length WebThickness => new Length(1.28, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.885, LengthUnit.Inch);

        public W18x258() { }
    }
}
