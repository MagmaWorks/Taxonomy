using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x86_5 : SingletonAmericanBase<WT15x86_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X86.5";
        public Length Height => new Length(15.20, LengthUnit.Inch);
        public Length Width => new Length(15.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.07, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.35, LengthUnit.Inch);

        public WT15x86_5() { }
    }
}
