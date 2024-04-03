using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S15x50 : SingletonAmericanBase<S15x50>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S15X50";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(5.64, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.755, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.453, LengthUnit.Inch);
        public Length WebHeight => new Length(12.25, LengthUnit.Inch);

        public S15x50() { }
    }
}
