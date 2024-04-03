using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S3x5_7 : SingletonAmericanBase<S3x5_7>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S3X5.7";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.33, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.26, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.365, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.219, LengthUnit.Inch);
        public Length WebHeight => new Length(1.75, LengthUnit.Inch);

        public S3x5_7() { }
    }
}
