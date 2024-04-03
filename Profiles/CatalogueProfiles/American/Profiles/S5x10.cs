using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class S5x10 : SingletonAmericanBase<S5x10>, IITaperFlange
    {
        public override AmericanShape Shape => AmericanShape.S;
        public override string Label => "S5X10";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(3.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.33, LengthUnit.Inch);
        public Length WebThickness => new Length(0.21, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.42, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.252, LengthUnit.Inch);
        public Length WebHeight => new Length(3.50, LengthUnit.Inch);

        public S5x10() { }
    }
}
