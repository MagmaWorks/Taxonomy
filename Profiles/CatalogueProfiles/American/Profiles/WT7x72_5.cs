using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x72_5 : SingletonAmericanBase<WT7x72_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X72.5";
        public Length Height => new Length(7.39, LengthUnit.Inch);
        public Length Width => new Length(15.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.09, LengthUnit.Inch);
        public Length WebThickness => new Length(0.68, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.72, LengthUnit.Inch);

        public WT7x72_5() { }
    }
}
