using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S24x121 : SingletonAmericanBase<S24x121>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S24X121";
        public Length Height => new Length(24.50, LengthUnit.Inch);
        public Length Width => new Length(8.05, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.09, LengthUnit.Inch);
        public Length WebThickness => new Length(0.80, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.91, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.455, LengthUnit.Inch);
        public Length WebHeight => new Length(20.50, LengthUnit.Inch);

        public S24x121() { }
    }
}
