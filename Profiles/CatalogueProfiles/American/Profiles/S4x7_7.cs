using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S4x7_7 : SingletonAmericanBase<S4x7_7>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S4X7.7";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(2.66, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.29, LengthUnit.Inch);
        public Length WebThickness => new Length(0.19, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.46, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.276, LengthUnit.Inch);
        public Length WebHeight => new Length(2.50, LengthUnit.Inch);

        public S4x7_7() { }
    }
}
