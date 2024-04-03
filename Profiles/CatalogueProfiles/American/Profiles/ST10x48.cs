using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST10x48 : SingletonAmericanBase<ST10x48>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST10X48";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(7.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.92, LengthUnit.Inch);
        public Length WebThickness => new Length(0.80, LengthUnit.Inch);
        public Length FilletRadius => new Length(8.45, LengthUnit.Inch);
        public Length ToeRadius => new Length(4.225, LengthUnit.Inch);

        public ST10x48() { }
    }
}
