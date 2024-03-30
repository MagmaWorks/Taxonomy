using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S8x18_4 : SingletonAmericanBase<S8x18_4>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S8X18.4";
        public Length Height => new Length(8.00, LengthUnit.Inch);
        public Length Width => new Length(4.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.27, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.57, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.285, LengthUnit.Inch);
        public Length WebHeight => new Length(6.00, LengthUnit.Inch);

        public S8x18_4() { }
    }
}
