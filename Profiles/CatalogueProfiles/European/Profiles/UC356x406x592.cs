namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x592 : SingletonEuropeanBase<UC356x406x592>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 406 × 592";
        public Length Height => new Length(465, LengthUnit.Millimeter);
        public Length Width => new Length(421, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(72.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(45, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x592() { }
    }
}
