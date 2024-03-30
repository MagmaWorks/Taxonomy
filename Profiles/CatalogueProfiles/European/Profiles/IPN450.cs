using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN450 : SingletonEuropeanBase<IPN450>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 450";
        public Length Height => new Length(450, LengthUnit.Millimeter);
        public Length Width => new Length(170, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16.2, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(9.7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(363, LengthUnit.Millimeter);

        public IPN450() { }
    }
}
