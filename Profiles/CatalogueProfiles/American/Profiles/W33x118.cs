using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x118 : SingletonAmericanBase<W33x118>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X118";
        public Length Height => new Length(32.90, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.74, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W33x118() { }
    }
}
