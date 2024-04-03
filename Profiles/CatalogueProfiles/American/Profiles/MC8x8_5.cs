using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC8x8_5 : SingletonAmericanBase<MC8x8_5>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC8X8.5";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(1.87, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.25, LengthUnit.Inch);
        public Length WebHeight => new Length(6.38, LengthUnit.Inch);

        public MC8x8_5() { }
    }
}
