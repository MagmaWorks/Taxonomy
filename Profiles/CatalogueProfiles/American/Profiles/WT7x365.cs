using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x365 : SingletonAmericanBase<WT7x365>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X365";
        public Length Height => new Length(11.20, LengthUnit.Inch);
        public Length Width => new Length(17.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(4.91, LengthUnit.Inch);
        public Length WebThickness => new Length(3.07, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.69, LengthUnit.Inch);

        public WT7x365() { }
    }
}
