using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT18x361_5 : SingletonAmericanBase<WT18x361_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT18X361.5";
        public Length Height => new Length(20.90, LengthUnit.Inch);
        public Length Width => new Length(17.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(3.90, LengthUnit.Inch);
        public Length WebThickness => new Length(2.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.165, LengthUnit.Inch);

        public WT18x361_5() { }
    }
}
