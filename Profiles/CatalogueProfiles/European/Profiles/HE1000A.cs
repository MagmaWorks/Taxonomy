namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000A : SingletonEuropeanBase<HE1000A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 1000 A";
        public Length Height => new Length(990, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(31, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000A() { }
    }
}
