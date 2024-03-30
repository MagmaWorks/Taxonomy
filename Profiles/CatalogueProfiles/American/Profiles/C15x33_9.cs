using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C15x33_9 : SingletonAmericanBase<C15x33_9>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C15X33.9";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(3.40, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.40, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.785, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.392, LengthUnit.Inch);
        public Length WebHeight => new Length(12.13, LengthUnit.Inch);

        public C15x33_9() { }
    }
}
