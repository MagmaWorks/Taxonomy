namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180A : SingletonEuropeanBase<HE180A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 180 A";
        public Length Height => new Length(171, LengthUnit.Millimeter);
        public Length Width => new Length(180, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE180A() { }
    }
}
