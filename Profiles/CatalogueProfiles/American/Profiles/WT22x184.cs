using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x184 : SingletonAmericanBase<WT22x184>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X184";
        public Length Height => new Length(22.20, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.97, LengthUnit.Inch);
        public Length WebThickness => new Length(1.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(19.44, LengthUnit.Inch);

        public WT22x184() { }
    }
}
