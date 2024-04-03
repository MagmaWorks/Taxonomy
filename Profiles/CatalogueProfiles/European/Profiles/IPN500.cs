using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN500 : SingletonEuropeanBase<IPN500>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 500";
        public Length Height => new Length(500, LengthUnit.Millimeter);
        public Length Width => new Length(185, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(27, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(10.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(404, LengthUnit.Millimeter);

        public IPN500() { }
    }
}
