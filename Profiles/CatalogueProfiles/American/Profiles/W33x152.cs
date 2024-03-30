using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x152 : SingletonAmericanBase<W33x152>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X152";
        public Length Height => new Length(33.50, LengthUnit.Inch);
        public Length Width => new Length(11.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.06, LengthUnit.Inch);
        public Length WebThickness => new Length(0.64, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.25, LengthUnit.Inch);

        public W33x152() { }
    }
}
