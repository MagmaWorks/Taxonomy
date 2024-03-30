using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT16_5x177 : SingletonAmericanBase<WT16_5x177>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT16.5X177";
        public Length Height => new Length(17.80, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.59, LengthUnit.Inch);

        public WT16_5x177() { }
    }
}
