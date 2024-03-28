using System.Text.RegularExpressions;

namespace CatalogueProfileGenerator
{
    internal struct CsvValues
    {
        public string Designation;
        public List<string> Values;

        public static CsvValues FromCsv(string csvLine)
        {
            string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            CsvValues csvValues = new CsvValues();
            csvValues.Designation = values[0].Replace("\"", string.Empty);
            csvValues.Values = values.Skip(1).ToList();
            return csvValues;
        }
    }
}
