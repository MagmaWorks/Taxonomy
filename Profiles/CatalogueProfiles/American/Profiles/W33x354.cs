using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x354 : SingletonAmericanBase<W33x354>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X354";
        public Length Height => new Length(35.60, LengthUnit.Inch);
        public Length Width => new Length(16.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.09, LengthUnit.Inch);
        public Length WebThickness => new Length(1.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.27, LengthUnit.Inch);

        public W33x354() { }
    }
}
