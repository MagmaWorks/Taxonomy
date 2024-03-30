using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x74 : SingletonEuropeanBase<UB457x191x74>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 191 × 74";
        public Length Height => new Length(457, LengthUnit.Millimeter);
        public Length Width => new Length(190.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x74() { }
    }
}
