using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST2_5x5 : SingletonAmericanBase<ST2_5x5>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST2.5X5";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.21, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.645, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.322, LengthUnit.Inch);

        public ST2_5x5() { }
    }
}
