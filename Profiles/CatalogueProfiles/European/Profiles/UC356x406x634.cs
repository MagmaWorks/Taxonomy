namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x634 : SingletonEuropeanBase<UC356x406x634>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 406 × 634";
        public Length Height => new Length(474.6, LengthUnit.Millimeter);
        public Length Width => new Length(424, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(77, LengthUnit.Millimeter);
        public Length WebThickness => new Length(47.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x634() { }
    }
}
