using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC6x7 : SingletonAmericanBase<MC6x7>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC6X7";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(1.88, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.46, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.23, LengthUnit.Inch);
        public Length WebHeight => new Length(4.50, LengthUnit.Inch);

        public MC6x7() { }
    }
}
