using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE330 : SingletonEuropeanBase<IPE330>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPE;
        public override string Label => "IPE 330";
        public Length Height => new Length(330, LengthUnit.Millimeter);
        public Length Width => new Length(160, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public IPE330() { }
    }
}
