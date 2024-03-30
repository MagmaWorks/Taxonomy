using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x327_5 : SingletonAmericanBase<WT20x327_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X327.5";
        public Length Height => new Length(21.80, LengthUnit.Inch);
        public Length Width => new Length(16.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.54, LengthUnit.Inch);
        public Length WebThickness => new Length(1.97, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.745, LengthUnit.Inch);

        public WT20x327_5() { }
    }
}
