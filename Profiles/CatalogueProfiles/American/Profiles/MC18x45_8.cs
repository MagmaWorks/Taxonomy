using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MC18x45_8 : SingletonAmericanBase<MC18x45_8>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MC;
        public override string Label => "MC18X45.8";
        public Length Height => new Length(18.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.50, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.805, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.402, LengthUnit.Inch);
        public Length WebHeight => new Length(15.13, LengthUnit.Inch);

        public MC18x45_8() { }
    }
}
