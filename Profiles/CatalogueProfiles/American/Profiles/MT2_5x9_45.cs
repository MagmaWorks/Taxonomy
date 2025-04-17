namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT2_5x9_45 : SingletonAmericanBase<MT2_5x9_45>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT2.5X9.45";
        public Length Height => new Length(2.50, LengthUnit.Inch);
        public Length Width => new Length(5.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.42, LengthUnit.Inch);
        public Length WebThickness => new Length(0.32, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.69, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.845, LengthUnit.Inch);

        public MT2_5x9_45() { }
    }
}
