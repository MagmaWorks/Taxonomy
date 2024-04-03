using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO180 : SingletonEuropeanBase<IPEO180>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPEO;
        public override string Label => "IPE O 180";
        public Length Height => new Length(182, LengthUnit.Millimeter);
        public Length Width => new Length(92, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPEO180() { }
    }
}
