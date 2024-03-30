using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x185 : SingletonAmericanBase<WT12x185>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X185";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(13.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.72, LengthUnit.Inch);
        public Length WebThickness => new Length(1.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.87, LengthUnit.Inch);

        public WT12x185() { }
    }
}
