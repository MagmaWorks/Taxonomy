using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT20x147 : SingletonAmericanBase<WT20x147>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT20X147";
        public Length Height => new Length(20.20, LengthUnit.Inch);
        public Length Width => new Length(12.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.93, LengthUnit.Inch);
        public Length WebThickness => new Length(1.06, LengthUnit.Inch);
        public Length FilletRadius => new Length(17.09, LengthUnit.Inch);

        public WT20x147() { }
    }
}
