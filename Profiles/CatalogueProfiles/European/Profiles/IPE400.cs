using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE400 : SingletonEuropeanBase<IPE400>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 400";
        public Length Height => new Length(400, LengthUnit.Millimeter);
        public Length Width => new Length(180, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPE400() { }
    }
}
