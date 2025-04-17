namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST6x15_9 : SingletonAmericanBase<ST6x15_9>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST6X15.9";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.35, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.81, LengthUnit.Inch);
        public Length ToeRadius => new Length(2.405, LengthUnit.Inch);

        public ST6x15_9() { }
    }
}
