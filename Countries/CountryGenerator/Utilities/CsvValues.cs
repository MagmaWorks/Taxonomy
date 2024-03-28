namespace CountryGenerator
{
    internal struct CsvValues
    {
        public string Name;
        public string CountryCode;

        public static CsvValues FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            CsvValues csvValues = new CsvValues();
            csvValues.CountryCode = values[0];
            csvValues.Name = values[1].Replace("\"", string.Empty);
            return csvValues;
        }
    }
}
