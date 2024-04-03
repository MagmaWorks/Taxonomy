using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE160M : SingletonEuropeanBase<HE160M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 160 M";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(166, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE160M() { }
    }
}
