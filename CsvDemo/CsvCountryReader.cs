public class CsvCountryReader
{
    private string filePath;

    public CsvCountryReader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Country> ReadCountries()
    {
        List<Country> countries = new List<Country>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var fields = line.Split(',');
                    if (fields.Length == 6)
                    {
                        string startIp = fields[0].Trim('"');
                        string endIp = fields[1].Trim('"');
                        long startIpNum = long.Parse(fields[2].Trim('"'));
                        long endIpNum = long.Parse(fields[3].Trim('"'));
                        string code = fields[4].Trim('"');
                        string name = fields[5].Trim('"');

                        Country country = new Country(startIp, endIp, startIpNum, endIpNum, code, name);
                        countries.Add(country);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the CSV file: " + ex.Message);
        }

        return countries;
    }
}
