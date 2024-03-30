using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W40x149 : SingletonAmericanBase<W40x149>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W40X149";
        public Length Height => new Length(38.20, LengthUnit.Inch);
        public Length Width => new Length(11.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.83, LengthUnit.Inch);
        public Length WebThickness => new Length(0.63, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W40x149() { }
    }
}
