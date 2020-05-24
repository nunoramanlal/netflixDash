using ViewingInsights.Services.FileReader;

namespace ViewingInsights.Services
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVFileReader csv = new CSVFileReader();
            csv.ReadFile(@"C:\Users\nunor\test1.csv"); 
        }
    }
}
