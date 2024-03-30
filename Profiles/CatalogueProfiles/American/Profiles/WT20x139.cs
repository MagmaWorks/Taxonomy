using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x139 : SingletonAmericanBase<WT20x139>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X139";
        public Length Height => new Length(20.10, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.81, LengthUnit.Inch);
        public Length WebThickness => new Length(1.03, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.495, LengthUnit.Inch);

        public WT20x139() { }
    }
}
