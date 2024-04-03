using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x283 : SingletonAmericanBase<W14x283>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X283";
        public Length Height => new Length(16.70, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.07, LengthUnit.Inch);
        public Length WebThickness => new Length(1.29, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.235, LengthUnit.Inch);

        public W14x283() { }
    }
}
