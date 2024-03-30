using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W30x261 : SingletonAmericanBase<W30x261>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W30X261";
        public Length Height => new Length(31.60, LengthUnit.Inch);
        public Length Width => new Length(15.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.93, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.275, LengthUnit.Inch);

        public W30x261() { }
    }
}
