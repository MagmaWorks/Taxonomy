using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN475 : SingletonEuropeanBase<IPN475>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 475";
        public Length Height => new Length(475, LengthUnit.Millimeter);
        public Length Width => new Length(178, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(17.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(10.3, LengthUnit.Millimeter);
        public Length WebHeight => new Length(384, LengthUnit.Millimeter);

        public IPN475() { }
    }
}
