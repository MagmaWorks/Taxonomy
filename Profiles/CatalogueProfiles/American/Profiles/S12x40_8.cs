using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S12x40_8 : SingletonAmericanBase<S12x40_8>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S12X40.8";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(5.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.66, LengthUnit.Inch);
        public Length WebThickness => new Length(0.46, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.775, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.465, LengthUnit.Inch);
        public Length WebHeight => new Length(9.13, LengthUnit.Inch);

        public S12x40_8() { }
    }
}
