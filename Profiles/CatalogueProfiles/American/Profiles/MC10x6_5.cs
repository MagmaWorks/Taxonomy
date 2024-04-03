using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC10x6_5 : SingletonAmericanBase<MC10x6_5>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC10X6.5";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(1.17, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.20, LengthUnit.Inch);
        public Length WebThickness => new Length(0.15, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.36, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.18, LengthUnit.Inch);
        public Length WebHeight => new Length(8.88, LengthUnit.Inch);

        public MC10x6_5() { }
    }
}
