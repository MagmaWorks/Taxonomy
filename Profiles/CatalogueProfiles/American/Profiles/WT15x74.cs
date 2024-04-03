using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x74 : SingletonAmericanBase<WT15x74>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X74";
        public Length Height => new Length(15.30, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.47, LengthUnit.Inch);

        public WT15x74() { }
    }
}
