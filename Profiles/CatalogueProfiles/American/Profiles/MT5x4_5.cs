namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class MT5x4_5 : SingletonAmericanBase<MT5x4_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.MT;
        public override string Label => "MT5X4.5";
        public Length Height => new Length(5.00, LengthUnit.Inch);
        public Length Width => new Length(2.69, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.44, LengthUnit.Inch);

        public MT5x4_5() { }
    }
}
