using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C5x9 : SingletonAmericanBase<C5x9>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C5X9";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(1.89, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.33, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.43, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.215, LengthUnit.Inch);
        public Length WebHeight => new Length(3.50, LengthUnit.Inch);

        public C5x9() { }
    }
}
