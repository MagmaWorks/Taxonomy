using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN200 : SingletonEuropeanBase<IPN200>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 200";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(159, LengthUnit.Millimeter);

        public IPN200() { }
    }
}

