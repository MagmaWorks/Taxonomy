using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x387 : SingletonAmericanBase<W33x387>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X387";
        public Length Height => new Length(36.00, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.28, LengthUnit.Inch);
        public Length WebThickness => new Length(1.26, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.18, LengthUnit.Inch);

        public W33x387() { }
    }
}
