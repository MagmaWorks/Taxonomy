namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP10x57 : SingletonAmericanBase<HP10x57>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP10X57";
        public Length Height => new Length(9.99, LengthUnit.Inch);
        public Length Width => new Length(10.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.57, LengthUnit.Inch);
        public Length WebThickness => new Length(0.57, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);

        public HP10x57() { }
    }
}
