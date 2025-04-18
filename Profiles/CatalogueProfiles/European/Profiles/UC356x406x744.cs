namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x744 : SingletonEuropeanBase<UC356x406x744>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 406 × 744";
        public Length Height => new Length(498, LengthUnit.Millimeter);
        public Length Width => new Length(432, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(88.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(55.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x744() { }
    }
}
