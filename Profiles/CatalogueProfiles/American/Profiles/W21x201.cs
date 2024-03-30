using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W21x201 : SingletonAmericanBase<W21x201>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W21X201";
        public Length Height => new Length(23.00, LengthUnit.Inch);
        public Length Width => new Length(12.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.63, LengthUnit.Inch);
        public Length WebThickness => new Length(0.91, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.245, LengthUnit.Inch);

        public W21x201() { }
    }
}
