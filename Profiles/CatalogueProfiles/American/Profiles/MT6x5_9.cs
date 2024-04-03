using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT6x5_9 : SingletonAmericanBase<MT6x5_9>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT6X5.9";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.44, LengthUnit.Inch);

        public MT6x5_9() { }
    }
}
