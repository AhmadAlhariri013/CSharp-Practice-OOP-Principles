namespace AbstractionPrinciple.FetchingData;
//Concrete Implementations
//Provide specific implementations for each data source
public class ApiFetcher : IDataFetcher
{
    public string FetchData()
    {
        // Assume logic to fetch from a web API
        return "Data from API";
    }
}