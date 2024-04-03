using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE600 : SingletonEuropeanBase<IPE600>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 600";
        public Length Height => new Length(600, LengthUnit.Millimeter);
        public Length Width => new Length(220, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPE600() { }
    }
}
