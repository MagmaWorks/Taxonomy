using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP14x73 : SingletonAmericanBase<HP14x73>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP14X73";
        public Length Height => new Length(13.60, LengthUnit.Inch);
        public Length Width => new Length(14.60, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.51, LengthUnit.Inch);
        public Length WebThickness => new Length(0.51, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public HP14x73() { }
    }
}
