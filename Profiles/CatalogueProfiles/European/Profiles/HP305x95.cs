using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x95 : SingletonEuropeanBase<HP305x95>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 305 × 95";
        public Length Height => new Length(303.7, LengthUnit.Millimeter);
        public Length Width => new Length(308.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x95() { }
    }
}
