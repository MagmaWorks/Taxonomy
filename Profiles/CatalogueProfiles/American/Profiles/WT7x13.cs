using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x13 : SingletonAmericanBase<WT7x13>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X13";
        public Length Height => new Length(6.96, LengthUnit.Inch);
        public Length Width => new Length(5.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.565, LengthUnit.Inch);

        public WT7x13() { }
    }
}
