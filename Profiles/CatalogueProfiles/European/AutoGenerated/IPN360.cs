using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN360 : SingletonEuropeanBase<IPN360>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 360";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(143, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(290, LengthUnit.Millimeter);

        public IPN360() { }
    }
}

