namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE340A : SingletonEuropeanBase<HE340A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 340 A";
        public Length Height => new Length(330, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE340A() { }
    }
}
