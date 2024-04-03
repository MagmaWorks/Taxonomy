using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x95_5 : SingletonAmericanBase<WT15x95_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X95.5";
        public Length Height => new Length(15.30, LengthUnit.Inch);
        public Length Width => new Length(15.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.33, LengthUnit.Inch);

        public WT15x95_5() { }
    }
}
