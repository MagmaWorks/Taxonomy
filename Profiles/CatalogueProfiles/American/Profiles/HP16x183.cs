using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP16x183 : SingletonAmericanBase<HP16x183>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP16X183";
        public Length Height => new Length(16.50, LengthUnit.Inch);
        public Length Width => new Length(16.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.245, LengthUnit.Inch);

        public HP16x183() { }
    }
}
