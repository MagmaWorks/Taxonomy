using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE140 : SingletonEuropeanBase<IPE140>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 140";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(73, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPE140() { }
    }
}
