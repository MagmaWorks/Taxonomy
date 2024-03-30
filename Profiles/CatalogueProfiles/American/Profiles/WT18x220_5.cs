using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x220_5 : SingletonAmericanBase<WT18x220_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X220.5";
        public Length Height => new Length(19.40, LengthUnit.Inch);
        public Length Width => new Length(17.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.44, LengthUnit.Inch);
        public Length WebThickness => new Length(1.36, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.43, LengthUnit.Inch);

        public WT18x220_5() { }
    }
}
