using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST10x33 : SingletonAmericanBase<ST10x33>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST10X33";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(6.26, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.80, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.245, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.622, LengthUnit.Inch);

        public ST10x33() { }
    }
}
