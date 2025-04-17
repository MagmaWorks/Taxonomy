namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP16x141 : SingletonAmericanBase<HP16x141>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP16X141";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(16.00, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.88, LengthUnit.Inch);
        public Length WebThickness => new Length(0.88, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.19, LengthUnit.Inch);

        public HP16x141() { }
    }
}
