using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x163 : SingletonAmericanBase<WT15x163>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X163";
        public Length Height => new Length(16.20, LengthUnit.Inch);
        public Length Width => new Length(15.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.05, LengthUnit.Inch);
        public Length WebThickness => new Length(1.14, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.36, LengthUnit.Inch);

        public WT15x163() { }
    }
}
