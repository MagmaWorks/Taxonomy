using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP14x117 : SingletonAmericanBase<HP14x117>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP14X117";
        public Length Height => new Length(14.20, LengthUnit.Inch);
        public Length Width => new Length(14.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.81, LengthUnit.Inch);
        public Length WebThickness => new Length(0.81, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.665, LengthUnit.Inch);

        public HP14x117() { }
    }
}
