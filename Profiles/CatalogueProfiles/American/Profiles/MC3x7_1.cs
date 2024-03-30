using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC3x7_1 : SingletonAmericanBase<MC3x7_1>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC3X7.1";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(1.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.35, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.46, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.23, LengthUnit.Inch);
        public Length WebHeight => new Length(1.38, LengthUnit.Inch);

        public MC3x7_1() { }
    }
}
