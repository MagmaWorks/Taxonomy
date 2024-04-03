using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x191 : SingletonAmericanBase<W30x191>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X191";
        public Length Height => new Length(30.70, LengthUnit.Inch);
        public Length Width => new Length(15.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.19, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.205, LengthUnit.Inch);

        public W30x191() { }
    }
}
