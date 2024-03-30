using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x62 : SingletonAmericanBase<WT15x62>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X62";
        public Length Height => new Length(15.10, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.93, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.375, LengthUnit.Inch);

        public WT15x62() { }
    }
}
