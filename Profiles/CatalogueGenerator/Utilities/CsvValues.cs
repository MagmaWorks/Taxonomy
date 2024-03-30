using System.Text.RegularExpressions;

namespace CatalogueProfileGenerator
{
    internal enum Catalogue
    {
        European,
        American
    }
    internal struct CsvValues
    {
        public string Designation;
        public string Type;
        public List<string> Values;
        public Catalogue Catalogue;

        public static CsvValues FromEuropeanCsv(string csvLine)
        {
            string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            CsvValues csvValues = new CsvValues();
            csvValues.Designation = values[0].Replace("\"", string.Empty);
            csvValues.Values = values.Skip(1).ToList();
            csvValues.Catalogue = Catalogue.European;
            return csvValues;
        }

        public static CsvValues FromAmericanCsv(string csvLine)
        {
            string[] values = Regex.Split(csvLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
            CsvValues csvValues = new CsvValues();
            csvValues.Type = values[0].Replace("\"", string.Empty);
            csvValues.Designation = values[1].Replace("\"", string.Empty);
            csvValues.Values = values.Skip(2).ToList();
            csvValues.Catalogue = Catalogue.American;
            return csvValues;
        }
    }
}
