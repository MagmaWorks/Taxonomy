using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases.EN
{
    public interface ITableA1_1Snow
    {
        TableA1_1Properties GetProperties(bool above1000m, NationalAnnex nationalAnnex);
    }
}
