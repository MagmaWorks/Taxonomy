using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST10x43 : SingletonAmericanBase<ST10x43>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST10X43";
        public Length Height => new Length(10.20, LengthUnit.Inch);
        public Length Width => new Length(7.06, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.92, LengthUnit.Inch);
        public Length WebThickness => new Length(0.66, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.45, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.725, LengthUnit.Inch);

        public ST10x43() { }
    }
}
