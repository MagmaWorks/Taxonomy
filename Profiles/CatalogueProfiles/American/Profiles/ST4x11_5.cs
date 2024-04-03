using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST4x11_5 : SingletonAmericanBase<ST4x11_5>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST4X11.5";
        public Length Height => new Length(4.00, LengthUnit.Inch);
        public Length Width => new Length(4.17, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.43, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(3, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.5, LengthUnit.Inch);

        public ST4x11_5() { }
    }
}
