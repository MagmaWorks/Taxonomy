using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x185 : SingletonAmericanBase<WT7x185>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X185";
        public Length Height => new Length(8.96, LengthUnit.Inch);
        public Length Width => new Length(16.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.66, LengthUnit.Inch);
        public Length WebThickness => new Length(1.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x185() { }
    }
}
