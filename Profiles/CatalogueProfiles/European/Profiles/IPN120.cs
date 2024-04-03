using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN120 : SingletonEuropeanBase<IPN120>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 120";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(58, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3.1, LengthUnit.Millimeter);
        public Length WebHeight => new Length(92, LengthUnit.Millimeter);

        public IPN120() { }
    }
}
