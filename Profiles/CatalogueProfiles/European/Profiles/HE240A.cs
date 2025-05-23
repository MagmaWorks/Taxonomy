namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE240A : SingletonEuropeanBase<HE240A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 240 A";
        public Length Height => new Length(230, LengthUnit.Millimeter);
        public Length Width => new Length(240, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public HE240A() { }
    }
}
