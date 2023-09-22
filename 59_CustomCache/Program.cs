IDataDownloader dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    private string DownloadData(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}

public class CachingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;

    public string DownloadData(string resourceId)
    {
        throw new NotImplementedException();
    }
}

public class Cache<TKey, TData>
{
    private readonly Dictionary<TKey, TData> _cachedData = new();

    public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
    {
        if (!_cachedData.ContainsKey(key))
        {
            _cachedData[key] = getForTheFirstTime(key);
        }

        return _cachedData[key];
    }
}
//private readonly Cache<string, string> _cache = new();

//public string DownloadData(string resourceId)
//{
//    return _cache.Get(resourceId, DownloadDataWithoutCaching);
//}
