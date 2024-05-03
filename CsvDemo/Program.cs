internal class Program
{
    private static void Main(string[] args)
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string filePath = Path.Combine(baseDirectory, "CountryFile.csv");

        CsvCountryReader reader = new CsvCountryReader(filePath);
        List<Country> countries = reader.ReadCountries();

        foreach (Country country in countries)
        {
            Console.WriteLine(country);
        }
    }
}