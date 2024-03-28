using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN240 : SingletonEuropeanBase<IPN240>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 240";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(106, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(192, LengthUnit.Millimeter);

        public IPN240() { }
    }
}

