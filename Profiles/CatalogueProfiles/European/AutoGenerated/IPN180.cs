using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN180 : SingletonEuropeanBase<IPN180>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 180";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(82, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(6.9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.1, LengthUnit.Millimeter);
        public Length WebHeight => new Length(142, LengthUnit.Millimeter);

        public IPN180() { }
    }
}

