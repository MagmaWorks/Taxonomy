using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE400AA : SingletonEuropeanBase<HE400AA>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEAA;
        public override string Label => "HE 400 AA";
        public Length Height => new Length(378, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE400AA() { }
    }
}
