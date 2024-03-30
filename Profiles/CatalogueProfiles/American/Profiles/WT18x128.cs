using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x128 : SingletonAmericanBase<WT18x128>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X128";
        public Length Height => new Length(18.70, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.73, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.14, LengthUnit.Inch);

        public WT18x128() { }
    }
}
