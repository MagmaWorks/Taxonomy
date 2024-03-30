using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C6x8_2 : SingletonAmericanBase<C6x8_2>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C6X8.2";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(1.92, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.34, LengthUnit.Inch);
        public Length WebThickness => new Length(0.20, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.47, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.235, LengthUnit.Inch);
        public Length WebHeight => new Length(4.38, LengthUnit.Inch);

        public C6x8_2() { }
    }
}
