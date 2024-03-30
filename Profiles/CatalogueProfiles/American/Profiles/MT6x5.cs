using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT6x5 : SingletonAmericanBase<MT6x5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT6X5";
        public Length Height => new Length(5.99, LengthUnit.Inch);
        public Length Width => new Length(3.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.15, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.05, LengthUnit.Inch);

        public MT6x5() { }
    }
}
