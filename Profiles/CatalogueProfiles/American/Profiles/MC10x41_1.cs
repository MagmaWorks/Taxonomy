using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC10x41_1 : SingletonAmericanBase<MC10x41_1>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC10X41.1";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(4.32, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.58, LengthUnit.Inch);
        public Length WebThickness => new Length(0.80, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.73, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.365, LengthUnit.Inch);
        public Length WebHeight => new Length(7.38, LengthUnit.Inch);

        public MC10x41_1() { }
    }
}
