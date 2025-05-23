namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE400B : SingletonEuropeanBase<HE400B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 400 B";
        public Length Height => new Length(400, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(24, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE400B() { }
    }
}
