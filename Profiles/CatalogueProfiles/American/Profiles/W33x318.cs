using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x318 : SingletonAmericanBase<W33x318>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X318";
        public Length Height => new Length(35.20, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.04, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W33x318() { }
    }
}
