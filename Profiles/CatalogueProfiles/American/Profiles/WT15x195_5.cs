using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x195_5 : SingletonAmericanBase<WT15x195_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X195.5";
        public Length Height => new Length(16.60, LengthUnit.Inch);
        public Length Width => new Length(15.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.44, LengthUnit.Inch);
        public Length WebThickness => new Length(1.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.37, LengthUnit.Inch);

        public WT15x195_5() { }
    }
}
