using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN340 : SingletonEuropeanBase<IPN340>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 340";
        public Length Height => new Length(340, LengthUnit.Millimeter);
        public Length Width => new Length(137, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12.2, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7.3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(274, LengthUnit.Millimeter);

        public IPN340() { }
    }
}
