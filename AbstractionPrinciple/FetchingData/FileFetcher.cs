namespace AbstractionPrinciple.FetchingData;
//Concrete Implementations
//Provide specific implementations for each data source
public class FileFetcher : IDataFetcher
{
    public string FetchData()
    {
        // Assume logic to read from a file system
        return "Data from File";
    }
}