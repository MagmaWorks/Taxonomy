using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x7 : SingletonAmericanBase<WT6x7>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X7";
        public Length Height => new Length(5.96, LengthUnit.Inch);
        public Length Width => new Length(3.97, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.20, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.43, LengthUnit.Inch);

        public WT6x7() { }
    }
}
