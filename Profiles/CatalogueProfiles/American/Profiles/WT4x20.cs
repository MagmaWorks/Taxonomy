using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x20 : SingletonAmericanBase<WT4x20>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X20";
        public Length Height => new Length(4.13, LengthUnit.Inch);
        public Length Width => new Length(8.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.905, LengthUnit.Inch);

        public WT4x20() { }
    }
}
