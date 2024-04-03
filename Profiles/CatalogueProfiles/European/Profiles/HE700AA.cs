using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE700AA : SingletonEuropeanBase<HE700AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 700 AA";
        public Length Height => new Length(670, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE700AA() { }
    }
}
