using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M3x2_9 : SingletonAmericanBase<M3x2_9>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M3X2.9";
        public Length Height => new Length(3.00, LengthUnit.Inch);
        public Length Width => new Length(2.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.13, LengthUnit.Inch);
        public Length WebThickness => new Length(0.09, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.37, LengthUnit.Inch);

        public M3x2_9() { }
    }
}
