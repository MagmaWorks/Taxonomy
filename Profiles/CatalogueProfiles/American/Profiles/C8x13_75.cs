using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C8x13_75 : SingletonAmericanBase<C8x13_75>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C8X13.75";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(2.34, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.39, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.545, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.272, LengthUnit.Inch);
        public Length WebHeight => new Length(6.13, LengthUnit.Inch);

        public C8x13_75() { }
    }
}
