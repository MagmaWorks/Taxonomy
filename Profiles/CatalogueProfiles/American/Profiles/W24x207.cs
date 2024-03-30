using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x207 : SingletonAmericanBase<W24x207>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X207";
        public Length Height => new Length(25.70, LengthUnit.Inch);
        public Length Width => new Length(13.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.28, LengthUnit.Inch);

        public W24x207() { }
    }
}
