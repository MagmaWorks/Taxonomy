using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases.EN
{
    public interface ITableA1_1
    {
        TableA1_1Properties GetProperties(NationalAnnex nationalAnnex);
    }
}
