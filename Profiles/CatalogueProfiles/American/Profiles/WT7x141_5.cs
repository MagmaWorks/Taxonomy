using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x141_5 : SingletonAmericanBase<WT7x141_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X141.5";
        public Length Height => new Length(8.37, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.07, LengthUnit.Inch);
        public Length WebThickness => new Length(1.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.735, LengthUnit.Inch);

        public WT7x141_5() { }
    }
}
