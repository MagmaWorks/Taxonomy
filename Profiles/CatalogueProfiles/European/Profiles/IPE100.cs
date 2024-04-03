using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE100 : SingletonEuropeanBase<IPE100>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 100";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(55, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPE100() { }
    }
}
