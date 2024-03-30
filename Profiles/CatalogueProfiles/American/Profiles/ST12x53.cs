using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST12x53 : SingletonAmericanBase<ST12x53>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST12X53";
        public Length Height => new Length(12.30, LengthUnit.Inch);
        public Length Width => new Length(7.87, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.09, LengthUnit.Inch);
        public Length WebThickness => new Length(0.62, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.625, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.812, LengthUnit.Inch);

        public ST12x53() { }
    }
}
