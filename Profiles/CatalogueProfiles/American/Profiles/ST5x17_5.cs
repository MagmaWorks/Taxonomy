namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST5x17_5 : SingletonAmericanBase<ST5x17_5>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST5X17.5";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(4.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.49, LengthUnit.Inch);
        public Length WebThickness => new Length(0.59, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.87, LengthUnit.Inch);
        public Length ToeRadius => new Length(1.935, LengthUnit.Inch);

        public ST5x17_5() { }
    }
}
