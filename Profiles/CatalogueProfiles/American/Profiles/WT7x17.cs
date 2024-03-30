using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x17 : SingletonAmericanBase<WT7x17>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X17";
        public Length Height => new Length(6.99, LengthUnit.Inch);
        public Length Width => new Length(6.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.46, LengthUnit.Inch);
        public Length WebThickness => new Length(0.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.37, LengthUnit.Inch);

        public WT7x17() { }
    }
}
