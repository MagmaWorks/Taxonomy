using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST5x12_7 : SingletonAmericanBase<ST5x12_7>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST5X12.7";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(4.66, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.49, LengthUnit.Inch);
        public Length WebThickness => new Length(0.31, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.87, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.935, LengthUnit.Inch);

        public ST5x12_7() { }
    }
}
