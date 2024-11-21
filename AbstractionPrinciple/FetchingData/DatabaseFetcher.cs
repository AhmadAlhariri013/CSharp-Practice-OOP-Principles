namespace AbstractionPrinciple.FetchingData;
//Concrete Implementations
//Provide specific implementations for each data source
public class DatabaseFetcher : IDataFetcher
{
    public string FetchData()
    {
        // Assume logic to connect and fetch from a database
        return "Data from Database";
    }
}

