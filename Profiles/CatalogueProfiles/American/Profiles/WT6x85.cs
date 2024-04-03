using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x85 : SingletonAmericanBase<WT6x85>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X85";
        public Length Height => new Length(7.02, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.56, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.86, LengthUnit.Inch);

        public WT6x85() { }
    }
}
