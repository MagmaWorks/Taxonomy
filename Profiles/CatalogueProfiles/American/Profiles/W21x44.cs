using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x44 : SingletonAmericanBase<W21x44>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X44";
        public Length Height => new Length(20.70, LengthUnit.Inch);
        public Length Width => new Length(6.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.45, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.635, LengthUnit.Inch);

        public W21x44() { }
    }
}
