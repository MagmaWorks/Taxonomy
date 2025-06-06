namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE600M : SingletonEuropeanBase<HE600M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 600 M";
        public Length Height => new Length(620, LengthUnit.Millimeter);
        public Length Width => new Length(305, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE600M() { }
    }
}
