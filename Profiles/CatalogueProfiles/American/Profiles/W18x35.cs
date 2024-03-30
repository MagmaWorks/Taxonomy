using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W18x35 : SingletonAmericanBase<W18x35>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W18X35";
        public Length Height => new Length(17.70, LengthUnit.Inch);
        public Length Width => new Length(6.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.67, LengthUnit.Inch);

        public W18x35() { }
    }
}
