using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x132 : SingletonAmericanBase<WT20x132>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X132";
        public Length Height => new Length(20.00, LengthUnit.Inch);
        public Length Width => new Length(11.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.73, LengthUnit.Inch);
        public Length WebThickness => new Length(0.96, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.56, LengthUnit.Inch);

        public WT20x132() { }
    }
}
