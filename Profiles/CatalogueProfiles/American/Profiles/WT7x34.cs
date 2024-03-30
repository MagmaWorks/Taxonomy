using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x34 : SingletonAmericanBase<WT7x34>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X34";
        public Length Height => new Length(7.02, LengthUnit.Inch);
        public Length Width => new Length(10.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.72, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.48, LengthUnit.Inch);

        public WT7x34() { }
    }
}
