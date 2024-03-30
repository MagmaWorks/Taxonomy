using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x169 : SingletonAmericanBase<W33x169>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X169";
        public Length Height => new Length(33.80, LengthUnit.Inch);
        public Length Width => new Length(11.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.67, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.24, LengthUnit.Inch);

        public W33x169() { }
    }
}
