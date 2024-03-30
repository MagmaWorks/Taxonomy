using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN220 : SingletonEuropeanBase<IPN220>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.IPN;
        public override string Label => "IPN 220";
        public Length Height => new Length(220, LengthUnit.Millimeter);
        public Length Width => new Length(98, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.1, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.9, LengthUnit.Millimeter);
        public Length WebHeight => new Length(176, LengthUnit.Millimeter);

        public IPN220() { }
    }
}
