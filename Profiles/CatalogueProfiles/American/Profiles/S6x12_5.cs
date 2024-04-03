using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S6x12_5 : SingletonAmericanBase<S6x12_5>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S6X12.5";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.33, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.23, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.45, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.27, LengthUnit.Inch);
        public Length WebHeight => new Length(4.38, LengthUnit.Inch);

        public S6x12_5() { }
    }
}
