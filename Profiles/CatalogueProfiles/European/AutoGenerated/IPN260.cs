using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN260 : SingletonEuropeanBase<IPN260>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 260";
        public Length Height => new Length(260, LengthUnit.Millimeter);
        public Length Width => new Length(113, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5.6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(208, LengthUnit.Millimeter);

        public IPN260() { }
    }
}

