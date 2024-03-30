using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE240AA : SingletonEuropeanBase<HE240AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 240 AA";
        public Length Height => new Length(224, LengthUnit.Millimeter);
        public Length Width => new Length(240, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public HE240AA() { }
    }
}
