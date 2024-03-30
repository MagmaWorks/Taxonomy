using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x11 : SingletonAmericanBase<WT6x11>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X11";
        public Length Height => new Length(6.16, LengthUnit.Inch);
        public Length Width => new Length(4.03, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.155, LengthUnit.Inch);

        public WT6x11() { }
    }
}
