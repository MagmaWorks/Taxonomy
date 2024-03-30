using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC8x22_8 : SingletonAmericanBase<MC8x22_8>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC8X22.8";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.53, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.328, LengthUnit.Inch);
        public Length WebHeight => new Length(5.63, LengthUnit.Inch);

        public MC8x22_8() { }
    }
}
