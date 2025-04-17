namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M12_5x12_4 : SingletonAmericanBase<M12_5x12_4>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M12.5X12.4";
        public Length Height => new Length(12.50, LengthUnit.Inch);
        public Length Width => new Length(3.75, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.3, LengthUnit.Inch);

        public M12_5x12_4() { }
    }
}
