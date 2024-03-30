using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN380 : SingletonEuropeanBase<IPN380>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 380";
        public Length Height => new Length(380, LengthUnit.Millimeter);
        public Length Width => new Length(149, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13.7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(306, LengthUnit.Millimeter);

        public IPN380() { }
    }
}
