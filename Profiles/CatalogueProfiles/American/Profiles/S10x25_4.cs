using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S10x25_4 : SingletonAmericanBase<S10x25_4>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S10X25.4";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(4.66, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.49, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.318, LengthUnit.Inch);
        public Length WebHeight => new Length(7.75, LengthUnit.Inch);

        public S10x25_4() { }
    }
}
