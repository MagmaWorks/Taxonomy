using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S6x17_25 : SingletonAmericanBase<S6x17_25>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S6X17.25";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(3.57, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.36, LengthUnit.Inch);
        public Length WebThickness => new Length(0.47, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.45, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.27, LengthUnit.Inch);
        public Length WebHeight => new Length(4.38, LengthUnit.Inch);

        public S6x17_25() { }
    }
}
