using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST12x45 : SingletonAmericanBase<ST12x45>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST12X45";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(7.13, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.75, LengthUnit.Inch);

        public ST12x45() { }
    }
}
