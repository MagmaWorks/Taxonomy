using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x45 : SingletonAmericanBase<WT7x45>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X45";
        public Length Height => new Length(7.01, LengthUnit.Inch);
        public Length Width => new Length(14.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.71, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x45() { }
    }
}
