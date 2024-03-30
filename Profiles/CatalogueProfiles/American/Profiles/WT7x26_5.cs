using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x26_5 : SingletonAmericanBase<WT7x26_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X26.5";
        public Length Height => new Length(6.96, LengthUnit.Inch);
        public Length Width => new Length(8.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.66, LengthUnit.Inch);
        public Length WebThickness => new Length(0.37, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.595, LengthUnit.Inch);

        public WT7x26_5() { }
    }
}
