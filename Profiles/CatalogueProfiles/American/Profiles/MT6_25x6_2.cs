using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT6_25x6_2 : SingletonAmericanBase<MT6_25x6_2>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT6.25X6.2";
        public Length Height => new Length(6.27, LengthUnit.Inch);
        public Length Width => new Length(3.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public MT6_25x6_2() { }
    }
}
