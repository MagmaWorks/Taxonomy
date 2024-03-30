using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x146 : SingletonAmericanBase<WT15x146>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X146";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(15.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.85, LengthUnit.Inch);
        public Length WebThickness => new Length(1.02, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.5, LengthUnit.Inch);

        public WT15x146() { }
    }
}
