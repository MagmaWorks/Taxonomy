namespace MagmaWorks.Taxonomy.Countries
{
    public interface IAmericas : ICountry { }

    public interface INorthernAmerica : IAmericas { }

    public interface ILatinAmerica : IAmericas { }

    public interface ICaribbean : ILatinAmerica { }
    public interface ICentralAmerica : ILatinAmerica { }
    public interface ISouthAmerica : ILatinAmerica { }
}
