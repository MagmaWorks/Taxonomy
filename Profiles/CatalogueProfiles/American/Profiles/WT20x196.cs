using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x196 : SingletonAmericanBase<WT20x196>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X196";
        public Length Height => new Length(20.80, LengthUnit.Inch);
        public Length Width => new Length(12.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.52, LengthUnit.Inch);
        public Length WebThickness => new Length(1.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.1, LengthUnit.Inch);

        public WT20x196() { }
    }
}
