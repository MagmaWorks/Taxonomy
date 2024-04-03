using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x66 : SingletonAmericanBase<WT7x66>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X66";
        public Length Height => new Length(7.33, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.03, LengthUnit.Inch);
        public Length WebThickness => new Length(0.65, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x66() { }
    }
}
