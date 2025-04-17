namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE400M : SingletonEuropeanBase<HE400M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 400 M";
        public Length Height => new Length(432, LengthUnit.Millimeter);
        public Length Width => new Length(307, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE400M() { }
    }
}
