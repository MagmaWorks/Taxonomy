using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W24x76 : SingletonAmericanBase<W24x76>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W24X76";
        public Length Height => new Length(23.90, LengthUnit.Inch);
        public Length Width => new Length(8.99, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.68, LengthUnit.Inch);
        public Length WebThickness => new Length(0.44, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W24x76() { }
    }
}
