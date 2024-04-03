using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x152x82 : SingletonEuropeanBase<UB457x152x82>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 152 × 82";
        public Length Height => new Length(465.8, LengthUnit.Millimeter);
        public Length Width => new Length(155.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x152x82() { }
    }
}
