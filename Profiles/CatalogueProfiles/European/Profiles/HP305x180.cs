using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x180 : SingletonEuropeanBase<HP305x180>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 305 × 180";
        public Length Height => new Length(326.7, LengthUnit.Millimeter);
        public Length Width => new Length(319.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x180() { }
    }
}
