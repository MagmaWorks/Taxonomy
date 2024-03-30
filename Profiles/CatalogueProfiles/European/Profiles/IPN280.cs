using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN280 : SingletonEuropeanBase<IPN280>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 280";
        public Length Height => new Length(280, LengthUnit.Millimeter);
        public Length Width => new Length(119, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.1, LengthUnit.Millimeter);
        public Length WebHeight => new Length(225, LengthUnit.Millimeter);

        public IPN280() { }
    }
}
