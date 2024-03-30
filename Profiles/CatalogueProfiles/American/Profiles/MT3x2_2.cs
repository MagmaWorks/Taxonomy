using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT3x2_2 : SingletonAmericanBase<MT3x2_2>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT3X2.2";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(1.84, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.17, LengthUnit.Inch);
        public Length WebThickness => new Length(0.11, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.485, LengthUnit.Inch);

        public MT3x2_2() { }
    }
}
