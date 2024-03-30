using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST6x25 : SingletonAmericanBase<ST6x25>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST6X25";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(5.48, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.66, LengthUnit.Inch);
        public Length WebThickness => new Length(0.69, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.955, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.478, LengthUnit.Inch);

        public ST6x25() { }
    }
}
