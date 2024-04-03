using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC12x14_3 : SingletonAmericanBase<MC12x14_3>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC12X14.3";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(2.12, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.31, LengthUnit.Inch);
        public Length WebThickness => new Length(0.25, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.44, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.22, LengthUnit.Inch);
        public Length WebHeight => new Length(10.50, LengthUnit.Inch);

        public MC12x14_3() { }
    }
}
