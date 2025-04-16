namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT3x1_85 : SingletonAmericanBase<MT3x1_85>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT3X1.85";
        public Length Height => new Length(2.96, LengthUnit.Inch);
        public Length Width => new Length(2.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.13, LengthUnit.Inch);
        public Length WebThickness => new Length(0.10, LengthUnit.Inch);
        public Length FilletRadius => new Length(2.65, LengthUnit.Inch);

        public MT3x1_85() { }
    }
}
