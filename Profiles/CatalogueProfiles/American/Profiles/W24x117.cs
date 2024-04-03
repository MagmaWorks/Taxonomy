using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x117 : SingletonAmericanBase<W24x117>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X117";
        public Length Height => new Length(24.30, LengthUnit.Inch);
        public Length Width => new Length(12.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.85, LengthUnit.Inch);
        public Length WebThickness => new Length(0.55, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.225, LengthUnit.Inch);

        public W24x117() { }
    }
}
