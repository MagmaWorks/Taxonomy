using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x88 : SingletonAmericanBase<WT7x88>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X88";
        public Length Height => new Length(7.61, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x88() { }
    }
}
