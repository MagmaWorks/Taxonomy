using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE100A : SingletonEuropeanBase<HE100A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 100 A";
        public Length Height => new Length(96, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE100A() { }
    }
}
