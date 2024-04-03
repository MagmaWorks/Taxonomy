using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180M : SingletonEuropeanBase<HE180M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 180 M";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(186, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE180M() { }
    }
}
