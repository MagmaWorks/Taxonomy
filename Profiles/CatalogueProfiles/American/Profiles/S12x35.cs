using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S12x35 : SingletonAmericanBase<S12x35>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S12X35";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(5.08, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.645, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.387, LengthUnit.Inch);
        public Length WebHeight => new Length(9.63, LengthUnit.Inch);

        public S12x35() { }
    }
}
