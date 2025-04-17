namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE240B : SingletonEuropeanBase<HE240B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 240 B";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(240, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public HE240B() { }
    }
}
