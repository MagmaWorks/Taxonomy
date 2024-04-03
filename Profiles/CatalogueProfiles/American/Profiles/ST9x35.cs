using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST9x35 : SingletonAmericanBase<ST9x35>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST9X35";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(6.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(7.5, LengthUnit.Inch);
        public Length ToeRadius => new Length(3.75, LengthUnit.Inch);

        public ST9x35() { }
    }
}
