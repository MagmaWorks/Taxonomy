namespace MagmaWorks.Taxonomy.Countries
{
    public interface IAfrica : ICountry { }

    public interface INorthernAfrica : IAfrica { }

    public interface ISubSaharanAfrica : IAfrica { }

    public interface IEasternAfrica : ISubSaharanAfrica { }
    public interface IMiddleAfrica : ISubSaharanAfrica { }
    public interface ISouthernAfrica : ISubSaharanAfrica { }
    public interface IWesternAfrica : ISubSaharanAfrica { }
}
