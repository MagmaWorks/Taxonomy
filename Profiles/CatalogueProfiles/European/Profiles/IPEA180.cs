using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA180 : SingletonEuropeanBase<IPEA180>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEA;
        public override string Label => "IPE A 180";
        public Length Height => new Length(177, LengthUnit.Millimeter);
        public Length Width => new Length(91, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPEA180() { }
    }
}
