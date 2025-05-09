namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE360B : SingletonEuropeanBase<HE360B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 360 B";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE360B() { }
    }
}
