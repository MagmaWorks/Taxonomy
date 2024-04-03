using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x250 : SingletonAmericanBase<WT7x250>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X250";
        public Length Height => new Length(9.80, LengthUnit.Inch);
        public Length Width => new Length(17.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.50, LengthUnit.Inch);
        public Length WebThickness => new Length(2.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x250() { }
    }
}
