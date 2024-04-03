using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x175 : SingletonAmericanBase<WT18x175>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X175";
        public Length Height => new Length(19.30, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.32, LengthUnit.Inch);
        public Length WebThickness => new Length(1.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(16.23, LengthUnit.Inch);

        public WT18x175() { }
    }
}
