namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x393 : SingletonEuropeanBase<UC356x406x393>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 406 × 393";
        public Length Height => new Length(419, LengthUnit.Millimeter);
        public Length Width => new Length(407, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(49.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x393() { }
    }
}
