using System.Reflection.Metadata;

namespace AspireTemplate.Web;

public class TestApiClient(HttpClient httpClient)
{
    public async Task<Stream> GetBlobStreamAsync(CancellationToken cancellationToken = default)
    {
        return await httpClient.GetStreamAsync("/imageblob", cancellationToken);
    }
}

