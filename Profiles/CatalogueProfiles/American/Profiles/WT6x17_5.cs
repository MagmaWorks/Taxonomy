using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x17_5 : SingletonAmericanBase<WT6x17_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X17.5";
        public Length Height => new Length(6.25, LengthUnit.Inch);
        public Length Width => new Length(6.56, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.43, LengthUnit.Inch);

        public WT6x17_5() { }
    }
}
