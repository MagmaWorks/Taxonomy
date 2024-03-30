using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB152x89x16 : SingletonEuropeanBase<UB152x89x16>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 152 × 89 × 16";
        public Length Height => new Length(152.4, LengthUnit.Millimeter);
        public Length Width => new Length(88.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB152x89x16() { }
    }
}
