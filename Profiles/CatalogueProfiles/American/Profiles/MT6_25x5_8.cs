using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT6_25x5_8 : SingletonAmericanBase<MT6_25x5_8>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT6.25X5.8";
        public Length Height => new Length(6.25, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.69, LengthUnit.Inch);

        public MT6_25x5_8() { }
    }
}
