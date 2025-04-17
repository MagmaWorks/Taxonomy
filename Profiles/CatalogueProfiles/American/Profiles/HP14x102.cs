namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP14x102 : SingletonAmericanBase<HP14x102>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP14X102";
        public Length Height => new Length(14.00, LengthUnit.Inch);
        public Length Width => new Length(14.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.71, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.205, LengthUnit.Inch);

        public HP14x102() { }
    }
}
