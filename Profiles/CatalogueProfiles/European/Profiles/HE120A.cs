using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE120A : SingletonEuropeanBase<HE120A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 120 A";
        public Length Height => new Length(114, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE120A() { }
    }
}
